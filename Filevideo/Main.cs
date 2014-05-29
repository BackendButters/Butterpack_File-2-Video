using Gif.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Filevideo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            image_rdobtn.Checked = true;
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void packFile_btn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fileToOpen_txtbx.Text))
            {
                MessageBox.Show("Invalid sourcefile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(Path.GetDirectoryName(fileToWrite_txtbx.Text)) || fileToWrite_txtbx.Text == string.Empty)
            {
                MessageBox.Show("Invalid targetdirectory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (video_rdnbtn.Checked)
                BL.Transformator.GetInstance().DoButterTransform_video(fileToOpen_txtbx.Text, height_trackbar.Value, width_trackbar.Value, fileToWrite_txtbx.Text);
            else
            { 
                if(pngimg_rdobtn.Checked)
                { 
                if(insertInto_chkbx.Checked && insertFilePath_txtbx.Text == string.Empty)
                {
                    MessageBox.Show("Please specify a image to insert data into or uncheck option", "No file to insert into specified", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                BL.Transformator.GetInstance().DoButterTransform_png(fileToOpen_txtbx.Text, fileToWrite_txtbx.Text, encrypt_chkbx.Checked, password_txtbx.Text);
                }
                else
                {
                    BL.Transformator.GetInstance().DoButterTransform_gif(fileToOpen_txtbx.Text, fileToWrite_txtbx.Text, int.Parse(gifframes_txtbx.Text), encrypt_chkbx.Checked, password_txtbx.Text);
                }

            }
            MessageBox.Show("Done", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void unpackFile_btn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fileToOpen_txtbx.Text))
            {
                MessageBox.Show("Invalid sourcefile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(Path.GetDirectoryName(fileToWrite_txtbx.Text)) || fileToWrite_txtbx.Text == string.Empty)
            {
                MessageBox.Show("Invalid targetdirectory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (image_rdobtn.Checked)
            {
                if (pngimg_rdobtn.Checked)
                    BL.Transformator.GetInstance().DoInverseButterTransform_png(fileToOpen_txtbx.Text, fileToWrite_txtbx.Text, decrypt_chkbx.Checked, password_txtbx.Text);
                else
                    BL.Transformator.GetInstance().DoInverseButterTransform_gif(fileToOpen_txtbx.Text, fileToWrite_txtbx.Text, decrypt_chkbx.Checked, password_txtbx.Text);
            }
            else
                BL.Transformator.GetInstance().DoInverseButterTransform_video(fileToOpen_txtbx.Text, fileToWrite_txtbx.Text);
            MessageBox.Show("Done", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void width_txtbx_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (!int.TryParse(width_txtbx.Text, out result))
            {
                width_txtbx.Text = "1280";
                return;
            }
            if(result == 0)
            {
                width_txtbx.Text = "1280";
                return;
            }
            if(result > 1920)
            {
                MessageBox.Show("Only FullHD for now. Sorry!", "Not supported", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                width_txtbx.Text = "1280";
                return;
            }
            width_trackbar.Value = result;
            updateCapLbl();
        }


        private void width_trackbar_ValueChanged(object sender, EventArgs e)
        {
            width_txtbx.Text = width_trackbar.Value.ToString();
            updateCapLbl();
        }

        private void height_trackbar_ValueChanged(object sender, EventArgs e)
        {
            height_txtbx.Text = height_trackbar.Value.ToString();
            updateCapLbl();
        }

        private void height_txtbx_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (!int.TryParse(height_txtbx.Text, out result))
            {
                height_txtbx.Text = "720";
                return;
            }
            if (result == 0)
            {
                height_txtbx.Text = "720";
                return;
            }
            if (result > 1080)
            {
                MessageBox.Show("Only FullHD for now. Sorry!", "Not supported", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                height_txtbx.Text = "720";
                return;
            }
            height_trackbar.Value = result;
            updateCapLbl();
        }
        private void updateCapLbl()
        {
            double capacity = height_trackbar.Value * width_trackbar.Value;
            
            capacity_lbl.Text = byteToPrefix(capacity);
        }
        private string byteToPrefix(double input)
        {
            if (input > Math.Pow(2, 10) && input < Math.Pow(Math.Pow(2, 10), 2))
                return Math.Round((input / Math.Pow(2, 10)), 3).ToString() + " kB";
            if (input > Math.Pow(Math.Pow(2, 10), 2))
                return Math.Round((input / Math.Pow(Math.Pow(2, 10), 2)), 3).ToString() + " MB";

            return input.ToString() + " B";
        }
        private void compare_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Multiselect = false;
            if (fd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            string fileToRead = fd.FileName;

            OpenFileDialog fd2 = new OpenFileDialog();
            fd2.CheckFileExists = true;
            fd2.CheckPathExists = true;
            fd2.Multiselect = false;
            if (fd2.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            string fileToRead2 = fd2.FileName;

            BL.Transformator.GetInstance().compareFiles(fileToRead, fileToRead2);
        }

        private void fps_txtbx_TextChanged(object sender, EventArgs e)
        {
            int fps = 10;
            if (!int.TryParse(fps_txtbx.Text, out fps))
                fps_txtbx.Text = "10";
        }

        private void setPWTxtbxStatus()
        {
            if (encrypt_chkbx.Checked || decrypt_chkbx.Checked)
                password_txtbx.Enabled = true;
            else
                password_txtbx.Enabled = false;
        }
        private void encrypt_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            setPWTxtbxStatus();
        }

        private void image_rdobtn_CheckedChanged(object sender, EventArgs e)
        {
            if(image_rdobtn.Checked)
            {
                videoSettings_grpbx.Enabled = false;
            }
            else
            {
                MessageBox.Show("Not yet fully implemented, sorry for dat!", "Not yet implemented", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                image_rdobtn.Checked = true;
                return;
                videoSettings_grpbx.Enabled = true;
            }
        }

        private void selectFileToOpen_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Multiselect = false;
            fd.ShowDialog();
            fileToOpen_txtbx.Text = fd.FileName;

            if (!File.Exists(fileToOpen_txtbx.Text))
            {
                MessageBox.Show("Invalid file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fileToOpen_txtbx.Text = "";
                source_fs_lbl.Text = "N/A";
                return;
            }

            FileInfo fi = new FileInfo(fileToOpen_txtbx.Text);
            source_fs_lbl.Text = byteToPrefix(fi.Length);

            List<int> imgDim = BL.Transformator.GetInstance().calculateReqImgDim(fi.Length);
            imagesize_lbl.Text = imgDim[0].ToString() + "x" + imgDim[1].ToString();

            if (fileToOpen_txtbx.Text.EndsWith("jpg") || fileToOpen_txtbx.Text.EndsWith("bmp") || fileToOpen_txtbx.Text.EndsWith("png"))
            { 
            if(BL.Transformator.GetInstance().ContainsHeader(fileToOpen_txtbx.Text))
            {
                containsHeader_lbl.Text = "Yee";
                containsHeader_lbl.ForeColor = Color.Green;
            }
            else
            {
                containsHeader_lbl.Text = "Nope";
                containsHeader_lbl.ForeColor = Color.Orange;
            }
            }
            else
            {
                containsHeader_lbl.Text = "N/A";
                containsHeader_lbl.ForeColor = Color.Orange;
            }
        }

        private void selectTargetFile_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.CheckPathExists = false;
            svd.DefaultExt = ".bmp";
            svd.ShowDialog();
            fileToWrite_txtbx.Text = svd.FileName;
        }

        private void decrypt_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            setPWTxtbxStatus();
        }

        private void selectINsertFile_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Multiselect = false;
            fd.ShowDialog();
            insertFilePath_txtbx.Text = fd.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] imageFilePaths = new String[] { "C:\\2.png", "C:\\3.png" };
            String outputFilePath = "C:\\ani.gif";
            AnimatedGifEncoder ec = new AnimatedGifEncoder();
            ec.Start(outputFilePath);
            ec.SetDelay(500);
            //-1:no repeat,0:always repeat
            ec.SetRepeat(0);
            for (int i = 0, count = imageFilePaths.Length; i < count; i++)
            {
                ec.AddFrame(Image.FromFile(imageFilePaths[i]));
            }
            ec.Finish();
            /* extract Gif */
            string outputPath = "c:\\";
            GifDecoder gifDecoder = new GifDecoder();
            gifDecoder.Read("c:\\test.gif");
            for (int i = 0, count = gifDecoder.GetFrameCount(); i < count; i++)
            {
                Image frame = gifDecoder.GetFrame(i);  // frame i
                frame.Save(outputPath + Guid.NewGuid().ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void insertInto_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            if(insertInto_chkbx.Checked)
            {
                selectINsertFile_btn.Enabled = true;
                insertFilePath_txtbx.Enabled = true;
            }
            else
            {
                selectINsertFile_btn.Enabled = false;
                insertFilePath_txtbx.Enabled = false;
            }
        }

        private void insertFilePath_txtbx_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(insertFilePath_txtbx.Text))
            {
                try
                {
                    Bitmap b = (Bitmap)Bitmap.FromFile(insertFilePath_txtbx.Text);
                    insertPos_trackbar.Maximum = b.Height * b.Width;
                    insertPos_trackbar.Enabled = true;
                    insertpos_lbl.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Filetype not yet supported", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    insertFilePath_txtbx.Text = string.Empty;
                }
            }
            else
            { 
                insertPos_trackbar.Enabled = false;
                insertpos_lbl.Enabled = false;
            }
        }

        private void gifimg_rdobtn_CheckedChanged(object sender, EventArgs e)
        {
            if(gifimg_rdobtn.Checked)
            {
                gifsettings_grpbx.Enabled = true;
                pngsettings_grpbx.Enabled = false;
            }
            else
            {
                gifsettings_grpbx.Enabled = false;
                pngsettings_grpbx.Enabled = true;
            }
        }

        private void gifframes_txtbx_TextChanged(object sender, EventArgs e)
        {
            int k = 0;
            if(!int.TryParse(gifframes_txtbx.Text, out k))
            {
                MessageBox.Show("Please specify a decimal number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gifframes_txtbx.Text = "1";
                return;
            }
        }
    }
}
