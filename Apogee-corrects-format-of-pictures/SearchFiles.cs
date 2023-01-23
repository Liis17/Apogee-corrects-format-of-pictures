using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows;

using Wpf.Ui.Controls;

using WinForms = System.Windows.Forms;

namespace Apogee_corrects_format_of_pictures
{
    public static class SearchFiles
    {

        public static void SearchFilesMethod()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                MainWindow.button1.Visibility = Visibility.Hidden;
                MainWindow.loadText.Visibility = Visibility.Visible;
            });
            fbd.ShowDialog();
            FolderView(fbd.SelectedPath);
        }

        public static void FolderView(string path)
        {
            if(path == "") 
            {
                System.Windows.Application.Current.Dispatcher.Invoke(() =>
                {
                    MainWindow.button1.Visibility = Visibility.Visible;
                    MainWindow.loadText.Visibility = Visibility.Hidden;
                });
                return; 
            }
            var directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (file.FullName.Contains(".mp4") || file.FullName.Contains(".gif") || file.FullName.Contains(".webm")) continue;
                    ImageList.ApogeeImages.Add(file.FullName);

                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri(file.FullName, UriKind.RelativeOrAbsolute);
                    bi3.EndInit();

                    ImageList.RamImages.Add(bi3);
                }
                ViewerWork.ClearUI();

            }
            else
            {
                System.Windows.MessageBox.Show("Папки не существует");
            }


         
        }
    }
}
