using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageDocu
{
    public interface IView
    {
        string[] DrivesList { get; set; }
        string LeftControlPath { get; set; }
        string[] LeftControlFiles { get; set; }
        string RightControlPath { get; set; }
        string[] RightControlFiles { get; set; }

        event Func<string[]> LoadMyDrives;
        event Func<string, string[]> LoadDriveFiles;
        event Func<string, string, string> CheckItem;
        event Func<string, string> GetParentPath;
        event Action<object, EventArgs, string, string, string, string> ButtonsClicked;

    }
}
