using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7
{

        //    2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число
        //    от 1 до 100, а человек пытается его угадать за минимальное число попыток.Для ввода данных
        //    от человека используется элемент TextBox.
        //    Старайтесь разбивать программы на подпрограммы. Переписывайте в начало программы
        //    условие и свою фамилию. Все программы сделать в одном решении.
    public partial class Task2 : Form
    {
        private int change;
        private Random random;
        private int r;
        private int counter;

        public Task2()
        {
            InitializeComponent();
        }

        private void GameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number)&& number!=8)
            {
                e.Handled = true;
            }
            if (number == 13)
            {
                Test.PerformClick();
                e.Handled = true;
            }

        }

        private void Task2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProgramStart programStart2 = new ProgramStart();
            programStart2.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void Start_Click(object sender, EventArgs e)
        {
           counter = 0;
           // number = new int[100];
            Start.Visible = false;
           // GameField.Text = 1.ToString();
           // number[0] = 1;
           // doubler = 1;
            CounterLabel.Text = $"Попытки: {counter}";
            random = new Random();
            r = random.Next(101);
            Rand.Text = $"Искомое число от 1 до 100 ";

            Check.Visible = true;
            Check.Text = $"Введите число";

        }

        private void Test_Click(object sender, EventArgs e)
        {
            counter++;
            CounterLabel.Text = $"Попытки: {counter}";
            if (r==int.Parse(GameField.Text))
            {
                MessageBox.Show($"Вы победили\n За {counter} попыток", "Congratulation", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                Start.Visible = true;
            }
            if (r <= int.Parse(GameField.Text))
            {
                Check.Text = $"Ваше число {GameField.Text} Больше искомого";
            }
            else
            {
                Check.Visible = true;
                Check.Text = $"Ваше число {GameField.Text} Меньше искомого";
            }
        }
    }
}
