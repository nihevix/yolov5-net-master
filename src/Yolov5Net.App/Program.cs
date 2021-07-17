using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Yolov5Net.Scorer;
using Yolov5Net.Scorer.Models;

namespace Yolov5Net.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var scorer = new YoloScorer<YoloCocoModel>();

            using var stream = new FileStream("Assets/test1.jpg", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //using var stream = new FileStream("C:\\Users\\Utente\\Desktop",FileMode.Open);
            //FileStream ImageResult = new FileStream(@"Assets/result.jpg", FileMode.Create);

            var image = Image.FromStream(stream);

            List<YoloPrediction> predictions = scorer.Predict(image);

            using var graphics = Graphics.FromImage(image);

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

            //File.WriteAllText("C:\\Users\\Utente\\Desktop", "");


            var folder = @"C:\Users\Utente\Desktop\";
            var file = "image1.jpg";
            var path = Path.Combine(folder, file);
            var resultimage = new Bitmap(image);

           // resultimage.Save(path, ImageFormat.Jpeg);
            image.Save(System.IO.Path.GetTempPath() + "\\myImage1.Jpeg", ImageFormat.Jpeg);
        }
    }
}
