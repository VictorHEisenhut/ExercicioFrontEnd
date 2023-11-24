using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoBD.Utilities
{
    internal class Connect
    {
        public static MySqlConnection Conectar()
        {
            string connectionString = @"Server=localhost;Database=agenda_db;Uid=root;Pwd=admin";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;


        }


    }
}
