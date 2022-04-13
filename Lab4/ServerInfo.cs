using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    static class ServerInfo
    {
        static readonly string host = "localhost";
        static readonly string port = "5432";
        static readonly string datebase = "restaurant";
        static readonly string username = "admin";
        static readonly string password = "hydra";

        public static string GetConnectionString() 
        {
            return $"Host = {host}; Port = {port}; Database = {datebase}; Username = {username}; Password = {password};";
        }
        
    }
    
}
