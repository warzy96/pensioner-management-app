using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public class FolderBrowserDialogService
    {
        private readonly string _desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\";
        public static DialogResult ShowDialog()
        {
            var fbd = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.DesktopDirectory
            };
            return fbd.ShowDialog();
        }
    }
}
