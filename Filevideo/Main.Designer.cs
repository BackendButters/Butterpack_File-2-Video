namespace Filevideo
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.packFile_btn = new System.Windows.Forms.Button();
            this.unpackFile_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.width_trackbar = new System.Windows.Forms.TrackBar();
            this.width_txtbx = new System.Windows.Forms.TextBox();
            this.videoSettings_grpbx = new System.Windows.Forms.GroupBox();
            this.fps_txtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.capacity_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.height_txtbx = new System.Windows.Forms.TextBox();
            this.height_trackbar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.compare_btn = new System.Windows.Forms.Button();
            this.image_rdobtn = new System.Windows.Forms.RadioButton();
            this.video_rdnbtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imagesize_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fileToOpen_txtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectFileToOpen_btn = new System.Windows.Forms.Button();
            this.selectTargetFile_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fileToWrite_txtbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.containsHeader_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.source_fs_lbl = new System.Windows.Forms.Label();
            this.encrypt_chkbx = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.decrypt_chkbx = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.imgSettings_grpbx = new System.Windows.Forms.GroupBox();
            this.gifsettings_grpbx = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gifframes_txtbx = new System.Windows.Forms.TextBox();
            this.pngsettings_grpbx = new System.Windows.Forms.GroupBox();
            this.selectINsertFile_btn = new System.Windows.Forms.Button();
            this.insertPos_trackbar = new System.Windows.Forms.TrackBar();
            this.insertInto_chkbx = new System.Windows.Forms.CheckBox();
            this.insertFilePath_txtbx = new System.Windows.Forms.TextBox();
            this.insertpos_lbl = new System.Windows.Forms.Label();
            this.gifimg_rdobtn = new System.Windows.Forms.RadioButton();
            this.pngimg_rdobtn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.width_trackbar)).BeginInit();
            this.videoSettings_grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height_trackbar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.imgSettings_grpbx.SuspendLayout();
            this.gifsettings_grpbx.SuspendLayout();
            this.pngsettings_grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertPos_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // packFile_btn
            // 
            this.packFile_btn.Location = new System.Drawing.Point(16, 306);
            this.packFile_btn.Name = "packFile_btn";
            this.packFile_btn.Size = new System.Drawing.Size(151, 23);
            this.packFile_btn.TabIndex = 0;
            this.packFile_btn.Text = "Pack file";
            this.packFile_btn.UseVisualStyleBackColor = true;
            this.packFile_btn.Click += new System.EventHandler(this.packFile_btn_Click);
            // 
            // unpackFile_btn
            // 
            this.unpackFile_btn.Location = new System.Drawing.Point(16, 335);
            this.unpackFile_btn.Name = "unpackFile_btn";
            this.unpackFile_btn.Size = new System.Drawing.Size(151, 23);
            this.unpackFile_btn.TabIndex = 1;
            this.unpackFile_btn.Text = "Unpack file";
            this.unpackFile_btn.UseVisualStyleBackColor = true;
            this.unpackFile_btn.Click += new System.EventHandler(this.unpackFile_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.Location = new System.Drawing.Point(775, 443);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(75, 23);
            this.quit_btn.TabIndex = 2;
            this.quit_btn.Text = "Quit";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // width_trackbar
            // 
            this.width_trackbar.Location = new System.Drawing.Point(6, 41);
            this.width_trackbar.Maximum = 1920;
            this.width_trackbar.Minimum = 1;
            this.width_trackbar.Name = "width_trackbar";
            this.width_trackbar.Size = new System.Drawing.Size(149, 45);
            this.width_trackbar.TabIndex = 3;
            this.width_trackbar.Value = 1280;
            this.width_trackbar.ValueChanged += new System.EventHandler(this.width_trackbar_ValueChanged);
            // 
            // width_txtbx
            // 
            this.width_txtbx.Location = new System.Drawing.Point(164, 41);
            this.width_txtbx.Name = "width_txtbx";
            this.width_txtbx.Size = new System.Drawing.Size(57, 20);
            this.width_txtbx.TabIndex = 4;
            this.width_txtbx.Text = "1280";
            this.width_txtbx.TextChanged += new System.EventHandler(this.width_txtbx_TextChanged);
            // 
            // videoSettings_grpbx
            // 
            this.videoSettings_grpbx.Controls.Add(this.fps_txtbx);
            this.videoSettings_grpbx.Controls.Add(this.label4);
            this.videoSettings_grpbx.Controls.Add(this.capacity_lbl);
            this.videoSettings_grpbx.Controls.Add(this.label3);
            this.videoSettings_grpbx.Controls.Add(this.height_txtbx);
            this.videoSettings_grpbx.Controls.Add(this.height_trackbar);
            this.videoSettings_grpbx.Controls.Add(this.label2);
            this.videoSettings_grpbx.Controls.Add(this.width_txtbx);
            this.videoSettings_grpbx.Controls.Add(this.label1);
            this.videoSettings_grpbx.Controls.Add(this.width_trackbar);
            this.videoSettings_grpbx.Location = new System.Drawing.Point(370, 190);
            this.videoSettings_grpbx.Name = "videoSettings_grpbx";
            this.videoSettings_grpbx.Size = new System.Drawing.Size(231, 236);
            this.videoSettings_grpbx.TabIndex = 5;
            this.videoSettings_grpbx.TabStop = false;
            this.videoSettings_grpbx.Text = "Video settings";
            // 
            // fps_txtbx
            // 
            this.fps_txtbx.Location = new System.Drawing.Point(45, 197);
            this.fps_txtbx.Name = "fps_txtbx";
            this.fps_txtbx.Size = new System.Drawing.Size(65, 20);
            this.fps_txtbx.TabIndex = 14;
            this.fps_txtbx.Text = "10";
            this.fps_txtbx.TextChanged += new System.EventHandler(this.fps_txtbx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "FPS:";
            // 
            // capacity_lbl
            // 
            this.capacity_lbl.AutoSize = true;
            this.capacity_lbl.Location = new System.Drawing.Point(116, 162);
            this.capacity_lbl.Name = "capacity_lbl";
            this.capacity_lbl.Size = new System.Drawing.Size(41, 13);
            this.capacity_lbl.TabIndex = 12;
            this.capacity_lbl.Text = "900 kB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Capacity per Frame:";
            // 
            // height_txtbx
            // 
            this.height_txtbx.Location = new System.Drawing.Point(164, 105);
            this.height_txtbx.Name = "height_txtbx";
            this.height_txtbx.Size = new System.Drawing.Size(57, 20);
            this.height_txtbx.TabIndex = 10;
            this.height_txtbx.Text = "720";
            this.height_txtbx.TextChanged += new System.EventHandler(this.height_txtbx_TextChanged);
            // 
            // height_trackbar
            // 
            this.height_trackbar.Location = new System.Drawing.Point(6, 105);
            this.height_trackbar.Maximum = 1080;
            this.height_trackbar.Minimum = 1;
            this.height_trackbar.Name = "height_trackbar";
            this.height_trackbar.Size = new System.Drawing.Size(149, 45);
            this.height_trackbar.TabIndex = 9;
            this.height_trackbar.Value = 720;
            this.height_trackbar.ValueChanged += new System.EventHandler(this.height_trackbar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Height";
            // 
            // compare_btn
            // 
            this.compare_btn.Location = new System.Drawing.Point(16, 380);
            this.compare_btn.Name = "compare_btn";
            this.compare_btn.Size = new System.Drawing.Size(151, 23);
            this.compare_btn.TabIndex = 6;
            this.compare_btn.Text = "Compare 2 files";
            this.compare_btn.UseVisualStyleBackColor = true;
            this.compare_btn.Click += new System.EventHandler(this.compare_btn_Click);
            // 
            // image_rdobtn
            // 
            this.image_rdobtn.AutoSize = true;
            this.image_rdobtn.Location = new System.Drawing.Point(12, 37);
            this.image_rdobtn.Name = "image_rdobtn";
            this.image_rdobtn.Size = new System.Drawing.Size(54, 17);
            this.image_rdobtn.TabIndex = 7;
            this.image_rdobtn.Text = "Image";
            this.image_rdobtn.UseVisualStyleBackColor = true;
            this.image_rdobtn.CheckedChanged += new System.EventHandler(this.image_rdobtn_CheckedChanged);
            // 
            // video_rdnbtn
            // 
            this.video_rdnbtn.AutoSize = true;
            this.video_rdnbtn.Checked = true;
            this.video_rdnbtn.Location = new System.Drawing.Point(12, 60);
            this.video_rdnbtn.Name = "video_rdnbtn";
            this.video_rdnbtn.Size = new System.Drawing.Size(52, 17);
            this.video_rdnbtn.TabIndex = 8;
            this.video_rdnbtn.TabStop = true;
            this.video_rdnbtn.Text = "Video";
            this.video_rdnbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.image_rdobtn);
            this.groupBox2.Controls.Add(this.video_rdnbtn);
            this.groupBox2.Location = new System.Drawing.Point(370, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Packaging target";
            // 
            // imagesize_lbl
            // 
            this.imagesize_lbl.AutoSize = true;
            this.imagesize_lbl.Location = new System.Drawing.Point(68, 34);
            this.imagesize_lbl.Name = "imagesize_lbl";
            this.imagesize_lbl.Size = new System.Drawing.Size(27, 13);
            this.imagesize_lbl.TabIndex = 24;
            this.imagesize_lbl.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Imagesize:";
            // 
            // fileToOpen_txtbx
            // 
            this.fileToOpen_txtbx.Location = new System.Drawing.Point(105, 74);
            this.fileToOpen_txtbx.Name = "fileToOpen_txtbx";
            this.fileToOpen_txtbx.Size = new System.Drawing.Size(165, 20);
            this.fileToOpen_txtbx.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "FIle of operation:";
            // 
            // selectFileToOpen_btn
            // 
            this.selectFileToOpen_btn.Location = new System.Drawing.Point(276, 72);
            this.selectFileToOpen_btn.Name = "selectFileToOpen_btn";
            this.selectFileToOpen_btn.Size = new System.Drawing.Size(75, 23);
            this.selectFileToOpen_btn.TabIndex = 12;
            this.selectFileToOpen_btn.Text = "Select";
            this.selectFileToOpen_btn.UseVisualStyleBackColor = true;
            this.selectFileToOpen_btn.Click += new System.EventHandler(this.selectFileToOpen_btn_Click);
            // 
            // selectTargetFile_btn
            // 
            this.selectTargetFile_btn.Location = new System.Drawing.Point(276, 190);
            this.selectTargetFile_btn.Name = "selectTargetFile_btn";
            this.selectTargetFile_btn.Size = new System.Drawing.Size(75, 23);
            this.selectTargetFile_btn.TabIndex = 15;
            this.selectTargetFile_btn.Text = "Select";
            this.selectTargetFile_btn.UseVisualStyleBackColor = true;
            this.selectTargetFile_btn.Click += new System.EventHandler(this.selectTargetFile_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Targetfile:";
            // 
            // fileToWrite_txtbx
            // 
            this.fileToWrite_txtbx.Location = new System.Drawing.Point(105, 192);
            this.fileToWrite_txtbx.Name = "fileToWrite_txtbx";
            this.fileToWrite_txtbx.Size = new System.Drawing.Size(165, 20);
            this.fileToWrite_txtbx.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Note: If packed file does not contain filename with extension,";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "you have to manually specify it";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Source file contains header:";
            // 
            // containsHeader_lbl
            // 
            this.containsHeader_lbl.AutoSize = true;
            this.containsHeader_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containsHeader_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.containsHeader_lbl.Location = new System.Drawing.Point(158, 134);
            this.containsHeader_lbl.Name = "containsHeader_lbl";
            this.containsHeader_lbl.Size = new System.Drawing.Size(23, 13);
            this.containsHeader_lbl.TabIndex = 19;
            this.containsHeader_lbl.Text = "No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Source filesize:";
            // 
            // source_fs_lbl
            // 
            this.source_fs_lbl.AutoSize = true;
            this.source_fs_lbl.Location = new System.Drawing.Point(158, 113);
            this.source_fs_lbl.Name = "source_fs_lbl";
            this.source_fs_lbl.Size = new System.Drawing.Size(27, 13);
            this.source_fs_lbl.TabIndex = 21;
            this.source_fs_lbl.Text = "N/A";
            // 
            // encrypt_chkbx
            // 
            this.encrypt_chkbx.AutoSize = true;
            this.encrypt_chkbx.Location = new System.Drawing.Point(173, 310);
            this.encrypt_chkbx.Name = "encrypt_chkbx";
            this.encrypt_chkbx.Size = new System.Drawing.Size(62, 17);
            this.encrypt_chkbx.TabIndex = 22;
            this.encrypt_chkbx.Text = "Encrypt";
            this.encrypt_chkbx.UseVisualStyleBackColor = true;
            this.encrypt_chkbx.CheckedChanged += new System.EventHandler(this.encrypt_chkbx_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(196, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(221, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Butterpack File-To-Media";
            // 
            // password_txtbx
            // 
            this.password_txtbx.Enabled = false;
            this.password_txtbx.Location = new System.Drawing.Point(251, 320);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(100, 20);
            this.password_txtbx.TabIndex = 24;
            // 
            // decrypt_chkbx
            // 
            this.decrypt_chkbx.AutoSize = true;
            this.decrypt_chkbx.Location = new System.Drawing.Point(173, 339);
            this.decrypt_chkbx.Name = "decrypt_chkbx";
            this.decrypt_chkbx.Size = new System.Drawing.Size(63, 17);
            this.decrypt_chkbx.TabIndex = 25;
            this.decrypt_chkbx.Text = "Decrypt";
            this.decrypt_chkbx.UseVisualStyleBackColor = true;
            this.decrypt_chkbx.CheckedChanged += new System.EventHandler(this.decrypt_chkbx_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(248, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Password:";
            // 
            // imgSettings_grpbx
            // 
            this.imgSettings_grpbx.Controls.Add(this.gifsettings_grpbx);
            this.imgSettings_grpbx.Controls.Add(this.pngsettings_grpbx);
            this.imgSettings_grpbx.Controls.Add(this.gifimg_rdobtn);
            this.imgSettings_grpbx.Controls.Add(this.pngimg_rdobtn);
            this.imgSettings_grpbx.Controls.Add(this.imagesize_lbl);
            this.imgSettings_grpbx.Controls.Add(this.label10);
            this.imgSettings_grpbx.Location = new System.Drawing.Point(619, 77);
            this.imgSettings_grpbx.Name = "imgSettings_grpbx";
            this.imgSettings_grpbx.Size = new System.Drawing.Size(224, 349);
            this.imgSettings_grpbx.TabIndex = 26;
            this.imgSettings_grpbx.TabStop = false;
            this.imgSettings_grpbx.Text = "Image settings";
            // 
            // gifsettings_grpbx
            // 
            this.gifsettings_grpbx.Controls.Add(this.label15);
            this.gifsettings_grpbx.Controls.Add(this.gifframes_txtbx);
            this.gifsettings_grpbx.Enabled = false;
            this.gifsettings_grpbx.Location = new System.Drawing.Point(6, 285);
            this.gifsettings_grpbx.Name = "gifsettings_grpbx";
            this.gifsettings_grpbx.Size = new System.Drawing.Size(206, 58);
            this.gifsettings_grpbx.TabIndex = 28;
            this.gifsettings_grpbx.TabStop = false;
            this.gifsettings_grpbx.Text = "GIF settings";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Number of images:";
            // 
            // gifframes_txtbx
            // 
            this.gifframes_txtbx.Location = new System.Drawing.Point(107, 17);
            this.gifframes_txtbx.Name = "gifframes_txtbx";
            this.gifframes_txtbx.Size = new System.Drawing.Size(69, 20);
            this.gifframes_txtbx.TabIndex = 0;
            this.gifframes_txtbx.Text = "2";
            this.gifframes_txtbx.TextChanged += new System.EventHandler(this.gifframes_txtbx_TextChanged);
            // 
            // pngsettings_grpbx
            // 
            this.pngsettings_grpbx.Controls.Add(this.selectINsertFile_btn);
            this.pngsettings_grpbx.Controls.Add(this.insertPos_trackbar);
            this.pngsettings_grpbx.Controls.Add(this.insertInto_chkbx);
            this.pngsettings_grpbx.Controls.Add(this.insertFilePath_txtbx);
            this.pngsettings_grpbx.Controls.Add(this.insertpos_lbl);
            this.pngsettings_grpbx.Location = new System.Drawing.Point(6, 113);
            this.pngsettings_grpbx.Name = "pngsettings_grpbx";
            this.pngsettings_grpbx.Size = new System.Drawing.Size(206, 166);
            this.pngsettings_grpbx.TabIndex = 29;
            this.pngsettings_grpbx.TabStop = false;
            this.pngsettings_grpbx.Text = "PNG settings";
            // 
            // selectINsertFile_btn
            // 
            this.selectINsertFile_btn.Enabled = false;
            this.selectINsertFile_btn.Location = new System.Drawing.Point(134, 55);
            this.selectINsertFile_btn.Name = "selectINsertFile_btn";
            this.selectINsertFile_btn.Size = new System.Drawing.Size(60, 23);
            this.selectINsertFile_btn.TabIndex = 27;
            this.selectINsertFile_btn.Text = "Select";
            this.selectINsertFile_btn.UseVisualStyleBackColor = true;
            this.selectINsertFile_btn.Click += new System.EventHandler(this.selectINsertFile_btn_Click);
            // 
            // insertPos_trackbar
            // 
            this.insertPos_trackbar.Enabled = false;
            this.insertPos_trackbar.Location = new System.Drawing.Point(9, 118);
            this.insertPos_trackbar.Name = "insertPos_trackbar";
            this.insertPos_trackbar.Size = new System.Drawing.Size(185, 45);
            this.insertPos_trackbar.TabIndex = 0;
            // 
            // insertInto_chkbx
            // 
            this.insertInto_chkbx.AutoSize = true;
            this.insertInto_chkbx.Location = new System.Drawing.Point(9, 23);
            this.insertInto_chkbx.Name = "insertInto_chkbx";
            this.insertInto_chkbx.Size = new System.Drawing.Size(119, 17);
            this.insertInto_chkbx.TabIndex = 1;
            this.insertInto_chkbx.Text = "Insert file into image";
            this.insertInto_chkbx.UseVisualStyleBackColor = true;
            this.insertInto_chkbx.CheckedChanged += new System.EventHandler(this.insertInto_chkbx_CheckedChanged);
            // 
            // insertFilePath_txtbx
            // 
            this.insertFilePath_txtbx.Enabled = false;
            this.insertFilePath_txtbx.Location = new System.Drawing.Point(9, 58);
            this.insertFilePath_txtbx.Name = "insertFilePath_txtbx";
            this.insertFilePath_txtbx.Size = new System.Drawing.Size(119, 20);
            this.insertFilePath_txtbx.TabIndex = 27;
            this.insertFilePath_txtbx.TextChanged += new System.EventHandler(this.insertFilePath_txtbx_TextChanged);
            // 
            // insertpos_lbl
            // 
            this.insertpos_lbl.AutoSize = true;
            this.insertpos_lbl.Enabled = false;
            this.insertpos_lbl.Location = new System.Drawing.Point(12, 102);
            this.insertpos_lbl.Name = "insertpos_lbl";
            this.insertpos_lbl.Size = new System.Drawing.Size(47, 13);
            this.insertpos_lbl.TabIndex = 25;
            this.insertpos_lbl.Text = "Position:";
            // 
            // gifimg_rdobtn
            // 
            this.gifimg_rdobtn.AutoSize = true;
            this.gifimg_rdobtn.Location = new System.Drawing.Point(9, 80);
            this.gifimg_rdobtn.Name = "gifimg_rdobtn";
            this.gifimg_rdobtn.Size = new System.Drawing.Size(74, 17);
            this.gifimg_rdobtn.TabIndex = 29;
            this.gifimg_rdobtn.Text = "GIF Image";
            this.gifimg_rdobtn.UseVisualStyleBackColor = true;
            this.gifimg_rdobtn.CheckedChanged += new System.EventHandler(this.gifimg_rdobtn_CheckedChanged);
            // 
            // pngimg_rdobtn
            // 
            this.pngimg_rdobtn.AutoSize = true;
            this.pngimg_rdobtn.Checked = true;
            this.pngimg_rdobtn.Location = new System.Drawing.Point(9, 57);
            this.pngimg_rdobtn.Name = "pngimg_rdobtn";
            this.pngimg_rdobtn.Size = new System.Drawing.Size(80, 17);
            this.pngimg_rdobtn.TabIndex = 28;
            this.pngimg_rdobtn.TabStop = true;
            this.pngimg_rdobtn.Text = "PNG Image";
            this.pngimg_rdobtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgSettings_grpbx);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.decrypt_chkbx);
            this.Controls.Add(this.password_txtbx);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.encrypt_chkbx);
            this.Controls.Add(this.source_fs_lbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.containsHeader_lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectTargetFile_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fileToWrite_txtbx);
            this.Controls.Add(this.selectFileToOpen_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fileToOpen_txtbx);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.compare_btn);
            this.Controls.Add(this.videoSettings_grpbx);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.unpackFile_btn);
            this.Controls.Add(this.packFile_btn);
            this.Name = "Main";
            this.Text = "Butterpack";
            ((System.ComponentModel.ISupportInitialize)(this.width_trackbar)).EndInit();
            this.videoSettings_grpbx.ResumeLayout(false);
            this.videoSettings_grpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height_trackbar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.imgSettings_grpbx.ResumeLayout(false);
            this.imgSettings_grpbx.PerformLayout();
            this.gifsettings_grpbx.ResumeLayout(false);
            this.gifsettings_grpbx.PerformLayout();
            this.pngsettings_grpbx.ResumeLayout(false);
            this.pngsettings_grpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertPos_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.Button unpackFile_btn;
        private System.Windows.Forms.Button packFile_btn;
        private System.Windows.Forms.GroupBox videoSettings_grpbx;
        private System.Windows.Forms.TrackBar width_trackbar;
        private System.Windows.Forms.TextBox width_txtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox height_txtbx;
        private System.Windows.Forms.TrackBar height_trackbar;
        private System.Windows.Forms.Button compare_btn;
        private System.Windows.Forms.Label capacity_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fps_txtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton image_rdobtn;
        private System.Windows.Forms.RadioButton video_rdnbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fileToOpen_txtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button selectFileToOpen_btn;
        private System.Windows.Forms.Button selectTargetFile_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fileToWrite_txtbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label containsHeader_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label source_fs_lbl;
        private System.Windows.Forms.CheckBox encrypt_chkbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label imagesize_lbl;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.CheckBox decrypt_chkbx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox imgSettings_grpbx;
        private System.Windows.Forms.CheckBox insertInto_chkbx;
        private System.Windows.Forms.TrackBar insertPos_trackbar;
        private System.Windows.Forms.Button selectINsertFile_btn;
        private System.Windows.Forms.TextBox insertFilePath_txtbx;
        private System.Windows.Forms.Label insertpos_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton gifimg_rdobtn;
        private System.Windows.Forms.RadioButton pngimg_rdobtn;
        private System.Windows.Forms.GroupBox gifsettings_grpbx;
        private System.Windows.Forms.GroupBox pngsettings_grpbx;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox gifframes_txtbx;
    }
}

