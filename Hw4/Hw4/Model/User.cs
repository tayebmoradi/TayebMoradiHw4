using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Dateofbirth { get; set; }
        public DateTime CreateUser { get; set; }
        public User(int id, string fullName, string phoneNumber, string dateofbirth, DateTime createUser)
        {
            this.Id = id;
            this.FullName = fullName;
            this.PhoneNumber = phoneNumber;
            this.Dateofbirth = dateofbirth;
            this.CreateUser = createUser;    
        }
    }
}
