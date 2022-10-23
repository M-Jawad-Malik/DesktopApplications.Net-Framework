namespace Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnequ = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.Btnmul = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnsqrt = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnon = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(3, 3);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(318, 83);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnequ, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnmod, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn0, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btndot, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnadd, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnsub, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Btnmul, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btndiv, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnsqrt, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnclear, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnon, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 92);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(318, 353);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnequ
            // 
            this.btnequ.BackColor = System.Drawing.Color.DarkGray;
            this.btnequ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnequ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequ.Location = new System.Drawing.Point(240, 283);
            this.btnequ.Name = "btnequ";
            this.btnequ.Size = new System.Drawing.Size(75, 67);
            this.btnequ.TabIndex = 19;
            this.btnequ.Text = "=";
            this.btnequ.UseVisualStyleBackColor = false;
            this.btnequ.Click += new System.EventHandler(this.btnequ_Click);
            // 
            // btnmod
            // 
            this.btnmod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod.Location = new System.Drawing.Point(161, 283);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(73, 67);
            this.btnmod.TabIndex = 18;
            this.btnmod.Text = "%";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(82, 283);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(73, 67);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Btnnum_Click);
            // 
            // btndot
            // 
            this.btndot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.Location = new System.Drawing.Point(3, 283);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(73, 67);
            this.btndot.TabIndex = 16;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.Btnnum_Click);
            // 
            // btnadd
            // 
            this.btnadd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(240, 213);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 64);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(161, 213);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(73, 64);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btnnum_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(82, 213);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(73, 64);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btnnum_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(3, 213);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(73, 64);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btnnum_Click);
            // 
            // btnsub
            // 
            this.btnsub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(240, 143);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 64);
            this.btnsub.TabIndex = 11;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(161, 143);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(73, 64);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btnnum_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(82, 143);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(73, 64);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btnnum_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(3, 143);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(73, 64);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btnnum_Click);
            // 
            // Btnmul
            // 
            this.Btnmul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnmul.Location = new System.Drawing.Point(240, 73);
            this.Btnmul.Name = "Btnmul";
            this.Btnmul.Size = new System.Drawing.Size(75, 64);
            this.Btnmul.TabIndex = 7;
            this.Btnmul.Text = "×";
            this.Btnmul.UseVisualStyleBackColor = true;
            this.Btnmul.Click += new System.EventHandler(this.Btnmul_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(161, 73);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(73, 64);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btnnum_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(82, 73);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(73, 64);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btnnum_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(3, 73);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(73, 64);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btnnum_Click);
            // 
            // btndiv
            // 
            this.btndiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(240, 3);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 64);
            this.btndiv.TabIndex = 3;
            this.btndiv.Text = "÷";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnsqrt
            // 
            this.btnsqrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsqrt.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsqrt.Location = new System.Drawing.Point(161, 3);
            this.btnsqrt.Name = "btnsqrt";
            this.btnsqrt.Size = new System.Drawing.Size(73, 64);
            this.btnsqrt.TabIndex = 2;
            this.btnsqrt.Text = "√";
            this.btnsqrt.UseVisualStyleBackColor = true;
            this.btnsqrt.Click += new System.EventHandler(this.btnsqrt_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnclear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnclear.Location = new System.Drawing.Point(82, 3);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(73, 64);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnon
            // 
            this.btnon.BackColor = System.Drawing.Color.Salmon;
            this.btnon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnon.Location = new System.Drawing.Point(3, 3);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(73, 64);
            this.btnon.TabIndex = 0;
            this.btnon.Text = "ON";
            this.btnon.UseVisualStyleBackColor = false;
            this.btnon.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caculator [ToddlerIT]";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnequ;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button Btnmul;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnsqrt;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnon;
    }
}

