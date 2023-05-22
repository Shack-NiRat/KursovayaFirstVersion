namespace MainForm
{
    partial class Calculator
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
            this.Equation = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.X0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Y0 = new System.Windows.Forms.TextBox();
            this.Multiply = new System.Windows.Forms.Button();
            this.Share = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Degree = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Arctan = new System.Windows.Forms.Button();
            this.Arccotan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.XStart = new System.Windows.Forms.TextBox();
            this.XEnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.DataGridView();
            this.Yi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            this.SuspendLayout();
            // 
            // Equation
            // 
            this.Equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equation.Location = new System.Drawing.Point(144, 56);
            this.Equation.Name = "Equation";
            this.Equation.Size = new System.Drawing.Size(1174, 31);
            this.Equation.TabIndex = 0;
            this.Equation.TextChanged += new System.EventHandler(this.Equation_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(65, 368);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(300, 90);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Вычислить";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // X0
            // 
            this.X0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X0.Location = new System.Drawing.Point(118, 180);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(67, 31);
            this.X0.TabIndex = 2;
            this.X0.TextChanged += new System.EventHandler(this.Equation_TextChanged);
            this.X0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X0_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Y\'=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y(";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(191, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = ") = ";
            // 
            // Y0
            // 
            this.Y0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y0.Location = new System.Drawing.Point(265, 180);
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(100, 31);
            this.Y0.TabIndex = 6;
            this.Y0.TextChanged += new System.EventHandler(this.Equation_TextChanged);
            this.Y0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X0_KeyPress);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiply.Location = new System.Drawing.Point(1138, 159);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(180, 90);
            this.Multiply.TabIndex = 7;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Share
            // 
            this.Share.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Share.Location = new System.Drawing.Point(921, 159);
            this.Share.Name = "Share";
            this.Share.Size = new System.Drawing.Size(180, 90);
            this.Share.TabIndex = 8;
            this.Share.Text = "\\";
            this.Share.UseVisualStyleBackColor = true;
            this.Share.Click += new System.EventHandler(this.Share_Click);
            // 
            // Addition
            // 
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addition.Location = new System.Drawing.Point(695, 160);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(180, 90);
            this.Addition.TabIndex = 9;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subtraction.Location = new System.Drawing.Point(481, 160);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(180, 90);
            this.Subtraction.TabIndex = 10;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // Degree
            // 
            this.Degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Degree.Location = new System.Drawing.Point(481, 294);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(180, 90);
            this.Degree.TabIndex = 11;
            this.Degree.Text = "x^";
            this.Degree.UseVisualStyleBackColor = true;
            this.Degree.Click += new System.EventHandler(this.Degree_Click);
            // 
            // Root
            // 
            this.Root.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Root.Location = new System.Drawing.Point(695, 294);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(180, 90);
            this.Root.TabIndex = 12;
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.Root_Click);
            // 
            // Cos
            // 
            this.Cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cos.Location = new System.Drawing.Point(1138, 428);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(180, 90);
            this.Cos.TabIndex = 13;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // Sin
            // 
            this.Sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sin.Location = new System.Drawing.Point(921, 428);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(180, 90);
            this.Sin.TabIndex = 14;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(481, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 90);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(695, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 90);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cotan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Arcsin
            // 
            this.Arcsin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arcsin.Location = new System.Drawing.Point(921, 551);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(180, 90);
            this.Arcsin.TabIndex = 17;
            this.Arcsin.Text = "Arcsin";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.Arcsin_Click);
            // 
            // Arccos
            // 
            this.Arccos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arccos.Location = new System.Drawing.Point(1138, 551);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(180, 90);
            this.Arccos.TabIndex = 18;
            this.Arccos.Text = "Arccos";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.Arccos_Click);
            // 
            // Arctan
            // 
            this.Arctan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arctan.Location = new System.Drawing.Point(481, 551);
            this.Arctan.Name = "Arctan";
            this.Arctan.Size = new System.Drawing.Size(180, 90);
            this.Arctan.TabIndex = 19;
            this.Arctan.Text = "Arctan";
            this.Arctan.UseVisualStyleBackColor = true;
            this.Arctan.Click += new System.EventHandler(this.Arctan_Click);
            // 
            // Arccotan
            // 
            this.Arccotan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arccotan.Location = new System.Drawing.Point(695, 551);
            this.Arccotan.Name = "Arccotan";
            this.Arccotan.Size = new System.Drawing.Size(180, 90);
            this.Arccotan.TabIndex = 20;
            this.Arccotan.Text = "Arccotan";
            this.Arccotan.UseVisualStyleBackColor = true;
            this.Arccotan.Click += new System.EventHandler(this.Arccotan_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(921, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 90);
            this.button3.TabIndex = 21;
            this.button3.Text = "Ln";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Log
            // 
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log.Location = new System.Drawing.Point(1138, 294);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(180, 90);
            this.Log.TabIndex = 22;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(134, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Результат:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(85, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "На промежутке";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(113, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "[";
            // 
            // XStart
            // 
            this.XStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XStart.Location = new System.Drawing.Point(159, 296);
            this.XStart.Name = "XStart";
            this.XStart.Size = new System.Drawing.Size(26, 31);
            this.XStart.TabIndex = 28;
            this.XStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X0_KeyPress);
            // 
            // XEnd
            // 
            this.XEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XEnd.Location = new System.Drawing.Point(254, 296);
            this.XEnd.Name = "XEnd";
            this.XEnd.Size = new System.Drawing.Size(26, 31);
            this.XEnd.TabIndex = 29;
            this.XEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X0_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(301, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(208, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = ";";
            // 
            // Result
            // 
            this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Yi,
            this.Xi});
            this.Result.Location = new System.Drawing.Point(36, 521);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.RowHeadersVisible = false;
            this.Result.RowTemplate.Height = 28;
            this.Result.Size = new System.Drawing.Size(369, 150);
            this.Result.TabIndex = 32;
            // 
            // Yi
            // 
            this.Yi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Yi.HeaderText = "Yi";
            this.Yi.Name = "Yi";
            this.Yi.ReadOnly = true;
            // 
            // Xi
            // 
            this.Xi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Xi.HeaderText = "Xi";
            this.Xi.Name = "Xi";
            this.Xi.ReadOnly = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 680);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.XEnd);
            this.Controls.Add(this.XStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Arccotan);
            this.Controls.Add(this.Arctan);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Share);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Y0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Equation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Equation;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox X0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Y0;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Share;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Degree;
        private System.Windows.Forms.Button Root;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Arctan;
        private System.Windows.Forms.Button Arccotan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox XStart;
        private System.Windows.Forms.TextBox XEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
    }
}

