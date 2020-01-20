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
            this.SetBtn2 = new System.Windows.Forms.Button();
            this.alphaN2 = new System.Windows.Forms.NumericUpDown();
            this.SetTitleBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SetBtn1 = new System.Windows.Forms.Button();
            this.SearchBtn2 = new System.Windows.Forms.Button();
            this.xN = new System.Windows.Forms.NumericUpDown();
            this.yN = new System.Windows.Forms.NumericUpDown();
            this.classnameBox = new System.Windows.Forms.TextBox();
            this.WinTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alphaN1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchBtn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delayN = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.hwndNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.alphaN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaN1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayN)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hwndNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // SetBtn2
            // 
            this.SetBtn2.Location = new System.Drawing.Point(179, 26);
            this.SetBtn2.Name = "SetBtn2";
            this.SetBtn2.Size = new System.Drawing.Size(127, 23);
            this.SetBtn2.TabIndex = 0;
            this.SetBtn2.Text = "Imposta trasparenza";
            this.SetBtn2.UseVisualStyleBackColor = true;
            this.SetBtn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // alphaN2
            // 
            this.alphaN2.Location = new System.Drawing.Point(53, 29);
            this.alphaN2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.alphaN2.Name = "alphaN2";
            this.alphaN2.Size = new System.Drawing.Size(75, 20);
            this.alphaN2.TabIndex = 2;
            this.alphaN2.Value = new decimal(new int[] {
            210,
            0,
            0,
            0});
            // 
            // SetTitleBtn
            // 
            this.SetTitleBtn.Location = new System.Drawing.Point(131, 20);
            this.SetTitleBtn.Name = "SetTitleBtn";
            this.SetTitleBtn.Size = new System.Drawing.Size(75, 23);
            this.SetTitleBtn.TabIndex = 3;
            this.SetTitleBtn.Text = "Cambio titolo";
            this.SetTitleBtn.UseVisualStyleBackColor = true;
            this.SetTitleBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(14, 32);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(94, 20);
            this.searchBox.TabIndex = 4;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(8, 22);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(117, 20);
            this.TitleBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alpha:";
            // 
            // SetBtn1
            // 
            this.SetBtn1.Location = new System.Drawing.Point(131, 16);
            this.SetBtn1.Name = "SetBtn1";
            this.SetBtn1.Size = new System.Drawing.Size(75, 23);
            this.SetBtn1.TabIndex = 9;
            this.SetBtn1.Text = "Imposta";
            this.SetBtn1.UseVisualStyleBackColor = true;
            this.SetBtn1.Click += new System.EventHandler(this.button4_Click);
            // 
            // SearchBtn2
            // 
            this.SearchBtn2.Location = new System.Drawing.Point(231, 45);
            this.SearchBtn2.Name = "SearchBtn2";
            this.SearchBtn2.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn2.TabIndex = 10;
            this.SearchBtn2.Text = "Conferma";
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
            this.classnameBox.Size = new System.Drawing.Size(312, 20);
            this.classnameBox.TabIndex = 14;
            // 
            // WinTextBox
            // 
            this.WinTextBox.Location = new System.Drawing.Point(16, 199);
            this.WinTextBox.Name = "WinTextBox";
            this.WinTextBox.Size = new System.Drawing.Size(312, 20);
            this.WinTextBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetBtn2);
            this.groupBox1.Controls.Add(this.alphaN2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 68);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taskbar - Start";
            // 
            // alphaN1
            // 
            this.alphaN1.Location = new System.Drawing.Point(50, 19);
            this.alphaN1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.alphaN1.Name = "alphaN1";
            this.alphaN1.Size = new System.Drawing.Size(75, 20);
            this.alphaN1.TabIndex = 9;
            this.alphaN1.Value = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.alphaN1.ValueChanged += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alpha:";
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
            this.SearchBtn1.Location = new System.Drawing.Point(120, 30);
            this.SearchBtn1.Name = "SearchBtn1";
            this.SearchBtn1.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn1.TabIndex = 20;
            this.SearchBtn1.Text = "Ricerca";
            this.SearchBtn1.UseVisualStyleBackColor = true;
            this.SearchBtn1.Click += new System.EventHandler(this.button2_Click_1);
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
            this.groupBox2.Controls.Add(this.searchBox);
            this.groupBox2.Controls.Add(this.SearchBtn1);
            this.groupBox2.Location = new System.Drawing.Point(16, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 70);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ottieni hWnd da Ricerca";
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
            this.groupBox3.Text = "Ottieni hWnd da coordinate";
            // 
            // delayN
            // 
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Delay (ms):";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.alphaN1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.SetBtn1);
            this.groupBox4.Location = new System.Drawing.Point(16, 393);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 56);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Imposta trasparenza";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TitleBox);
            this.groupBox5.Controls.Add(this.SetTitleBtn);
            this.groupBox5.Location = new System.Drawing.Point(16, 455);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 57);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cambia titolo";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 526);
            this.Controls.Add(this.hwndNumeric);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WinTextBox);
            this.Controls.Add(this.classnameBox);
            this.Name = "Form1";
            this.Text = "Window hWnd Utility";
            ((System.ComponentModel.ISupportInitialize)(this.alphaN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaN1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayN)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hwndNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetBtn2;
        private System.Windows.Forms.NumericUpDown alphaN2;
        private System.Windows.Forms.Button SetTitleBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SetBtn1;
        private System.Windows.Forms.Button SearchBtn2;
        private System.Windows.Forms.NumericUpDown xN;
        private System.Windows.Forms.NumericUpDown yN;
        private System.Windows.Forms.TextBox classnameBox;
        private System.Windows.Forms.TextBox WinTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown alphaN1;
        private System.Windows.Forms.Label label4;
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
    }
}

