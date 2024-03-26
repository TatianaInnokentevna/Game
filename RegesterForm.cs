using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ItprogerApp
{
    public partial class RegesterForm : Form
    {
        public RegesterForm()
        {
            InitializeComponent();

            UserLoginField.Text = "Введите имя";
            UserEmailField.Text = "Введите почту";
            UserPasswordField.Text = "Введите пароль";
            this.Text = "Регистрация в программе";

        }

        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Введите имя")
                {
                UserLoginField.Text = "";
                UserLoginField.ForeColor = Color.White;
            }

            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "Введите почту")
            {
                UserEmailField.Text = "";
                UserEmailField.ForeColor = Color.White;
            }

            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Введите пароль")
            {
                UserPasswordField.Text = "";
                UserPasswordField.UseSystemPasswordChar = true;
                UserPasswordField.ForeColor = Color.White;
            }
        }


        public void TextBox_Leave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "")
            {
                UserLoginField.Text = "Введите имя";
                UserLoginField.ForeColor = Color.Blue;
            }

            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "")
            {
                UserEmailField.Text = "Введите почту";
                UserEmailField.ForeColor = Color.Blue;
            }

            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Введите пароль";
                UserPasswordField.UseSystemPasswordChar = false;
                UserPasswordField.ForeColor = Color.Blue;
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand( "INSERT INTO users (login, password, email) VALUES (@login, @password, @email)", db.GetConnection());

            command.Parameters.AddWithValue("login", UserLoginField.Text);
            command.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));
            command.Parameters.AddWithValue("email", UserEmailField.Text);

            db.OpenConnection();

            try
            {
                if (command.ExecuteNonQuery() == 1) MessageBox.Show("Аккаунт создан");

                else MessageBox.Show("Ошибка при выполнении");
            } 
            
            catch (MySqlException ex) 
            {
                if (ex.Message.Contains("Duplicate entry")) MessageBox.Show("Такой логин уже существует");
               else MessageBox.Show (ex.Message); 
            }
 

            db.CloseConnection();
        }

       private string Hash(string input)
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void RegesterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void LinkToAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Close();
        }
    }
}
