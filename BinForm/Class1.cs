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

    class Class1 : Form1

    {
        public Class1()
        {}
        /*
        public void TentoTwo()
        {
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


                else if (char2int > 1)
                {
                    MessageBox.Show("Ta liczba nie jest w formacie dwójkowym");
                    textBox1.Text = "";
                    textBox1.Focus();
                    break;
                }

                else
                    value += (char2int * (int)(Math.Pow(2, i)));

            }

            if (i == bin.Length)
            {
                label3.Text = $"Cyfra {bin} w formacie dziesiętnym wynosi: ";
                textBox2.Text = value.ToString();
            }


        }


        public void TwotoTen()
        {

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
                    array.Add(temp % 2);
                    temp /= 2;
                }

                array.Reverse();

                label3.Text = $"Cyfra {dec} w formacie binarnym wynosi: ";

                foreach (Object obj in array)
                    textBox2.Text += obj.ToString();

            }

            /*
            static void Main(string[] args)
            {

                //SetNumber2to10();
                SetNumber10to2();


                Console.ReadKey();
            }
            
        }
    */
    }
}

