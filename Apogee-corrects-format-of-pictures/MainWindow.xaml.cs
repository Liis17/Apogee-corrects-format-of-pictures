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
        public MainWindow()
        {
            InitializeComponent();
            button1 = Button1;
            winFrame = WinFrame;
            mainWindowName = MainWindowName;
            loadText = LoadText;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
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
    }
}
