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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            BalanceBox.Text = "Введите сумму";
            BalanceBox.ForeColor = Color.Gray;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        Point lastPoint;

        private void Store_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Store_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LabelInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LabelInfo_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainStore_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainStore_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        int balance;
        double FinishSum = 0;
        int Buy = 0;

        private void ButtomBalance_Click(object sender, EventArgs e)
        {
            if (Buy == 0)
            {
                if (BalanceBox.Text == "Введите сумму" || BalanceBox.Text == "" || BalanceBox.Text == "-")
                {
                    MessageBox.Show("Введите сумму");
                    return;
                }

                balance = Convert.ToInt32(Balance.Text);

                if (balance <= 100000000)
                {
                    balance += Convert.ToInt32(BalanceBox.Text);

                    if (balance > 0)
                    {
                        Balance.Text = balance.ToString();
                        BalanceBox.Clear();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели слишком большое количество");
                    BalanceBox.Clear();
                    return;
                }
            }
        }

        private void BalanceBox_Enter(object sender, EventArgs e)
        {
            if (BalanceBox.Text == "Введите сумму")
            {
                BalanceBox.Text = "";
                BalanceBox.ForeColor = Color.Black;
            }
        }

        private void BalanceBox_Leave(object sender, EventArgs e)
        {
            if (BalanceBox.Text == "")
            {
                BalanceBox.Text = "Введите сумму";
                BalanceBox.ForeColor = Color.Gray;
            }
        }

        private void BalanceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }

            if (BalanceBox.Text.Length == 0)
            {
                if (e.KeyChar == '0')
                    e.Handled = true;
            }
        }

        double sum = 0;
        int proverkaPoint = 0;
        int proverkaRazmer = 0;
        int proverkaQuantity = 0;
        int proverkaMarka = 0;
        double PriceRazmer = 0;
        double PriceKolVo = 0;
        double PriceMarka = 0;
        double Rasstoyanie = 0;
        string Marka;
        string Point;
        double Razmer = 0;
        double KolVo = 0;

        public void ButtonInfo_Click(object sender, EventArgs e)
        {
            if (Buy == 0)
            {


                Marka = Convert.ToString(CementBox.Text);
                Point = Convert.ToString(PointBox.Text);

                switch (CementBox.SelectedIndex) {
                    case 0:
                        Marka = "ЦЕМ I 42,5 Н СС";
                        PriceMarka = 8120;
                        proverkaMarka = 1;
                        break;
                    case 1:
                        Marka = "ЦЕМ II/А-Ш 42,5Н";
                        PriceMarka = 8550;
                        proverkaMarka = 1;
                        break;
                    case 2:
                        Marka = "ЦЕМ I 52,5Н";
                        PriceMarka = 10425;
                        proverkaMarka = 1;
                        break;
                }


                switch (PointBox.SelectedIndex)
                {
                    case 0:
                        Point = "Чусовой";
                        Rasstoyanie = 39;
                        proverkaPoint = 1;
                        break;
                    case 1:
                        Point = "Кунгур";
                        Rasstoyanie = 159;
                        proverkaPoint = 1;
                        break;
                    case 2:
                        Point = "Березники";
                        Rasstoyanie = 186;
                        proverkaPoint = 1;
                        break;
                    case 3:
                        Point = "Пермь";
                        Rasstoyanie = 129;
                        proverkaPoint = 1;
                        break;
                    case 4:
                        Point = "Соликамск";
                        Rasstoyanie = 166;
                        proverkaPoint = 1;
                        break;
                    case 5:
                        Point = "Краснокамск";
                        Rasstoyanie = 202;
                        proverkaPoint = 1;
                        break;
                }

                switch (RazmerBox.SelectedIndex)
                {
                    case 0:
                        Razmer = 25;
                        PriceRazmer = 0.025;
                        proverkaRazmer = 1;
                        break;
                    case 1:
                        Razmer = 500;
                        PriceRazmer = 0.5;
                        proverkaRazmer = 1;
                        break;
                    case 2:
                        Razmer = 1000;
                        PriceRazmer = 1;
                        proverkaRazmer = 1;
                        break;
                }

                switch (QuantityBox.SelectedIndex)
                {
                    case 0:
                        KolVo = 50;
                        PriceKolVo = 50;
                        proverkaQuantity = 1;
                        break;
                    case 1:
                        KolVo = 100;
                        PriceKolVo = 100;
                        proverkaQuantity = 1;
                        break;
                    case 2:
                        KolVo = 200;
                        PriceKolVo = 200;
                        proverkaQuantity = 1;
                        break;
                    case 3:
                        KolVo = 500;
                        PriceKolVo = 500;
                        proverkaQuantity = 1;
                        break;
                    case 4:
                        KolVo = 1000;
                        PriceKolVo = 1000;
                        proverkaQuantity = 1;
                        break;
                }
                    sum = (PriceMarka * PriceRazmer) * PriceKolVo;

                    LabelInfo.Text = "Информация: " + "\nМесто отправления: Горнозаводск" + "\nМарка цемента: " + Marka +
                    "\nСпособ доставки: Машина" +
                    "\nМесто доставки: " + Point + "\nРасстояние: " + Rasstoyanie.ToString() + "км." +
                    "\nРазмер мешков: " + Razmer.ToString() + "кг." +
                    "\nКоличество мешков: " + KolVo.ToString() +
                    "\nИтого: " + sum.ToString("c");
            } 
        }
        private void ButtonBuy_Click(object sender, EventArgs e)
        {
            if (balance == 0 || sum == 0)
                return;

            Marka = Convert.ToString(CementBox.Text);
            Point = Convert.ToString(PointBox.Text);

            if (proverkaPoint == 0 || proverkaRazmer == 0 || proverkaQuantity == 0 || proverkaMarka == 0)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
                
            if (sum > balance)
            {
                MessageBox.Show("У вас не хватает денег, пополните баланс");
            }
            else if (Buy == 0)
            {
                FinishSum = balance - sum;
                MessageBox.Show("Покупка прошла успешно! Можете закрыть приложение");
                this.Balance.Text = FinishSum.ToString();
                Buy = 1;
                CementBox.Enabled = false;
                RazmerBox.Enabled = false;
                QuantityBox.Enabled = false;
                PointBox.Enabled = false;
                BalanceBox.Enabled = false;

                sum = (PriceMarka * PriceRazmer) * PriceKolVo;

                LabelInfo.Text = "Покупка прошла успешно" + "\nИнформация о покупке: " + "\nМесто отправления: Горнозаводск" + "\nМарка цемента: " + Marka +
                "\nСпособ доставки: Машина" +
                "\nМесто доставки: " + Point + "\nРасстояние: " + Rasstoyanie.ToString() + "км." +
                "\nРазмер мешков: " + Razmer.ToString() + "кг." +
                "\nКоличество мешков: " + KolVo.ToString() +
                "\nИтого: " + sum.ToString("c");
            }

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (Buy == 0)
            {
                MessageBox.Show("Это программа о покупке цемента оптом " +
               "\nИнструкция:" +
               "\n1.Заполните поля(марка цемента,количество мешков, размер мешков, место доставки) и нажмите кнопку 'получение информации'" +
               "\n2.После получения информации и итоговой суммы пополните баланс, для этого введите сумму и нажмите кнопку 'пополнить баланс'" +
               "\n3.После пополнения баланса на нужную сумму нажмите кнопку купить" +
               "\nВнимание!" +
               "\n1.Вы не сможете совершить покупку если хоть одно поле будет пропущено или баланс будет меньше итоговой суммы(или вовсе нулевым). " +
               "\n2.Как складывается итоговая сумма? Все зависит от марки цемента, цена марки цемента указана за 1 тонну(1000кг)!" +
               "\n(Марка цемента * размер мешков) * количество мешков" +
               "\n3.Покупку можно совершить один раз, после совершения покупки ничего нельзя будет изменить");
            }
            else
            {

            }
           
        }


    }

}




