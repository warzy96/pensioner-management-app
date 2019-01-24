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
        private static FolderBrowserDialogService _instance;
        private FolderBrowserDialog _folderBrowserDialog;
        public static FolderBrowserDialogService GetInstance()
        {
            return _instance ?? (_instance = new FolderBrowserDialogService());
        }
        public DialogResult ShowDialog()
        {
            _folderBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = _desktopPath
            };
            return _folderBrowserDialog.ShowDialog();
        }

        public string GetPath()
        {
            return _folderBrowserDialog.SelectedPath + "\\";
        }
    }
}
