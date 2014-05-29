using AviFile;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using NReco.VideoConverter;
using System.Windows.Forms;
using System.Security.Cryptography;
using Gif.Components;
namespace Filevideo.BL
{
    public class Transformator
    {
        private static Transformator instance = null;
        private const double desiredImgXRatio = 16;
        private const double desiredImgYRatio = 9;
        public const double usedBytesPerPixel = 3;
        public byte[] dataFrameHeader = null;
        private Transformator()
        {
            dataFrameHeader = new byte[] { 66, 69, 11, 0, 0, 101 };
        }
        public List<int> calculateReqImgDim(long sizeInBytes)
        {
            double overallBytesReq = sizeInBytes + dataFrameHeader.Length;

            double requiredPixels = (long)(Math.Ceiling((double)((overallBytesReq / usedBytesPerPixel))));

            double x = (desiredImgXRatio / desiredImgYRatio);

            double left = Math.Ceiling(requiredPixels / x);
            double height = (long)(Math.Ceiling(Math.Sqrt(left)));
            double width = (long)(Math.Ceiling((double)((requiredPixels / height))));

            return new List<int> { (int)width, (int)height };
        }
       
        #region ButterTransform
        internal void DoButterTransform_video(string filepath, int height, int width, string targetFile)
        {
            byte[] fileAsBytes = readFileAsBytes(filepath);
            Bitmap singleImage = bytesToBitmap(fileAsBytes, height, width);
            CreateMovie(width, height, targetFile, singleImage);
        }
        internal void DoButterTransform_png(string filepath, string targetfile, bool encrypt, string password = "")
        {
            byte[] fileAsBytes = readFileAsBytes(filepath);
            byte[] dataFrame = getDataFrame(fileAsBytes, encrypt, password);
            bytesToBitmap(dataFrame).Save(targetfile);
        }
        internal void DoButterTransform_gif(string filepath, string targetfile, int frameCount, bool encrypt, string password = "")
        {
            byte[] fileAsBytes = readFileAsBytes(filepath);
            byte[] dataFrame = getDataFrame(fileAsBytes, encrypt, password);

            int byteLengthPerGifFrame = (int)Math.Ceiling((double)dataFrame.Length / frameCount);
            List<int> frameDimensions = calculateReqImgDim(byteLengthPerGifFrame);

            List<Bitmap> gifFrames = new List<Bitmap>();
            for (int i = 0; i < frameCount; i++ )
            {
                List<byte> subFrame = new List<byte>();
                for(int k = i * byteLengthPerGifFrame; k<i*byteLengthPerGifFrame + byteLengthPerGifFrame; k++)
                {
                    subFrame.Add(dataFrame[k]);
                }
                gifFrames.Add(bytesToBitmap(subFrame.ToArray(),frameDimensions[0],frameDimensions[1]));
            }

            AnimatedGifEncoder ec = new AnimatedGifEncoder();
            ec.SetQuality(100);
            ec.Start(targetfile);
            
            ec.SetDelay(500);
            //-1:no repeat,0:always repeat
            ec.SetRepeat(0);
            for (int i = 0, count = gifFrames.Count; i < count; i++)
            {
                ec.AddFrame(gifFrames[i]);
            }
            ec.Finish();
        }
        private byte[] getDataFrame(byte[] fileAsBytes, bool encrypt, string password = "")
        {
            //Header 6Byte
            //Length 4Byte
            //Payload x

            if(encrypt)
                fileAsBytes = Crypto.GetInstance().encryptByteArray(fileAsBytes, password);

            List<byte> overallData = new List<byte>();
            overallData.AddRange(dataFrameHeader);
            overallData.AddRange(BitConverter.GetBytes(fileAsBytes.Length));
            overallData.AddRange(fileAsBytes);

            return overallData.ToArray();
        }
        private Bitmap bytesToBitmap(byte[] bytes, int height = 0, int width = 0)
        {
            if(height == 0 && width == 0)
            {
                List<int> imgDimensions = calculateReqImgDim(bytes.Length);
                width = imgDimensions[0];
                height = imgDimensions[1];
            }

            long datapointer = 0;
            Bitmap bmp = new Bitmap(width, height);
            Color c = new Color();
            Random rnd = new Random();

            for (int i = 0; i < width; i++)
            {
                for (int k = 0; k < height; k++)
                {
                    if (datapointer > bytes.Length)
                        c = Color.FromArgb((int)rnd.Next(0, 255), (int)rnd.Next(0, 255), (int)rnd.Next(0, 255));
                    else
                    {
                        int Rpointer = 0;
                        int Gpointer = 0;
                        int Bpointer = 0;


                        if (datapointer < bytes.Length)
                            Rpointer = (int)datapointer;
                        else
                            Rpointer = rnd.Next(0, 255);
                        datapointer++;

                        if (datapointer < bytes.Length)
                            Gpointer = (int)datapointer;
                        else
                            Gpointer = rnd.Next(0, 255);
                        datapointer++;

                        if (datapointer < bytes.Length)
                            Bpointer = (int)datapointer;
                        else
                            Bpointer = rnd.Next(0, 255);
                        datapointer++;

                        c = Color.FromArgb(bytes[Rpointer], bytes[Gpointer], bytes[Bpointer]);
                    }
                    
                    bmp.SetPixel(i,k, c);
                }
            }
            return bmp;
        }

