using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string username;
        private string password;
        private int typeID;
        private string displayName;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int TypeID { get => typeID; set => typeID = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public Account() { }
        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public Account(string username, string password, int typeID, string displayName)
        {
            Username = username;
            Password = password;
            TypeID = typeID;
            DisplayName = displayName;
        }
        public Account(DataRow row)
        {
            this.Username = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.TypeID = (int)row["TypeID"];
            this.Password = row["Password"].ToString();
        }
    }
}
