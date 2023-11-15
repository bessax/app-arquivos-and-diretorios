namespace app_arquivos_winforms.Forms
{
    partial class FormCadastro
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
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtRaca = new TextBox();
            label3 = new Label();
            label4 = new Label();
            nudIdade = new NumericUpDown();
            label5 = new Label();
            txtPeso = new TextBox();
            label6 = new Label();
            cmbPorte = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudIdade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 42);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(81, 39);
            txtId.Name = "txtId";
            txtId.Size = new Size(211, 23);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(103, 86);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(189, 23);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 89);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(103, 131);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(189, 23);
            txtRaca.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 134);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Raça";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 177);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Idade";
            // 
            // nudIdade
            // 
            nudIdade.Location = new Point(103, 169);
            nudIdade.Name = "nudIdade";
            nudIdade.Size = new Size(120, 23);
            nudIdade.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 219);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 8;
            label5.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(103, 216);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(120, 23);
            txtPeso.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 264);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 10;
            label6.Text = "Porte";
            // 
            // cmbPorte
            // 
            cmbPorte.FormattingEnabled = true;
            cmbPorte.Items.AddRange(new object[] { "selecione", "Pequeno", "Médio", "Grande" });
            cmbPorte.Location = new Point(103, 264);
            cmbPorte.Name = "cmbPorte";
            cmbPorte.Size = new Size(189, 23);
            cmbPorte.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(184, 343);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 12;
            button1.Text = "SALVAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(70, 343);
            button2.Name = "button2";
            button2.Size = new Size(108, 23);
            button2.TabIndex = 13;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(103, 304);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(189, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 310);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 15;
            label7.Text = "Dt. Vacinação";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 378);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbPorte);
            Controls.Add(label6);
            Controls.Add(txtPeso);
            Controls.Add(label5);
            Controls.Add(nudIdade);
            Controls.Add(label4);
            Controls.Add(txtRaca);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormCadastro";
            Text = "[CADASTRO DE PET]";
            ((System.ComponentModel.ISupportInitialize)nudIdade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtRaca;
        private Label label3;
        private Label label4;
        private NumericUpDown nudIdade;
        private Label label5;
        private TextBox txtPeso;
        private Label label6;
        private ComboBox cmbPorte;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
    }
}