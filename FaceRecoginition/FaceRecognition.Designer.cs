namespace FaceRecoginition
{
    partial class FaceRecognition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmailId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboutName = new System.Windows.Forms.TextBox();
            this.tboutEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbinputImage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRebuildAlbum = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbAlbumName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnViewAlbum = new System.Windows.Forms.Button();
            this.btnCreateAlbum = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(111, 236);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(176, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbEmailId
            // 
            this.tbEmailId.Location = new System.Drawing.Point(111, 282);
            this.tbEmailId.Name = "tbEmailId";
            this.tbEmailId.Size = new System.Drawing.Size(176, 20);
            this.tbEmailId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(36, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(23, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email Id :";
            // 
            // btnCapture
            // 
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCapture.Location = new System.Drawing.Point(95, 152);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(120, 78);
            this.btnCapture.TabIndex = 5;
            this.btnCapture.Text = "Capture and Save";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnCapture);
            this.panel1.Location = new System.Drawing.Point(14, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 333);
            this.panel1.TabIndex = 10;
            this.panel1.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(11, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "This section will capture the image from \r\nthe webcam and train the image.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email Id :";
            // 
            // tboutName
            // 
            this.tboutName.Location = new System.Drawing.Point(104, 32);
            this.tboutName.Name = "tboutName";
            this.tboutName.Size = new System.Drawing.Size(176, 20);
            this.tboutName.TabIndex = 7;
            // 
            // tboutEmail
            // 
            this.tboutEmail.Location = new System.Drawing.Point(104, 80);
            this.tboutEmail.Name = "tboutEmail";
            this.tboutEmail.Size = new System.Drawing.Size(176, 20);
            this.tboutEmail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(358, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Output";
            // 
            // tbinputImage
            // 
            this.tbinputImage.Location = new System.Drawing.Point(90, 27);
            this.tbinputImage.Name = "tbinputImage";
            this.tbinputImage.Size = new System.Drawing.Size(176, 20);
            this.tbinputImage.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(14, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tboutName);
            this.panel2.Controls.Add(this.tboutEmail);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(386, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 105);
            this.panel2.TabIndex = 12;
            // 
            // btnRecognize
            // 
            this.btnRecognize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecognize.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRecognize.Location = new System.Drawing.Point(112, 63);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(120, 51);
            this.btnRecognize.TabIndex = 0;
            this.btnRecognize.Text = "Recognize";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(273, 26);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(40, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "......";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(14, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Image :";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBrowse);
            this.panel3.Controls.Add(this.tbinputImage);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnRecognize);
            this.panel3.Location = new System.Drawing.Point(386, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 124);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(352, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 333);
            this.panel4.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(28, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "3.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(56, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 34);
            this.label8.TabIndex = 7;
            this.label8.Text = "This section will take the input image\r\nand recognize the face.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClear.Location = new System.Drawing.Point(294, 488);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 42);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnRebuildAlbum);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(14, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 334);
            this.panel5.TabIndex = 10;
            this.panel5.Tag = "";
            // 
            // btnRebuildAlbum
            // 
            this.btnRebuildAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRebuildAlbum.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRebuildAlbum.Location = new System.Drawing.Point(165, 182);
            this.btnRebuildAlbum.Name = "btnRebuildAlbum";
            this.btnRebuildAlbum.Size = new System.Drawing.Size(120, 78);
            this.btnRebuildAlbum.TabIndex = 8;
            this.btnRebuildAlbum.Text = "Rebuild Album";
            this.btnRebuildAlbum.UseVisualStyleBackColor = true;
            this.btnRebuildAlbum.Click += new System.EventHandler(this.btnRebuildAlbum_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(-1, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "2.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(25, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 68);
            this.label9.TabIndex = 6;
            this.label9.Text = "This section will capture the image from \r\nthe webcam and train the image. \r\nTo r" +
                "ebuild the album train atleast two \r\nimages for a particular entry id.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(34, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "Capture and Train";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.tbAlbumName);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.btnViewAlbum);
            this.panel6.Controls.Add(this.btnCreateAlbum);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(13, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(745, 107);
            this.panel6.TabIndex = 16;
            // 
            // tbAlbumName
            // 
            this.tbAlbumName.Location = new System.Drawing.Point(173, 53);
            this.tbAlbumName.Name = "tbAlbumName";
            this.tbAlbumName.Size = new System.Drawing.Size(176, 20);
            this.tbAlbumName.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(47, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Album Name :";
            // 
            // btnViewAlbum
            // 
            this.btnViewAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAlbum.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewAlbum.Location = new System.Drawing.Point(558, 36);
            this.btnViewAlbum.Name = "btnViewAlbum";
            this.btnViewAlbum.Size = new System.Drawing.Size(141, 51);
            this.btnViewAlbum.TabIndex = 11;
            this.btnViewAlbum.Text = "View Album";
            this.btnViewAlbum.UseVisualStyleBackColor = true;
            this.btnViewAlbum.Click += new System.EventHandler(this.btnViewAlbum_Click);
            // 
            // btnCreateAlbum
            // 
            this.btnCreateAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAlbum.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreateAlbum.Location = new System.Drawing.Point(378, 36);
            this.btnCreateAlbum.Name = "btnCreateAlbum";
            this.btnCreateAlbum.Size = new System.Drawing.Size(148, 51);
            this.btnCreateAlbum.TabIndex = 10;
            this.btnCreateAlbum.Text = "Create Album";
            this.btnCreateAlbum.UseVisualStyleBackColor = true;
            this.btnCreateAlbum.Click += new System.EventHandler(this.btnCreateAlbum_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(6, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "1.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(32, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(706, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "This section will Create the Album and return the AlbumKey.Please store the album" +
                " name and key to config file.";
            // 
            // FaceRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 536);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbEmailId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.Name = "FaceRecognition";
            this.Text = "Face Recognizer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmailId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboutName;
        private System.Windows.Forms.TextBox tboutEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbinputImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnViewAlbum;
        private System.Windows.Forms.Button btnCreateAlbum;
        private System.Windows.Forms.TextBox tbAlbumName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnRebuildAlbum;
    }
}

