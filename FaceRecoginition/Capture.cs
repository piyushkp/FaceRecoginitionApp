using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing;
using System.IO;
using System.Configuration;
using System.Windows.Forms;

namespace FaceRecoginition
{
    public class Capture
    {

        // enumerate video devices
        public FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        //camera
        public VideoCaptureDevice videoSource;
        //screen shot
        public Bitmap bitmap;

        public string entryID;

        public string Name { get; set; }

        public string emailID { get; set; }

        public Capture(string name, string _emailID)
        {
            Name = name;
            emailID = _emailID;
            // create video source
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            // set NewFrame event handler

            StartVideo(videoSource);

            System.Threading.Thread.Sleep(7000);

            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);            
        }

        public void StartVideo(VideoCaptureDevice videoSource)
        {
            // start the video source
            videoSource.Start();            
        }

        public void StopVideo(VideoCaptureDevice videoSource)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                // stop the video source
                videoSource.SignalToStop();
                
                videoSource = null;
                // ...
            }
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Cursor.Current = Cursors.WaitCursor;

            // get new frame
            bitmap = eventArgs.Frame;

            bitmap.Save(ConfigurationSettings.AppSettings["SaveImageLocation"]);

            StopVideo(videoSource);
            // process the frame
            byte[] data = File.ReadAllBytes(ConfigurationSettings.AppSettings["SaveImageLocation"]);

            // train the capture image
            FaceRecoginition.FaceRecognition.TrainAlbum(Name , emailID, data);
            
            Cursor.Current = Cursors.Default;
        }

        //private byte[] ImageToByte2(Bitmap img)
        //{
        //    byte[] byteArray = new byte[0];
        //    using (MemoryStream stream = new MemoryStream())
        //    {
        //        img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        stream.Close();

        //        byteArray = stream.ToArray();
        //    }

        //    return byteArray;
        //}

        //public Stream ConvertToStream(Bitmap bitmapImage)
        //{
        //    MemoryStream stream = new MemoryStream();

        //    bitmapImage.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);

        //    return stream;
        //}
    }
}