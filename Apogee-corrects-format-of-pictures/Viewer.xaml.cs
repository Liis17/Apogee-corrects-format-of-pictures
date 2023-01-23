using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Apogee_corrects_format_of_pictures
{
    /// <summary>
    /// Логика взаимодействия для Viewer.xaml
    /// </summary>
    public partial class Viewer : Page
    {
        public int indexPic = 0;
        public Viewer()
        {
            InitializeComponent();
            LoadPic();
        }

        public void LoadPic()
        {
            if (indexPic <= ImageList.ApogeeImages.Count - 1)
            {
                MessageBox.Show("КАРТИНКИ КОНЧИЛИСЬ ЕБАТЬ!!!", "КАРТИНКИ КОНЧИЛИСЬ ЕБАТЬ!!!");
                return;
            }





                if (indexPic <= ImageList.ApogeeImages.Count - 1)
            {
                picUpdate(ImageList.ApogeeImages[indexPic]);
                indexPic++;
            }
            
        }

        public void picUpdate(string pic)
        {
            if (pic.Contains(".gif") && pic.Contains(".webm") && pic.Contains(".mp4"))
            {
                indexPic++;
            }
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(pic, UriKind.RelativeOrAbsolute);
            bi3.EndInit();
            Img.Source = bi3;
            Blur.Source = bi3;
        }

        private void MouseUp(object sender, MouseButtonEventArgs e)
        {
            LoadPic();
        }
    }
}
