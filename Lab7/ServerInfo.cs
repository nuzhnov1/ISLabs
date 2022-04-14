using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    static class ServerInfo
    {
        public static readonly string host = "localhost";
        public static readonly string port = "5432";
        public static string datebase = "restaurant";
        public static readonly string username = "admin";
        public static readonly string password = "hydra";

        public static string GetConnectionString() 
        {
            return $"Host = {host}; Port = {port}; Database = {datebase}; Username = {username}; Password = {password};";
        }
        
    }
    
}
