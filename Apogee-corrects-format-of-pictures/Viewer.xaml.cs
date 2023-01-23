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
using System.Windows.Threading;

namespace Apogee_corrects_format_of_pictures
{
    /// <summary>
    /// Логика взаимодействия для Viewer.xaml
    /// </summary>
    public partial class Viewer : Page
    {
        public int indexPic = 0;
        DispatcherTimer timemachine = new DispatcherTimer();

        public Viewer()
        {
            InitializeComponent();
            LoadPic();
            StartSaveTimer();
        }

        public void LoadPic()
        {
            if (indexPic == ImageList.ApogeeImages.Count - 1)
            {
                MessageBox.Show("КАРТИНКИ КОНЧИЛИСЬ ЕБАТЬ!!!", "КАРТИНКИ КОНЧИЛИСЬ ЕБАТЬ!!!");
                return;
            }

            var pic = ImageList.ApogeeImages[indexPic];

            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(pic, UriKind.RelativeOrAbsolute);
            bi3.EndInit();
            Img.Source = bi3;
            Blur.Source = bi3;

            indexPic++;
        }
        public void StartSaveTimer()
        {
            timemachine.Interval = TimeSpan.FromMilliseconds(10);
            timemachine.Tick += TimerFinish;
            timemachine.Start();
        }

        private void TimerFinish(object? sender, EventArgs e)
        {
            Screenshoter.CaptureMyScreen();
            LoadPic();
        }

        private void MouseUp(object sender, MouseButtonEventArgs e)
        {
            //Screenshoter.CaptureMyScreen();
            //LoadPic();
        }
    }
}
