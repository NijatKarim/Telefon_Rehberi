using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var books = DataStore.books;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                if(DataStore.AppUser.Username == txtUsername.Text && DataStore.AppUser.Password == txtPassword.Text)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve ya şifre yalnış");
                }
            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız");
            }
        }
    }
}
