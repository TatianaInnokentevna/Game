﻿using MySql.Data.MySqlClient;
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

namespace ItprogerApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            UserLoginField.Text = "Введите имя";
         
            UserPasswordField.Text = "Введите пароль";
            this.Text = "Авторизация";
        }

        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Введите имя")
            {
                UserLoginField.Text = "";
                UserLoginField.ForeColor = Color.White;
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

            
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Введите пароль";
                UserPasswordField.UseSystemPasswordChar = false;
                UserPasswordField.ForeColor = Color.Blue;
            }
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            if (UserLoginField.Text.Trim() == "" && UserLoginField.Text.Trim() == "Введите имя")
            {

                MessageBox.Show("Вы не ввели имя");
                return;
            }

            if (UserPasswordField.Text.Trim() == "" && UserPasswordField.Text.Trim() == "Введите пароль")
            {

                MessageBox.Show("Вы не ввели пароль");
                return;
            }
           
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(id) FROM users WHERE login = @login AND password = @password", db.GetConnection());

            command.Parameters.AddWithValue("login", UserLoginField.Text);
            command.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));
           

            db.OpenConnection();

           int countUser = Convert.ToInt32(command.ExecuteScalar());
            if (countUser > 0) 
            {
                this.Hide();
                PingPong pingPong = new PingPong();
                pingPong.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("User not exists");

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

   

        private void AuthForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void LinkToReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegesterForm registerForm = new RegesterForm();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
