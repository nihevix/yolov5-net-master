

using DirectShowLib;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Yolov5Net.App;



namespace FormVideo
{
    public partial class Form1 : Form
    {
        bool isCameraRunning = false;
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        bool Threadbusy = false;
        YoloRecorder yoloRecord;


        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// make a trasparent layer on the pictureBox where rectangles are draw and
        /// set the list of different video Input
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.BackColor = Color.Transparent;
            var videoDevices = new List<DsDevice>(DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice));
            frame = new Mat();
            yoloRecord = new YoloRecorder(frame);

            foreach (var device in videoDevices)
            {
                ddlVideoDevices.Items.Add(device.Name);
            }
        }

        /// <summary>
        /// 
        /// Starting  assigned Webcam
        /// </summary>
        private void StartCamera()
        {
            DisposeCameraResources();

            isCameraRunning = true;
            btnRecord.Text = "Stop";

            Mat Frame = new Mat();
            int deviceIndex = ddlVideoDevices.SelectedIndex;
            capture = new VideoCapture(deviceIndex);
            capture.Open(deviceIndex);
        }

        private void StopCamera()
        {
            isCameraRunning = false;
            btnRecord.Text = "Start";

            recordingTimer.Stop();
            recordingTimer.Enabled = false;

            DisposeCaptureResources();
        }
        private void DisposeCameraResources()
        {
            if (frame != null)
            {
                frame.Dispose();
            }

            if (image != null)
            {
                image.Dispose();
            }
        }
        private void DisposeCaptureResources()
        {
            if (capture != null)
            {
                capture.Release();
                capture.Dispose();
            }


        }
        private void YoloThreadMethod()
        {
            Threadbusy = true;
            Mat frame = new Mat();
            capture.Read(frame);
            yoloRecord.Start(frame);
            pictureBox2.Image = yoloRecord.bitmap;
            Threadbusy = false;

        }
        private async void recordingTimer_Tick(object sender, EventArgs e)
        {
            if (capture.IsOpened())
            {
                try
                {
                    Mat frame = new Mat();
                    capture.Read(frame);
                    if (!Threadbusy)
                    {
                        Thread t = new Thread(new ThreadStart(YoloThreadMethod));
                        t.Start();
                    }
                    if (frame != null)
                    {

                        image = BitmapConverter.ToBitmap(frame);
                        pictureBox1.Image = image;

                    }

                }
                catch (Exception)
                {
                    pictureBox1.Image = null;
                }

            }
        }


        private async void btnRecord_Click(object sender, EventArgs e)
        {
            if (ddlVideoDevices.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a video device as the Video Source.", "Video Source Not Defined", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isCameraRunning)
            {
                lblStatus.Text = "Starting recording...";
                StartCamera();
                recordingTimer.Enabled = true;
                lblStatus.Text = "Recording...";
            }
            else
            {
                StopCamera();
                lblStatus.Text = "Recording ended.";

            }
        }
    }
}