        private byte[] readFileAsBytes(string filepath)
        {
            //Limit: 2.147GB!

            if (filepath == string.Empty)
                return new byte[0];

            FileStream fs = null;
            byte[] bytes;
            try
            {
                fs = File.OpenRead(filepath);
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));

            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
            return bytes;
        }

        private void CreateMovie(int width, int height, string filepath, Bitmap image)
        {
            double framerate = 10;

            Bitmap b = (Bitmap)image.Clone();
            AviManager avm = new AviManager(filepath, false);
            
            VideoStream vs = avm.AddVideoStream(false, framerate, b);
            
            for (int i = 0; i < 20; i++)
            {
                b = (Bitmap)image.Clone();
                vs.AddFrame(b);
            }
            avm.Close();
        }
        #endregion

        #region inverse ButterTransform
        internal void DoInverseButterTransform_video(string filepathToOpen, string filepathToSave)
        {
            //List<Bitmap> frames = readVideoAsImages(filepathToOpen);
            List<Bitmap> frames = readVideoAsImages_AForge(filepathToOpen);
            List<byte[]> framesAsByte = framesToBytes(frames);
            //List<byte[]> framesWOHandF = removeHandF(framesAsByte);
            //saveBytesToFile(framesWOHandF[0], filepathToSave);
        }
        internal void DoInverseButterTransform_png(string filepathToOpen, string filepathToSave, bool decrypt, string password = "")
        {
            Bitmap bmp = (Bitmap)Bitmap.FromFile(filepathToOpen);
            byte[] payload = getPayloadFromImage(bmp, decrypt,password);
            saveBytesToFile(payload, filepathToSave);
        }
        internal void DoInverseButterTransform_gif(string filepathToOpen, string filepathToSave, bool decrypt, string password = "")
        {
            GifDecoder gifDecoder = new GifDecoder();
            gifDecoder.Read(filepathToOpen);
            List<Bitmap> frames = new List<Bitmap>();
            for (int i = 0, count = gifDecoder.GetFrameCount(); i < count; i++)
            {
                frames.Add(new Bitmap(gifDecoder.GetFrame(i)));  // frame i
                
            }
            throw new NotImplementedException("Not yet implemented");

            byte[] payload = getPayloadFromImage(frames[1], decrypt, password);

            //saveBytesToFile(payload, filepathToSave);
        }
        internal bool ContainsHeader(string filepath)
        {
            Bitmap bmp = (Bitmap)Bitmap.FromFile(filepath);
            return checkForHeader(bmp);
        }
        private bool checkForHeader(Bitmap bmp)
        {
            List<byte> imgDataStream = new List<byte>();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int k = 0; k < bmp.Height; k++)
                {
                    Color c = bmp.GetPixel(i, k);
                    imgDataStream.Add(c.R);
                    imgDataStream.Add(c.G);
                    imgDataStream.Add(c.B);
                }
            }

            bool headerFound = false;
            int headerStartPos = 0;
            for (int i = 0; i < imgDataStream.Count; i++)
            {
                if (headerFound)
                    break;

                if (imgDataStream[i] == dataFrameHeader[0])
                {
                    headerFound = true;
                    for (int j = 0; j < dataFrameHeader.Length; j++)
                    {
                        if (imgDataStream[i + j] == dataFrameHeader[j] && headerFound)
                            headerFound = true;
                        else
                            headerFound = false;
                    }
                    if (headerFound)
                        headerStartPos = i;
                }
            }
            return headerFound;
        }
        private byte[] getPayloadFromImage(Bitmap bmp, bool decrypt, string password = "")
        {
            List<byte> imgDataStream = new List<byte>();
            for(int i = 0; i<bmp.Width; i++)
            {
                for(int k = 0; k<bmp.Height; k++)
                {
                    Color c = bmp.GetPixel(i, k);
                    imgDataStream.Add(c.R);
                    imgDataStream.Add(c.G);
                    imgDataStream.Add(c.B);
                }
            }

            bool headerFound = false;
            int headerStartPos = 0;
            for(int i = 0; i<imgDataStream.Count; i++)
            {
                if(headerFound)
                    break;

                if(imgDataStream[i] == dataFrameHeader[0])
                {
                    headerFound = true;
                    for(int j = 0; j<dataFrameHeader.Length; j++)
                    {
                        if (imgDataStream[i + j] == dataFrameHeader[j] && headerFound)
                            headerFound = true;
                        else
                            headerFound = false;
                    }
                    if (headerFound)
                        headerStartPos = i;
                }
            }
            if (!headerFound)
                throw new FormatException("Could not find header in this file");

            byte[] lengthBytes = imgDataStream.GetRange(headerStartPos+dataFrameHeader.Length,4).ToArray();
            int payloadLength = BitConverter.ToInt32(lengthBytes, 0);

            List<byte> payload = new List<byte>();

            for (int i = 0; i < payloadLength; i++)
            {
                payload.Add(imgDataStream[i + headerStartPos + dataFrameHeader.Length + 4]);
            }

            byte[] result;
            if (decrypt)
                result = Crypto.GetInstance().decryptByteArray(payload.ToArray(), password, payloadLength);
            else
                result = payload.ToArray();

            return result;
        }
        private List<Bitmap> readVideoAsImages_AForge(string filePathToOpen)
        {
            FileStream F = new FileStream("sample.txt", FileMode.CreateNew, FileAccess.Write, FileShare.Write);

            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            ffMpeg.ConvertMedia(filePathToOpen, F, NReco.VideoConverter.Format.avi);



            return new List<Bitmap>();
        }

        private void saveBytesToFile(byte[] b, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);

            fs.Write(b, 0, b.Length);

            fs.Close();
        }
        private List<byte[]> framesToBytes(List<Bitmap> frames)
        {
            List<byte[]> result = new List<byte[]>();
            for (int i = 0; i < frames.Count; i++)
            {
                byte[] singleRow = new byte[frames[i].Width * frames[i].Height];
                int posCounter = 0;
                for(int w = 0; w<frames[i].Width; w++)
                {
                    for(int h = 0; h<frames[i].Height;h++)
                    {
                        singleRow[posCounter] = frames[i].GetPixel(w, h).R;
                        posCounter++;
                    }
                }
                result.Add(singleRow);
            }
            return result;
        }
        private List<Bitmap> readVideoAsImages(string filepathToOpen)
        {
            AviManager avm = new AviManager(filepathToOpen, true);

            VideoStream vs = avm.GetVideoStream();
            vs.GetFrameOpen();

            List<Bitmap> frames = new List<Bitmap>();

            for(int i = 0; i < vs.CountFrames; i++)
            {
                frames.Add(vs.GetBitmap(i));
            }
            vs.GetFrameClose();
            avm.Close();
            return frames;
        }

        #endregion

        internal bool compareFiles(string filepath1, string filepath2)
        {
            byte[] f1 = readFileAsBytes(filepath1);
            byte[] f2 = readFileAsBytes(filepath2);

            if (f1.Length != f2.Length)
            {
                MessageBox.Show("Files differ by length!", "Not equal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
            }

            for(int i = 0; i<filepath1.Length; i++)
            {
                if (f1[i] != f2[i])
                { 
                    MessageBox.Show("Files differ by content!", "Not equal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
                }

            }
            MessageBox.Show("Files seem to be equal", "Files equal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public static Transformator GetInstance()
        {
            if (instance == null)
                instance = new Transformator();
            return instance;
        }
    }
}