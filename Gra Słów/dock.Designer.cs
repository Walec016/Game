
namespace Gra_Słów
{
    partial class dock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.SideButton6 = new System.Windows.Forms.Button();
            this.SideButton5 = new System.Windows.Forms.Button();
            this.SideButton4 = new System.Windows.Forms.Button();
            this.SideButton3 = new System.Windows.Forms.Button();
            this.SideButton2 = new System.Windows.Forms.Button();
            this.SideButton1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.ucMenu2 = new Gra_Słów.UCMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.SideButton6);
            this.panel1.Controls.Add(this.SideButton5);
            this.panel1.Controls.Add(this.SideButton4);
            this.panel1.Controls.Add(this.SideButton3);
            this.panel1.Controls.Add(this.SideButton2);
            this.panel1.Controls.Add(this.SideButton1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 655);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gra_Słów.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Gold;
            this.SidePanel.Location = new System.Drawing.Point(0, 139);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 76);
            this.SidePanel.TabIndex = 5;
            // 
            // SideButton6
            // 
            this.SideButton6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SideButton6.FlatAppearance.BorderSize = 0;
            this.SideButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideButton6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.SideButton6.ForeColor = System.Drawing.Color.Gold;
            this.SideButton6.Location = new System.Drawing.Point(0, 549);
            this.SideButton6.Name = "SideButton6";
            this.SideButton6.Size = new System.Drawing.Size(253, 76);
            this.SideButton6.TabIndex = 4;
            this.SideButton6.Text = "Wyloguj Się";
            this.SideButton6.UseVisualStyleBackColor = false;
            this.SideButton6.Click += new System.EventHandler(this.SideButton6_Click);
            // 
            // SideButton5
            // 
            this.SideButton5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SideButton5.FlatAppearance.BorderSize = 0;
            this.SideButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideButton5.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.SideButton5.ForeColor = System.Drawing.Color.Gold;
            this.SideButton5.Location = new System.Drawing.Point(0, 467);
            this.SideButton5.Name = "SideButton5";
            this.SideButton5.Size = new System.Drawing.Size(253, 76);
            this.SideButton5.TabIndex = 1;
            this.SideButton5.Text = "Aktywni Użytkownicy";
            this.SideButton5.UseVisualStyleBackColor = false;
            this.SideButton5.Click += new System.EventHandler(this.SideButton5_Click);
            // 
            // SideButton4
            // 
            this.SideButton4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SideButton4.FlatAppearance.BorderSize = 0;
            this.SideButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideButton4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.SideButton4.ForeColor = System.Drawing.Color.Gold;
            this.SideButton4.Location = new System.Drawing.Point(0, 385);
            this.SideButton4.Name = "SideButton4";
            this.SideButton4.Size = new System.Drawing.Size(253, 76);
            this.SideButton4.TabIndex = 3;
            this.SideButton4.Text = "Zalicz Koledze";
            this.SideButton4.UseVisualStyleBackColor = false;
            this.SideButton4.Click += new System.EventHandler(this.SideButton4_Click);
            // 
            // SideButton3
            // 
            this.SideButton3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SideButton3.FlatAppearance.BorderSize = 0;
            this.SideButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideButton3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.SideButton3.ForeColor = System.Drawing.Color.Gold;
            this.SideButton3.Location = new System.Drawing.Point(0, 303);
            this.SideButton3.Name = "SideButton3";
            this.SideButton3.Size = new System.Drawing.Size(253, 76);
            this.SideButton3.TabIndex = 2;
            this.SideButton3.Text = "Losuj Słowo";
            this.SideButton3.UseVisualStyleBackColor = false;
            this.SideButton3.Click += new System.EventHandler(this.SideButton3_Click);
            // 
            // SideButton2
            // 
            this.SideButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SideButton2.FlatAppearance.BorderSize = 0;
            this.SideButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideButton2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.SideButton2.ForeColor = System.Drawing.Color.Gold;
            this.SideButton2.Location = new System.Drawing.Point(0, 221);
            this.SideButton2.Name = "SideButton2";
            this.SideButton2.Size = new System.Drawing.Size(253, 76);
            this.SideButton2.TabIndex = 1;
            this.SideButton2.Text = "Ranking";
            this.SideButton2.UseVisualStyleBackColor = false;
            this.SideButton2.Click += new System.EventHandler(this.SideButton2_Click);
            // 
            // SideButton1
            // 
            this.SideButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SideButton1.FlatAppearance.BorderSize = 0;
            this.SideButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideButton1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SideButton1.ForeColor = System.Drawing.Color.Gold;
            this.SideButton1.Location = new System.Drawing.Point(0, 139);
            this.SideButton1.Name = "SideButton1";
            this.SideButton1.Size = new System.Drawing.Size(253, 76);
            this.SideButton1.TabIndex = 0;
            this.SideButton1.Text = "Menu";
            this.SideButton1.UseVisualStyleBackColor = false;
            this.SideButton1.Click += new System.EventHandler(this.SideButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(248, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 660);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(927, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 43);
            this.label4.TabIndex = 22;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(732, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 65);
            this.button2.TabIndex = 24;
            this.button2.Text = "Edytuj Dane";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ucMenu2
            // 
            this.ucMenu2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucMenu2.Location = new System.Drawing.Point(684, 179);
            this.ucMenu2.Name = "ucMenu2";
            this.ucMenu2.Size = new System.Drawing.Size(9, 62);
            this.ucMenu2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            // 
            // dock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(976, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucMenu2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dock";
            this.Load += new System.EventHandler(this.dock_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SideButton1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button SideButton6;
        private System.Windows.Forms.Button SideButton5;
        private System.Windows.Forms.Button SideButton4;
        private System.Windows.Forms.Button SideButton3;
        private System.Windows.Forms.Button SideButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button2;
        private UCMenu ucMenu2;
        private System.Windows.Forms.Label label1;
    }
}