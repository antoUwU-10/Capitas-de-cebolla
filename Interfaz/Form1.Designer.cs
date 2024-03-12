namespace Interfaz
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox6 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(350, 352);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(411, 53);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "agregar usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(414, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(411, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(414, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(414, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(414, 227);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(414, 271);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(533, 53);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 8;
            label2.Text = "eliminar usuario";
            label2.Click += label2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(533, 80);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(533, 119);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 10;
            button2.Text = "eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(651, 53);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 11;
            label3.Text = "editar usuario";
            label3.Click += label3_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(651, 80);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(651, 119);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(651, 162);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(651, 202);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 15;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(651, 244);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 16;
            // 
            // button3
            // 
            button3.Location = new Point(651, 282);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 17;
            button3.Text = "editar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 476);
            Controls.Add(button3);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Label label2;
        private TextBox textBox6;
        private Button button2;
        private Label label3;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Button button3;
    }
}
