using Constructor_Login.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        User user;         // global alanda user tanımladık 
        private void Form1_Load(object sender, EventArgs e)
        {
            user = new User("mert", "123");            // User diye class oluşturduk ve sonra userın içini doldurduk kullanıcı ismi ve şifre olarak.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;      // kullanıcıdan bir username aldık
            string password = txtPassword.Text;      // kullanıcıdan bir şifre aldık
            if (userName==user.userName && password == user.password)       // doğru mu diye kontrol ediyoruz
            {
                Login login = new Login(user); // eğer doğru değilse bir login formu daha yollayacağız kullanıcıya 
                login.Show();// eğer doğru değilse göster diyoruz show komutu ile
                this.Hide();//formu gösterirken diğer formu görünmez yapıyoruz
            }
            else 
            {
                MessageBox.Show("Hatalı giriş .");
            }    
        }
    }
}
