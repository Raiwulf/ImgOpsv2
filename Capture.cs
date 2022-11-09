using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImgOps
{
    public class Capture
    {
        public Bitmap CapIt(int x,int width, string capName)
        {
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenHeight = SystemInformation.VirtualScreen.Height;
            string capturedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/Captured/";

            using (Bitmap bitmap = new Bitmap(width, screenHeight))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    var capSize = new Size(width,
                                  screenHeight);

                    Bitmap grayed = new Bitmap(width, screenHeight);
                    g.CopyFromScreen(x, screenTop, 0, 0, capSize);
                    grayed = b2grayNformat(bitmap);
                    grayed.Save(capturedPath + capName + ".jpg");
                    return grayed;
                }
            }
        }

        public static Bitmap b2grayNformat(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            using (Graphics g = Graphics.FromImage(newBitmap))
            {

                //create the grayscale ColorMatrix
                ColorMatrix colorMatrix = new ColorMatrix(
                   new float[][]
                   {
                     new float[] {.3f, .3f, .3f, 0, 0},
                     new float[] {.59f, .59f, .59f, 0, 0},
                     new float[] {.11f, .11f, .11f, 0, 0},
                     new float[] {0, 0, 0, 1, 0},
                     new float[] {0, 0, 0, 0, 1}
                   });

                //create some image attributes
                using (ImageAttributes attributes = new ImageAttributes())
                {

                    //set the color matrix attribute
                    attributes.SetColorMatrix(colorMatrix);

                    //draw the original image on the new image
                    //using the grayscale color matrix
                    g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                                0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            Bitmap final = AForge.Imaging.Image.Clone(newBitmap, PixelFormat.Format24bppRgb);
            return final;
        }

    }
}



