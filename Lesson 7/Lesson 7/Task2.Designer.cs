
namespace Lesson_7
{
    partial class Task2
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
            this.label2 = new System.Windows.Forms.Label();
            this.Rand = new System.Windows.Forms.Label();
            this.GameField = new System.Windows.Forms.TextBox();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Игровое поле";
            // 
            // Rand
            // 
            this.Rand.AutoSize = true;
            this.Rand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rand.Location = new System.Drawing.Point(144, 147);
            this.Rand.Name = "Rand";
            this.Rand.Size = new System.Drawing.Size(145, 24);
            this.Rand.TabIndex = 10;
            this.Rand.Text = "Искомое число";
            // 
            // GameField
            // 
            this.GameField.Location = new System.Drawing.Point(240, 228);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(100, 20);
            this.GameField.TabIndex = 11;
            this.GameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameField_KeyPress);
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterLabel.Location = new System.Drawing.Point(61, 297);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(88, 24);
            this.CounterLabel.TabIndex = 12;
            this.CounterLabel.Text = "Попытки";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(310, 374);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 15, 25, 15);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(140, 40);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Start.Location = new System.Drawing.Point(32, 35);
            this.Start.Margin = new System.Windows.Forms.Padding(3, 15, 25, 15);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(428, 390);
            this.Start.TabIndex = 14;
            this.Start.Text = "Играть";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Test
            // 
            this.Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Test.ForeColor = System.Drawing.Color.DarkCyan;
            this.Test.Location = new System.Drawing.Point(310, 304);
            this.Test.Margin = new System.Windows.Forms.Padding(3, 15, 25, 15);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(140, 40);
            this.Test.TabIndex = 15;
            this.Test.Text = "Проверка";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // Check
            // 
            this.Check.AutoSize = true;
            this.Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check.Location = new System.Drawing.Point(78, 102);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(313, 24);
            this.Check.TabIndex = 16;
            this.Check.Text = "Ваше число 16  Меньше искомого";
            this.Check.Visible = false;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.GameField);
            this.Controls.Add(this.Rand);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Task2";
            this.Text = "Программа \"Угадай число\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Task2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Rand;
        private System.Windows.Forms.TextBox GameField;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Label Check;
    }
}