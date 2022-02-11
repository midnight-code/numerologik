namespace numerologik
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMatrix = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGod = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblchislo1 = new System.Windows.Forms.Label();
            this.lblChislo2 = new System.Windows.Forms.Label();
            this.lblChislo3 = new System.Windows.Forms.Label();
            this.lblChisloSumm = new System.Windows.Forms.Label();
            this.lblChislo4 = new System.Windows.Forms.Label();
            this.lblChislo5 = new System.Windows.Forms.Label();
            this.lblChislo6 = new System.Windows.Forms.Label();
            this.lblChisloSumm2 = new System.Windows.Forms.Label();
            this.lblChislo7 = new System.Windows.Forms.Label();
            this.lblChislo8 = new System.Windows.Forms.Label();
            this.lblChislo9 = new System.Windows.Forms.Label();
            this.lblChisloSumm3 = new System.Windows.Forms.Label();
            this.lblChislo10 = new System.Windows.Forms.Label();
            this.lblChislo11 = new System.Windows.Forms.Label();
            this.lblChislo12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите дату рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "День";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Месяц";
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Location = new System.Drawing.Point(11, 179);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(51, 13);
            this.lblMatrix.TabIndex = 4;
            this.lblMatrix.Text = "Матрица";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Год";
            // 
            // txtGod
            // 
            this.txtGod.Location = new System.Drawing.Point(205, 119);
            this.txtGod.MaxLength = 4;
            this.txtGod.Name = "txtGod";
            this.txtGod.Size = new System.Drawing.Size(100, 20);
            this.txtGod.TabIndex = 2;
            this.txtGod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGod_KeyPress);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(74, 119);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 1;
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(15, 119);
            this.txtDen.MaxLength = 2;
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(44, 20);
            this.txtDen.TabIndex = 0;
            this.txtDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 153);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Дата рождения";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(33, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(10, 13);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "-";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(164, 38);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(10, 13);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "-";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(295, 38);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(10, 13);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "-";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(394, 38);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(10, 13);
            this.lbl4.TabIndex = 13;
            this.lbl4.Text = "-";
            // 
            // lblchislo1
            // 
            this.lblchislo1.AutoSize = true;
            this.lblchislo1.Location = new System.Drawing.Point(33, 74);
            this.lblchislo1.Name = "lblchislo1";
            this.lblchislo1.Size = new System.Drawing.Size(10, 13);
            this.lblchislo1.TabIndex = 14;
            this.lblchislo1.Text = "-";
            // 
            // lblChislo2
            // 
            this.lblChislo2.AutoSize = true;
            this.lblChislo2.Location = new System.Drawing.Point(164, 74);
            this.lblChislo2.Name = "lblChislo2";
            this.lblChislo2.Size = new System.Drawing.Size(10, 13);
            this.lblChislo2.TabIndex = 15;
            this.lblChislo2.Text = "-";
            // 
            // lblChislo3
            // 
            this.lblChislo3.AutoSize = true;
            this.lblChislo3.Location = new System.Drawing.Point(295, 74);
            this.lblChislo3.Name = "lblChislo3";
            this.lblChislo3.Size = new System.Drawing.Size(10, 13);
            this.lblChislo3.TabIndex = 16;
            this.lblChislo3.Text = "-";
            // 
            // lblChisloSumm
            // 
            this.lblChisloSumm.AutoSize = true;
            this.lblChisloSumm.Location = new System.Drawing.Point(394, 74);
            this.lblChisloSumm.Name = "lblChisloSumm";
            this.lblChisloSumm.Size = new System.Drawing.Size(10, 13);
            this.lblChisloSumm.TabIndex = 17;
            this.lblChisloSumm.Text = "-";
            // 
            // lblChislo4
            // 
            this.lblChislo4.AutoSize = true;
            this.lblChislo4.Location = new System.Drawing.Point(33, 112);
            this.lblChislo4.Name = "lblChislo4";
            this.lblChislo4.Size = new System.Drawing.Size(10, 13);
            this.lblChislo4.TabIndex = 18;
            this.lblChislo4.Text = "-";
            // 
            // lblChislo5
            // 
            this.lblChislo5.AutoSize = true;
            this.lblChislo5.Location = new System.Drawing.Point(164, 112);
            this.lblChislo5.Name = "lblChislo5";
            this.lblChislo5.Size = new System.Drawing.Size(10, 13);
            this.lblChislo5.TabIndex = 19;
            this.lblChislo5.Text = "-";
            // 
            // lblChislo6
            // 
            this.lblChislo6.AutoSize = true;
            this.lblChislo6.Location = new System.Drawing.Point(295, 112);
            this.lblChislo6.Name = "lblChislo6";
            this.lblChislo6.Size = new System.Drawing.Size(10, 13);
            this.lblChislo6.TabIndex = 20;
            this.lblChislo6.Text = "-";
            // 
            // lblChisloSumm2
            // 
            this.lblChisloSumm2.AutoSize = true;
            this.lblChisloSumm2.Location = new System.Drawing.Point(394, 112);
            this.lblChisloSumm2.Name = "lblChisloSumm2";
            this.lblChisloSumm2.Size = new System.Drawing.Size(10, 13);
            this.lblChisloSumm2.TabIndex = 21;
            this.lblChisloSumm2.Text = "-";
            // 
            // lblChislo7
            // 
            this.lblChislo7.AutoSize = true;
            this.lblChislo7.Location = new System.Drawing.Point(33, 149);
            this.lblChislo7.Name = "lblChislo7";
            this.lblChislo7.Size = new System.Drawing.Size(10, 13);
            this.lblChislo7.TabIndex = 22;
            this.lblChislo7.Text = "-";
            // 
            // lblChislo8
            // 
            this.lblChislo8.AutoSize = true;
            this.lblChislo8.Location = new System.Drawing.Point(164, 149);
            this.lblChislo8.Name = "lblChislo8";
            this.lblChislo8.Size = new System.Drawing.Size(10, 13);
            this.lblChislo8.TabIndex = 23;
            this.lblChislo8.Text = "-";
            // 
            // lblChislo9
            // 
            this.lblChislo9.AutoSize = true;
            this.lblChislo9.Location = new System.Drawing.Point(295, 149);
            this.lblChislo9.Name = "lblChislo9";
            this.lblChislo9.Size = new System.Drawing.Size(10, 13);
            this.lblChislo9.TabIndex = 24;
            this.lblChislo9.Text = "-";
            // 
            // lblChisloSumm3
            // 
            this.lblChisloSumm3.AutoSize = true;
            this.lblChisloSumm3.Location = new System.Drawing.Point(394, 149);
            this.lblChisloSumm3.Name = "lblChisloSumm3";
            this.lblChisloSumm3.Size = new System.Drawing.Size(10, 13);
            this.lblChisloSumm3.TabIndex = 25;
            this.lblChisloSumm3.Text = "-";
            // 
            // lblChislo10
            // 
            this.lblChislo10.AutoSize = true;
            this.lblChislo10.Location = new System.Drawing.Point(33, 181);
            this.lblChislo10.Name = "lblChislo10";
            this.lblChislo10.Size = new System.Drawing.Size(10, 13);
            this.lblChislo10.TabIndex = 26;
            this.lblChislo10.Text = "-";
            // 
            // lblChislo11
            // 
            this.lblChislo11.AutoSize = true;
            this.lblChislo11.Location = new System.Drawing.Point(164, 181);
            this.lblChislo11.Name = "lblChislo11";
            this.lblChislo11.Size = new System.Drawing.Size(10, 13);
            this.lblChislo11.TabIndex = 27;
            this.lblChislo11.Text = "-";
            // 
            // lblChislo12
            // 
            this.lblChislo12.AutoSize = true;
            this.lblChislo12.Location = new System.Drawing.Point(295, 181);
            this.lblChislo12.Name = "lblChislo12";
            this.lblChislo12.Size = new System.Drawing.Size(10, 13);
            this.lblChislo12.TabIndex = 28;
            this.lblChislo12.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lblChislo12);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lblChislo11);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lblChislo10);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lblChisloSumm3);
            this.groupBox1.Controls.Add(this.lblchislo1);
            this.groupBox1.Controls.Add(this.lblChislo9);
            this.groupBox1.Controls.Add(this.lblChislo2);
            this.groupBox1.Controls.Add(this.lblChislo8);
            this.groupBox1.Controls.Add(this.lblChislo3);
            this.groupBox1.Controls.Add(this.lblChislo7);
            this.groupBox1.Controls.Add(this.lblChisloSumm);
            this.groupBox1.Controls.Add(this.lblChisloSumm2);
            this.groupBox1.Controls.Add(this.lblChislo4);
            this.groupBox1.Controls.Add(this.lblChislo6);
            this.groupBox1.Controls.Add(this.lblChislo5);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(5, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 206);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица расчётов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(476, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDen);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtGod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMatrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Нумерология Елены Полупановой";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMatrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGod;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblchislo1;
        private System.Windows.Forms.Label lblChislo2;
        private System.Windows.Forms.Label lblChislo3;
        private System.Windows.Forms.Label lblChisloSumm;
        private System.Windows.Forms.Label lblChislo4;
        private System.Windows.Forms.Label lblChislo5;
        private System.Windows.Forms.Label lblChislo6;
        private System.Windows.Forms.Label lblChisloSumm2;
        private System.Windows.Forms.Label lblChislo7;
        private System.Windows.Forms.Label lblChislo8;
        private System.Windows.Forms.Label lblChislo9;
        private System.Windows.Forms.Label lblChisloSumm3;
        private System.Windows.Forms.Label lblChislo10;
        private System.Windows.Forms.Label lblChislo11;
        private System.Windows.Forms.Label lblChislo12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

