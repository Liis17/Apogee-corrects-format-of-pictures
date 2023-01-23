using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Apogee_corrects_format_of_pictures
{
    public static class ViewerWork
    {
        public static void ClearUI()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                MainWindow.button1.Visibility = Visibility.Hidden;
                MainWindow.mainWindowName.MinHeight = 1080;
                MainWindow.mainWindowName.MinWidth = 1920;
                MainWindow.winFrame.Visibility = Visibility.Visible;
                MainWindow.winFrame.Navigate(new Viewer());
            });
        }
    }
}
