using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Wpf.Ui.Controls;

using WinForms = System.Windows.Forms;

namespace Apogee_corrects_format_of_pictures
{
    public static class SearchFiles
    {

        public static void SearchFilesMethod()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            FolderView(fbd.SelectedPath);
        }

        public static void FolderView(string path)
        {
            var directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    ImageList.ApogeeImages.Add(file.FullName);
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
