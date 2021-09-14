using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Net;
using System.Net.Http;
using AForge.Video;
using AForge.Imaging;
using AForge.Math;
using Vlc;

namespace RTSP
{
    public partial class Form1 : Form
    {
        string videoSelected;
        //MJPEGStream stream;
        //JPEGStream stream;       

        public Form1()
        {
            InitializeComponent();
            //rtsp://admin:213388al@192.168.100.199:554/cam/realmonitor?channel=1&subtype=0

            //stream = new MJPEGStream("rtsp://alarmaq:213388al@45.224.164.99:554/cam/realmonitor?channel=2&subtype=0");
            //stream.NewFrame += GetNewFrame;

            //stream = new JPEGStream("http://45.224.164.99/cgi-bin/mjpg/video.cgi?channel=1&subtype=0");
            //stream.NewFrame += GetNewFrame;
        }

        void GetNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            //pictureBox1.Image = bmp;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(videoSelected == "videoCapture2")
                {
                    videoCapture2.IP_Camera_Source = new VisioForge.Types.Sources.IPCameraSourceSettings()
                    {
                        URL = $"rtsp://{txtUsuario.Text}:{txtSenha.Text}@{txtIp.Text}:{txtPorta.Text}/cam/realmonitor?channel={txtCanal.Text}&subtype=0",
                        Type = VisioForge.Types.VFIPSource.Auto_LAV
                    };

                    videoCapture2.Audio_PlayAudio = false;
                    videoCapture2.Mode = VisioForge.Types.VFVideoCaptureMode.IPPreview;

                    videoCapture2.Start();
                    videoSelected = "";
                }
                else
                {
                    videoCapture1.IP_Camera_Source = new VisioForge.Types.Sources.IPCameraSourceSettings()
                    {
                        URL = $"rtsp://{txtUsuario.Text}:{txtSenha.Text}@{txtIp.Text}:{txtPorta.Text}/cam/realmonitor?channel={txtCanal.Text}&subtype=0",
                        Type = VisioForge.Types.VFIPSource.Auto_LAV
                    };

                    videoCapture1.Audio_PlayAudio = false;
                    videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.IPPreview;

                    videoCapture1.Start();
                    videoSelected = "";
                }
                
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoCapture1.Stop();
        }

        private void videoCapture1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(videoCapture1.Width == 850)
            {
                videoCapture1.Width = 425;
                videoCapture1.Height = 235;

                videoCapture2.Visible = true;
                videoCapture3.Visible = true;
                videoCapture4.Visible = true;
            }
            else
            {
                videoCapture1.Width = 850;
                videoCapture1.Height = 470;

                videoCapture2.Visible = false;
                videoCapture3.Visible = false;
                videoCapture4.Visible = false;
            }
            
        }

        private void videoCapture2_MouseClick(object sender, MouseEventArgs e)
        {
            videoSelected = "videoCapture2";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                videoCapture1.Frame_Save(saveFileDialog1.FileName, VisioForge.Types.VFImageFormat.JPEG,85);
                videoCapture1.WMV_CustomProfile_SaveToFile(VisioForge.Types.OutputFormat.VFMPEGTSOutput, saveFileDialog1.FileName);
            }
            
        }
    }
}
