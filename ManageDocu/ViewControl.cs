using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace ManageDocu
{
    public partial class ViewControl : UserControl
    {
        public ViewControl()
        {
            InitializeComponent();
        }


        
        //A UserControl Toolbox megjelenítése miatt implementáljuk
        [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
        public class UserControl1 : System.Windows.Forms.UserControl
        {
           
    
        }

        public string CurrentPath {  get { return textBox1.Text; } set { textBox1.Text = value; } }
        public string[] Drives { get { return comboBox1.Items.OfType<string>().ToArray(); } set { comboBox1.Items.Clear(); comboBox1.Items.AddRange(value); } }

        public string[] FilesList 
        {
            get { return listBox1.Items.OfType<string>().ToArray(); }
            set { listBox1.Items.Clear();
                if (value != null)
                {
                    listBox1.Items.AddRange(value);
                }
            }
            
        }
        public string ClickedItem 
        {
            get
            {
                if (listBox1.SelectedIndex != -1)
                {
                    return listBox1.SelectedItem.ToString();
                }
                else
                {
                    return "";
                }
            }
        }

        public bool IsFocused
        {
            get
            {
                if (listBox1.SelectedIndex != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public event EventHandler OnLoadDrives;
        public event EventHandler OnPathChanged;
        public event EventHandler OnitemClicked;
        public event EventHandler GetParentPath;

        private void ViewControl_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e) 
        {
            if (OnLoadDrives != null)
            {
                OnLoadDrives(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetParentPath != null)
            {
                GetParentPath(this, e);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                CurrentPath = comboBox1.SelectedItem.ToString();
                if (OnPathChanged!=null)
                {
                    OnPathChanged(this, e);
                }
            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e) 
        {
            if (OnitemClicked != null)
            {
                OnitemClicked(this, e);
            }
        }

        public void Reload(object sender, EventArgs e) 
        {
            OnPathChanged(this, e);
        }
    }
}
