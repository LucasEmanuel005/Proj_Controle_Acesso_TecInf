using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj01_Controle_Acesso
{
    public partial class Menu_Principal : Form
    {
        int cod_p;
        int cod_upd;
       
        pessoa pess = new pessoa();
        public Menu_Principal()
        {
            InitializeComponent();

        }
        public Menu_Principal(int cod)
        {
            InitializeComponent();
            cod_p = Convert.ToInt32(cod.ToString());
            
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            if (cod_p == 2)
            {
                bt_log.Visible = false;
            }
            else
            {
                bt_log.Visible = true;
            }

            label10.Visible = false;
            label11.Visible = false;
            label6.Visible = false;
            txt_nome_emp.Visible = false;
            ms_txt_cnpj.Visible = false;
            txt_cra.Visible = false;

            cb_acao.Items.Add("Entrar");
            cb_acao.Items.Add("Sair");



        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            this.Hide();
            log.ShowDialog();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Dispose();
            login.ShowDialog();

        }
       
        private void Bt_pesq_Click(object sender, EventArgs e)
        {


           

            txt_nome.Text = null;
            ms_txt_tel.Text = null;
            ms_txt_cel.Text = null;
            txt_apart.Text = null;
            txt_blo.Text = null;
            txt_and.Text = null;
            ms_txt_cnpj.Text = null;
            txt_cat.Text = null;
            txt_cra.Text = null;
            txt_nome_emp.Text = null;
            





            pesquisa pesq = new pesquisa();
            if (rb_Morador.Checked)
            {
                dataGridView1.DataSource = pesq.ExibirDados(txt_pesq.Text);
                dataGridView1.DataSource = pesq.ExibirDados(txt_pesq.Text);
            }
            else if (rb_Visitante.Checked)
            {
                dataGridView1.DataSource = pesq.ExibirDados_visitante(txt_pesq.Text);
                dataGridView1.DataSource = pesq.ExibirDados_visitante(txt_pesq.Text);
            }
            else if (rb_PresServ.Checked)
            {
                dataGridView1.DataSource = pesq.ExibirDados_ps(txt_pesq.Text);
                dataGridView1.DataSource = pesq.ExibirDados_ps(txt_pesq.Text);
                label10.Visible = true;
                label11.Visible = true;
                label6.Visible = true;
                txt_nome_emp.Visible = true;
                ms_txt_cnpj.Visible = true;
                txt_cra.Visible = true;

            }
            else 
            {
                MessageBox.Show("Selecione uma categoria");
            }


        }
       
        private void Bt_cad_Click(object sender, EventArgs e)
        {
            f_cadastrar f_Cadastro = new f_cadastrar();
            this.Dispose();
            f_Cadastro.ShowDialog();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell.Value.ToString();
            int referencia = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());

            

            pess.nome = dataGridView1.Rows[referencia].Cells[0].Value.ToString();
            pess.tel = dataGridView1.Rows[referencia].Cells[1].Value.ToString();
            pess.cel = dataGridView1.Rows[referencia].Cells[2].Value.ToString();
            pess.andar = dataGridView1.Rows[referencia].Cells[3].Value.ToString();
            pess.bloco = dataGridView1.Rows[referencia].Cells[4].Value.ToString();
            pess.apart = dataGridView1.Rows[referencia].Cells[5].Value.ToString();



    
            txt_nome.Text = pess.nome;

            ms_txt_tel.Text = pess.tel;
            ms_txt_cel.Text = pess.cel;
            txt_and.Text = pess.andar;
            txt_blo.Text = pess.bloco;
            txt_apart.Text = pess.apart;
            txt_nome_emp.Text = pess.nome_emp;
            ms_txt_cnpj.Text = pess.cnpj;


            if (rb_PresServ.Checked)
            {
                pess.nome_emp = dataGridView1.Rows[referencia].Cells[6].Value.ToString();
                pess.cnpj = dataGridView1.Rows[referencia].Cells[7].Value.ToString();               
           

                txt_nome_emp.Text = pess.nome_emp;
                ms_txt_cnpj.Text = pess.cnpj;

            }
            else if (rb_Morador.Checked || rb_Visitante.Checked)
            {
                txt_cat.Text = dataGridView1.Rows[referencia].Cells[6].Value.ToString();
                cod_upd = Convert.ToInt32(dataGridView1.Rows[referencia].Cells[7].Value.ToString());

            }
        }


        private void rb_PresServ_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            txt_apart.Enabled = true;
            txt_blo.Enabled = true;
            txt_and.Enabled = true;

            txt_nome.Text = null;
            ms_txt_tel.Text = null;
            ms_txt_cel.Text = null;
            txt_apart.Text = null;
            txt_blo.Text = null;
            txt_and.Text = null;
            ms_txt_cnpj.Text = null;
            txt_cat.Text = null;
            txt_cra.Text = null;
            txt_nome_emp.Text = null;


        }

        private void rb_Visitante_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            label10.Visible = false;
            label11.Visible = false;
            label6.Visible = false;
            txt_nome_emp.Visible = false;
            ms_txt_cnpj.Visible = false;
            txt_cra.Visible = false;


            txt_nome.Text = null;
            ms_txt_tel.Text = null;
            ms_txt_cel.Text = null;
            txt_apart.Text = null;
            txt_blo.Text = null;
            txt_and.Text = null;
            ms_txt_cnpj.Text = null;
            txt_cat.Text = null;
            txt_cra.Text = null;
            txt_nome_emp.Text = null;

        }

        private void rb_Morador_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            label10.Visible = false;
            label11.Visible = false;
            label6.Visible = false;
            txt_nome_emp.Visible = false;
            ms_txt_cnpj.Visible = false;
            txt_cra.Visible = false;

            txt_apart.Enabled = false;
            txt_blo.Enabled = false;
            txt_and.Enabled = false;


            txt_nome.Text = null;
            ms_txt_tel.Text = null;
            ms_txt_cel.Text = null;
            txt_apart.Text = null;
            txt_blo.Text = null;
            txt_and.Text = null;
            ms_txt_cnpj.Text = null;
            txt_cat.Text = null;
            txt_cra.Text = null;
            txt_nome_emp.Text = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((pess.acao == null) || (String.IsNullOrEmpty(txt_nome.Text)))
            {
                MessageBox.Show("Selecione uma pessoa ou uma ação");
            }
            else
            {
                DialogResult result = MessageBox.Show("Deseja enviar?", "Salvar Log", MessageBoxButtons.YesNo);

                               
                if (result == DialogResult.Yes)
                {
                    
                    pess.desc = txt_desc.Text;
                    DateTime data = DateTime.Now;                   
                    

                    cadastrar gerar_log = new cadastrar();
                    int t = Convert.ToInt32( gerar_log.Log(pess, data));
                    if (t > 0)
                    {
                        MessageBox.Show("Log salvo com sucesso");
                    }
                    else { MessageBox.Show("Houve erro, tente de novo"); }
                    
                }
            }
           
        }

        private void cb_acao_SelectedIndexChanged(object sender, EventArgs e)
        {
            pess.acao = cb_acao.Text;
        }

        private void bt_edi_Click(object sender, EventArgs e)
        {         

            f_cadastrar update = new f_cadastrar(cod_upd, pess.nome);
            this.Dispose();
            update.ShowDialog();

        }
    }
}


