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
    public partial class ProgramStart : Form
    {
        public ProgramStart()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {

            this.Hide();
            Task1 task1 = new Task1();
            task1.Show();
        }


        private void ProgramStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task2 task2 = new Task2();
            task2.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {           
                Close();
                Application.Exit();            
        }
    }
}
