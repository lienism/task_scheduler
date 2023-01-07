using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Compare_Image_test
{
    public partial class Compare_image_form : Form
    {
        public Compare_image_form()
        {
            InitializeComponent();
        }
        Mat Left_Mat = new Mat();
        Mat Right_Mat = new Mat();

        private void Left_pictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                Left_Mat = Cv2.ImRead(openFileDialog1.FileName);
                Left_pictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void Right_picture_Button_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName != "")
            {
                Right_Mat = Cv2.ImRead(openFileDialog2.FileName);
                Right_pictureBox.Image = new Bitmap(openFileDialog2.FileName);
            }
        }

        private void Compare_process_Click(object sender, EventArgs e)
        {
            Mat Left_RGB_processed = RGB_Process(Left_Mat);
            Mat Right_RGB_processed = RGB_Process(Right_Mat);
            Double[] Result = Compare_Image(Left_RGB_processed, Right_RGB_processed);
            hist_compare_value_res.Text = "" + Result[0];
            Match_Shape_value_res.Text = "" + Result[1];
            Debug.WriteLine("asdf");
        }
        public Double[] Compare_Image(Mat left , Mat right)
        {
            Double[] Result = new double[2];
            Double Match_Shape_res = 0.0;
            Double histogram_compare_res = 0.0;
            OpenCvSharp.Point[][] left_contour;
            OpenCvSharp.Point[][] right_contour;
            HierarchyIndex[] left_hi;
            HierarchyIndex[] right_hi;

            left.ConvertTo(left, MatType.CV_8U);
            right.ConvertTo(right, MatType.CV_8U);
            int left_channelNum = left.Channels();
            int right_channelNum = right.Channels();
            var left_histogram = new Mat[left_channelNum];
            var right_histogram = new Mat[right_channelNum];

            int[] hdims = { 256 };
            Rangef[] ranges = { new Rangef(0, 256) };

            left_histogram[0] = new Mat();
            right_histogram[0] = new Mat();


            Mat template_compare_res = new Mat();
            
            Cv2.CvtColor(left, left, ColorConversionCodes.BGR2GRAY);
            Cv2.CvtColor(right, right, ColorConversionCodes.BGR2GRAY);
            Cv2.FindContours(left, out left_contour, out left_hi, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            Cv2.FindContours(right, out right_contour, out right_hi, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            if(left_contour.Length == 1 && right_contour.Length == 1)
            {
                Match_Shape_res = Cv2.MatchShapes(left_contour[0], right_contour[0], ShapeMatchModes.I1);
                Cv2.CalcHist(
                new Mat[] { left },
                new int[] { 0 },
                null,
                left_histogram[0],
                1,
                hdims,
                ranges);
                Cv2.CalcHist(
                new Mat[] { right },
                new int[] { 0 },
                null,
                right_histogram[0],
                1,
                hdims,
                ranges);
                histogram_compare_res = Cv2.CompareHist(left_histogram[0], right_histogram[0], HistCompMethods.Bhattacharyya);
                Result[0] = histogram_compare_res;
                Result[1] = Match_Shape_res;
            }
            //Cv2.MatchTemplate(left, right, template_compare_res, TemplateMatchModes.CCoeffNormed);
           

            return Result;
        }
        public Mat RGB_Process(Mat src)
        {
            Mat result = new Mat();
            Mat Dummy_mat = new Mat();
            OpenCvSharp.Point[][] Blue;
            OpenCvSharp.Point[][] Green;
            OpenCvSharp.Point[][] Red;
            OpenCvSharp.Point[][] Dummy;
            OpenCvSharp.Point[][] result_contour;
            HierarchyIndex[] result_hierachy;
            HierarchyIndex[] blue_hi;
            HierarchyIndex[] green_hi;
            HierarchyIndex[] red_hi;
            Mat[] BGR;
            BGR = Cv2.Split(src);
            for (int i = 0; i < BGR.Length; i++)
            {
                Cv2.CvtColor(BGR[i], BGR[i], ColorConversionCodes.GRAY2BGR);
                Cv2.CvtColor(BGR[i], BGR[i], ColorConversionCodes.BGR2GRAY);
                Cv2.Threshold(BGR[i], BGR[i], 0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);
                for (int a = 0; a <= 6; a++)
                {
                    Cv2.Erode(BGR[i], BGR[i], new Mat());
                    Cv2.Dilate(BGR[i], BGR[i], new Mat());
                }
            }
            Cv2.FindContours(BGR[0], out Blue, out blue_hi, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            Cv2.FindContours(BGR[1], out Green, out green_hi, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            Cv2.FindContours(BGR[2], out Red, out red_hi, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            double Blue_sum = 0;
            for (int i = 0; i < Blue.Length; i++)
            {
                Blue_sum = Blue_sum + Cv2.ContourArea(Blue[i]);
            }
            double Green_sum = 0;
            for (int i = 0; i < Green.Length; i++)
            {
                Green_sum = Green_sum + Cv2.ContourArea(Green[i]);
            }
            double Red_sum = 0;
            for (int i = 0; i < Red.Length; i++)
            {
                Red_sum = Red_sum + Cv2.ContourArea(Red[i]);
            }
            if (Blue_sum < Red_sum)
            {
                Dummy = Blue;
                Dummy_mat = BGR[0];
                Blue = Red;
                BGR[0] = BGR[2];
                Red = Dummy;
                BGR[2] = Dummy_mat;
            }
            if (Blue_sum < Green_sum)
            {
                Dummy = Blue;
                Dummy_mat = BGR[0];
                Blue = Green;
                Dummy_mat = BGR[1];
                Green = Dummy;
                BGR[1] = Dummy_mat;
            }
            if (Red_sum < Green_sum)
            {
                Dummy = Green;
                Dummy_mat = BGR[1];
                Green = Red;
                BGR[1] = BGR[2];
                Red = Dummy;
                BGR[1] = Dummy_mat;
            }
            Cv2.BitwiseAnd(BGR[0], BGR[1], result);
            Cv2.BitwiseOr(result, BGR[2], result);
            Cv2.FindContours(result, out result_contour, out result_hierachy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            Cv2.BitwiseAnd(result.CvtColor(ColorConversionCodes.GRAY2BGR), src, result);
            return result;
        }
    }
}
