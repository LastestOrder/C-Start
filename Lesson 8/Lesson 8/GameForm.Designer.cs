
namespace Lesson_8
{
    partial class GameForm
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
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnFlase = new System.Windows.Forms.Button();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrue
            // 
            this.btnTrue.BackColor = System.Drawing.Color.Transparent;
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrue.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnTrue.Location = new System.Drawing.Point(39, 288);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(30, 3, 3, 30);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(200, 50);
            this.btnTrue.TabIndex = 0;
            this.btnTrue.Text = "True";
            this.btnTrue.UseVisualStyleBackColor = false;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // btnFlase
            // 
            this.btnFlase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFlase.ForeColor = System.Drawing.Color.Red;
            this.btnFlase.Location = new System.Drawing.Point(329, 288);
            this.btnFlase.Margin = new System.Windows.Forms.Padding(30, 3, 30, 30);
            this.btnFlase.Name = "btnFlase";
            this.btnFlase.Size = new System.Drawing.Size(200, 50);
            this.btnFlase.TabIndex = 1;
            this.btnFlase.Text = "False";
            this.btnFlase.UseVisualStyleBackColor = true;
            this.btnFlase.Click += new System.EventHandler(this.btnFlase_Click);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(24, 42);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(519, 222);
            this.tbQuestion.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(186, 371);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(200, 50);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 440);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.btnFlase);
            this.Controls.Add(this.btnTrue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.Text = "Игра \"Верю Неверю\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFlase;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Button btnNext;
    }
}