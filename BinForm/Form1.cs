using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinForm
{
    public partial class Form1 : Form
    {
        //Class1 functions = new Class1();

        public Form1()
        {
            InitializeComponent();
        }


        protected void label1_Click(object sender, EventArgs e)
        {

        }

        protected void label2_Click(object sender, EventArgs e)
        {


        }

        protected void label3_Click(object sender, EventArgs e)
        {

        }

        protected void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
           
            if (selectedItem.Contains("Liczba dziesiętna na dwójkową (10 na 2)") || selectedItem.Contains("Liczba dziesiętna na ósemkową (10 na 8") )
            {
                label2.Text = "Podaj liczbe w formacie dziesiętnym!";
                Clear();

            }

            else if (selectedItem.Contains("Liczba dwójkowa na dziesiętną (2 na 10)") || selectedItem.Contains("Liczba dwójkowa na ósemkową (2 na 8)") )
            {
                label2.Text = "Podaj liczbe w formacie dwójkowym!";
                Clear();
            }

            else if (selectedItem.Contains("Liczba ósemkowa na dziesiętną (8 na 10)") || selectedItem.Contains("Liczba ósemkowa na dwójkową (8 na 2)"))
            {
                label2.Text = "Podaj liczbe w formacie ósemkowym!";
                Clear();
            }
        }

        protected void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
           string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();

            if (selectedItem.Contains("Liczba dwójkowa na dziesiętną (2 na 10)"))
            {
                TwotoTen(2);
            }

           else if (selectedItem.Contains("Liczba ósemkowa na dziesiętną (8 na 10)"))
            {
                TwotoTen(8);
            }

            else if (selectedItem.Contains("Liczba dziesiętna na dwójkową (10 na 2)"))
            {
               TentoTwo(2);              
            }

            else if (selectedItem.Contains("Liczba dziesiętna na ósemkową (10 na 8)"))
            {
                TentoTwo(8);
            }

            else if (selectedItem.Contains("Liczba ósemkowa na dwójkową (8 na 2)"))
            {
                EightToTwo();
            }

            else if (selectedItem.Contains("Liczba dwójkowa na ósemkową (2 na 8)"))
            {
                TwoToEight();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1 = " ";
            textBox1.Text = "";
            textBox2.Text = "";
            label2.Text = "";
            label3.Text = "";


        }

        public void TwotoTen(int a)
        {
            textBox2.Text = "";
            string bin = textBox1.Text;
            int value = 0;
            int i = 0;

            for (i = 0; i < bin.Length; i++)
            {
                int char2int = bin[bin.Length - 1 - i] - '0', x;

                if (!int.TryParse(bin, out x))
                {
                    MessageBox.Show("To nie jest liczba!");
                    textBox1.Text = "";
                    textBox1.Focus();
                    break;

                }


                else if ((a == 2) && (char2int > 1))
                {
                        MessageBox.Show($"Ta liczba nie jest w formacie {a}-kowym");
                        textBox1.Text = "";
                        textBox1.Focus();
                        break;
                }

                else if ((a == 8) && (char2int > 7))
                {
                    MessageBox.Show($"Ta liczba nie jest w formacie {a}-kowym");
                    textBox1.Text = "";
                    textBox1.Focus();
                    break;
                }


                else
                    value += (char2int * (int)(Math.Pow(a, i)));

            }

            if (i == bin.Length)
            {
                label3.Text = $"Liczba {bin} w formacie dziesiętnym wynosi: ";
                textBox2.Text = value.ToString();
            }


        }
        
        public void TentoTwo(int a)
        {
            textBox2.Text = "";
            int x;
            string dec = textBox1.Text;
            if (!int.TryParse(dec, out x))
            {
                MessageBox.Show("Musisz podać liczbę, spróbuj ponownie: ");
                textBox1.Text = "";
                textBox1.Focus();
            }

            else
            {
                int temp = x;
                ArrayList array = new ArrayList();

                if (temp == 0)
                {
                    array.Add(temp);
                }

                while (temp > 0)
                {
                    array.Add(temp % a);
                    temp /= a;
                }

                array.Reverse();

                label3.Text = $"Cyfra {dec} w formacie {a}-kowym wynosi: ";

                foreach (Object obj in array)
                    textBox2.Text += obj.ToString();

            }

        }

        public void EightToTwo()
        {
            textBox2.Text = "";
            int x;
            string oct = textBox1.Text;
            if (!int.TryParse(oct, out x))
            {
                MessageBox.Show("Musisz podać liczbę, spróbuj ponownie: ");
                textBox1.Text = "";
                textBox1.Focus();
            }

            else
            {
                int temp = x;
                ArrayList array = new ArrayList();

                if (temp == 0)
                {
                    array.Add(temp);
                }

                while (temp > 0)
                {
                    int c = temp % 10;
                    if (c > 7)
                        {
                            MessageBox.Show($"Ta liczba nie jest w formacie 8-kowym");
                            textBox1.Text = "";
                            textBox1.Focus();
                            break;
                        }

                    string conv = Converse(c);
                    array.Add(conv);
                    temp /= 10;
                }

                array.Reverse();

                label3.Text = $"Cyfra {oct} w formacie 2-kowym wynosi: ";

                foreach (Object obj in array)
                    textBox2.Text += obj.ToString();
            }
}

        private void TwoToEight()
        {
            textBox2.Text = "";
            string bin = textBox1.Text;
            int oct = 0;

            NoNumber(bin);

            if (bin.Length%3!=0)
            {
                if (bin.Length == 2 | (bin.Length % 2 != 0 && bin.Length != 1) )
                    bin = bin.Insert(0, "0");

               else if (bin.Length == 1 | bin.Length % 2 == 0)
                {
                    bin = bin.Insert(0, "0");
                    bin = bin.Insert(0, "0");
                }

            }

            for ( int i=0; i<bin.Length; i=i+3)
            {
                string fragment;
                fragment = bin.Substring(i, 3);
                int conv = Converse(fragment);
                oct = oct * 10 + conv;

            }

            label3.Text = $"Cyfra {bin} w formacie 8-kowym wynosi: ";
            textBox2.Text = oct.ToString();
        }

        private void Clear()
        {
            textBox1.Focus();
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }

        private string Converse (int c)
        {
            string n = "";
            string[] tab = { "000", "001", "010", "011", "100", "101", "110", "111" };
            
            for (int i=0; i<tab.Length; i++)
            {
                if (i == c)
                    n = tab[i];
            }

            return n;
        }

        private int Converse(string c)
        {
            int n = 0;
            string[] tab = { "000", "001", "010", "011", "100", "101", "110", "111" };

            for (int i = 0; i < tab.Length; i++)
            {
                if (c.Equals(tab[i]))
                    n = i;
            }

            return n;
        }

        private void NoNumber(string bin)
        {
            for (int i = 0; i < bin.Length; i++)
            {
                int char2int = bin[bin.Length - 1 - i] - '0', x;

                if (!int.TryParse(bin, out x))
                {
                    MessageBox.Show("To nie jest liczba!");
                    textBox1.Text = "";
                    textBox1.Focus();
                    break;

                }


                else if (char2int > 1)
                {
                    MessageBox.Show($"Ta liczba nie jest w formacie {2}-kowym");
                    textBox1.Text = "";
                    textBox1.Focus();
                    break;
                }

            }
        }
    }
}

