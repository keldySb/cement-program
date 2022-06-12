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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            UserName.Text = "Введите имя";
            UserName.ForeColor = Color.Gray;
            UserSurname.Text = "Введите фамилию";
            UserSurname.ForeColor = Color.Gray;
            Loginbox.Text = "Введите логин";
            Loginbox.ForeColor = Color.Gray;
            Passwordbox.Text = "Введите пароль";
            Passwordbox.ForeColor = Color.Gray;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void UserName_Enter(object sender, EventArgs e)
        {
            if (UserName.Text == "Введите имя")
            {
                UserName.Text = "";
                UserName.ForeColor = Color.Black;
            }


        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (UserName.Text == "")
            {
                UserName.Text = "Введите имя";
                UserName.ForeColor = Color.Gray;
            }
        }

        private void UserSurname_Enter(object sender, EventArgs e)
        {
            if (UserSurname.Text == "Введите фамилию")
            {
                UserSurname.Text = "";
                UserSurname.ForeColor = Color.Black;
            }
        }

        private void UserSurname_Leave(object sender, EventArgs e)
        {
            if (UserSurname.Text == "")
            {
                UserSurname.Text = "Введите фамилию";
                UserSurname.ForeColor = Color.Gray;
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

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "Введите имя" || UserSurname.Text == "Введите фамилию" || Loginbox.Text == "Введите логин" || Passwordbox.Text == "Введите пароль")
                return;

            if (CheckUser() || CheckPass())
                return;

            DateBase db = new DateBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @password, @name, @surname)",db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Loginbox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Passwordbox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserName.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurname.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();

        }

        public Boolean CheckUser()
        {
            DateBase db = new DateBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Loginbox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой");
                return true;
            }
            else
                return false;

            
        }

        public Boolean CheckPass()
        {
            if (Passwordbox.Text.Length < 6)
            {
                MessageBox.Show("Слишком маленький пароль!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
        }

        private void Passwordbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Passwordbox.Text.Length == 0)
            {
                if (e.KeyChar == ' ')
                {
                    e.Handled = true;
                }
            }
        }
    }
}
