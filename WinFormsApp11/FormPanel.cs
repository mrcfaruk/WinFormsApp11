using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class FormPanel : Form
    {
        string _username;
        public FormPanel(string username)
        {
            _username = username;
            InitializeComponent();
        }

        private void FormPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormPanel_Load(object sender, EventArgs e)
        {
            labelUsername.Text = _username;
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw = new StreamWriter("login.txt"))
            {
                
            }
            this.Hide();
            FormLogin formlogin = new();
            formlogin.Show();
        }

        private void ürünEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new();
            formProduct.ShowDialog();
        }

        private void ürünleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductList formProductList = new();
            formProductList.ShowDialog();
        }
    }
}
