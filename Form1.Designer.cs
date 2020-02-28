namespace WinHWndUtils
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.SetTitleBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.SearchBtn2 = new System.Windows.Forms.Button();
            this.xN = new System.Windows.Forms.NumericUpDown();
            this.yN = new System.Windows.Forms.NumericUpDown();
            this.classnameBox = new System.Windows.Forms.TextBox();
            this.WinTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alphaN2_value = new System.Windows.Forms.Label();
            this.alphaN2 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchBtn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.delayN = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.alphaN1 = new System.Windows.Forms.TrackBar();
            this.alphaN1_value = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.hwndNumeric = new System.Windows.Forms.NumericUpDown();
            this.force_close = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.window_btn = new System.Windows.Forms.Button();
            this.maximize_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Pname_lbl = new System.Windows.Forms.Label();
            this.pid_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchresults = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.xN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaN2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayN)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaN1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hwndNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SetTitleBtn
            // 
            this.SetTitleBtn.Location = new System.Drawing.Point(131, 20);
            this.SetTitleBtn.Name = "SetTitleBtn";
            this.SetTitleBtn.Size = new System.Drawing.Size(75, 23);
            this.SetTitleBtn.TabIndex = 3;
            this.SetTitleBtn.Text = "Set";
            this.SetTitleBtn.UseVisualStyleBackColor = true;
            this.SetTitleBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(14, 32);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(187, 20);
            this.searchBox.TabIndex = 4;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(8, 22);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(117, 20);
            this.TitleBox.TabIndex = 5;
            // 
            // SearchBtn2
            // 
            this.SearchBtn2.Location = new System.Drawing.Point(231, 45);
            this.SearchBtn2.Name = "SearchBtn2";
            this.SearchBtn2.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn2.TabIndex = 10;
            this.SearchBtn2.Text = "Confirm";
            this.SearchBtn2.UseVisualStyleBackColor = true;
            this.SearchBtn2.Click += new System.EventHandler(this.button5_Click);
            // 
            // xN
            // 
            this.xN.Location = new System.Drawing.Point(14, 48);
            this.xN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xN.Name = "xN";
            this.xN.Size = new System.Drawing.Size(44, 20);
            this.xN.TabIndex = 11;
            // 
            // yN
            // 
            this.yN.Location = new System.Drawing.Point(64, 48);
            this.yN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yN.Name = "yN";
            this.yN.Size = new System.Drawing.Size(44, 20);
            this.yN.TabIndex = 12;
            // 
            // classnameBox
            // 
            this.classnameBox.Location = new System.Drawing.Point(16, 153);
            this.classnameBox.Name = "classnameBox";
            this.classnameBox.ReadOnly = true;
            this.classnameBox.Size = new System.Drawing.Size(312, 20);
            this.classnameBox.TabIndex = 14;
            // 
            // WinTextBox
            // 
            this.WinTextBox.Location = new System.Drawing.Point(16, 199);
            this.WinTextBox.Name = "WinTextBox";
            this.WinTextBox.ReadOnly = true;
            this.WinTextBox.Size = new System.Drawing.Size(312, 20);
            this.WinTextBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.alphaN2_value);
            this.groupBox1.Controls.Add(this.alphaN2);
            this.groupBox1.Location = new System.Drawing.Point(334, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 56);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taskbar and Start transparency";
            // 
            // alphaN2_value
            // 
            this.alphaN2_value.AutoSize = true;
            this.alphaN2_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaN2_value.Location = new System.Drawing.Point(136, 23);
            this.alphaN2_value.Name = "alphaN2_value";
            this.alphaN2_value.Size = new System.Drawing.Size(29, 16);
            this.alphaN2_value.TabIndex = 10;
            this.alphaN2_value.Text = "255";
            // 
            // alphaN2
            // 
            this.alphaN2.AutoSize = false;
            this.alphaN2.Location = new System.Drawing.Point(10, 23);
            this.alphaN2.Maximum = 255;
            this.alphaN2.Name = "alphaN2";
            this.alphaN2.Size = new System.Drawing.Size(117, 24);
            this.alphaN2.TabIndex = 9;
            this.alphaN2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.alphaN2.Value = 255;
            this.alphaN2.Scroll += new System.EventHandler(this.alphaN2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "hWnd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ClassName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "WindowText";
            // 
            // SearchBtn1
            // 
            this.SearchBtn1.Location = new System.Drawing.Point(231, 29);
            this.SearchBtn1.Name = "SearchBtn1";
            this.SearchBtn1.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn1.TabIndex = 20;
            this.SearchBtn1.Text = "Search";
            this.SearchBtn1.UseVisualStyleBackColor = true;
            this.SearchBtn1.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Y:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pname_lbl);
            this.groupBox2.Controls.Add(this.pid_lbl);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.searchresults);
            this.groupBox2.Controls.Add(this.searchBox);
            this.groupBox2.Controls.Add(this.SearchBtn1);
            this.groupBox2.Location = new System.Drawing.Point(16, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 193);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get hWnd from search (process name, caption or class name)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.delayN);
            this.groupBox3.Controls.Add(this.SearchBtn2);
            this.groupBox3.Controls.Add(this.xN);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.yN);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(16, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 86);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get hWnd from screen coordinates";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Delay (ms):";
            // 
            // delayN
            // 
            this.delayN.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delayN.Location = new System.Drawing.Point(120, 48);
            this.delayN.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.delayN.Name = "delayN";
            this.delayN.Size = new System.Drawing.Size(81, 20);
            this.delayN.TabIndex = 23;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.alphaN1);
            this.groupBox4.Controls.Add(this.alphaN1_value);
            this.groupBox4.Location = new System.Drawing.Point(334, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 56);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Change hWnd transparency";
            // 
            // alphaN1
            // 
            this.alphaN1.AutoSize = false;
            this.alphaN1.Location = new System.Drawing.Point(6, 23);
            this.alphaN1.Maximum = 255;
            this.alphaN1.Name = "alphaN1";
            this.alphaN1.Size = new System.Drawing.Size(117, 24);
            this.alphaN1.TabIndex = 11;
            this.alphaN1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.alphaN1.Value = 255;
            this.alphaN1.Scroll += new System.EventHandler(this.alphaN1_Scroll);
            // 
            // alphaN1_value
            // 
            this.alphaN1_value.AutoSize = true;
            this.alphaN1_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaN1_value.Location = new System.Drawing.Point(132, 23);
            this.alphaN1_value.Name = "alphaN1_value";
            this.alphaN1_value.Size = new System.Drawing.Size(29, 16);
            this.alphaN1_value.TabIndex = 12;
            this.alphaN1_value.Text = "255";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TitleBox);
            this.groupBox5.Controls.Add(this.SetTitleBtn);
            this.groupBox5.Location = new System.Drawing.Point(334, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 57);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Set hWnd window title";
            // 
            // hwndNumeric
            // 
            this.hwndNumeric.Location = new System.Drawing.Point(16, 110);
            this.hwndNumeric.Maximum = new decimal(new int[] {
            -194313216,
            20,
            0,
            0});
            this.hwndNumeric.Name = "hwndNumeric";
            this.hwndNumeric.Size = new System.Drawing.Size(312, 20);
            this.hwndNumeric.TabIndex = 27;
            // 
            // force_close
            // 
            this.force_close.AutoSize = true;
            this.force_close.Location = new System.Drawing.Point(536, 206);
            this.force_close.Name = "force_close";
            this.force_close.Size = new System.Drawing.Size(110, 17);
            this.force_close.TabIndex = 32;
            this.force_close.Text = "force hWnd close";
            this.force_close.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.minimize_btn);
            this.panel1.Controls.Add(this.window_btn);
            this.panel1.Controls.Add(this.maximize_btn);
            this.panel1.Location = new System.Drawing.Point(334, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 33);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 32);
            this.panel2.TabIndex = 32;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.Black;
            this.close_btn.Image = global::WinHWndUtils.Properties.Resources.close1;
            this.close_btn.Location = new System.Drawing.Point(265, 1);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(46, 32);
            this.close_btn.TabIndex = 28;
            this.close_btn.TabStop = false;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            this.close_btn.MouseEnter += new System.EventHandler(this.close_btn_MouseEnter);
            this.close_btn.MouseLeave += new System.EventHandler(this.close_btn_MouseLeave);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.minimize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Image = global::WinHWndUtils.Properties.Resources.minimize;
            this.minimize_btn.Location = new System.Drawing.Point(127, 1);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(46, 32);
            this.minimize_btn.TabIndex = 31;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // window_btn
            // 
            this.window_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.window_btn.FlatAppearance.BorderSize = 0;
            this.window_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.window_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.window_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.window_btn.Image = global::WinHWndUtils.Properties.Resources.window;
            this.window_btn.Location = new System.Drawing.Point(173, 1);
            this.window_btn.Name = "window_btn";
            this.window_btn.Size = new System.Drawing.Size(46, 32);
            this.window_btn.TabIndex = 29;
            this.window_btn.TabStop = false;
            this.window_btn.UseVisualStyleBackColor = false;
            this.window_btn.Click += new System.EventHandler(this.window_btn_Click);
            // 
            // maximize_btn
            // 
            this.maximize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.maximize_btn.FlatAppearance.BorderSize = 0;
            this.maximize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.maximize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.maximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_btn.Image = global::WinHWndUtils.Properties.Resources.maximize;
            this.maximize_btn.Location = new System.Drawing.Point(219, 1);
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(46, 32);
            this.maximize_btn.TabIndex = 30;
            this.maximize_btn.TabStop = false;
            this.maximize_btn.UseVisualStyleBackColor = false;
            this.maximize_btn.Click += new System.EventHandler(this.maximize_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 33);
            this.label9.TabIndex = 34;
            this.label9.Text = "hWnd Utility";
            // 
            // Pname_lbl
            // 
            this.Pname_lbl.AutoSize = true;
            this.Pname_lbl.Location = new System.Drawing.Point(163, 110);
            this.Pname_lbl.Name = "Pname_lbl";
            this.Pname_lbl.Size = new System.Drawing.Size(83, 13);
            this.Pname_lbl.TabIndex = 24;
            this.Pname_lbl.Text = "Process name: -";
            // 
            // pid_lbl
            // 
            this.pid_lbl.AutoSize = true;
            this.pid_lbl.Location = new System.Drawing.Point(163, 77);
            this.pid_lbl.Name = "pid_lbl";
            this.pid_lbl.Size = new System.Drawing.Size(34, 13);
            this.pid_lbl.TabIndex = 23;
            this.pid_lbl.Text = "PID: -";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(166, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // searchresults
            // 
            this.searchresults.FormattingEnabled = true;
            this.searchresults.Location = new System.Drawing.Point(14, 77);
            this.searchresults.Name = "searchresults";
            this.searchresults.Size = new System.Drawing.Size(128, 108);
            this.searchresults.TabIndex = 21;
            this.searchresults.SelectedIndexChanged += new System.EventHandler(this.searchresults_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(662, 522);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hwndNumeric);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WinTextBox);
            this.Controls.Add(this.classnameBox);
            this.Controls.Add(this.force_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Window hWnd Utility";
            ((System.ComponentModel.ISupportInitialize)(this.xN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaN2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayN)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaN1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hwndNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SetTitleBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Button SearchBtn2;
        private System.Windows.Forms.NumericUpDown xN;
        private System.Windows.Forms.NumericUpDown yN;
        private System.Windows.Forms.TextBox classnameBox;
        private System.Windows.Forms.TextBox WinTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchBtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown delayN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown hwndNumeric;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button window_btn;
        private System.Windows.Forms.Button maximize_btn;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.CheckBox force_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label alphaN2_value;
        private System.Windows.Forms.TrackBar alphaN2;
        private System.Windows.Forms.Label alphaN1_value;
        private System.Windows.Forms.TrackBar alphaN1;
        private System.Windows.Forms.Label Pname_lbl;
        private System.Windows.Forms.Label pid_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox searchresults;
    }
}

