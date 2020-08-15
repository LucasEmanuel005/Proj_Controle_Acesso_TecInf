using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proj01_Controle_Acesso
{
    class pesquisa
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database = bd_cont_aces; user id = root; Password = ");
        MySqlCommand comando = null;

        string query;

        public DataTable ExibirDados(string txt_pesq)
        {
             query = "SELECT m.nome, m.celular, m.telefone, m.andar, m.bloco, m.apartamento, c.nome_cat, m.id_morador FROM morador AS m JOIN categoria AS c ON m.id_categoria = c.id_categoria WHERE nome LIKE '" + txt_pesq + "%'";

            comando = new MySqlCommand(query, con);

            try
            {
                MySqlDataAdapter Executador = new MySqlDataAdapter();
                Executador.SelectCommand = comando;

                DataTable tabela = new DataTable();
                Executador.Fill(tabela);
                return tabela;

            }
            catch(Exception erro)
            {
                throw erro;
            }
        }



        public DataTable ExibirDados_visitante(string txt_pesq)
        {
            query = "SELECT v.nome, v.celular, v.telefone, v.andar, v.bloco, v.apartamento, c.nome_cat, v.id_visitante FROM visitante AS v JOIN categoria AS c ON v.id_categoria = c.id_categoria WHERE nome LIKE '" + txt_pesq + "%'";

            comando = new MySqlCommand(query, con);

            try
            {
                MySqlDataAdapter Executador = new MySqlDataAdapter();
                Executador.SelectCommand = comando;

                DataTable tabela = new DataTable();
                Executador.Fill(tabela);                
                return tabela;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

      
            
        public DataTable ExibirDados_ps(string txt_pesq)
        {
            query = "SELECT ps.nome, ps.celular, ps.telefone, ps.andar, ps.bloco, ps.apartamento, ps.nome_empresa, ps.cnpj, c.nome_cat, ps.id_prestador_serv FROM prestador_serv  AS ps JOIN categoria AS c ON ps.id_categoria = c.id_categoria WHERE nome LIKE '" + txt_pesq + "%'";

            comando = new MySqlCommand(query, con);

            try
            {
                MySqlDataAdapter Executador = new MySqlDataAdapter();
                Executador.SelectCommand = comando;

                DataTable tabela = new DataTable();
                Executador.Fill(tabela);
                return tabela;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public DataTable ExibirDados_log()
        {
            query = "SELECT * FROM log  ORDER BY id_log DESC LIMIT 50";

            comando = new MySqlCommand(query, con);

            try
            {
                MySqlDataAdapter Executador = new MySqlDataAdapter();
                Executador.SelectCommand = comando;

                DataTable tabela = new DataTable();
                Executador.Fill(tabela);
                return tabela;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public DataTable ExibirDados_log_pesq(string nome)
        {
            query = "SELECT * FROM log WHERE pessoa LIKE '" + nome + "%' ORDER BY id_log DESC LIMIT 50";

            comando = new MySqlCommand(query, con);

            try
            {
                MySqlDataAdapter Executador = new MySqlDataAdapter();
                Executador.SelectCommand = comando;

                DataTable tabela = new DataTable();
                Executador.Fill(tabela);
                return tabela;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public DataTable ExibirDados_log_Sem_Lim()
        {
            query = "SELECT * FROM log ORDER BY id_log DESC";

            comando = new MySqlCommand(query, con);

            try
            {
                MySqlDataAdapter Executador = new MySqlDataAdapter();
                Executador.SelectCommand = comando;

                DataTable tabela = new DataTable();
                Executador.Fill(tabela);
                return tabela;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public DataTable ExibirDados_log_Sem_Lim_pesq(string nome)
        {
            query = "SELECT * FROM log WHERE pessoa LIKE '" + nome + "%' ORDER BY id_log DESC ";

            comando = new MySqlCommand(query, con);

            try
            {
                MySqlDataAdapter Executador = new MySqlDataAdapter();
                Executador.SelectCommand = comando;

                DataTable tabela = new DataTable();
                Executador.Fill(tabela);
                return tabela;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }






    }
}
