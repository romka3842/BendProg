namespace BendProg
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Calculation_change_Box = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_Zak = new System.Windows.Forms.TextBox();
            this.textBox_Bort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TrayInfo_Box = new System.Windows.Forms.GroupBox();
            this.board4Tray = new System.Windows.Forms.RadioButton();
            this.board3Tray = new System.Windows.Forms.RadioButton();
            this.board2Tray = new System.Windows.Forms.RadioButton();
            this.typeOfTray = new System.Windows.Forms.GroupBox();
            this.bort2_Size = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SizePicture = new System.Windows.Forms.PictureBox();
            this.bort3_Size = new System.Windows.Forms.PictureBox();
            this.Calculation_change_Box.SuspendLayout();
            this.TrayInfo_Box.SuspendLayout();
            this.typeOfTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bort2_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bort3_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Толщина материала";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Радиус пуансона";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Угол гиба";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(63, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Calculation_change_Box
            // 
            this.Calculation_change_Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Calculation_change_Box.Controls.Add(this.radioButton2);
            this.Calculation_change_Box.Controls.Add(this.radioButton1);
            this.Calculation_change_Box.Location = new System.Drawing.Point(12, 146);
            this.Calculation_change_Box.Name = "Calculation_change_Box";
            this.Calculation_change_Box.Size = new System.Drawing.Size(144, 100);
            this.Calculation_change_Box.TabIndex = 7;
            this.Calculation_change_Box.TabStop = false;
            this.Calculation_change_Box.Text = "Выбор метода расчёта";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По таблице";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Расчётный";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(9, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Результат: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(143, 171);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(35, 20);
            this.textBox_A.TabIndex = 12;
            this.textBox_A.TextChanged += new System.EventHandler(this.textBox_A_TextChanged);
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(4, 272);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(39, 20);
            this.textBox_B.TabIndex = 13;
            this.textBox_B.TextChanged += new System.EventHandler(this.textBox_B_TextChanged);
            // 
            // textBox_Zak
            // 
            this.textBox_Zak.Location = new System.Drawing.Point(143, 67);
            this.textBox_Zak.Name = "textBox_Zak";
            this.textBox_Zak.Size = new System.Drawing.Size(35, 20);
            this.textBox_Zak.TabIndex = 14;
            this.textBox_Zak.TextChanged += new System.EventHandler(this.textBox_Zak_TextChanged);
            // 
            // textBox_Bort
            // 
            this.textBox_Bort.Location = new System.Drawing.Point(194, 92);
            this.textBox_Bort.Name = "textBox_Bort";
            this.textBox_Bort.Size = new System.Drawing.Size(35, 20);
            this.textBox_Bort.TabIndex = 15;
            this.textBox_Bort.TextChanged += new System.EventHandler(this.textBox_Bort_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // TrayInfo_Box
            // 
            this.TrayInfo_Box.Controls.Add(this.textBox_B);
            this.TrayInfo_Box.Controls.Add(this.textBox_A);
            this.TrayInfo_Box.Controls.Add(this.textBox_Bort);
            this.TrayInfo_Box.Controls.Add(this.textBox_Zak);
            this.TrayInfo_Box.Controls.Add(this.pictureBox2);
            this.TrayInfo_Box.Controls.Add(this.SizePicture);
            this.TrayInfo_Box.Controls.Add(this.bort3_Size);
            this.TrayInfo_Box.Controls.Add(this.bort2_Size);
            this.TrayInfo_Box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TrayInfo_Box.Location = new System.Drawing.Point(162, 12);
            this.TrayInfo_Box.Name = "TrayInfo_Box";
            this.TrayInfo_Box.Size = new System.Drawing.Size(312, 385);
            this.TrayInfo_Box.TabIndex = 17;
            this.TrayInfo_Box.TabStop = false;
            this.TrayInfo_Box.Text = "Противень 4 борта";
            this.TrayInfo_Box.Enter += new System.EventHandler(this.TrayInfo_Box_Enter);
            // 
            // board4Tray
            // 
            this.board4Tray.AutoSize = true;
            this.board4Tray.Checked = true;
            this.board4Tray.Location = new System.Drawing.Point(7, 20);
            this.board4Tray.Name = "board4Tray";
            this.board4Tray.Size = new System.Drawing.Size(63, 17);
            this.board4Tray.TabIndex = 0;
            this.board4Tray.TabStop = true;
            this.board4Tray.Text = "4 борта";
            this.board4Tray.UseVisualStyleBackColor = true;
            this.board4Tray.CheckedChanged += new System.EventHandler(this.board4Tray_CheckedChanged);
            // 
            // board3Tray
            // 
            this.board3Tray.AutoSize = true;
            this.board3Tray.Location = new System.Drawing.Point(7, 43);
            this.board3Tray.Name = "board3Tray";
            this.board3Tray.Size = new System.Drawing.Size(63, 17);
            this.board3Tray.TabIndex = 0;
            this.board3Tray.Text = "3 борта";
            this.board3Tray.UseVisualStyleBackColor = true;
            this.board3Tray.CheckedChanged += new System.EventHandler(this.board3Tray_CheckedChanged);
            // 
            // board2Tray
            // 
            this.board2Tray.AutoSize = true;
            this.board2Tray.Location = new System.Drawing.Point(7, 66);
            this.board2Tray.Name = "board2Tray";
            this.board2Tray.Size = new System.Drawing.Size(63, 17);
            this.board2Tray.TabIndex = 0;
            this.board2Tray.Text = "2 борта";
            this.board2Tray.UseVisualStyleBackColor = true;
            this.board2Tray.CheckedChanged += new System.EventHandler(this.board2Tray_CheckedChanged);
            // 
            // typeOfTray
            // 
            this.typeOfTray.Controls.Add(this.board2Tray);
            this.typeOfTray.Controls.Add(this.board3Tray);
            this.typeOfTray.Controls.Add(this.board4Tray);
            this.typeOfTray.Location = new System.Drawing.Point(12, 252);
            this.typeOfTray.Name = "typeOfTray";
            this.typeOfTray.Size = new System.Drawing.Size(141, 116);
            this.typeOfTray.TabIndex = 18;
            this.typeOfTray.TabStop = false;
            this.typeOfTray.Text = "Вид противня";
            this.typeOfTray.Enter += new System.EventHandler(this.typeOfTray_Enter);
            // 
            // bort2_Size
            // 
            this.bort2_Size.Image = global::BendProg.Properties.Resources._2borta_size;
            this.bort2_Size.Location = new System.Drawing.Point(36, 174);
            this.bort2_Size.Name = "bort2_Size";
            this.bort2_Size.Size = new System.Drawing.Size(248, 211);
            this.bort2_Size.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bort2_Size.TabIndex = 19;
            this.bort2_Size.TabStop = false;
            this.bort2_Size.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BendProg.Properties.Resources.Bort;
            this.pictureBox2.Location = new System.Drawing.Point(36, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // SizePicture
            // 
            this.SizePicture.Image = global::BendProg.Properties.Resources.Gabarit;
            this.SizePicture.Location = new System.Drawing.Point(36, 174);
            this.SizePicture.Name = "SizePicture";
            this.SizePicture.Size = new System.Drawing.Size(248, 210);
            this.SizePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SizePicture.TabIndex = 16;
            this.SizePicture.TabStop = false;
            // 
            // bort3_Size
            // 
            this.bort3_Size.Image = global::BendProg.Properties.Resources._3borta_size;
            this.bort3_Size.Location = new System.Drawing.Point(36, 174);
            this.bort3_Size.Name = "bort3_Size";
            this.bort3_Size.Size = new System.Drawing.Size(248, 211);
            this.bort3_Size.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bort3_Size.TabIndex = 17;
            this.bort3_Size.TabStop = false;
            this.bort3_Size.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(476, 438);
            this.Controls.Add(this.typeOfTray);
            this.Controls.Add(this.TrayInfo_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Calculation_change_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт развертки противня";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Calculation_change_Box.ResumeLayout(false);
            this.Calculation_change_Box.PerformLayout();
            this.TrayInfo_Box.ResumeLayout(false);
            this.TrayInfo_Box.PerformLayout();
            this.typeOfTray.ResumeLayout(false);
            this.typeOfTray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bort2_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bort3_Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox Calculation_change_Box;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_Zak;
        private System.Windows.Forms.TextBox textBox_Bort;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.GroupBox TrayInfo_Box;
        private System.Windows.Forms.RadioButton board4Tray;
        private System.Windows.Forms.RadioButton board3Tray;
        private System.Windows.Forms.RadioButton board2Tray;
        private System.Windows.Forms.GroupBox typeOfTray;
        private System.Windows.Forms.PictureBox SizePicture;
        private System.Windows.Forms.PictureBox bort3_Size;
        private System.Windows.Forms.PictureBox bort2_Size;
    }
}

