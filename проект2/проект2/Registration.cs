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
    public partial class Registration : Form
    {
        readonly ApplicationContext db;
        public Registration() 
        {
            InitializeComponent();
            db = new ApplicationContext();
        }
        private void Button2_Click(object sender, EventArgs e) // Регистрация пользователя 
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;
            User user = new User(login, pass);
            db.Users.Add(user); //добавление в БД
            db.SaveChanges();//сохранение в БД
            if (login == "" | pass == "")
            {
                MessageBox.Show("Заполните поля"); //при незаполненных полях будет показываться сообщение
            }
            else
            { 
                PersonalArea newform = new PersonalArea(); //переход в личный кабинет
                newform.Show();
                Close();
            }
        }
    }
}