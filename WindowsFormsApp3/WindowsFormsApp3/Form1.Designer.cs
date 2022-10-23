namespace WindowsFormsApp3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.xuiJoyStick1 = new XanderUI.XUIJoyStick();
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaGoogleSwitch1 = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaNumeric1 = new Guna.UI.WinForms.GunaNumeric();
            this.gunaWinSwitch1 = new Guna.UI.WinForms.GunaWinSwitch();
            this.radVirtualKeyboardForm1 = new Telerik.WinControls.UI.RadVirtualKeyboardForm(this.components);
            this.gunaHScrollBar1 = new Guna.UI.WinForms.GunaHScrollBar();
            this.gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.xuiFlatProgressBar2 = new XanderUI.XUIFlatProgressBar();
            this.xuiCircleProgressBar1 = new XanderUI.XUICircleProgressBar();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.radClock1 = new Telerik.WinControls.UI.RadClock();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiClock1
            // 
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(639, 47);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(122, 130);
            this.xuiClock1.TabIndex = 0;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // xuiJoyStick1
            // 
            this.xuiJoyStick1.BackColor = System.Drawing.Color.White;
            this.xuiJoyStick1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xuiJoyStick1.BackgroundImage")));
            this.xuiJoyStick1.JoyStickColor = System.Drawing.Color.DodgerBlue;
            this.xuiJoyStick1.KeepOnScreen = true;
            this.xuiJoyStick1.Location = new System.Drawing.Point(350, 256);
            this.xuiJoyStick1.MovableObject = this.radClock1;
            this.xuiJoyStick1.Name = "xuiJoyStick1";
            this.xuiJoyStick1.Sensitivity = 3;
            this.xuiJoyStick1.Size = new System.Drawing.Size(122, 122);
            this.xuiJoyStick1.TabIndex = 1;
            this.xuiJoyStick1.Text = "xuiJoyStick1";
            this.xuiJoyStick1.Click += new System.EventHandler(this.xuiJoyStick1_Click);
            // 
            // xuiSuperButton1
            // 
            this.xuiSuperButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiSuperButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperButton1.ButtonImage")));
            this.xuiSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton1.ButtonText = "SuperButton";
            this.xuiSuperButton1.CornerRadius = 5;
            this.xuiSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton1.Location = new System.Drawing.Point(21, 144);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(226, 33);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 2;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Button";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(118, 30);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(200, 50);
            this.xuiButton1.TabIndex = 3;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.CheckedImage")));
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.Image")));
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(21, 294);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(226, 93);
            this.gunaAdvenceTileButton1.TabIndex = 4;
            this.gunaAdvenceTileButton1.Text = "gunaAdvenceTileButton1";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(427, 22);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(181, 133);
            this.gunaDataGridView1.TabIndex = 6;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(250, 208);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(121, 26);
            this.gunaComboBox1.TabIndex = 7;
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(21, 235);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(223, 30);
            this.gunaDateTimePicker1.TabIndex = 8;
            this.gunaDateTimePicker1.Text = "Sunday, October 25, 2020";
            this.gunaDateTimePicker1.Value = new System.DateTime(2020, 10, 25, 7, 15, 19, 242);
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(39, 12);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(57, 59);
            this.gunaCircleButton1.TabIndex = 9;
            this.gunaCircleButton1.Text = "gunaCircleButton1";
            // 
            // gunaGoogleSwitch1
            // 
            this.gunaGoogleSwitch1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaGoogleSwitch1.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.gunaGoogleSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGoogleSwitch1.FillColor = System.Drawing.Color.White;
            this.gunaGoogleSwitch1.Location = new System.Drawing.Point(118, 118);
            this.gunaGoogleSwitch1.Name = "gunaGoogleSwitch1";
            this.gunaGoogleSwitch1.Size = new System.Drawing.Size(38, 20);
            this.gunaGoogleSwitch1.TabIndex = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(350, 402);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(68, 15);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "gunaLabel1";
            // 
            // gunaNumeric1
            // 
            this.gunaNumeric1.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric1.BorderColor = System.Drawing.Color.Silver;
            this.gunaNumeric1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaNumeric1.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric1.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric1.Location = new System.Drawing.Point(21, 91);
            this.gunaNumeric1.Maximum = ((long)(9999999));
            this.gunaNumeric1.Minimum = ((long)(0));
            this.gunaNumeric1.Name = "gunaNumeric1";
            this.gunaNumeric1.Size = new System.Drawing.Size(75, 30);
            this.gunaNumeric1.TabIndex = 13;
            this.gunaNumeric1.Text = "gunaNumeric1";
            this.gunaNumeric1.Value = ((long)(0));
            // 
            // gunaWinSwitch1
            // 
            this.gunaWinSwitch1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaWinSwitch1.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.gunaWinSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaWinSwitch1.FillColor = System.Drawing.Color.White;
            this.gunaWinSwitch1.Location = new System.Drawing.Point(182, 117);
            this.gunaWinSwitch1.Name = "gunaWinSwitch1";
            this.gunaWinSwitch1.Size = new System.Drawing.Size(40, 22);
            this.gunaWinSwitch1.TabIndex = 16;
            // 
            // gunaHScrollBar1
            // 
            this.gunaHScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaHScrollBar1.LargeChange = 10;
            this.gunaHScrollBar1.Location = new System.Drawing.Point(21, 193);
            this.gunaHScrollBar1.Maximum = 100;
            this.gunaHScrollBar1.Name = "gunaHScrollBar1";
            this.gunaHScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaHScrollBar1.Size = new System.Drawing.Size(224, 10);
            this.gunaHScrollBar1.TabIndex = 17;
            this.gunaHScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaHScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaHScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // gunaCircleProgressBar1
            // 
            this.gunaCircleProgressBar1.AnimationSpeed = 0.6F;
            this.gunaCircleProgressBar1.BaseColor = System.Drawing.Color.White;
            this.gunaCircleProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaCircleProgressBar1.IdleOffset = 20;
            this.gunaCircleProgressBar1.Image = null;
            this.gunaCircleProgressBar1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar1.Location = new System.Drawing.Point(508, 327);
            this.gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            this.gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCircleProgressBar1.ProgressOffset = 20;
            this.gunaCircleProgressBar1.Size = new System.Drawing.Size(119, 114);
            this.gunaCircleProgressBar1.TabIndex = 18;
            // 
            // xuiFlatProgressBar2
            // 
            this.xuiFlatProgressBar2.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.xuiFlatProgressBar2.BorderColor = System.Drawing.Color.Black;
            this.xuiFlatProgressBar2.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuiFlatProgressBar2.InocmpletedColor = System.Drawing.Color.White;
            this.xuiFlatProgressBar2.Location = new System.Drawing.Point(21, 393);
            this.xuiFlatProgressBar2.MaxValue = 100;
            this.xuiFlatProgressBar2.Name = "xuiFlatProgressBar2";
            this.xuiFlatProgressBar2.ShowBorder = true;
            this.xuiFlatProgressBar2.Size = new System.Drawing.Size(226, 10);
            this.xuiFlatProgressBar2.TabIndex = 20;
            this.xuiFlatProgressBar2.Text = "xuiFlatProgressBar2";
            this.xuiFlatProgressBar2.Value = 50;
            // 
            // xuiCircleProgressBar1
            // 
            this.xuiCircleProgressBar1.AnimationSpeed = 5;
            this.xuiCircleProgressBar1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.xuiCircleProgressBar1.FilledColorAlpha = 130;
            this.xuiCircleProgressBar1.FilledThickness = 40;
            this.xuiCircleProgressBar1.IsAnimated = false;
            this.xuiCircleProgressBar1.Location = new System.Drawing.Point(491, 176);
            this.xuiCircleProgressBar1.Name = "xuiCircleProgressBar1";
            this.xuiCircleProgressBar1.Percentage = 63;
            this.xuiCircleProgressBar1.ShowText = true;
            this.xuiCircleProgressBar1.Size = new System.Drawing.Size(130, 128);
            this.xuiCircleProgressBar1.TabIndex = 22;
            this.xuiCircleProgressBar1.TextColor = System.Drawing.Color.Gray;
            this.xuiCircleProgressBar1.TextSize = 25;
            this.xuiCircleProgressBar1.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.xuiCircleProgressBar1.UnfilledThickness = 24;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(260, 92);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(95, 95);
            this.bunifuCircleProgressbar1.TabIndex = 23;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(21, 414);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(228, 14);
            this.bunifuProgressBar1.TabIndex = 24;
            this.bunifuProgressBar1.Value = 0;
            // 
            // radClock1
            // 
            this.radClock1.Location = new System.Drawing.Point(654, 243);
            this.radClock1.Name = "radClock1";
            this.radClock1.Size = new System.Drawing.Size(134, 135);
            this.radClock1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radClock1);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.xuiCircleProgressBar1);
            this.Controls.Add(this.xuiFlatProgressBar2);
            this.Controls.Add(this.gunaCircleProgressBar1);
            this.Controls.Add(this.gunaHScrollBar1);
            this.Controls.Add(this.gunaWinSwitch1);
            this.Controls.Add(this.gunaNumeric1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaGoogleSwitch1);
            this.Controls.Add(this.gunaCircleButton1);
            this.Controls.Add(this.gunaDateTimePicker1);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.gunaAdvenceTileButton1);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.xuiSuperButton1);
            this.Controls.Add(this.xuiJoyStick1);
            this.Controls.Add(this.xuiClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIClock xuiClock1;
        private XanderUI.XUIJoyStick xuiJoyStick1;
        private XanderUI.XUISuperButton xuiSuperButton1;
        private XanderUI.XUIButton xuiButton1;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaGoogleSwitch gunaGoogleSwitch1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric1;
        private Guna.UI.WinForms.GunaWinSwitch gunaWinSwitch1;
        private Telerik.WinControls.UI.RadVirtualKeyboardForm radVirtualKeyboardForm1;
        private Guna.UI.WinForms.GunaHScrollBar gunaHScrollBar1;
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
        private XanderUI.XUIFlatProgressBar xuiFlatProgressBar2;
        private XanderUI.XUICircleProgressBar xuiCircleProgressBar1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Telerik.WinControls.UI.RadClock radClock1;
    }
}

