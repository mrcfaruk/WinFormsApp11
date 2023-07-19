using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
    
    public partial class FormLogin : Form
    {
        string username ="mrcfaruk", password ="yz43kr2";
        int loginlimit = 3;
        bool otomatikGiris = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        public void DisableLogin()
        {

            loginlimit--;

            labelLimit.Text = loginlimit.ToString();

            if (loginlimit == 0)
            {
                MessageBox.Show("Giris hakkiniz dolmustur.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonLogin.Enabled = false;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            using(StreamReader sr = new StreamReader("login.txt"))
            {
                List<string> login = new();
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    if(string.IsNullOrEmpty(line) == false)
                    {
                        try
                        {
                            login.Add(line.Split(":")[1]);
                        }
                        catch (Exception ex)
                        {

                            
                        }
                        finally
                        {

                        }
                    }
                }
                if (login.Count == 2 && login[0] == username && login[1] == password)
                {
                    otomatikGiris = true;
                    FormPanel formpanel = new(login[0]);
                   
                    formpanel.Show();
                    

                }
            }
            labelLimit.Text = loginlimit.ToString();
            
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            if(otomatikGiris == true)
            {
                this.Hide();
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (loginlimit > 3)
            {

            }
            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                
                DisableLogin();
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }

           if(textBoxUsername.Text != username)
            {
                
                DisableLogin();
                MessageBox.Show("Kullanici adi yanlis", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxPassword.Text != password)
            {
                
                DisableLogin();
                MessageBox.Show("Sifre yanlis", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBoxRememberMe.Checked)
            {
                using (StreamWriter sw = new StreamWriter("login.txt"))
                {
                    sw.WriteLine($"username : {textBoxUsername.Text}");
                    sw.Write($"password : {textBoxPassword.Text}");
                }
            }


            FormPanel formpanel = new(textBoxUsername.Text);
            formpanel.Show();
            this.Hide();
            

        }

    }
}
