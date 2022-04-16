using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageDocu
{
    public partial class Zipper : Form
    {
        public Zipper()
        {
            InitializeComponent();
        }
        string pathtofolder;
        string zipfolder;

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog obj = new FolderBrowserDialog(); //Mappa böngésző
            DialogResult result = obj.ShowDialog(); //Mappa kiválasztása
            if (result==DialogResult.OK && !string.IsNullOrWhiteSpace(obj.SelectedPath)) //Ha létezik a mappa
            {
                string[] folder = obj.SelectedPath.Split('\\'); //A mappa egy tömbbe kerül \ alapján elválasztva
                string foldertobezip = folder[folder.Length - 1]; //A tömb utolsó előtti eleme
                pathtofolder = obj.SelectedPath;
                zipfolder = string.Join(@"\", folder.Take(folder.Length - 1)) + @"\" + foldertobezip + ".zip"; 
                ZipFile.CreateFromDirectory(pathtofolder, zipfolder); //Elkészül a ZIP file
                MessageBox.Show("Zip file is created!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZipFile.ExtractToDirectory(zipfolder, pathtofolder);
        }
    }
}
