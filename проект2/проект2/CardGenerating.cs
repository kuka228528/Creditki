using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проект2
{
    public partial class CardGenerating : Form
    {
        public CardGenerating()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e) //генерация карты
        {
            var chars = "";
            var random = new Random();
            for (int i = 1; i < 17; i++)
            {
                chars += random.Next(1, 9).ToString();
            }
            textBox1.Text = chars;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            //  int sum = 0;
            // string str = textBox1.Text;
            //  int num = int.Parse(str);

            // int digitCount = (int)Math.Log10(num) + 1;
            //
            // int[] array = new int[digitCount];
            //
            // for (int i = 0; i < digitCount; i++)
            //  {
            //     array[i] = num % 10;
            //     num /= 10;
            // }
            //  int p = 1;
            //if (digitCount % 2 == 0)
            //{
            //  for (int i = 0; i < digitCount - 1; i++)
            //{
            //  if (i % 2 == 0)
            //{
            //  p = array[i] * 2;
            //if (p > 9)
            //{
            //     p -= 9;
            //    }
            //       array[i] = p;
            //    }
            //     else array[i] = array[i];
            //      sum = sum + array[i];
            //    }

            //     if (sum % 10 == 0)
            //       {
            //         textBox3.Text = "Number is valid";
            //     }
            //    else textBox3.Text = "Number is not valid";
            int sum = 0;
            bool alt = false;
            for (int i = textBox1.Text.Length - 2; i >= 0; i--)
            {
                int curDigit = (i);
                if (alt)
                {
                    curDigit *= 2;
                    if (curDigit > 9)
                    {
                        curDigit -= 9;
                    }
                }
                sum += curDigit;
                alt = !alt;
                if (sum % 10 == 0)
                {
                    textBox3.Text = "Number is valid";
                }
                else textBox3.Text = "Number is not valid";
            }
        }
    }
}