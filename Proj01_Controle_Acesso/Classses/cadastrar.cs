using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Proj01_Controle_Acesso
{
    class cadastrar 
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database = bd_cont_aces; user id = root; Password = ");
        MySqlCommand comandoMysql;
        public string cadastrar_m(pessoa pess)
        {
            //                                                                                                                                        nome,           rg,         cpf,                celular,     telefone,          email,               andar,                  bloco,             apartamento , descricao, id_categoria
            string query = "INSERT INTO morador(nome, rg, cpf, celular, telefone, email, andar, bloco, apartamento, id_categoria)VALUES('" + pess.nome + "', '" + pess.rg + "', '" + pess.cpf + "', '" + pess.cel + "', '" + pess.tel + "', '" + pess.email + "', '" + pess.andar + "', '" + pess.bloco + "', '" + pess.apart + "', " + pess.cat + ")";
            comandoMysql = new MySqlCommand(query, con);

            con.Open();
            int res = comandoMysql.ExecuteNonQuery();
            con.Close();
            return res.ToString();
        }
        public string cadastrar_v(pessoa pess)
        {
            //                                                                                                                                        nome,           rg,         cpf,                celular,     telefone,          email,               andar,                  bloco,             apartamento , descricao, id_categoria
            string query = "INSERT INTO visitante(nome, rg, cpf, celular, telefone, email, andar, bloco, apartamento, id_categoria)VALUES('" + pess.nome + "', '" + pess.rg + "', '" + pess.cpf + "', '" + pess.cel + "', '" + pess.tel + "', '" + pess.email + "', '" + pess.andar + "', '" + pess.bloco + "', '" + pess.apart + "', '" + pess.cat + ")";
            comandoMysql = new MySqlCommand(query, con);

            con.Open();
            int res = comandoMysql.ExecuteNonQuery();
            con.Close();
            return res.ToString();
        }

        public string cadastrar_ps(pessoa pess)
        {
//                                                                                                                                                                                               nome,               rg, 			    cpf,                celular, 		    telefone, 		    email, 		         andar,                     bloco,              apartamento,        descricao,           nome_empresa,             cnpj,                           id_categoria
            string query = "INSERT INTO prestador_Serv (nome, rg, cpf, celular, telefone, email, andar, bloco, apartamento, nome_empresa, cnpj, cracha, id_categoria ) VALUES ('" + pess.nome + "', '" + pess.rg + "', '" + pess.cpf + "', '" + pess.cel + "', '" + pess.tel + "', '" + pess.email + "', '" + pess.andar + "', '" + pess.bloco + "', '" + pess.apart + "', '" + pess.nome_emp + "' , '" + pess.cnpj + "' , " + pess.cat +" )";
            comandoMysql = new MySqlCommand(query, con);

            con.Open();
            int res = comandoMysql.ExecuteNonQuery();
            con.Close();
            return res.ToString();
        }

        public string Log(pessoa pess, DateTime data)
        {
          

            
            string query = "INSERT INTO log (pessoa, data, acao, observacao) VALUES ('" + pess.nome + "', '"+ data.ToString()+ "', '" + pess.acao + "', '" + pess.desc + "')";
            comandoMysql = new MySqlCommand(query, con);

            con.Open();
            int res = comandoMysql.ExecuteNonQuery();
            con.Close();
            return res.ToString();     
        }

        public string update(pessoa pess)         
        {
            string query = "UPDATE morador SET nome = '"+ pess.nome+"', rg='"+pess.rg+"', cpf='"+ pess.cpf + "', celular='"+ pess.cel + "', telefone='" + pess.tel + "', email='" + pess.email + "', andar='" + pess.andar + "', bloco='" + pess.bloco + "', apartamento='" + pess.apart + "', '" + pess.desc + "', '" + pess.nome_emp + "' , '" + pess.cnpj + "' , " + pess.cat + "  WHERE nome='"+pess.nome+"')";
            comandoMysql = new MySqlCommand(query, con);

            con.Open();
            int res = comandoMysql.ExecuteNonQuery();
            con.Close();
            return res.ToString();

        }








    }
}
