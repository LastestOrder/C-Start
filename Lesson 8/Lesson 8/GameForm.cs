using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_8
{
    public partial class GameForm : Form
    {
        private Random random;
        public int r;
        public TrueFalse database;
        public GameForm()
        {
            InitializeComponent();
            random = new Random();
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load(); 
                r = random.Next(database.Count);
                tbQuestion.Text = database[r].Text;
            }

            
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartProgram startProgram = new StartProgram();
            startProgram.Show();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            if (database[r].TrueFalse == false)
                MessageBox.Show("Вы не угадали!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Вы угадали!", "Поздравление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                r = random.Next(0, database.Count);
                tbQuestion.Text = database[r].Text;
            }
        }

        private void btnFlase_Click(object sender, EventArgs e)
        {
            if (database[r].TrueFalse == false)
            {
                MessageBox.Show("Вы угадали!", "Поздравление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                r = random.Next(0, database.Count);
                tbQuestion.Text = database[r].Text;
            }
            else
                MessageBox.Show("Вы не угадали!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            r = random.Next(0, database.Count);
            tbQuestion.Text = database[r].Text;
        }
    }
}
