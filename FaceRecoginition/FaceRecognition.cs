using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using unirest_net.http;
using System.IO;
using System.Web.Script.Serialization;
using System.Configuration;

namespace FaceRecoginition
{
    public partial class FaceRecognition : Form
    {
        public static string album;
        public static string albumKey;
        public static string mashapeAuthKey;

        public string InputFile { get; set; }

        public string Name { get; set; }

        public string emailID { get; set; }


        public FaceRecognition()
        {
            InitializeComponent();
        }

        #region Events

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            tboutEmail.Text = string.Empty;
            tboutName.Text = string.Empty;

            album = ConfigurationSettings.AppSettings["Album"];
            albumKey = ConfigurationSettings.AppSettings["AlbumKey"];
            mashapeAuthKey = ConfigurationSettings.AppSettings["MashapeAuthKey"];

            Recognize(InputFile);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                InputFile = openFileDialog1.FileName;
                tbinputImage.Text = InputFile;
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Name = tbName.Text.Trim();
            emailID = tbEmailId.Text.Trim();

            if (!string.IsNullOrEmpty(Name) || !string.IsNullOrEmpty(emailID))
            {
                album = ConfigurationSettings.AppSettings["Album"];
                albumKey = ConfigurationSettings.AppSettings["AlbumKey"];
                mashapeAuthKey = ConfigurationSettings.AppSettings["MashapeAuthKey"];
               
                FaceRecoginition.Capture _capture = new FaceRecoginition.Capture(Name, emailID);               
            }
            else
            {
                MessageBox.Show("Please enter Name and emailID.");
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = string.Empty;
            tbEmailId.Text = string.Empty;
            tboutEmail.Text = string.Empty;
            tboutName.Text = string.Empty;
            tbinputImage.Text = string.Empty;
            tbAlbumName.Text = string.Empty;
        }

        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAlbumName.Text.Trim()))
                CreateAlbum(tbAlbumName.Text.Trim());
            else
                MessageBox.Show("Please enter album name.");
        }

        private void btnViewAlbum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAlbumName.Text.Trim()))
                ViewAlbum(tbAlbumName.Text.Trim());
            else
                MessageBox.Show("Please enter album name and provide valid album key in config file.");            
        }

        private void btnRebuildAlbum_Click(object sender, EventArgs e)
        {
            RebuildAlbum();
        }

        #endregion

        #region Methods

        private void ViewAlbum(string albumname)
        {
            Cursor.Current = Cursors.WaitCursor;

            albumKey = ConfigurationSettings.AppSettings["AlbumKey"];
            mashapeAuthKey = ConfigurationSettings.AppSettings["MashapeAuthKey"];

            HttpResponse<string> response = Unirest.get("https://lambda-face-recognition.p.mashape.com/album?album=" + albumname + "&albumkey=" + albumKey)
              .header("X-Mashape-Authorization", mashapeAuthKey)
              .asString();

            string _output = response.Body;

            JavaScriptSerializer jss = new JavaScriptSerializer();
            var output = jss.Deserialize<dynamic>(response.Body);

            Cursor.Current = Cursors.Default;

            MessageBox.Show(response.Body);
        }

        private void CreateAlbum(string albumname)
        {
            Cursor.Current = Cursors.WaitCursor;

            mashapeAuthKey = ConfigurationSettings.AppSettings["MashapeAuthKey"];

            HttpResponse<string> response = Unirest.post("https://lambda-face-recognition.p.mashape.com/album")
              .header("X-Mashape-Authorization", mashapeAuthKey)
              .field("album", albumname)
              .asString();

            JavaScriptSerializer jss = new JavaScriptSerializer();
            var output = jss.Deserialize<dynamic>(response.Body);

            foreach (var item in output)
            {
                if (item.Key == "albumkey")
                    albumKey = item.Value;
            }

            Cursor.Current = Cursors.Default;

            if (string.IsNullOrEmpty(albumKey))
            {
                MessageBox.Show("Album is already exist, please try using different name.");
            }
            else
            {
                MessageBox.Show("Albumkey :" + albumKey + " Please store the album name and key to config file");
            }
        }

        public static void TrainAlbum(string name, string emailID, byte[] data)
        {
            try
            {
                //byte[] data1 = File.ReadAllBytes(ConfigurationSettings.AppSettings["SaveImageLocation"]);

                string entryID = FaceDAO.GetEntryIDByName(name).ToString();

                HttpResponse<string> response = Unirest.post("https://lambda-face-recognition.p.mashape.com/album_train")
                  .header("X-Mashape-Authorization", mashapeAuthKey)
                   .field("album", album)
                  .field("albumkey", albumKey)
                  .field("entryid", entryID)
                  .field("files", data)
                  .asString();

                JavaScriptSerializer jss = new JavaScriptSerializer();
                var output = jss.Deserialize<dynamic>(response.Body);

                FaceData _facedata = new FaceData();
                _facedata.name = name;
                _facedata.emailID = emailID;
                _facedata.album = album;
                _facedata.albumkey = albumKey;

                FaceDAO.InsertUserData(_facedata);

                MessageBox.Show("Image capture and trained.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Detect(string filename)
        {
            mashapeAuthKey = ConfigurationSettings.AppSettings["MashapeAuthKey"];

            byte[] data = File.ReadAllBytes(filename);

            HttpResponse<string> response = Unirest.post("https://lambda-face-recognition.p.mashape.com/detect")
              .header("X-Mashape-Authorization", mashapeAuthKey)
              .field("files", data)
              .asString();

            string output = response.Body;

            MessageBox.Show(output);
        }

        public static void RebuildAlbum()
        {
            Cursor.Current = Cursors.WaitCursor;

            album = ConfigurationSettings.AppSettings["Album"];
            albumKey = ConfigurationSettings.AppSettings["AlbumKey"];
            mashapeAuthKey = ConfigurationSettings.AppSettings["MashapeAuthKey"];

            HttpResponse<string> response = Unirest.get("https://lambda-face-recognition.p.mashape.com/album_rebuild?album=" + album + "&albumkey=" + albumKey)
              .header("X-Mashape-Authorization", mashapeAuthKey)
              .asString();

            JavaScriptSerializer jss = new JavaScriptSerializer();
            var output = jss.Deserialize<dynamic>(response.Body);
            Cursor.Current = Cursors.Default;

            MessageBox.Show(response.Body);
        }

        private void Recognize(string filename)
        {
            try
            {

                Cursor = Cursors.WaitCursor;

                byte[] data = File.ReadAllBytes(filename);

                Stream stream = new MemoryStream(data);

                HttpResponse<string> response = Unirest.post("https://lambda-face-recognition.p.mashape.com/recognize")
                  .header("X-Mashape-Authorization", mashapeAuthKey)
                  .field("album", album)
                  .field("albumkey", albumKey)
                  .field("files", data)
                  .asJson<string>();

                JavaScriptSerializer jss = new JavaScriptSerializer();
                var output = jss.Deserialize<dynamic>(response.Body);

                string entryID = output["photos"][0]["tags"][0]["uids"][0]["prediction"];

                FaceData _facedata =  FaceDAO.GetFaceInfoByEntryID(Convert.ToInt32(entryID));

                tboutName.Text = _facedata.name;
                tboutEmail.Text = _facedata.emailID;

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Face not recognize.");
                Cursor = Cursors.Default;
            }
        }

        #endregion

      
    }
}
