namespace TaskHard2WinForm
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Budget = new System.Windows.Forms.TextBox();
            this.comboBox_Home = new System.Windows.Forms.ComboBox();
            this.label_city1 = new System.Windows.Forms.Label();
            this.label_city2 = new System.Windows.Forms.Label();
            this.label_city3 = new System.Windows.Forms.Label();
            this.comboBox_Travel1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Travel2 = new System.Windows.Forms.ComboBox();
            this.comboBox_Travel3 = new System.Windows.Forms.ComboBox();
            this.btn_Result = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Count);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_Result);
            this.panel1.Controls.Add(this.comboBox_Travel3);
            this.panel1.Controls.Add(this.comboBox_Travel2);
            this.panel1.Controls.Add(this.comboBox_Travel1);
            this.panel1.Controls.Add(this.label_city3);
            this.panel1.Controls.Add(this.label_city2);
            this.panel1.Controls.Add(this.label_city1);
            this.panel1.Controls.Add(this.comboBox_Home);
            this.panel1.Controls.Add(this.textBox_Budget);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 409);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ваш бюджет:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите из какого города вы отправитесь в путешествие:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_Budget
            // 
            this.textBox_Budget.Location = new System.Drawing.Point(159, 71);
            this.textBox_Budget.Name = "textBox_Budget";
            this.textBox_Budget.Size = new System.Drawing.Size(115, 20);
            this.textBox_Budget.TabIndex = 2;
            this.textBox_Budget.TextChanged += new System.EventHandler(this.textBox_Budget_TextChanged);
            // 
            // comboBox_Home
            // 
            this.comboBox_Home.FormattingEnabled = true;
            this.comboBox_Home.Items.AddRange(new object[] {
            "Берлин",
            "Прага",
            "Париж",
            "Рига",
            "Лондон",
            "Ватикан",
            "Палермо",
            "Варшава",
            "Кишинев",
            "Мадрид",
            "Будапешт"});
            this.comboBox_Home.Location = new System.Drawing.Point(354, 104);
            this.comboBox_Home.Name = "comboBox_Home";
            this.comboBox_Home.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Home.TabIndex = 3;
            this.comboBox_Home.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_city1
            // 
            this.label_city1.AutoSize = true;
            this.label_city1.Location = new System.Drawing.Point(36, 205);
            this.label_city1.Name = "label_city1";
            this.label_city1.Size = new System.Drawing.Size(195, 26);
            this.label_city1.TabIndex = 4;
            this.label_city1.Text = "Выберите в какой город вы поедите:\r\n\r\n";
            this.label_city1.Visible = false;
            this.label_city1.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_city2
            // 
            this.label_city2.AutoSize = true;
            this.label_city2.Location = new System.Drawing.Point(36, 243);
            this.label_city2.Name = "label_city2";
            this.label_city2.Size = new System.Drawing.Size(195, 26);
            this.label_city2.TabIndex = 5;
            this.label_city2.Text = "Выберите в какой город вы поедите:\r\n\r\n";
            this.label_city2.Visible = false;
            // 
            // label_city3
            // 
            this.label_city3.AutoSize = true;
            this.label_city3.Location = new System.Drawing.Point(36, 280);
            this.label_city3.Name = "label_city3";
            this.label_city3.Size = new System.Drawing.Size(195, 26);
            this.label_city3.TabIndex = 6;
            this.label_city3.Text = "Выберите в какой город вы поедите:\r\n\r\n";
            this.label_city3.Visible = false;
            // 
            // comboBox_Travel1
            // 
            this.comboBox_Travel1.FormattingEnabled = true;
            this.comboBox_Travel1.Items.AddRange(new object[] {
            "Берлин",
            "Прага",
            "Париж",
            "Рига",
            "Лондон",
            "Ватикан",
            "Палермо",
            "Варшава",
            "Кишинев",
            "Мадрид",
            "Будапешт"});
            this.comboBox_Travel1.Location = new System.Drawing.Point(237, 202);
            this.comboBox_Travel1.Name = "comboBox_Travel1";
            this.comboBox_Travel1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Travel1.TabIndex = 7;
            this.comboBox_Travel1.Visible = false;
            this.comboBox_Travel1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Travel1_SelectedIndexChanged);
            // 
            // comboBox_Travel2
            // 
            this.comboBox_Travel2.FormattingEnabled = true;
            this.comboBox_Travel2.Items.AddRange(new object[] {
            "Берлин",
            "Прага",
            "Париж",
            "Рига",
            "Лондон",
            "Ватикан",
            "Палермо",
            "Варшава",
            "Кишинев",
            "Мадрид",
            "Будапешт"});
            this.comboBox_Travel2.Location = new System.Drawing.Point(237, 240);
            this.comboBox_Travel2.Name = "comboBox_Travel2";
            this.comboBox_Travel2.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Travel2.TabIndex = 8;
            this.comboBox_Travel2.Visible = false;
            // 
            // comboBox_Travel3
            // 
            this.comboBox_Travel3.FormattingEnabled = true;
            this.comboBox_Travel3.Items.AddRange(new object[] {
            "Берлин",
            "Прага",
            "Париж",
            "Рига",
            "Лондон",
            "Ватикан",
            "Палермо",
            "Варшава",
            "Кишинев",
            "Мадрид",
            "Будапешт"});
            this.comboBox_Travel3.Location = new System.Drawing.Point(237, 277);
            this.comboBox_Travel3.Name = "comboBox_Travel3";
            this.comboBox_Travel3.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Travel3.TabIndex = 9;
            this.comboBox_Travel3.Visible = false;
            this.comboBox_Travel3.SelectedIndexChanged += new System.EventHandler(this.comboBox_Travel3_SelectedIndexChanged);
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(354, 324);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(165, 23);
            this.btn_Result.TabIndex = 10;
            this.btn_Result.Text = "Подсчитать цену";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите сколько городов хотите посетить:";
            // 
            // textBox_Count
            // 
            this.textBox_Count.Location = new System.Drawing.Point(268, 151);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(115, 20);
            this.textBox_Count.TabIndex = 12;
            this.textBox_Count.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 525);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Budget;
        private System.Windows.Forms.ComboBox comboBox_Home;
        private System.Windows.Forms.Label label_city1;
        private System.Windows.Forms.ComboBox comboBox_Travel3;
        private System.Windows.Forms.ComboBox comboBox_Travel2;
        private System.Windows.Forms.ComboBox comboBox_Travel1;
        private System.Windows.Forms.Label label_city3;
        private System.Windows.Forms.Label label_city2;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.Label label6;
    }
}

