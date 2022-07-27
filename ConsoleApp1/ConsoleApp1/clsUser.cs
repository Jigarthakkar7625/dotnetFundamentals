using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class clsUser
    {

        private string UserName = "";

        public int Id { get; set; } //Data member // Properties

        public string Name { get; set; }
        public string Username { get; set; }
        public int MyProperty { get; set; }

        public clsUser(string UserName)
        {
            this.UserName = UserName;
            Console.WriteLine();
        }

        ~clsUser()
        {

            Console.WriteLine();

        }
    }
}
