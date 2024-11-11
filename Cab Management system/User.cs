using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB011943
{
    public class User
    {
        private string name;
        private string contact;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        public User(string name, string contact)
        {
            this.name = name;
            this.contact = contact;
            
        }
    }
}
