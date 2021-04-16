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
    public partial class StartProgram : Form
    {
        public TrueFalse database;

        public StartProgram()
        {
            InitializeComponent();
            Control(false);
        }

        private void menuitemExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void menuitemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(saveFileDialog.FileName);
                database.Add("Земля круглая?", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                Control(true);
                
            }
        }

        private void menuitemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
                Control(true);
                
                tbQuestion.Text = database[0].Text;
                cbTrue.Checked = database[0].TrueFalse;
            }
        }

        private void menuitemSave_Click(object sender, EventArgs e)
        {
            database.Save();
        }

        private void menuitemGame_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
            this.Hide();
        }

        private void menuitemAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            database.Add("#" + (database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum = database.Count;
        }

        private void Control(bool check)
        {
            menuitemSave.Enabled = check;
            btnAdd.Enabled = check;
            btnDelete.Enabled = check;
            btnSave.Enabled = check;
            nudNumber.Enabled = check;
            cbTrue.Enabled = check;
            tbNum.Enabled = check;
        }

        private void tbNum_TextChanged(object sender, EventArgs e)
        {
            if (tbNum.Text != string.Empty)
                if (int.Parse(tbNum.Text) >= nudNumber.Minimum && int.Parse(tbNum.Text) <= nudNumber.Maximum)
                    nudNumber.Value = int.Parse(tbNum.Text);
        }

        private void StartProgram_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
