using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj01_Controle_Acesso
{
    class pessoa
    {
        private string p_nome, p_rg, p_cpf, p_cel, p_tel, p_email, p_apart, p_bloco, p_andar, p_desc, p_nome_emp, p_cnpj, p_acao, p_obs;
        private int p_cat;
        DateTime p_data;

        public string nome{get { return p_nome; } set { p_nome = value; }}
        public string rg {get { return p_rg; } set { p_rg = value; }}
        public string cpf { get { return p_cpf; } set { p_cpf = value; } }
        public string cel { get { return p_cel; } set { p_cel = value; } }
        public string tel { get { return p_tel; } set { p_tel = value; } }
        public string email { get { return p_email; } set { p_email = value; } }
        public string apart { get { return p_apart; } set { p_apart = value; } }
        public string bloco { get { return p_bloco; } set { p_bloco = value; } }
        public string andar { get { return p_andar; } set { p_andar = value; } }
        public string desc { get { return p_desc; } set { p_desc = value; } }
        public int cat { get { return p_cat; } set { p_cat = value; } }
        //CAT P.S
        public string nome_emp { get { return p_nome_emp; } set { p_nome_emp = value; } }
        public string cnpj { get { return p_cnpj; } set { p_cnpj = value; } }

        public string acao  { get { return p_acao; } set { p_acao = value; } }

        public DateTime data { get { return p_data; }}

    }
}
