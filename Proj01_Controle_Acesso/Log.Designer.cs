namespace Proj01_Controle_Acesso
{
    partial class Log
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.lbl_pesq_nome = new System.Windows.Forms.Label();
            this.txt_pesq_nome = new System.Windows.Forms.TextBox();
            this.rb_lis_tudo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_lim_50 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.Location = new System.Drawing.Point(641, 415);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(147, 23);
            this.bt_Voltar.TabIndex = 1;
            this.bt_Voltar.Text = "Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = true;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // lbl_pesq_nome
            // 
            this.lbl_pesq_nome.AutoSize = true;
            this.lbl_pesq_nome.Location = new System.Drawing.Point(43, 16);
            this.lbl_pesq_nome.Name = "lbl_pesq_nome";
            this.lbl_pesq_nome.Size = new System.Drawing.Size(103, 13);
            this.lbl_pesq_nome.TabIndex = 2;
            this.lbl_pesq_nome.Text = "Pesquisar por nome:";
            // 
            // txt_pesq_nome
            // 
            this.txt_pesq_nome.Location = new System.Drawing.Point(154, 13);
            this.txt_pesq_nome.Name = "txt_pesq_nome";
            this.txt_pesq_nome.Size = new System.Drawing.Size(215, 20);
            this.txt_pesq_nome.TabIndex = 3;
            // 
            // rb_lis_tudo
            // 
            this.rb_lis_tudo.AutoSize = true;
            this.rb_lis_tudo.Location = new System.Drawing.Point(387, 14);
            this.rb_lis_tudo.Name = "rb_lis_tudo";
            this.rb_lis_tudo.Size = new System.Drawing.Size(74, 17);
            this.rb_lis_tudo.TabIndex = 4;
            this.rb_lis_tudo.TabStop = true;
            this.rb_lis_tudo.Text = "Listar tudo";
            this.rb_lis_tudo.UseVisualStyleBackColor = true;
            this.rb_lis_tudo.CheckedChanged += new System.EventHandler(this.rb_lis_tudo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_lim_50
            // 
            this.rb_lim_50.AutoSize = true;
            this.rb_lim_50.Location = new System.Drawing.Point(483, 14);
            this.rb_lim_50.Name = "rb_lim_50";
            this.rb_lim_50.Size = new System.Drawing.Size(79, 17);
            this.rb_lim_50.TabIndex = 6;
            this.rb_lim_50.TabStop = true;
            this.rb_lim_50.Text = "Limitar a 50";
            this.rb_lim_50.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_lim_50);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_lis_tudo);
            this.Controls.Add(this.txt_pesq_nome);
            this.Controls.Add(this.lbl_pesq_nome);
            this.Controls.Add(this.bt_Voltar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Log";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.Label lbl_pesq_nome;
        private System.Windows.Forms.TextBox txt_pesq_nome;
        private System.Windows.Forms.RadioButton rb_lis_tudo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_lim_50;
    }
}