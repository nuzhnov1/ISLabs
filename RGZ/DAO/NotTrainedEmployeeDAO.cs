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
    internal class NotTrainedEmployeeDAO : AbstractDAO
    {

        public NotTrainedEmployeeDAO() : base()
        {
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
            Columns["surname"].ReadOnly = true;
            Columns["name"].ReadOnly = true;
            Columns["job"].ReadOnly = true;
            Columns["department"].ReadOnly = true;
            Columns["employment_date"].ReadOnly = true;
        }

        public override string GetQueryString() => $"SELECT * FROM get_not_trained_employee();";

        public override void Insert(NpgsqlConnection connection, DataRow row)
        {
            throw new SystemException("для данной таблицы эта операция не допустима");
        }

        public override void Update(NpgsqlConnection connection, DataRow row)
        {
            throw new SystemException("для данной таблицы эта операция не допустима");
        }

        public override void Delete(NpgsqlConnection connection, int id)
        {
            throw new SystemException("для данной таблицы эта операция не допустима");
        }

        public override void GenerateCertificate(FileStream file)
        {

        }
    }
}
