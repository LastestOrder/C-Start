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
        //    1. а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
        //  б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
        //  Игрок должен постараться получить это число за минимальное количество ходов.
        //  в) * Добавить кнопку «Отменить», которая отменяет последние ходы.

    public partial class Task1 : Form
    {

        public int counter;
        public int counterL;
        public int[] number;
        private int doubler;
        public Random random;
        public int r;

        public Task1()
        {
            InitializeComponent();
        }

        private void Task1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProgramStart programStart = new ProgramStart();
            programStart.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            counter = 0;
            counterL = 1;
            number = new int[100];
            Start.Visible = false;
            GameField.Text = 1.ToString();
            number[0] = 1;
            doubler = 1;
            CounterLabel.Text = $"Попытки: {counter}";
            random = new Random();
            r = random.Next(101);
            Rand.Text = $"Искомое число: {r}";


        }

        private void Plus1_Click(object sender, EventArgs e)
        {
            doubler += 1;
            number[counterL] = doubler;
            GameField.Text = number[counterL].ToString();
            if (r == doubler)
            {
                MessageBox.Show($"Вы победили\n За {counter} попыток", "Congratulation", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                Start.Visible = true;
            }            
            counter++;
            counterL++;
            CounterLabel.Text = $"Попытки: {counter}";
            if (r==doubler)
            {

            }


        }

        private void Multy2_Click(object sender, EventArgs e)
        {
            doubler *= 2;
            number[counterL] = doubler;
            GameField.Text = number[counterL].ToString();
            if (r == doubler)
            {
                MessageBox.Show($"Вы победили\n За {counter} попыток", "Congratulation", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                Start.Visible = true;
            }
            counter++;
            counterL++;
            CounterLabel.Text = $"Попытки: {counter}";

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (counterL > 1)
            {
                counterL--;
                number[counterL] = number[counterL - 1];
                doubler = number[counterL];
                GameField.Text = number[counterL].ToString();
                counter++;
                
                CounterLabel.Text = $"Попытки: {counter}";
            }
            else
                MessageBox.Show("Это самое первое число, больше отменять нельзя!", "Удвоитель ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            doubler = 1;
            counterL = 0;
            number[counterL] = doubler;
            GameField.Text = number[counterL].ToString();
            counter++;
            counterL = 0;
            CounterLabel.Text = $"Попытки: {counter}";

        }
    }
}
