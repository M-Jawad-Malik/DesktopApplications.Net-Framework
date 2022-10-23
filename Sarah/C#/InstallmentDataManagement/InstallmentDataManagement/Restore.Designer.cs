namespace FazleRabbi
{
    partial class Restore
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
            this.browsebtn = new System.Windows.Forms.Button();
            this.restorebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Exotc350 Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 31);
            this.label3.TabIndex = 144;
            this.label3.Text = "Restore Database";
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
            this.txtb1.Location = new System.Drawing.Point(403, 366);
            this.txtb1.Margin = new System.Windows.Forms.Padding(4);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(356, 35);
            this.txtb1.TabIndex = 147;
            this.txtb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 148;
            this.label5.Text = "Location ";
            // 
            // browsebtn
            // 
            this.browsebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsebtn.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsebtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.browsebtn.Location = new System.Drawing.Point(814, 365);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(98, 32);
            this.browsebtn.TabIndex = 149;
            this.browsebtn.Text = "Browse";
            this.browsebtn.UseVisualStyleBackColor = true;
            // 
            // restorebtn
            // 
            this.restorebtn.Enabled = false;
            this.restorebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restorebtn.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restorebtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.restorebtn.Location = new System.Drawing.Point(814, 446);
            this.restorebtn.Name = "restorebtn";
            this.restorebtn.Size = new System.Drawing.Size(98, 32);
            this.restorebtn.TabIndex = 150;
            this.restorebtn.Text = "Restore!";
            this.restorebtn.UseVisualStyleBackColor = true;
            // 
            // Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.restorebtn);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.label3);
            this.Name = "Restore";
            this.Size = new System.Drawing.Size(1086, 677);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtb1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button browsebtn;
        public System.Windows.Forms.Button restorebtn;
    }
}
