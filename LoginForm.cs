using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indiv_zadanie
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Loginbox.Text = "Введите логин";
            Loginbox.ForeColor = Color.Gray;
            Passwordbox.Text = "Введите пароль";
            Passwordbox.ForeColor = Color.Gray;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Black;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.DimGray;
        }

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Avtorizchia_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Avtorizchia_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Loginbox_Enter(object sender, EventArgs e)
        {
            if (Loginbox.Text == "Введите логин")
            {
                Loginbox.Text = "";
                Loginbox.ForeColor = Color.Black;
            }
        }

        private void Loginbox_Leave(object sender, EventArgs e)
        {
            if (Loginbox.Text == "")
            {
                Loginbox.Text = "Введите логин";
                Loginbox.ForeColor = Color.Gray;
            }
        }

        private void Passwordbox_Enter(object sender, EventArgs e)
        {
            if (Passwordbox.Text == "Введите пароль")
            {
                Passwordbox.Text = "";
                Passwordbox.ForeColor = Color.Black;
                Passwordbox.UseSystemPasswordChar = true;
            }
        }

        private void Passwordbox_Leave(object sender, EventArgs e)
        {
            if (Passwordbox.Text == "")
            {
                Passwordbox.Text = "Введите пароль";
                Passwordbox.ForeColor = Color.Gray;
                Passwordbox.UseSystemPasswordChar = false;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (Loginbox.Text == "Введите логин" || Passwordbox.Text == "Введите пароль")
                return;

            String loginUser = Loginbox.Text;
            String passUser = Passwordbox.Text;

            DateBase db = new DateBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
             adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }

        }


        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
