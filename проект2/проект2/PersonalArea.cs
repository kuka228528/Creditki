using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проект2
{
    public partial class PersonalArea : Form
    {
        public PersonalArea()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Authorization newform = new Authorization();// переход на форму авторизации
            newform.Show();
            Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            CardGenerating newform = new CardGenerating(); //переход в окно генерации карт
            newform.Show();
            Close();
        }
    }
}