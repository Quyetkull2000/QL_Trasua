using QLTrasua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrasua
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
     
        }




        bool Login(string UserName, string PassWord)
        {
            return AccountDAO.Instance.Login(UserName, PassWord);
        }

        private void fmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txbUsername.Text;
            string PassWord = txbPassword.Text;
            if (Login(UserName, PassWord))
            {
                fmMain f = new fmMain(UserName, AccountDAO.Instance.GetTypeAccount(UserName));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo");
                txbUsername.Text = "";
                txbPassword.Text = "";
                txbUsername.Focus();
            }
            txbUsername.Text = "";
            txbPassword.Text = "";
            txbUsername.Focus();
        }
    }
}
