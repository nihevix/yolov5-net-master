using System;
using System.Collections.Generic;
using System.Drawing;
using Yolov5Net.Scorer;
using Yolov5Net.Scorer.Models;
using OpenCvSharp;


namespace Yolov5Net.App
{
    public class YoloRecorder
    {

        public Bitmap bitmap;
        YoloScorer<YoloCocoModel> scorer;
        public  YoloRecorder(Mat stream)
        {
            scorer = new YoloScorer<YoloCocoModel>();
        }

        public async void Start(Mat stream)
        {

            Image image = MatToBitmap(stream);

            List<YoloPrediction> predictions = scorer.Predict(image);

            bitmap = new Bitmap(image.Width, image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using Graphics graphics = Graphics.FromImage(bitmap);
            foreach (var prediction in predictions) // iterate each prediction to draw results
            {
                double score = Math.Round(prediction.Score, 2);

                graphics.DrawRectangles(new Pen(prediction.Label.Color, 1),
                    new[] { prediction.Rectangle });

                var (x, y) = (prediction.Rectangle.X - 3, prediction.Rectangle.Y - 23);

                graphics.DrawString($"{prediction.Label.Name} ({score})",
                    new Font("Consolas", 16, GraphicsUnit.Pixel), new SolidBrush(prediction.Label.Color),
                    new PointF(x, y));
            }
        }

        public static Bitmap MatToBitmap(Mat image)
        {
            try
            {
                return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
            }
            catch
            {
                image = new Mat();
                return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
            }
        } // end of MatToBitmap function
    }
}
