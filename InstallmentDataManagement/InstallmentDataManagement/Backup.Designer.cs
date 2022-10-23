namespace FazleRabbi
{
    partial class Backup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.txtb1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.backupbtn = new System.Windows.Forms.Button();
            this.backupbrowsebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Exotc350 Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 31);
            this.label3.TabIndex = 142;
            this.label3.Text = "Backup of Database";
            // 
            // txtb1
            // 
            this.txtb1.BackColor = System.Drawing.SystemColors.Control;
            this.txtb1.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtb1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.txtb1.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtb1.BorderThickness = 1;
            this.txtb1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtb1.isPassword = false;
            this.txtb1.Location = new System.Drawing.Point(383, 288);
            this.txtb1.Margin = new System.Windows.Forms.Padding(4);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(356, 35);
            this.txtb1.TabIndex = 144;
            this.txtb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 145;
            this.label5.Text = "Location ";
            // 
            // backupbtn
            // 
            this.backupbtn.Enabled = false;
            this.backupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupbtn.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.backupbtn.Location = new System.Drawing.Point(796, 362);
            this.backupbtn.Name = "backupbtn";
            this.backupbtn.Size = new System.Drawing.Size(98, 32);
            this.backupbtn.TabIndex = 152;
            this.backupbtn.Text = "BackUp!";
            this.backupbtn.UseVisualStyleBackColor = true;
            // 
            // backupbrowsebtn
            // 
            this.backupbrowsebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupbrowsebtn.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupbrowsebtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.backupbrowsebtn.Location = new System.Drawing.Point(796, 288);
            this.backupbrowsebtn.Name = "backupbrowsebtn";
            this.backupbrowsebtn.Size = new System.Drawing.Size(98, 32);
            this.backupbrowsebtn.TabIndex = 151;
            this.backupbrowsebtn.Text = "Browse";
            this.backupbrowsebtn.UseVisualStyleBackColor = true;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.backupbtn);
            this.Controls.Add(this.backupbrowsebtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.label3);
            this.Name = "Backup";
            this.Size = new System.Drawing.Size(1086, 677);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtb1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button backupbtn;
        public System.Windows.Forms.Button backupbrowsebtn;
    }
}
