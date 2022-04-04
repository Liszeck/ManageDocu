
namespace ManageDocu
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NotepadBttn = new System.Windows.Forms.Button();
            this.viewControl2 = new ManageDocu.ViewControl();
            this.viewControl1 = new ManageDocu.ViewControl();
            this.RminderBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.operationButtonsClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Move";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.operationButtonsClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.operationButtonsClicked);
            // 
            // NotepadBttn
            // 
            this.NotepadBttn.Location = new System.Drawing.Point(380, 471);
            this.NotepadBttn.Name = "NotepadBttn";
            this.NotepadBttn.Size = new System.Drawing.Size(75, 23);
            this.NotepadBttn.TabIndex = 5;
            this.NotepadBttn.Text = "Notepad";
            this.NotepadBttn.UseVisualStyleBackColor = true;
            this.NotepadBttn.Click += new System.EventHandler(this.NotepadBttn_Click);
            // 
            // viewControl2
            // 
            this.viewControl2.CurrentPath = "";
            this.viewControl2.Drives = new string[0];
            this.viewControl2.FilesList = new string[0];
            this.viewControl2.Location = new System.Drawing.Point(12, 12);
            this.viewControl2.Margin = new System.Windows.Forms.Padding(6);
            this.viewControl2.Name = "viewControl2";
            this.viewControl2.Size = new System.Drawing.Size(343, 546);
            this.viewControl2.TabIndex = 4;
            // 
            // viewControl1
            // 
            this.viewControl1.CurrentPath = "";
            this.viewControl1.Drives = new string[0];
            this.viewControl1.FilesList = new string[0];
            this.viewControl1.Location = new System.Drawing.Point(479, 12);
            this.viewControl1.Margin = new System.Windows.Forms.Padding(6);
            this.viewControl1.Name = "viewControl1";
            this.viewControl1.Size = new System.Drawing.Size(343, 539);
            this.viewControl1.TabIndex = 3;
            // 
            // RminderBttn
            // 
            this.RminderBttn.Location = new System.Drawing.Point(380, 517);
            this.RminderBttn.Name = "RminderBttn";
            this.RminderBttn.Size = new System.Drawing.Size(75, 23);
            this.RminderBttn.TabIndex = 6;
            this.RminderBttn.Text = "Reminder";
            this.RminderBttn.UseVisualStyleBackColor = true;
            this.RminderBttn.Click += new System.EventHandler(this.RminderBttn_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 552);
            this.Controls.Add(this.RminderBttn);
            this.Controls.Add(this.NotepadBttn);
            this.Controls.Add(this.viewControl2);
            this.Controls.Add(this.viewControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ViewControl viewControl1;
        private ViewControl viewControl2;
        private System.Windows.Forms.Button NotepadBttn;
        private System.Windows.Forms.Button RminderBttn;
    }
}