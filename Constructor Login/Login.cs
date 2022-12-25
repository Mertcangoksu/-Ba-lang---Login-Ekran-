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
    public partial class Login : Form
    {
        public Login(User _user)  // buda bir constructor ve içerisine parametre koyduk 
        {
            InitializeComponent();
            user = _user; // userın içerisine attık
        }

        User user; // gönderildiğinde buraya aktarıcak
        private void Login_Load(object sender, EventArgs e)
        {
            lblMessage.Text = $"Hoş geldiniz {user.userName}"; // mesaj 
        }
    }
}
