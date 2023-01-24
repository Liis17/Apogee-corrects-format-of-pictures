using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Apogee_corrects_format_of_pictures
{
    public class Screenshoter
    {
        public static double screenLeft = 0;
        public static double screenTop = 0;
        public static double screenWidth = 2559;
        public static double screenHeight = 1439;
        public static void CaptureMyScreen()
        {
            try
            {
                /*
                double screenLeft = SystemParameters.VirtualScreenLeft;
                double screenTop = SystemParameters.VirtualScreenTop;
                double screenWidth = SystemParameters.VirtualScreenWidth;
                double screenHeight = SystemParameters.VirtualScreenHeight;
                */

                using (Bitmap bmp = new Bitmap((int)screenWidth, (int)screenHeight))
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        String filename = $"image{DateTime.Now.ToString("HH.mm.ss.fff")}.png";
                        g.CopyFromScreen((int)screenLeft, (int)screenTop, 0, 0, bmp.Size);

                        var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\apogeescreenshots";
                        Directory.CreateDirectory(path);
                        //var path = "A:\\apogeescreenshots";

                        var fileName = Path.Combine(path, filename);
                        bmp.Save(fileName);

                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

    }
}
