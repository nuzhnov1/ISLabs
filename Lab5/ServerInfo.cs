using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    static class ServerInfo
    {
        static string host = "localhost";
        static string port = "1100";
        static string datebase = "restaurant";
        static string username = "postgres";
        static string password = "0000";

        public static string GetConnectionString() 
        {
            return $"Host = {host}; Port = {port}; Database = {datebase}; Username = {username}; Password = {password};";
        }
        
    }
    
}
