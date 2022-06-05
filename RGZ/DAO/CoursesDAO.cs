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
    internal class CoursesDAO : AbstractDAO
    {
        public CoursesDAO() : base()
        {
            AllowInsert = true;
            AllowDelete = true;

            Columns.Add("id");
            Columns.Add("name");
            Columns.Add("duration");
            Columns.Add("department");
            Columns.Add("description");

            Columns["id"].Caption = "ID";
            Columns["name"].Caption = "Наименование";
            Columns["duration"].Caption = "Продолжительность (час)";
            Columns["department"].Caption = "Для какого отдела";
            Columns["description"].Caption = "Краткое описание";

            Columns["id"].ReadOnly = true;
        }

        public override string GetQueryString() => "SELECT * FROM get_courses();";

        public override void Insert(NpgsqlConnection connection, DataRow row)
        {
            string name = (string)row["name"];
            int duration = int.Parse((string)row["duration"]);
            string department = (string)row["department"];
            string description = (string)row["description"];

            string queryString = $@"SELECT insert_course(
                '{name}', {duration}, '{department}', '{description}'
            );";

            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);
            
            command.ExecuteNonQuery();
        }

        public override void Update(NpgsqlConnection connection, DataRow row)
        {
            int id = int.Parse((string)row["id"]);
            string name = (string)row["name"];
            int duration = int.Parse((string)row["duration"]);
            string department = (string)row["department"];
            string description = (string)row["description"];

            string queryString = $@"SELECT update_course(
                {id}, '{name}', {duration}, '{department}', '{description}'
            );";

            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);
            
            command.ExecuteNonQuery();
        }

        public override void Delete(NpgsqlConnection connection, int id)
        {
            string queryString = $@"SELECT delete_course({id});";
            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);

            command.ExecuteNonQuery();
        }

        public override void GenerateCertificate(FileStream file)
        {
            throw new SystemException("для данной таблицы эта операция не допустима");
        }
    }
}
