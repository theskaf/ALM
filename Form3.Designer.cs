namespace ALM
{
    partial class frmSettingsAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingsAbout));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            rbOn = new RadioButton();
            rbOff = new RadioButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(773, 444);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(765, 416);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Settings";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(765, 416);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "How to play";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(765, 416);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "About";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOff);
            groupBox1.Controls.Add(rbOn);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(112, 91);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Music - Sounds";
            // 
            // rbOn
            // 
            rbOn.AutoSize = true;
            rbOn.Location = new Point(25, 22);
            rbOn.Name = "rbOn";
            rbOn.Size = new Size(41, 19);
            rbOn.TabIndex = 0;
            rbOn.TabStop = true;
            rbOn.Text = "On";
            rbOn.UseVisualStyleBackColor = true;
            // 
            // rbOff
            // 
            rbOff.AutoSize = true;
            rbOff.Location = new Point(25, 56);
            rbOff.Name = "rbOff";
            rbOff.Size = new Size(42, 19);
            rbOff.TabIndex = 1;
            rbOff.TabStop = true;
            rbOff.Text = "Off";
            rbOff.UseVisualStyleBackColor = true;
            // 
            // frmSettingsAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(773, 444);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSettingsAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings - About";
            Load += frmSettingsAbout_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private RadioButton rbOff;
        private RadioButton rbOn;
    }
}