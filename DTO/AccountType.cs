using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountType
    {
        private int id;
        private string typeName;

        public int Id { get => id; set => id = value; }
        public string TypeName { get => typeName; set => typeName = value; }
        public AccountType() { }
        public AccountType(int id, string typename)
        {
            this.id = id;
            this.typeName = typename;
        }
    }
}
