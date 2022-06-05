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
    internal class CompletedCoursesDAO : AbstractDAO
    {
        public CompletedCoursesDAO() : base()
        {
            AllowInsert = true;
            AllowDelete = true;

            Columns.Add("id");
            Columns.Add("employee_id");
            Columns.Add("employee_surname");
            Columns.Add("employee_name");
            Columns.Add("employee_position");
            Columns.Add("department");
            Columns.Add("course_id");
            Columns.Add("course_name");
            Columns.Add("course_duration");
            Columns.Add("course_description");
            Columns.Add("completion_date");

            Columns["id"].Caption = "ID";
            Columns["employee_id"].Caption = "ID сотрудника";
            Columns["employee_surname"].Caption = "Фамилия сотрудника";
            Columns["employee_name"].Caption = "Имя сотрудника";
            Columns["employee_position"].Caption = "Должность сотрудника";
            Columns["department"].Caption = "Отдел";
            Columns["course_id"].Caption = "ID курса";
            Columns["course_name"].Caption = "Название курса";
            Columns["course_duration"].Caption = "Длительность курса (час)";
            Columns["course_description"].Caption = "Краткое описание курса";
            Columns["completion_date"].Caption = "Дата завершения";

            Columns["id"].ReadOnly = true;
            Columns["employee_surname"].ReadOnly = true;
            Columns["employee_name"].ReadOnly = true;
            Columns["employee_position"].ReadOnly = true;
            Columns["department"].ReadOnly = true;
            Columns["course_name"].ReadOnly = true;
            Columns["course_duration"].ReadOnly = true;
            Columns["course_description"].ReadOnly = true;
        }

        public override string GetQueryString() => "SELECT * FROM get_completed_courses();";

        public override void Insert(NpgsqlConnection connection, DataRow row)
        {
            int employee_id = int.Parse((string)row["employee_id"]);
            int course_id = int.Parse((string)row["course_id"]);
            string completion_date = (string)row["completion_date"];

            string queryString = $@"SELECT insert_completed_course(
                {employee_id}, {course_id}, '{completion_date}'
            );";

            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);

            command.ExecuteNonQuery();
        }

        public override void Update(NpgsqlConnection connection, DataRow row)
        {
            int employee_id = int.Parse((string)row["employee_id"]);
            int course_id = int.Parse((string)row["course_id"]);
            string completion_date = (string)row["completion_date"];

            string queryString = $@"SELECT update_completed_course(
                {employee_id}, {course_id}, '{completion_date}'
            );";

            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);

            command.ExecuteNonQuery();
        }

        public override void Delete(NpgsqlConnection connection, int id)
        {
            string queryString = $@"SELECT delete_completed_course({id});";

            NpgsqlCommand command = new NpgsqlCommand(queryString, connection);

            command.ExecuteNonQuery();
        }

        public override void GenerateCertificate(FileStream file)
        {
            throw new SystemException("для данной таблицы эта операция не допустима");
        }
    }
}
