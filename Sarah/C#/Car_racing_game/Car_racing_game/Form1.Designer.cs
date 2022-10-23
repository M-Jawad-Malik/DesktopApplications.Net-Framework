namespace Car_racing_game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.line1 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.line4 = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enm1 = new System.Windows.Forms.PictureBox();
            this.enm2 = new System.Windows.Forms.PictureBox();
            this.enm3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enm3)).BeginInit();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(186, 0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 86);
            this.line1.TabIndex = 0;
            this.line1.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(186, 248);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(10, 86);
            this.line3.TabIndex = 1;
            this.line3.TabStop = false;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.White;
            this.line4.Location = new System.Drawing.Point(186, 377);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(10, 86);
            this.line4.TabIndex = 2;
            this.line4.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(186, 123);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 86);
            this.line2.TabIndex = 3;
            this.line2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(373, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 466);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 466);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.Color.Transparent;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(258, 347);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(62, 67);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 6;
            this.Car.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enm1
            // 
            this.enm1.BackColor = System.Drawing.Color.Transparent;
            this.enm1.Image = ((System.Drawing.Image)(resources.GetObject("enm1.Image")));
            this.enm1.Location = new System.Drawing.Point(80, 277);
            this.enm1.Name = "enm1";
            this.enm1.Size = new System.Drawing.Size(43, 57);
            this.enm1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enm1.TabIndex = 7;
            this.enm1.TabStop = false;
            // 
            // enm2
            // 
            this.enm2.BackColor = System.Drawing.Color.Transparent;
            this.enm2.Image = ((System.Drawing.Image)(resources.GetObject("enm2.Image")));
            this.enm2.Location = new System.Drawing.Point(97, 73);
            this.enm2.Name = "enm2";
            this.enm2.Size = new System.Drawing.Size(43, 57);
            this.enm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enm2.TabIndex = 8;
            this.enm2.TabStop = false;
            // 
            // enm3
            // 
            this.enm3.BackColor = System.Drawing.Color.Transparent;
            this.enm3.Image = ((System.Drawing.Image)(resources.GetObject("enm3.Image")));
            this.enm3.Location = new System.Drawing.Point(267, 218);
            this.enm3.Name = "enm3";
            this.enm3.Size = new System.Drawing.Size(43, 57);
            this.enm3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enm3.TabIndex = 9;
            this.enm3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.enm3);
            this.Controls.Add(this.enm2);
            this.Controls.Add(this.enm1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Car Racing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enm3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox enm1;
        private System.Windows.Forms.PictureBox enm2;
        private System.Windows.Forms.PictureBox enm3;
    }
}

