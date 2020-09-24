using Microsoft.AspNetCore.Identity;

namespace Estore.models
{
    public abstract class User
    {


        public string Phone { get; set; }
        public Address HomeAddress { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        protected User()
        {
        }

        protected User(string phone, Address homeAddress, string emailAddress, string name, string password)
        {
            Phone = phone;
           HomeAddress = homeAddress;
           EmailAddress = emailAddress;
           Name = name;
           
           Password = password;
        }
    }
}