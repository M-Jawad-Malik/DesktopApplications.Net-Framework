namespace Petrol_Pump_Software.Forms
{
    partial class HomePg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePg));
            this.dashboard1 = new Petrol_Pump_Software.UserControls.Dashboard();
            this.mainpg1 = new Petrol_Pump_Software.UserControls.Mainpg();
            this.SuspendLayout();
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard1.Location = new System.Drawing.Point(-2, 30);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1368, 740);
            this.dashboard1.TabIndex = 0;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load);
            // 
            // mainpg1
            // 
            this.mainpg1.Location = new System.Drawing.Point(-2, 30);
            this.mainpg1.Name = "mainpg1";
            this.mainpg1.Size = new System.Drawing.Size(1368, 740);
            this.mainpg1.TabIndex = 1;
            // 
            // HomePg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1368, 772);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.mainpg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petrol Pump Software - DashBoard         Toddler IT";
            this.Load += new System.EventHandler(this.HomePg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Dashboard dashboard1;
        private UserControls.Mainpg mainpg1;
    }
}