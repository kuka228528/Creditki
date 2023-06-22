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
    public partial class PersonalAreaAdmin : Form
    {
        public PersonalAreaAdmin()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext(); //обращение к классу
            List<User> users = db.Users.ToList();
            dataGridView1.DataSource = users; //подключение БД для отображения в dataGridView1
            ApplicationContext3 DB = new ApplicationContext3();// обращение к классу
            List<Card> cards = DB.Cards.ToList();
            dataGridView2.DataSource = cards; // подключение БД для отображения в dataGridView2
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Authorization newform = new Authorization();// переход на форму авторизации
            newform.Show();
            Close();
        }
    }
}