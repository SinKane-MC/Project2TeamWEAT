//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab2
{
    using System;
    using System.Collections.Generic;
    using BCrypt.Net;


    public partial class Customer
    {
        public Customer()
        {
            this.Leases = new HashSet<Lease>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public string Salt { get; set; }
    
        public virtual ICollection<Lease> Leases { get; set; }

        public string EncryptPassword(string plainPass, string salt)
        {
            if (salt == null)
                salt = GetSalt();
            string passwordHash = BCrypt.HashPassword(plainPass,salt);
            return passwordHash;
        }

        public string GetSalt()
        {
            if (Salt == "" || Salt == null)
            {
                Salt = BCrypt.GenerateSalt();
            }
           return Salt;
        }

        public bool VerifyPassword(string plainPass)
        {
            bool success = BCrypt.Verify(plainPass, Password);
            return success;
        }
       
    }
}
