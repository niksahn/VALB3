namespace VALB3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            A = new NumericUpDown();
            B = new NumericUpDown();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label7 = new Label();
            rezult = new TextBox();
            button1 = new Button();
            label8 = new Label();
            E = new NumericUpDown();
            comboBox1 = new ComboBox();
            secRez = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)E).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 0;
            label1.Text = "Найти корни уравнения:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 69);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 1;
            label2.Text = "e^1,5x +3x - 4,5 = 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 24);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Промежуток";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 69);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 3;
            label4.Text = "A:";
            // 
            // A
            // 
            A.Location = new Point(310, 67);
            A.Name = "A";
            A.Size = new Size(69, 27);
            A.TabIndex = 4;
            // 
            // B
            // 
            B.Location = new Point(436, 67);
            B.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            B.Name = "B";
            B.Size = new Size(66, 27);
            B.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 72);
            label5.Name = "label5";
            label5.Size = new Size(21, 20);
            label5.TabIndex = 5;
            label5.Text = "B:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(27, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(352, 222);
            dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Бинарный поиск";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Метод секущих";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 112);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 8;
            label6.Text = "Таблица итераций:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 384);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 9;
            label7.Text = "Результат";
            // 
            // rezult
            // 
            rezult.Location = new Point(94, 381);
            rezult.Name = "rezult";
            rezult.Size = new Size(125, 27);
            rezult.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(398, 199);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(269, 112);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 12;
            label8.Text = "Точность";
            // 
            // E
            // 
            E.DecimalPlaces = 15;
            E.Location = new Point(367, 110);
            E.Minimum = new decimal(new int[] { 1, 0, 0, 983040 });
            E.Name = "E";
            E.Size = new Size(123, 27);
            E.TabIndex = 13;
            E.Value = new decimal(new int[] { 1, 0, 0, 262144 });
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(385, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // secRez
            // 
            secRez.Location = new Point(241, 381);
            secRez.Name = "secRez";
            secRez.Size = new Size(138, 27);
            secRez.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 426);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 16;
            label9.Text = "Время";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 423);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(241, 423);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 27);
            textBox2.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 479);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(secRez);
            Controls.Add(comboBox1);
            Controls.Add(E);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(rezult);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(B);
            Controls.Add(label5);
            Controls.Add(A);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)A).EndInit();
            ((System.ComponentModel.ISupportInitialize)B).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)E).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown A;
        private NumericUpDown B;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private TextBox rezult;
        private Button button1;
        private Label label8;
        private NumericUpDown E;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private ComboBox comboBox1;
        private TextBox secRez;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}