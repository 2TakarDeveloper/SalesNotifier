namespace SalesNotifier.App
{
    partial class MainPage
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
            this.Data = new MetroFramework.Controls.MetroTile();
            this.Notifications = new MetroFramework.Controls.MetroTile();
            this.Exit = new MetroFramework.Controls.MetroTile();
            this.Aboutus = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.ActiveControl = null;
            this.Data.BackColor = System.Drawing.Color.Green;
            this.Data.Location = new System.Drawing.Point(23, 77);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(221, 211);
            this.Data.TabIndex = 0;
            this.Data.Text = "Data";
            this.Data.UseCustomBackColor = true;
            this.Data.UseMnemonic = false;
            this.Data.UseSelectable = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // Notifications
            // 
            this.Notifications.ActiveControl = null;
            this.Notifications.BackColor = System.Drawing.Color.Chocolate;
            this.Notifications.Location = new System.Drawing.Point(250, 77);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(336, 105);
            this.Notifications.TabIndex = 1;
            this.Notifications.Text = "Notification";
            this.Notifications.UseCustomBackColor = true;
            this.Notifications.UseMnemonic = false;
            this.Notifications.UseSelectable = true;
            this.Notifications.Click += new System.EventHandler(this.Notifications_Click);
            // 
            // Exit
            // 
            this.Exit.ActiveControl = null;
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(472, 188);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(114, 100);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseCustomBackColor = true;
            this.Exit.UseMnemonic = false;
            this.Exit.UseSelectable = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Aboutus
            // 
            this.Aboutus.ActiveControl = null;
            this.Aboutus.BackColor = System.Drawing.Color.DimGray;
            this.Aboutus.Location = new System.Drawing.Point(250, 188);
            this.Aboutus.Name = "Aboutus";
            this.Aboutus.Size = new System.Drawing.Size(216, 100);
            this.Aboutus.TabIndex = 3;
            this.Aboutus.Text = "About Us";
            this.Aboutus.UseCustomBackColor = true;
            this.Aboutus.UseMnemonic = false;
            this.Aboutus.UseSelectable = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(608, 318);
            this.ControlBox = false;
            this.Controls.Add(this.Aboutus);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Notifications);
            this.Controls.Add(this.Data);
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Main Menu";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile Data;
        private MetroFramework.Controls.MetroTile Notifications;
        private MetroFramework.Controls.MetroTile Exit;
        private MetroFramework.Controls.MetroTile Aboutus;
    }
}

