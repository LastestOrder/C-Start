
namespace Lesson_8
{
    partial class StartProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartProgram));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuitemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.cbTrue = new System.Windows.Forms.CheckBox();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.menuitemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemNew,
            this.menuitemOpen,
            this.menuitemSave,
            this.toolStripSeparator2,
            this.menuitemGame,
            this.toolStripSeparator1,
            this.menuitemAbout,
            this.menuitemExit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // menuitemNew
            // 
            this.menuitemNew.Name = "menuitemNew";
            this.menuitemNew.Size = new System.Drawing.Size(180, 22);
            this.menuitemNew.Text = "New";
            this.menuitemNew.Click += new System.EventHandler(this.menuitemNew_Click);
            // 
            // menuitemOpen
            // 
            this.menuitemOpen.Name = "menuitemOpen";
            this.menuitemOpen.Size = new System.Drawing.Size(180, 22);
            this.menuitemOpen.Text = "Open";
            this.menuitemOpen.Click += new System.EventHandler(this.menuitemOpen_Click);
            // 
            // menuitemSave
            // 
            this.menuitemSave.Name = "menuitemSave";
            this.menuitemSave.Size = new System.Drawing.Size(180, 22);
            this.menuitemSave.Text = "Save";
            this.menuitemSave.Click += new System.EventHandler(this.menuitemSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // menuitemGame
            // 
            this.menuitemGame.Name = "menuitemGame";
            this.menuitemGame.Size = new System.Drawing.Size(180, 22);
            this.menuitemGame.Text = "Game";
            this.menuitemGame.Click += new System.EventHandler(this.menuitemGame_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuitemExit
            // 
            this.menuitemExit.Name = "menuitemExit";
            this.menuitemExit.Size = new System.Drawing.Size(180, 22);
            this.menuitemExit.Text = "Exit";
            this.menuitemExit.Click += new System.EventHandler(this.menuitemExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbNum);
            this.panel1.Controls.Add(this.cbTrue);
            this.panel1.Controls.Add(this.nudNumber);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 1;
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(472, 33);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 20);
            this.tbNum.TabIndex = 5;
            this.tbNum.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            // 
            // cbTrue
            // 
            this.cbTrue.AutoSize = true;
            this.cbTrue.Location = new System.Drawing.Point(718, 33);
            this.cbTrue.Margin = new System.Windows.Forms.Padding(3, 31, 25, 31);
            this.cbTrue.Name = "cbTrue";
            this.cbTrue.Size = new System.Drawing.Size(48, 17);
            this.cbTrue.TabIndex = 4;
            this.cbTrue.Text = "True";
            this.cbTrue.UseVisualStyleBackColor = true;
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(600, 32);
            this.nudNumber.Margin = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(103, 20);
            this.nudNumber.TabIndex = 3;
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(239, 26);
            this.btnSave.Margin = new System.Windows.Forms.Padding(25, 28, 3, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(136, 28);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(25, 28, 3, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 28);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(28, 28, 3, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(0, 28);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(800, 343);
            this.tbQuestion.TabIndex = 3;
            // 
            // menuitemAbout
            // 
            this.menuitemAbout.Name = "menuitemAbout";
            this.menuitemAbout.Size = new System.Drawing.Size(180, 22);
            this.menuitemAbout.Text = "About";
            this.menuitemAbout.Click += new System.EventHandler(this.menuitemAbout_Click);
            // 
            // StartProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbQuestion);
            this.Name = "StartProgram";
            this.Text = "Старт Программы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartProgram_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem menuitemNew;
        private System.Windows.Forms.ToolStripMenuItem menuitemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuitemSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuitemExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbTrue;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuitemGame;
        private System.Windows.Forms.ToolStripMenuItem menuitemAbout;
    }
}

