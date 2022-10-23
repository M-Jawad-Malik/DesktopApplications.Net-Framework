namespace FazleRabbi
{
    partial class StockPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockPanel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(1, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 51);
            this.panel2.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(11, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 51);
            this.button3.TabIndex = 25;
            this.button3.Text = "Stock Record";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // StockPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Name = "StockPanel";
            this.Size = new System.Drawing.Size(245, 400);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button button3;
    }
}
