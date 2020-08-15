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
    public partial class f_cadastrar : Form
    {
        int cod_cat;
        string nome;
        public f_cadastrar()
        {
            InitializeComponent();
                       
        }

        public f_cadastrar(int cod_cat_p, string nome_p)
        {
            InitializeComponent();

            cod_cat = cod_cat_p;
            nome = nome_p;
               

        }
        public f_cadastrar(int id_pess)
        {
            InitializeComponent();

            cod_cat = id_pess;
          //  nome = nome_p;


        }

        private void Bt_canc_Click(object sender, EventArgs e)
        {
            Menu_Principal f_menu = new Menu_Principal();
            this.Dispose();
            f_menu.ShowDialog();
           
        }

        private void Bt_cad_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_nome.Text) || String.IsNullOrWhiteSpace(ms_txt_rg.Text) || String.IsNullOrWhiteSpace(ms_txt_cpf.Text) || String.IsNullOrWhiteSpace(ms_txt_cel.Text) || String.IsNullOrWhiteSpace(ms_txt_tel.Text) || String.IsNullOrWhiteSpace(txt_apart.Text) || String.IsNullOrWhiteSpace(txt_blo.Text) || String.IsNullOrWhiteSpace(txt_and.Text) || String.IsNullOrWhiteSpace(cb_cat.Text))
            {
                MessageBox.Show("Campos obrigátorio!!");
            }
            else 
            {
                if (cb_cat.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione a categoria, por favor não digite!");
                }

                else if (cb_cat.SelectedIndex == 0)
                {
                    pessoa pess = new pessoa();
                    pess.nome = txt_nome.Text;
                    pess.rg = ms_txt_rg.Text;
                    pess.cpf = ms_txt_cpf.Text;
                    pess.cel = ms_txt_cel.Text;
                    pess.tel = ms_txt_tel.Text;
                    pess.email = txt_email.Text;
                    pess.apart = txt_apart.Text;
                    pess.bloco = txt_blo.Text;
                    pess.andar = txt_and.Text;
                    
                    pess.cat = cb_cat.SelectedIndex + 1;

                    cadastrar bd_cadastrar = new cadastrar();
                    int res = Convert.ToInt32(bd_cadastrar.cadastrar_m(pess));

                    if (res > 0)
                    {
                        MessageBox.Show("Cadastrado com sucesso!!!");
                        txt_nome.Text = null;
                        ms_txt_rg.Text = null;
                        ms_txt_cpf.Text = null;
                        ms_txt_cel.Text = null;
                        ms_txt_tel.Text = null;
                        txt_email.Text = null;
                        txt_apart.Text = null;
                        txt_blo.Text = null;
                        txt_and.Text = null;
                       
                        cb_cat.Text = null;
                    }
                }

                else if (cb_cat.SelectedIndex == 1)
                {
                    pessoa pess = new pessoa();
                    pess.nome = txt_nome.Text;
                    pess.rg = ms_txt_rg.Text;
                    pess.cpf = ms_txt_cpf.Text;
                    pess.cel = ms_txt_cel.Text;
                    pess.tel = ms_txt_tel.Text;
                    pess.email = txt_email.Text;
                    pess.apart = txt_apart.Text;
                    pess.bloco = txt_blo.Text;
                    pess.andar = txt_and.Text;
                  
                    pess.cat = cb_cat.SelectedIndex + 1;

                    cadastrar bd_cadastrar = new cadastrar();
                    int res = Convert.ToInt32(bd_cadastrar.cadastrar_v(pess));

                    if (res > 0)
                    {
                        MessageBox.Show("Cadastrado com sucesso!!!");
                        txt_nome.Text = null;
                        ms_txt_rg.Text = null;
                        ms_txt_cpf.Text = null;
                        ms_txt_cel.Text = null;
                        ms_txt_tel.Text = null;
                        txt_email.Text = null;
                        txt_apart.Text = null;
                        txt_blo.Text = null;
                        txt_and.Text = null;
                       
                        cb_cat.Text = null;
                    }
                }

                else if (cb_cat.SelectedIndex == 2)
                {
                    if (String.IsNullOrWhiteSpace(txt_nome_emp.Text) || String.IsNullOrWhiteSpace(ms_txt_cnpj.Text))
                    {
                        MessageBox.Show("Campos obrigátorio!!");
                    }
                    else
                    {
                        pessoa pess = new pessoa();
                        pess.nome = txt_nome.Text;
                        pess.rg = ms_txt_rg.Text;
                        pess.cpf = ms_txt_cpf.Text;
                        pess.cel = ms_txt_cel.Text;
                        pess.tel = ms_txt_tel.Text;
                        pess.email = txt_email.Text;
                        pess.apart = txt_apart.Text;
                        pess.bloco = txt_blo.Text;
                        pess.andar = txt_and.Text;
                        
                        pess.cat = cb_cat.SelectedIndex + 1;
                        pess.nome_emp = txt_nome_emp.Text;
                        pess.cnpj = ms_txt_cnpj.Text;
                        

                        cadastrar bd_cadastrar = new cadastrar();
                        int res = Convert.ToInt32(bd_cadastrar.cadastrar_ps(pess));

                        if (res > 0)
                        {
                            MessageBox.Show("Cadastrado com sucesso!!!");
                            txt_nome.Text = null;
                            ms_txt_rg.Text = null;
                            ms_txt_cpf.Text = null;
                            ms_txt_cel.Text = null;
                            ms_txt_tel.Text = null;
                            txt_email.Text = null;
                            txt_apart.Text = null;
                            txt_blo.Text = null;
                            txt_and.Text = null;
                            cb_cat.Text = null;
                            txt_nome_emp.Text = null;
                            ms_txt_cnpj.Text = null;
                           
                        }
                    }
                }   
            }
        }
       


        private void Cb_cat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_cat.SelectedIndex == 2)
            {
                lbl_nome_emp.Visible = true;
                lbl_cnpj.Visible = true;                
                txt_nome_emp.Visible = true;
                ms_txt_cnpj.Visible = true;              

            }
            else
            {
                lbl_nome_emp.Visible = false;
                lbl_cnpj.Visible = false;
                txt_nome_emp.Visible = false;
                ms_txt_cnpj.Visible = false;              
            }
        }

        private void f_cadastrar_Load(object sender, EventArgs e)
        {
            cb_cat.Items.Add("Morador");
            cb_cat.Items.Add("Visitante");
            cb_cat.Items.Add("Prestador de Serviço");

            lbl_nome_emp.Visible = false;
            lbl_cnpj.Visible = false;
            txt_nome_emp.Visible = false;
            ms_txt_cnpj.Visible = false;
            

            if (String.IsNullOrEmpty(nome))
            {
                bt_cad.Visible = true;
                bt_update.Visible = false;

            }
            else
            {

                bt_update.Visible = true;
                bt_cad.Visible = false;

                pesquisa pesq_upd = new pesquisa();

                if (cod_cat == 1)
                {
                    pesq_upd.ExibirDados(nome);
                }
                else if (cod_cat == 2)
                {
                    pesq_upd.ExibirDados_visitante(nome);
                }
                else if (cod_cat == 3)
                {
                    pesq_upd.ExibirDados_ps(nome);
                }
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {

        }
    }
}
