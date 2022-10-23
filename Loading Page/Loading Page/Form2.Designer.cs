namespace Loading_Page
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtb1 = new Guna.UI.WinForms.GunaTextBox();
            this.txtb2 = new Guna.UI.WinForms.GunaTextBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.gunaElipsePanel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1366, 768);
            this.bunifuGradientPanel1.TabIndex = 14;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.pictureBox2);
            this.gunaElipsePanel1.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel1.Controls.Add(this.txtb1);
            this.gunaElipsePanel1.Controls.Add(this.txtb2);
            this.gunaElipsePanel1.Controls.Add(this.bunifuThinButton21);
            this.gunaElipsePanel1.Controls.Add(this.gunaCircleButton1);
            this.gunaElipsePanel1.Controls.Add(this.label3);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(218, 130);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 15;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(936, 522);
            this.gunaElipsePanel1.TabIndex = 0;
            this.gunaElipsePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(450, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // txtb1
            // 
            this.txtb1.BackColor = System.Drawing.Color.Transparent;
            this.txtb1.BaseColor = System.Drawing.Color.White;
            this.txtb1.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtb1.BorderSize = 3;
            this.txtb1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb1.FocusedBaseColor = System.Drawing.Color.White;
            this.txtb1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtb1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtb1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtb1.Location = new System.Drawing.Point(498, 202);
            this.txtb1.Name = "txtb1";
            this.txtb1.PasswordChar = '\0';
            this.txtb1.Radius = 7;
            this.txtb1.SelectedText = "";
            this.txtb1.Size = new System.Drawing.Size(312, 42);
            this.txtb1.TabIndex = 1;
            this.txtb1.Text = "Username";
            this.txtb1.TextChanged += new System.EventHandler(this.txtb1_TextChanged);
            this.txtb1.MouseEnter += new System.EventHandler(this.txtb1_MouseEnter);
            this.txtb1.MouseLeave += new System.EventHandler(this.txtb1_MouseLeave);
            // 
            // txtb2
            // 
            this.txtb2.BackColor = System.Drawing.Color.Transparent;
            this.txtb2.BaseColor = System.Drawing.Color.White;
            this.txtb2.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtb2.BorderSize = 3;
            this.txtb2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb2.FocusedBaseColor = System.Drawing.Color.White;
            this.txtb2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtb2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtb2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtb2.Location = new System.Drawing.Point(498, 287);
            this.txtb2.Name = "txtb2";
            this.txtb2.PasswordChar = '\0';
            this.txtb2.Radius = 7;
            this.txtb2.SelectedText = "";
            this.txtb2.Size = new System.Drawing.Size(312, 42);
            this.txtb2.TabIndex = 2;
            this.txtb2.Text = "Password";
            this.txtb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtb2_MouseDown);
            this.txtb2.MouseEnter += new System.EventHandler(this.txtb2_MouseEnter);
            this.txtb2.MouseLeave += new System.EventHandler(this.txtb2_MouseLeave);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 35;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Login";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 35;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(567, 376);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(178, 54);
            this.bunifuThinButton21.TabIndex = 3;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.SkyBlue;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton1.Image")));
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(128, 128);
            this.gunaCircleButton1.Location = new System.Drawing.Point(121, 155);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(196, 194);
            this.gunaCircleButton1.TabIndex = 25;
            this.gunaCircleButton1.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 50);
            this.label3.TabIndex = 17;
            this.label3.Text = "User login";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtb1;
        private Guna.UI.WinForms.GunaTextBox txtb2;
    }
}

