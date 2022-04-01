using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageDocu
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
            viewControl1.OnLoadDrives += new EventHandler(this.ViewControlLoadDrives);
            viewControl1.OnPathChanged += new EventHandler(this.loadFiles);
            viewControl1.OnitemClicked += new EventHandler(this.itemClicked);
            viewControl1.GetParentPath += new EventHandler(this.getParentPath);
            viewControl2.OnLoadDrives += new EventHandler(this.ViewControlLoadDrives);
            viewControl2.OnPathChanged += new EventHandler(this.loadFiles);
            viewControl2.OnitemClicked += new EventHandler(this.itemClicked);
            viewControl2.GetParentPath += new EventHandler(this.getParentPath);

        }

        private void ViewControl2_OnPathChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public string[] DrivesList //IView tagok a ButtonsClickedig
        {
            get { return viewControl1.Drives; }
            set { viewControl1.Drives = value;
                viewControl2.Drives = value;
            }
        }
        public string LeftControlPath
        {
            get {
                return viewControl1.CurrentPath;
            }
            set
            {
                viewControl1.CurrentPath = value;
            }
        }
        public string[] LeftControlFiles
        {
            get
            {
                return viewControl1.FilesList;
            }
            set
            {
                viewControl1.FilesList = value;
            }
        }
        public string RightControlPath { get { return viewControl2.CurrentPath; } set { viewControl2.CurrentPath = value; } } //viewControl1 volt megadva
        public string[] RightControlFiles { get { return viewControl2.FilesList; } set { viewControl2.FilesList = value; } }

        public event Func<string[]> LoadMyDrives;
        public event Func<string, string[]> LoadDriveFiles;
        public event Func<string, string, string> CheckItem;
        public event Func<string, string> GetParentPath;
        public event Action<object, EventArgs, string, string, string, string> ButtonsClicked;

        private void View_Load(object sender, EventArgs e) 
        {
            if (LoadMyDrives != null)
            {
                DrivesList = LoadMyDrives();
            }
        }
        private void ViewControlLoadDrives(object sender, EventArgs e) 
        {
            if (LoadMyDrives != null)
            {
                DrivesList = LoadMyDrives();
            }
        }
        private void loadFiles(object sender, EventArgs e) 
        {
            ViewControl control = (ViewControl)sender;

            if (LoadDriveFiles != null)
            {
                control.FilesList = LoadDriveFiles(control.CurrentPath);
            }
        }

        private void getParentPath(object sender, EventArgs e) 
        {
            ViewControl control = (ViewControl)sender;
            if (control.CurrentPath.Length >3 && GetParentPath != null && LoadDriveFiles != null)
            {
                control.CurrentPath = GetParentPath(control.CurrentPath);
                control.FilesList = LoadDriveFiles(control.CurrentPath);
            }
        }
        private void operationButtonsClicked(object sender, EventArgs e) 
        {
            Button button = (Button)sender;
            if (ButtonsClicked != null)
            {
                if (viewControl1.IsFocused)
                {
                    ButtonsClicked(sender, e, LeftControlPath, RightControlPath, viewControl1.ClickedItem, button.Text);
                    viewControl1.Reload(viewControl1, e);
                    viewControl2.Reload(viewControl1, e);
                }
                else if (viewControl2.IsFocused)
                {
                    ButtonsClicked(sender, e, RightControlPath, LeftControlPath, viewControl2.ClickedItem, button.Text);
                    viewControl2.Reload(viewControl1, e);
                    viewControl1.Reload(viewControl1, e); //viewcontrol2 volt írva
                }
            }
        }
        
        private void itemClicked(object sender, EventArgs e) 
        {
            ViewControl control = (ViewControl)sender;
            if (CheckItem != null && LoadDriveFiles != null && control.ClickedItem != null)
            {
                string tmp = control.CurrentPath;
                control.CurrentPath = CheckItem(control.ClickedItem, control.CurrentPath);
                if (control.CurrentPath != tmp && LoadDriveFiles != null)
                {
                    control.FilesList = LoadDriveFiles(control.CurrentPath);
                }
            }
        }

        private void NotepadBttn_Click(object sender, EventArgs e)
        {
            Notepad np = new Notepad();
            np.ShowDialog();
        }
    }
}
