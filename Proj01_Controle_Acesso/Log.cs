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
    public partial class Log : Form
    {
        int t; 
        pesquisa pesq_log = new pesquisa();
        public Log()
        {
            InitializeComponent();
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            Menu_Principal menuP = new Menu_Principal();
            this.Dispose();
            menuP.ShowDialog();
        }

        private void Log_Load(object sender, EventArgs e)
        {
                   

            

        }

        private void rb_lis_tudo_CheckedChanged(object sender, EventArgs e)
        {
            t = 1;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_lim_50.Checked)
            {
               
                if (String.IsNullOrWhiteSpace(txt_pesq_nome.Text))
                {
                    dataGridView1.DataSource = pesq_log.ExibirDados_log();
                }
                else
                {
                    dataGridView1.DataSource = pesq_log.ExibirDados_log_pesq(txt_pesq_nome.Text);

                }
            }
            else if (rb_lis_tudo.Checked) 
            {
                if (String.IsNullOrWhiteSpace(txt_pesq_nome.Text))
                {
                    dataGridView1.DataSource = pesq_log.ExibirDados_log_Sem_Lim();
                }
                else 
                {
                    dataGridView1.DataSource = pesq_log.ExibirDados_log_Sem_Lim_pesq(txt_pesq_nome.Text);
                }
               
            }


        }
    }
}
