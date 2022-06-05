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
    internal abstract class AbstractDAO : DataTable
    {
        public bool AllowInsert { get; protected set; } = false;
        public bool AllowDelete { get; protected set; } = false;


        public AbstractDAO() : base() {}


        public abstract string GetQueryString();

        public void Fill(NpgsqlConnection connection)
        {
            NpgsqlCommand command = new NpgsqlCommand(GetQueryString(), connection);
            NpgsqlDataReader reader = command.ExecuteReader();

            Clear();
            Load(reader);
        }

        public abstract void Insert(NpgsqlConnection connection, DataRow row);
        public abstract void Update(NpgsqlConnection connection, DataRow row);
        public abstract void Delete(NpgsqlConnection connection, int id);

        public abstract void GenerateCertificate(FileStream file);
    }
}
