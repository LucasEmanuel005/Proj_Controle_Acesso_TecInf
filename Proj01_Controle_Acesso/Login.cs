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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_login.Text) || String.IsNullOrWhiteSpace(txtsenha.Text))
            {
                MessageBox.Show("Campos obrigatórios");
            }
            else
            {
                select_log login_inic = new select_log();
                int cod_clas = Convert.ToInt32( login_inic.Logar(txt_login.Text, txtsenha.Text));
                if (cod_clas > 0)
                {
                    txt_login.Text = null;
                    txtsenha.Text = null;

                    Menu_Principal form_Pri = new Menu_Principal(cod_clas);
                    this.Dispose();
                    form_Pri.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Usuário não encontrado!");
                }
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
