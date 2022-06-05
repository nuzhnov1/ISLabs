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
    internal class EmployeeDAO: AbstractDAO
    {
        public EmployeeDAO() : base()
        {
            AllowInsert = true;
            AllowDelete = true;
            
            Columns.Add("id");
            Columns.Add("surname");
            Columns.Add("name");
            Columns.Add("job");
            Columns.Add("department");
            Columns.Add("employment_date");

            Columns["id"].Caption = "ID";
            Columns["surname"].Caption = "Фамилия";
            Columns["name"].Caption = "Имя";
            Columns["job"].Caption = "Должность";
            Columns["department"].Caption = "Отдел";
            Columns["employment_date"].Caption = "Дата приёма";

            Columns["id"].ReadOnly = true;
        }

        public override string GetQueryString() => "SELECT * FROM get_employee();";

        public override void Insert(NpgsqlConnection connection, DataRow row)
        {
            string surname = (string)row["surname"];
            string name = (string)row["name"];
            string job = (string)row["job"];
            string department = (string)row["department"];
            string employment_date = (string)row["employment_date"];

            string queryString = $@"SELECT insert_employee(
                '{surname}', '{name}', '{job}',
                '{department}', '{employment_date}'
            );";

            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);
            
            command.ExecuteNonQuery();
        }

        public override void Update(NpgsqlConnection connection, DataRow row)
        {
            int id = int.Parse((string)row["id"]);
            string surname = (string)row["surname"];
            string name = (string)row["name"];
            string job = (string)row["job"];
            string department = (string)row["department"];
            string employment_date = (string)row["employment_date"];

            string queryString = $@"SELECT update_employee(
                {id}, '{surname}', '{name}', '{job}',
                '{department}', '{employment_date}'
            );";

            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);
            
            command.ExecuteNonQuery();
        }

        public override void Delete(NpgsqlConnection connection, int id)
        {
            string queryString = $@"SELECT delete_employee({id});";
            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);

            command.ExecuteNonQuery();
        }

        public override void GenerateCertificate(FileStream file)
        {
            throw new SystemException("для данной таблицы эта операция не допустима");
        }
    }
}
