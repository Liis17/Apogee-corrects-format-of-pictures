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
        public int countPics = 0;
        DispatcherTimer timemachine = new DispatcherTimer();
        public static int speed = 500;

        public Viewer()
        {
            countPics = ImageList.RamImages.Count/* - 1*/;

            InitializeComponent();
            LoadPic();
            StartSaveTimer();
        }

        public void LoadPic()
        {
            if (indexPic == countPics)
            {
                timemachine.Stop();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MainWindow.mainWindowName.WindowState = WindowState.Normal;
                });
                MessageBox.Show("КАРТИНКИ КОНЧИЛИСЬ!!!", "КАРТИНКИ КОНЧИЛИСЬ!!!");
                return;
            }

            if(indexPic != 0)
            {
                ImageList.RamImages[indexPic - 1] = null;

                GC.Collect();
            }

            var pic = ImageList.RamImages[indexPic];

            pic.Freeze();

            Img.Source = pic;
            Blur.Source = pic;

            indexPic++;
        }
        public void StartSaveTimer()
        {
            timemachine.Interval = TimeSpan.FromMilliseconds(speed);
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
