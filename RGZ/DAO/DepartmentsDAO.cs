using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace RGZ.DAO
{
    internal class DepartmentsDAO : AbstractDAO
    {
        public DepartmentsDAO() : base()
        {
            AllowInsert = true;
            AllowDelete = true;

            Columns.Add("id");
            Columns.Add("name");

            Columns["id"].Caption = "ID";
            Columns["name"].Caption = "Название";

            Columns["id"].ReadOnly = true;
        }

        public override string GetQueryString() => "SELECT * FROM get_departments_list();";

        public override void Insert(NpgsqlConnection connection, DataRow row)
        {
            string name = (string)row["name"];
            string queryString = $@"SELECT insert_department('{name}');";
            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);

            command.ExecuteNonQuery();
        }

        public override void Update(NpgsqlConnection connection, DataRow row)
        {
            int id = int.Parse((string)row["id"]);
            string name = (string)row["name"];
            string queryString = $@"SELECT update_department({id}, '{name}');";
            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);

            command.ExecuteNonQuery();
        }

        public override void Delete(NpgsqlConnection connection, int id)
        {
            string queryString = $@"SELECT delete_department({id});";
            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);

            command.ExecuteNonQuery();
        }

        public override void GenerateCertificate(FileStream file)
        {
            throw new SystemException("для данной таблицы эта операция не допустима");
        }
    }
}
