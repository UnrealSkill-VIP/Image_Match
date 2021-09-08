using System.Windows.Forms;
using System;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Diagnostics;
using Emgu.CV.CvEnum;
public class SearchImageClass
{
    private enum TernaryRasterOperations : uint
    {
        SRCCOPY = 0x00CC0020,
        SRCPAINT = 0x00EE0086,
        SRCAND = 0x008800C6,
        SRCINVERT = 0x00660046,
        SRCERASE = 0x00440328,
        NOTSRCCOPY = 0x00330008,
        NOTSRCERASE = 0x001100A6,
        MERGECOPY = 0x00C000CA,
        MERGEPAINT = 0x00BB0226,
        PATCOPY = 0x00F00021,
        PATPAINT = 0x00FB0A09,
        PATINVERT = 0x005A0049,
        DSTINVERT = 0x00550009,
        BLACKNESS = 0x00000042,
        WHITENESS = 0x00FF0062,
        CAPTUREBLT = 0x40000000
    }
    public static Bitmap outputImage;
    public static void SearchImage(Bitmap imgSource, Bitmap imgSeach, double accuracy)
    {
        try
        {
            Image<Bgr, byte> template = new Image<Bgr, byte>(imgSeach);
            Image<Bgr, byte> source = new Image<Bgr, byte>(imgSource);
            Image<Bgr, byte> imageToShow = source.Copy();
            Stopwatch watch = Stopwatch.StartNew();
            Image<Gray, float> result = source.MatchTemplate(template, TemplateMatchingType.CcoeffNormed);
            double[] minValues, maxValues;
            Point[] minLocations, maxLocations;
            result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
            watch.Stop();
            if (maxValues[0] > accuracy)
            {
                Rectangle match = new Rectangle(maxLocations[0], template.Size);
                imageToShow.Draw(match, new Bgr(Color.Blue), 3);
                outputImage = imageToShow.ToBitmap();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
}
