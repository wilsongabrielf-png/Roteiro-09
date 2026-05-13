namespace Roteiro09
{
    partial class form
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
            txtName = new Label();
            txtEmail = new Label();
            txtTelefone = new Label();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            txtlistBox1 = new ListBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tabControl01 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl01.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(25, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(40, 15);
            txtName.TabIndex = 0;
            txtName.Text = "Nome";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(25, 46);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(36, 15);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.AutoSize = true;
            txtTelefone.Location = new Point(25, 61);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(52, 15);
            txtTelefone.TabIndex = 2;
            txtTelefone.Text = "Telefone";
            // 
            // button1
            // 
            button1.Location = new Point(25, 11);
            button1.Name = "button1";
            button1.Size = new Size(94, 21);
            button1.TabIndex = 3;
            button1.Text = "Mostrar Dados";
            button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(40, 163);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(154, 23);
            maskedTextBox1.TabIndex = 4;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(40, 192);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Desenvolvedor", "", "Designer", "", "Suporte", "", "Gerente" });
            comboBox1.Location = new Point(40, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(40, 264);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Receber emails";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(40, 289);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(96, 19);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Modo Escuro";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(40, 314);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(92, 19);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Notificações";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(40, 339);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(129, 19);
            checkBox4.TabIndex = 10;
            checkBox4.Text = "Backup automático";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(37, 378);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(40, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pix";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(37, 394);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cartão";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(37, 419);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(70, 19);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Dinheiro";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // txtlistBox1
            // 
            txtlistBox1.FormattingEnabled = true;
            txtlistBox1.Location = new Point(252, 166);
            txtlistBox1.Name = "txtlistBox1";
            txtlistBox1.Size = new Size(108, 19);
            txtlistBox1.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 23);
            textBox1.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(251, 235);
            button2.Name = "button2";
            button2.Size = new Size(52, 24);
            button2.TabIndex = 16;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(302, 236);
            button3.Name = "button3";
            button3.Size = new Size(58, 23);
            button3.TabIndex = 17;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(259, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(353, 394);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 51);
            dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Produto";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Preço";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Estoque";
            Column4.Name = "Column4";
            // 
            // tabControl01
            // 
            tabControl01.Controls.Add(tabPage1);
            tabControl01.Controls.Add(tabPage2);
            tabControl01.Location = new Point(490, 28);
            tabControl01.Name = "tabControl01";
            tabControl01.SelectedIndex = 0;
            tabControl01.Size = new Size(220, 88);
            tabControl01.TabIndex = 20;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(212, 60);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(212, 60);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl01);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(txtlistBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            MinimumSize = new Size(250, 0);
            Name = "form";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl01.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtName;
        private Label txtEmail;
        private Label txtTelefone;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ListBox txtlistBox1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TabControl tabControl01;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
