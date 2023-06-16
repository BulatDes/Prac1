
namespace Zadanie_1._3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.ClearBut = new System.Windows.Forms.Button();
            this.DeleteSongBut = new System.Windows.Forms.Button();
            this.pereity = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PereityInd = new System.Windows.Forms.Button();
            this.BackBut = new System.Windows.Forms.Button();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.NextBut = new System.Windows.Forms.Button();
            this.addbut = new System.Windows.Forms.Button();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(181, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Текущая композиция:";
            this.label9.UseWaitCursor = true;
            // 
            // ClearBut
            // 
            this.ClearBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBut.Location = new System.Drawing.Point(340, 12);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(199, 29);
            this.ClearBut.TabIndex = 46;
            this.ClearBut.Text = "Очистить плейлист";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.UseWaitCursor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // DeleteSongBut
            // 
            this.DeleteSongBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSongBut.Location = new System.Drawing.Point(340, 66);
            this.DeleteSongBut.Name = "DeleteSongBut";
            this.DeleteSongBut.Size = new System.Drawing.Size(199, 29);
            this.DeleteSongBut.TabIndex = 45;
            this.DeleteSongBut.Text = "Удалить композицию";
            this.DeleteSongBut.UseVisualStyleBackColor = true;
            this.DeleteSongBut.UseWaitCursor = true;
            this.DeleteSongBut.Click += new System.EventHandler(this.DeleteSongBut_Click);
            // 
            // pereity
            // 
            this.pereity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pereity.Location = new System.Drawing.Point(135, 12);
            this.pereity.Name = "pereity";
            this.pereity.Size = new System.Drawing.Size(199, 29);
            this.pereity.TabIndex = 44;
            this.pereity.Text = "Перейти к началу";
            this.pereity.UseVisualStyleBackColor = true;
            this.pereity.UseWaitCursor = true;
            this.pereity.Click += new System.EventHandler(this.pereity_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(209, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 26);
            this.textBox1.TabIndex = 43;
            this.textBox1.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(138, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Индекс:";
            this.label8.UseWaitCursor = true;
            // 
            // PereityInd
            // 
            this.PereityInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PereityInd.Location = new System.Drawing.Point(579, 12);
            this.PereityInd.Name = "PereityInd";
            this.PereityInd.Size = new System.Drawing.Size(199, 29);
            this.PereityInd.TabIndex = 41;
            this.PereityInd.Text = "Перейти по индексу";
            this.PereityInd.UseVisualStyleBackColor = true;
            this.PereityInd.UseWaitCursor = true;
            this.PereityInd.Click += new System.EventHandler(this.PereityInd_Click);
            // 
            // BackBut
            // 
            this.BackBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBut.Location = new System.Drawing.Point(12, 101);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(112, 29);
            this.BackBut.TabIndex = 40;
            this.BackBut.Text = "Назад";
            this.BackBut.UseVisualStyleBackColor = true;
            this.BackBut.UseWaitCursor = true;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filenameLabel.Location = new System.Drawing.Point(188, 217);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(0, 20);
            this.filenameLabel.TabIndex = 39;
            this.filenameLabel.UseWaitCursor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(188, 179);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 20);
            this.titleLabel.TabIndex = 38;
            this.titleLabel.UseWaitCursor = true;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(188, 144);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(0, 20);
            this.authorLabel.TabIndex = 37;
            this.authorLabel.UseWaitCursor = true;
            // 
            // NextBut
            // 
            this.NextBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextBut.Location = new System.Drawing.Point(12, 66);
            this.NextBut.Name = "NextBut";
            this.NextBut.Size = new System.Drawing.Size(112, 29);
            this.NextBut.TabIndex = 36;
            this.NextBut.Text = "Далее";
            this.NextBut.UseVisualStyleBackColor = true;
            this.NextBut.UseWaitCursor = true;
            this.NextBut.Click += new System.EventHandler(this.NextBut_Click);
            // 
            // addbut
            // 
            this.addbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbut.Location = new System.Drawing.Point(12, 12);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(112, 29);
            this.addbut.TabIndex = 35;
            this.addbut.Text = "Добавить";
            this.addbut.UseVisualStyleBackColor = true;
            this.addbut.UseWaitCursor = true;
            this.addbut.Click += new System.EventHandler(this.addbut_Click);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filenameTextBox.Location = new System.Drawing.Point(161, 386);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(220, 26);
            this.filenameTextBox.TabIndex = 34;
            this.filenameTextBox.UseWaitCursor = true;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(161, 354);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(220, 26);
            this.titleTextBox.TabIndex = 33;
            this.titleTextBox.UseWaitCursor = true;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorTextBox.Location = new System.Drawing.Point(161, 322);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(220, 26);
            this.authorTextBox.TabIndex = 32;
            this.authorTextBox.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(59, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Имя файла";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Название песни";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(99, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Автор";
            this.label5.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.DeleteSongBut);
            this.Controls.Add(this.pereity);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PereityInd);
            this.Controls.Add(this.BackBut);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.NextBut);
            this.Controls.Add(this.addbut);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ClearBut;
        private System.Windows.Forms.Button DeleteSongBut;
        private System.Windows.Forms.Button pereity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button PereityInd;
        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Button NextBut;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

