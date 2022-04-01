using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageDocu
{
    public class Presenter
    {
        Model model;
        IView view;
        public Presenter(Model model, IView view) 
        {
            this.model = model;
            this.view = view;
            view.LoadMyDrives += getDrives;
            view.LoadDriveFiles += getFiles;
            view.GetParentPath += getParent;
            view.ButtonsClicked += operation;
            view.CheckItem += checkItem;

        }

        private string[] getDrives() 
        {
            return model.LoadMyDrives();
        }

        private string[] getFiles(string path) 
        {
            return model.LoadDriveFiles(path);
        }
        private string getParent(string path) 
        {
            return model.GetParent(path);
        }

        private void operation(object obj, EventArgs e, string source, string target, string item, string operation) 
        {
            model.PerformOperation(source, target, item, operation);
        }
        private string checkItem(string item, string path) 
        {
            return model.CheckItem(item, path);
        }

    }
}
