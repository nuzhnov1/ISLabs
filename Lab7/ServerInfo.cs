using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    static class ServerInfo
    {
        public static string host = "localhost";
        public static string port = "1100";
        public static string datebase = "restaurant";
        public static string username = "test";
        public static string password = "0000";

        public static string GetConnectionString() 
        {
            return $"Host = {host}; Port = {port}; Database = {datebase}; Username = {username}; Password = {password};";
        }
        
    }
    
}
