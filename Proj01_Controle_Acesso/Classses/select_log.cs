using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proj01_Controle_Acesso
{
    class select_log
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database = bd_cont_aces; user id = root; Password = ");
        MySqlCommand comandomysql;
        int cod;


        public string Logar(string login, string senha)
        {
            string querymysql = "SELECT * FROM users WHERE login='"+ login + "' AND senha='"+ senha + "'";
            comandomysql = new MySqlCommand(querymysql, con);
            con.Open();
            MySqlDataReader resp =  comandomysql.ExecuteReader();


            if (resp.Read())
            {
                cod = int.Parse(resp["privilegio"].ToString());

            }
            else
            {
                cod = 0; 
            }

            con.Close();
            resp.Close();

            
            return cod.ToString();

        }


    }
}
