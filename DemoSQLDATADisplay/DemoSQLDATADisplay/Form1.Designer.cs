namespace DemoSQLDATADisplay
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(22, 63);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(383, 315);
            this.dgv1.TabIndex = 0;
            // 
            // dgv2
            // 
            this.dgv2.BackgroundColor = System.Drawing.Color.White;
            this.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_ID,
            this.first_nm,
            this.Salary});
            this.dgv2.Location = new System.Drawing.Point(455, 63);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(341, 315);
            this.dgv2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Populate DG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee_ID
            // 
            this.Employee_ID.DataPropertyName = "emp_id";
            this.Employee_ID.HeaderText = "Employee ID";
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.ReadOnly = true;
            // 
            // first_nm
            // 
            this.first_nm.DataPropertyName = "first_name";
            this.first_nm.HeaderText = "First Name";
            this.first_nm.Name = "first_nm";
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 491);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Name = "Form1";
            this.Text = "DempSQLDataDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.TextBox textBox1;
    }
}

