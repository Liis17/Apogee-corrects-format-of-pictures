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

using Wpf.Ui.Controls;

using MessageBox = System.Windows.MessageBox;

namespace Apogee_corrects_format_of_pictures
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UiWindow
    {
        public static System.Windows.Controls.Button? button1;
        public static Frame? winFrame;
        public static UiWindow? mainWindowName;
        public static TextBlock? loadText;
        public static Grid? otherUI;
        public MainWindow()
        {
            InitializeComponent();
            button1 = Button1;
            winFrame = WinFrame;
            mainWindowName = MainWindowName;
            loadText = LoadText;
            otherUI = OtherUI;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"экран:\nЛЕВЫЙ\nвысота {Screenshoter.screenTop}   ширина {Screenshoter.screenLeft}\nПРАВЫЙ\nвысота {Screenshoter.screenHeight}   ширина {Screenshoter.screenWidth}");
            SearchFiles.SearchFilesMethod();
        }

        private void MouseLeave(object sender, MouseEventArgs e)
        {
            maintitlebar.Visibility= Visibility.Hidden;
        }

        private void MouseEnter(object sender, MouseEventArgs e)
        {
            maintitlebar.Visibility = Visibility.Visible;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //левая высота
            System.Windows.Controls.TextBox box = (System.Windows.Controls.TextBox)sender;
            try
            {
                Screenshoter.screenTop = Convert.ToDouble(box.Text);
            }
            catch
            {
                Screenshoter.screenTop = 0;
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            //левый ширина
            System.Windows.Controls.TextBox box = (System.Windows.Controls.TextBox)sender;
            try
            {
                Screenshoter.screenLeft = Convert.ToDouble(box.Text);
            }
            catch
            {
                Screenshoter.screenLeft = 0;
            }
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            //правый ширина
            System.Windows.Controls.TextBox box = (System.Windows.Controls.TextBox)sender;
            try
            {
                Screenshoter.screenWidth = Convert.ToDouble(box.Text);

            }
            catch
            {
                Screenshoter.screenWidth = 0;
            }
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            //правый высота
            System.Windows.Controls.TextBox box = (System.Windows.Controls.TextBox)sender;
            try
            {
                Screenshoter.screenHeight = Convert.ToDouble(box.Text);
            }
            catch
            {
                Screenshoter.screenHeight = 0;
            }
        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {
            //скорость
            System.Windows.Controls.TextBox box = (System.Windows.Controls.TextBox)sender;
            try
            {
                Viewer.speed = Convert.ToInt16(box.Text);
            }
            catch
            {
                Viewer.speed = 0;
            }

        }
    }
}
