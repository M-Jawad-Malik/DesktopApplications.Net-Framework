namespace Loading_Page
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
            this.frmformulatorio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Loadingbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drop = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.drop2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.drop3 = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drop3)).BeginInit();
            this.SuspendLayout();
            // 
            // frmformulatorio
            // 
            this.frmformulatorio.ElipseRadius = 12;
            this.frmformulatorio.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loadingbar
            // 
            this.Loadingbar.animated = false;
            this.Loadingbar.animationIterval = 5;
            this.Loadingbar.animationSpeed = 200;
            this.Loadingbar.BackColor = System.Drawing.Color.Transparent;
            this.Loadingbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loadingbar.BackgroundImage")));
            this.Loadingbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadingbar.ForeColor = System.Drawing.Color.Red;
            this.Loadingbar.LabelVisible = true;
            this.Loadingbar.LineProgressThickness = 3;
            this.Loadingbar.LineThickness = 5;
            this.Loadingbar.Location = new System.Drawing.Point(352, 326);
            this.Loadingbar.Margin = new System.Windows.Forms.Padding(6);
            this.Loadingbar.MaxValue = 100;
            this.Loadingbar.Name = "Loadingbar";
            this.Loadingbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.Loadingbar.ProgressColor = System.Drawing.Color.Yellow;
            this.Loadingbar.Size = new System.Drawing.Size(82, 82);
            this.Loadingbar.TabIndex = 0;
            this.Loadingbar.Value = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(354, 414);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(80, 18);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Loading...";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(166, 113);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(479, 37);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Petrol Pump Management Software";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(365, 140);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(146, 147);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 4;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.drop3);
            this.bunifuGradientPanel2.Controls.Add(this.drop2);
            this.bunifuGradientPanel2.Controls.Add(this.Loadingbar);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel2.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel2.Controls.Add(this.drop);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel2.Controls.Add(this.gunaCirclePictureBox1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(800, 450);
            this.bunifuGradientPanel2.TabIndex = 5;
            this.bunifuGradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(651, 414);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(129, 17);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Steps to Revolution";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(651, 394);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(118, 17);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "© Toddler IT 2020";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(651, 374);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "v 1.0";
            // 
            // drop
            // 
            this.drop.BackColor = System.Drawing.Color.Transparent;
            this.drop.BaseColor = System.Drawing.Color.White;
            this.drop.Image = ((System.Drawing.Image)(resources.GetObject("drop.Image")));
            this.drop.Location = new System.Drawing.Point(385, 265);
            this.drop.Name = "drop";
            this.drop.Size = new System.Drawing.Size(21, 29);
            this.drop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drop.TabIndex = 5;
            this.drop.TabStop = false;
            this.drop.UseTransfarantBackground = false;
            // 
            // drop2
            // 
            this.drop2.BackColor = System.Drawing.Color.Transparent;
            this.drop2.BaseColor = System.Drawing.Color.White;
            this.drop2.Image = ((System.Drawing.Image)(resources.GetObject("drop2.Image")));
            this.drop2.Location = new System.Drawing.Point(390, 261);
            this.drop2.Name = "drop2";
            this.drop2.Size = new System.Drawing.Size(12, 24);
            this.drop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drop2.TabIndex = 11;
            this.drop2.TabStop = false;
            this.drop2.UseTransfarantBackground = false;
            // 
            // drop3
            // 
            this.drop3.BackColor = System.Drawing.Color.Transparent;
            this.drop3.BaseColor = System.Drawing.Color.White;
            this.drop3.Image = ((System.Drawing.Image)(resources.GetObject("drop3.Image")));
            this.drop3.Location = new System.Drawing.Point(390, 286);
            this.drop3.Name = "drop3";
            this.drop3.Size = new System.Drawing.Size(12, 24);
            this.drop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drop3.TabIndex = 12;
            this.drop3.TabStop = false;
            this.drop3.UseTransfarantBackground = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drop3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse frmformulatorio;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Guna.UI.WinForms.GunaCirclePictureBox drop;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar Loadingbar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox drop3;
        private Guna.UI.WinForms.GunaCirclePictureBox drop2;
    }
}

