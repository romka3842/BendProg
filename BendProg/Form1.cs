using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BendProg
{
    public partial class Form1 : Form
    {
        double _s, _rad, _angle;
        double SizeA, SizeB, bort, zak;

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            board4Tray.Checked = true;
            textBox1.Text = "1";
            textBox2.Text = "0,8";
            textBox3.Text = "90";
            textBox_A.Text = "500";
            textBox_B.Text = "500";
            textBox_Bort.Text = "20";
            textBox_Zak.Text = "10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ovenTray side4_tray = new ovenTray(4, SizeA, SizeB, bort, zak, _rad, _s, _angle);
            double reamerA, reamerB;
            label5.Text = null;
            label4.Text = null;
            label5.Text = "Результат: ";

            if (radioButton1.Checked == true)
            {

                if (zak <= bort)
                {
                    if (zak < 7 && zak > 0)
                    {
                        MessageBox.Show("Заковка меньше 7 мм! Проверьте минимальный отгиб на используемой матрице!", "Внимание!");
                        radioButton2.Checked = false;
                        double kfactor = side4_tray.K_factorCalculation();

                        reamerA = side4_tray.reamerA_Calculation(kfactor);
                        reamerB = side4_tray.reamerB_Calculation(kfactor);

                        label5.Text += String.Format("Допуск на гибку для угла {0} равен: {1:f1}, k-фактор: {2:f2}", _angle, side4_tray._BA, kfactor);
                        label4.Text += String.Format("Размер развертки: {0:f1}x{1:f1}", reamerA, reamerB);
                    }
                    else
                    {
                        radioButton2.Checked = false;
                        double kfactor = side4_tray.K_factorCalculation();

                        reamerA = side4_tray.reamerA_Calculation(kfactor);
                        reamerB = side4_tray.reamerB_Calculation(kfactor);

                        label5.Text += String.Format("Допуск на гибку для угла {0} равен: {1:f1}, k-фактор: {2:f2}", _angle, side4_tray._BA, kfactor);
                        label4.Text += String.Format("Размер развертки: {0:f1}x{1:f1}. Размер вырубки углов {2:f1}x{2:f1}", reamerA, reamerB, side4_tray.cutout_Calculation());
                    }
                }

                else
                {
                    MessageBox.Show("Заковка больше, чем борт!");
                }
            }
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                MessageBox.Show("В разработке!", "В разработке!");
            }            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _s = Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException ex)
            {
                textBox1.Text = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                _rad = Convert.ToDouble(textBox2.Text);
            }
            catch (FormatException ex)
            {
                textBox2.Text = null;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Zak_TextChanged(object sender, EventArgs e)
        {
            try
            {
                zak = Double.Parse(textBox_Zak.Text);
            }
            catch (FormatException ex)
            {
                textBox_Zak.Text = null;
            }
        }

        private void textBox_Bort_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bort = Double.Parse(textBox_Bort.Text);
            }
            catch (FormatException ex)
            {
                textBox_Bort.Text = null;
            }
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SizeB = Double.Parse(textBox_B.Text);
            }
            catch (FormatException ex)
            {
                textBox_B.Text = null;
            }
        }

        protected void TrayInfo_Box_Enter(object sender, EventArgs e)
        {

        }

        private void typeOfTray_Enter(object sender, EventArgs e)
        {

        }

        private void board4Tray_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton board4Tray = (RadioButton)sender;
            if (!board4Tray.Checked)
            {
                SizePicture.Visible = false;
                //SizePicture.ImageLocation="\Resources\3borta_size.png";
                //TrayInfo_Box.Visible = false;
            }
            if (board4Tray.Checked)
            {
                SizePicture.Visible = true;
                //TrayInfo_Box.Visible = true;
            }
        }

        private void board3Tray_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton board3Tray = (RadioButton)sender;
            if (!board3Tray.Checked)
            {
                bort3_Size.Visible = false;
            }
            if (board3Tray.Checked)
            {
                bort3_Size.Visible = true;
            }
        }

        private void board2Tray_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton board2Tray = (RadioButton)sender;
            if (!board2Tray.Checked)
            {
                bort2_Size.Visible = false;
            }
            if (board2Tray.Checked)
            {
                bort2_Size.Visible = true;
            }
        }

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SizeA = Double.Parse(textBox_A.Text);
            }
            catch (FormatException ex)
            {
                textBox_A.Text = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _angle = Convert.ToDouble(textBox3.Text);
            }
            catch (FormatException ex)
            {
                textBox3.Text = null;
            }
        }
    }
}
