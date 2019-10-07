using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Calculate(
                Convert.ToInt32(txtNumber1.Text),
                Convert.ToInt32(txtNumber2.Text),
                Convert.ToInt32(txtNumber3.Text));
                txtResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hesaplanacak sayıları giriniz.");
            }

        }
        private int Calculate(int number1, int number2, int number3)
        {
            return (number1 + number2) * number3;
        }

        private void Btnzigzag_Click(object sender, EventArgs e)
        {

            ZigZag();
        }

        private void ZigZag()
        {
            for (int i = 1; i <= 200; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    txtZigzag.Text += "zigzag" + " - ";

                }

                else if (i % 3 == 0)
                {
                    txtZigzag.Text += "zig" + " - ";
                }
                else if (i % 5 == 0)
                {
                    txtZigzag.Text += "zag" + " - ";
                }

                else
                {
                    txtZigzag.Text += i.ToString() + " - ";
                }

            }
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                Multiplication();

            }
            catch (Exception)
            {

                MessageBox.Show("Birşeyler ters gitti");

            }

        }
        private void Multiplication()
        {
            int number = Convert.ToInt32(txtMultiplicationNumber.Text);
            listBox1.Items.Clear();
            if (number < 0 && number >= 15)
            {
                MessageBox.Show("Sayınız 1 ile 16 arasında olmalıdır.");

            }
            for (int i = 1; i <= Convert.ToInt32(txtMultiplicationNumber.Text); i++)
            {
                string sonuc = "";
                for (int j = 1; j <= Convert.ToInt32(txtMultiplicationNumber.Text); j++)
                {
                    int carpim = i * j;
                    sonuc = sonuc + carpim.ToString() + "\t";
                }
                listBox1.Items.Add(sonuc.ToString());
            }
        }

        private void BtnFibonacciResult_Click(object sender, EventArgs e)
        {
            txtFibonacciResult.Text = Fibonacci(Convert.ToInt32(txtFibonacci.Text)).ToString();
        }
        private int Fibonacci(int number)
        {
            if (number == 1) return 0; //fibonacci serisinin ilk sayısı = 0
            else if (number == 2 || number == 3) return 1; //fibonacci serisinin ikinci ve üçüncü sayısı = 1
            else return Fibonacci(number - 1) + Fibonacci(number - 2); //her eleman bir önceki elemanın toplamı 
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //Hatalı 

            ArrayList array = new ArrayList();
            
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = fileDialog.OpenFile();


                    using (StreamReader reader = new StreamReader(fileStream))
                    {

                        array.Add(reader.ReadToEnd());

                        array.Sort();
                       
                        foreach (var item in array)
                        {
                            textBox2.Text += item;
                        }
                        

                    }
                }
            }
        }

      
    }
}


            
