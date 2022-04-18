
namespace ManageDocu
{
    partial class Reminder
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CalendarEvents = new System.Windows.Forms.Label();
            this.GetEvents = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(193, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documents with deadline:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalendarEvents
            // 
            this.CalendarEvents.BackColor = System.Drawing.Color.Transparent;
            this.CalendarEvents.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalendarEvents.ForeColor = System.Drawing.Color.White;
            this.CalendarEvents.Location = new System.Drawing.Point(66, 164);
            this.CalendarEvents.Name = "CalendarEvents";
            this.CalendarEvents.Size = new System.Drawing.Size(666, 191);
            this.CalendarEvents.TabIndex = 1;
            this.CalendarEvents.Text = "Documents with deadline";
            this.CalendarEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetEvents
            // 
            this.GetEvents.Enabled = true;
            this.GetEvents.Interval = 10000;
            this.GetEvents.Tick += new System.EventHandler(this.GetEvents_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open Google Calendar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManageDocu.Properties.Resources.XILBcC;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalendarEvents);
            this.Controls.Add(this.label1);
            this.Name = "Reminder";
            this.Text = "Reminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CalendarEvents;
        private System.Windows.Forms.Timer GetEvents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}