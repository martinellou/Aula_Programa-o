namespace BoletimColecoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cboDisciplina = new System.Windows.Forms.ComboBox();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colEstudante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Estudante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disciplina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota (0 a 10)";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 71);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(123, 22);
            this.txtNome.TabIndex = 3;
            // 
            // cboDisciplina
            // 
            this.cboDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisciplina.FormattingEnabled = true;
            this.cboDisciplina.Items.AddRange(new object[] {
            "Matemática",
            "Química",
            "Física"});
            this.cboDisciplina.Location = new System.Drawing.Point(277, 71);
            this.cboDisciplina.Name = "cboDisciplina";
            this.cboDisciplina.Size = new System.Drawing.Size(121, 24);
            this.cboDisciplina.TabIndex = 4;
            // 
            // nudNota
            // 
            this.nudNota.DecimalPlaces = 1;
            this.nudNota.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudNota.Location = new System.Drawing.Point(507, 72);
            this.nudNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(120, 22);
            this.nudNota.TabIndex = 5;
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEstudante,
            this.colDisciplina,
            this.colNota});
            this.dgvNotas.Location = new System.Drawing.Point(64, 193);
            this.dgvNotas.MultiSelect = false;
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.RowHeadersVisible = false;
            this.dgvNotas.RowHeadersWidth = 51;
            this.dgvNotas.RowTemplate.Height = 24;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(740, 150);
            this.dgvNotas.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(64, 139);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(90, 23);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(220, 139);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(158, 23);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover Selecionado";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(451, 139);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar Todos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtResumo
            // 
            this.txtResumo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumo.Location = new System.Drawing.Point(64, 384);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.ReadOnly = true;
            this.txtResumo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResumo.Size = new System.Drawing.Size(740, 140);
            this.txtResumo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resumo das Coleções (Atualizado Automaticamente)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cadastro de Notas Array e Coleções";
            // 
            // colEstudante
            // 
            this.colEstudante.HeaderText = "Estudante";
            this.colEstudante.MinimumWidth = 6;
            this.colEstudante.Name = "colEstudante";
            this.colEstudante.ReadOnly = true;
            // 
            // colDisciplina
            // 
            this.colDisciplina.HeaderText = "Disciplina";
            this.colDisciplina.MinimumWidth = 6;
            this.colDisciplina.Name = "colDisciplina";
            this.colDisciplina.ReadOnly = true;
            // 
            // colNota
            // 
            this.colNota.HeaderText = "Nota";
            this.colNota.MinimumWidth = 6;
            this.colNota.Name = "colNota";
            this.colNota.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 583);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.nudNota);
            this.Controls.Add(this.cboDisciplina);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboDisciplina;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstudante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota;
    }
}

