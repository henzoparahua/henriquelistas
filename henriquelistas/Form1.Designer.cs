
namespace henriquelistas
{
    partial class Form1
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
            this.radio = new System.Windows.Forms.GroupBox();
            this.rdbOne = new System.Windows.Forms.RadioButton();
            this.rdbTwo = new System.Windows.Forms.RadioButton();
            this.rdbThree = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.idade = new System.Windows.Forms.NumericUpDown();
            this.state = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPFColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OldColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idade)).BeginInit();
            this.SuspendLayout();
            // 
            // radio
            // 
            this.radio.Controls.Add(this.rdbOne);
            this.radio.Controls.Add(this.rdbTwo);
            this.radio.Controls.Add(this.rdbThree);
            this.radio.Location = new System.Drawing.Point(214, 29);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(109, 109);
            this.radio.TabIndex = 29;
            this.radio.TabStop = false;
            this.radio.Text = "estado civil";
            // 
            // rdbOne
            // 
            this.rdbOne.AutoSize = true;
            this.rdbOne.Location = new System.Drawing.Point(6, 27);
            this.rdbOne.Name = "rdbOne";
            this.rdbOne.Size = new System.Drawing.Size(58, 17);
            this.rdbOne.TabIndex = 2;
            this.rdbOne.TabStop = true;
            this.rdbOne.Text = "solteiro";
            this.rdbOne.UseVisualStyleBackColor = true;
            this.rdbOne.CheckedChanged += new System.EventHandler(this.rdbOne_CheckedChanged);
            // 
            // rdbTwo
            // 
            this.rdbTwo.AutoSize = true;
            this.rdbTwo.Location = new System.Drawing.Point(6, 51);
            this.rdbTwo.Name = "rdbTwo";
            this.rdbTwo.Size = new System.Drawing.Size(60, 17);
            this.rdbTwo.TabIndex = 3;
            this.rdbTwo.TabStop = true;
            this.rdbTwo.Text = "casado";
            this.rdbTwo.UseVisualStyleBackColor = true;
            this.rdbTwo.CheckedChanged += new System.EventHandler(this.rdbTwo_CheckedChanged);
            // 
            // rdbThree
            // 
            this.rdbThree.AutoSize = true;
            this.rdbThree.Location = new System.Drawing.Point(6, 74);
            this.rdbThree.Name = "rdbThree";
            this.rdbThree.Size = new System.Drawing.Size(51, 17);
            this.rdbThree.TabIndex = 4;
            this.rdbThree.TabStop = true;
            this.rdbThree.Text = "viuvo";
            this.rdbThree.UseVisualStyleBackColor = true;
            this.rdbThree.CheckedChanged += new System.EventHandler(this.rdbThree_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(143, 256);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 28;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // idade
            // 
            this.idade.Location = new System.Drawing.Point(214, 187);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(120, 20);
            this.idade.TabIndex = 27;
            this.idade.ValueChanged += new System.EventHandler(this.idade_ValueChanged);
            // 
            // state
            // 
            this.state.FormattingEnabled = true;
            this.state.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Bahia",
            "Santa Catarina",
            "Parana",
            "Para",
            "Amapa",
            "Sergipe",
            "Goias",
            "Amazonas"});
            this.state.Location = new System.Drawing.Point(30, 186);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(121, 21);
            this.state.TabIndex = 26;
            this.state.SelectedIndexChanged += new System.EventHandler(this.state_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Estado de nascimento";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(217, 155);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(34, 13);
            this.age.TabIndex = 23;
            this.age.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(30, 56);
            this.name.Name = "name";
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 21;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // cpf
            // 
            this.cpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cpf.Location = new System.Drawing.Point(30, 116);
            this.cpf.Mask = "000.000.000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(100, 20);
            this.cpf.TabIndex = 20;
            this.cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.cpf.ValidatingType = typeof(System.DateTime);
            this.cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpf_MaskInputRejected);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.CPFColumn,
            this.BirthColumn,
            this.StateColumn,
            this.OldColumn});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(357, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 332);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Nome";
            // 
            // CPFColumn
            // 
            this.CPFColumn.Text = "CPF";
            // 
            // BirthColumn
            // 
            this.BirthColumn.Text = "Data de Nascimento";
            // 
            // StateColumn
            // 
            this.StateColumn.Text = "Estado Civil";
            // 
            // OldColumn
            // 
            this.OldColumn.Text = "Idade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 407);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.radio);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.radio.ResumeLayout(false);
            this.radio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox radio;
        private System.Windows.Forms.RadioButton rdbOne;
        private System.Windows.Forms.RadioButton rdbTwo;
        private System.Windows.Forms.RadioButton rdbThree;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.NumericUpDown idade;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader CPFColumn;
        private System.Windows.Forms.ColumnHeader BirthColumn;
        private System.Windows.Forms.ColumnHeader StateColumn;
        private System.Windows.Forms.ColumnHeader OldColumn;
    }
}

