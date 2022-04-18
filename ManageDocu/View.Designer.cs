
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
            this.viewControl2 = new ManageDocu.ViewControl();
            this.viewControl1 = new ManageDocu.ViewControl();
            this.btnZip = new System.Windows.Forms.Button();
            this.btnFtpCon = new System.Windows.Forms.Button();
            this.RminderBttn = new System.Windows.Forms.Button();
            this.NotepadBttn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.operationButtonsClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Move";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.operationButtonsClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.operationButtonsClicked);
            // 
            // viewControl2
            // 
            this.viewControl2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.viewControl2.CurrentPath = "";
            this.viewControl2.Drives = new string[0];
            this.viewControl2.FilesList = new string[0];
            this.viewControl2.Location = new System.Drawing.Point(29, 24);
            this.viewControl2.Margin = new System.Windows.Forms.Padding(6);
            this.viewControl2.Name = "viewControl2";
            this.viewControl2.Size = new System.Drawing.Size(340, 540);
            this.viewControl2.TabIndex = 4;
            // 
            // viewControl1
            // 
            this.viewControl1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.viewControl1.CurrentPath = "";
            this.viewControl1.Drives = new string[0];
            this.viewControl1.FilesList = new string[0];
            this.viewControl1.Location = new System.Drawing.Point(584, 24);
            this.viewControl1.Margin = new System.Windows.Forms.Padding(6);
            this.viewControl1.Name = "viewControl1";
            this.viewControl1.Size = new System.Drawing.Size(340, 540);
            this.viewControl1.TabIndex = 3;
            // 
            // btnZip
            // 
            this.btnZip.BackColor = System.Drawing.Color.Transparent;
            this.btnZip.BackgroundImage = global::ManageDocu.Properties.Resources.icons8_winrar_48;
            this.btnZip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZip.ForeColor = System.Drawing.Color.Transparent;
            this.btnZip.Location = new System.Drawing.Point(414, 357);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(48, 48);
            this.btnZip.TabIndex = 8;
            this.btnZip.UseVisualStyleBackColor = false;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // btnFtpCon
            // 
            this.btnFtpCon.BackColor = System.Drawing.Color.Transparent;
            this.btnFtpCon.BackgroundImage = global::ManageDocu.Properties.Resources.icons8_ftp_48;
            this.btnFtpCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFtpCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFtpCon.Location = new System.Drawing.Point(486, 357);
            this.btnFtpCon.Name = "btnFtpCon";
            this.btnFtpCon.Size = new System.Drawing.Size(48, 48);
            this.btnFtpCon.TabIndex = 7;
            this.btnFtpCon.Text = "FTP";
            this.btnFtpCon.UseVisualStyleBackColor = false;
            this.btnFtpCon.Click += new System.EventHandler(this.btnFtpCon_Click);
            // 
            // RminderBttn
            // 
            this.RminderBttn.BackColor = System.Drawing.Color.Transparent;
            this.RminderBttn.BackgroundImage = global::ManageDocu.Properties.Resources.icons8_google_calendar_48;
            this.RminderBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RminderBttn.Location = new System.Drawing.Point(414, 428);
            this.RminderBttn.Name = "RminderBttn";
            this.RminderBttn.Size = new System.Drawing.Size(48, 48);
            this.RminderBttn.TabIndex = 6;
            this.RminderBttn.UseVisualStyleBackColor = false;
            this.RminderBttn.Click += new System.EventHandler(this.RminderBttn_Click);
            // 
            // NotepadBttn
            // 
            this.NotepadBttn.BackColor = System.Drawing.Color.Transparent;
            this.NotepadBttn.BackgroundImage = global::ManageDocu.Properties.Resources.icons8_notepad_48;
            this.NotepadBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NotepadBttn.Location = new System.Drawing.Point(486, 428);
            this.NotepadBttn.Name = "NotepadBttn";
            this.NotepadBttn.Size = new System.Drawing.Size(48, 48);
            this.NotepadBttn.TabIndex = 5;
            this.NotepadBttn.UseVisualStyleBackColor = false;
            this.NotepadBttn.Click += new System.EventHandler(this.NotepadBttn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(395, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "Methods";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(425, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tools";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManageDocu.Properties.Resources.XILBcC;
            this.ClientSize = new System.Drawing.Size(960, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnZip);
            this.Controls.Add(this.btnFtpCon);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ViewControl viewControl1;
        private ViewControl viewControl2;
        private System.Windows.Forms.Button NotepadBttn;
        private System.Windows.Forms.Button RminderBttn;
        private System.Windows.Forms.Button btnFtpCon;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}