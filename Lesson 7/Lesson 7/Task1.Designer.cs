
namespace Lesson_7
{
    partial class Task1
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
            this.Exit = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Multy2 = new System.Windows.Forms.Button();
            this.Plus1 = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.GameField = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.Rand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(319, 356);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 15, 25, 15);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(140, 40);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset.ForeColor = System.Drawing.Color.OrangeRed;
            this.Reset.Location = new System.Drawing.Point(319, 286);
            this.Reset.Margin = new System.Windows.Forms.Padding(3, 15, 25, 15);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(140, 40);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "=1";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Multy2
            // 
            this.Multy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multy2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Multy2.Location = new System.Drawing.Point(319, 146);
            this.Multy2.Margin = new System.Windows.Forms.Padding(3, 15, 25, 15);
            this.Multy2.Name = "Multy2";
            this.Multy2.Size = new System.Drawing.Size(140, 40);
            this.Multy2.TabIndex = 2;
            this.Multy2.Text = "*2";
            this.Multy2.UseVisualStyleBackColor = true;
            this.Multy2.Click += new System.EventHandler(this.Multy2_Click);
            // 
            // Plus1
            // 
            this.Plus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Plus1.Location = new System.Drawing.Point(319, 76);
            this.Plus1.Margin = new System.Windows.Forms.Padding(3, 15, 25, 15);
            this.Plus1.Name = "Plus1";
            this.Plus1.Size = new System.Drawing.Size(140, 40);
            this.Plus1.TabIndex = 3;
            this.Plus1.Text = "+1";
            this.Plus1.UseVisualStyleBackColor = true;
            this.Plus1.Click += new System.EventHandler(this.Plus1_Click);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Start.Location = new System.Drawing.Point(31, 40);
            this.Start.Margin = new System.Windows.Forms.Padding(3, 15, 25, 15);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(428, 390);
            this.Start.TabIndex = 4;
            this.Start.Text = "Играть";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(319, 216);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 15, 25, 15);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(140, 40);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // GameField
            // 
            this.GameField.AutoSize = true;
            this.GameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameField.Location = new System.Drawing.Point(71, 167);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(190, 69);
            this.GameField.TabIndex = 6;
            this.GameField.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Игровое поле";
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterLabel.Location = new System.Drawing.Point(90, 262);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(88, 24);
            this.CounterLabel.TabIndex = 8;
            this.CounterLabel.Text = "Попытки";
            // 
            // Rand
            // 
            this.Rand.AutoSize = true;
            this.Rand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rand.Location = new System.Drawing.Point(90, 321);
            this.Rand.Name = "Rand";
            this.Rand.Size = new System.Drawing.Size(145, 24);
            this.Rand.TabIndex = 9;
            this.Rand.Text = "Искомое число";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Rand);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameField);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Plus1);
            this.Controls.Add(this.Multy2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Task1";
            this.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.Text = "Программа \"Удвоитель\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Task1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Multy2;
        private System.Windows.Forms.Button Plus1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label GameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.Label Rand;
    }
}