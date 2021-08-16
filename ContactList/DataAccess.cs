using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ContactList
{
    public class DataAccess
    {
        string ConectionString = "Data Source=todes-server.database.windows.net;Initial Catalog=AW;User Id=todes;Password=Qaz73501505";
        public List<Contact> GetContact()
        {
            using (IDbConnection connection = new SqlConnection(ConectionString))
            {
                return connection
                        .Query<Contact>($"select * from ola.Contact")
                        .ToList();
            }
        }

        public void AddContact(string name, string lastName, DateTime birthday)
        {
            using (IDbConnection connection = new SqlConnection(ConectionString))
            {
                string sql_command = $"insert into ola.Contact (Name, LastName, Birthday) values (N'{name}', N'{lastName}', N'{birthday}');";
                connection.Execute(sql_command);
            }

        }
        public void DeleteContact (int id)
        {
            using (IDbConnection connection = new SqlConnection(ConectionString))
            {
                string sql_command = $"delete from ola.Contact where ID = {id}";
                connection.Execute(sql_command);
            }

        }

    }
}
