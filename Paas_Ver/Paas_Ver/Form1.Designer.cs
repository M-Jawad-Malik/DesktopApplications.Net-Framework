namespace Paas_Ver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Registerbtn = new Telerik.WinControls.UI.RadRepeatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.Registerbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // Registerbtn
            // 
            this.Registerbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbtn.Location = new System.Drawing.Point(127, 311);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(127, 35);
            this.Registerbtn.TabIndex = 0;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Registration Form";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.HintForeColor = System.Drawing.Color.Empty;
            this.textBox1.HintText = "";
            this.textBox1.isPassword = false;
            this.textBox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBox1.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBox1.LineThickness = 3;
            this.textBox1.Location = new System.Drawing.Point(88, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 44);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Enter your email";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.HintForeColor = System.Drawing.Color.Empty;
            this.textBox2.HintText = "";
            this.textBox2.isPassword = false;
            this.textBox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBox2.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBox2.LineThickness = 3;
            this.textBox2.Location = new System.Drawing.Point(88, 218);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 44);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "Enter your password";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(373, 386);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Registerbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registration Form";
            ((System.ComponentModel.ISupportInitialize)(this.Registerbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRepeatButton Registerbtn;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox2;
    }
}

