using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BankApp
{
   class Customer
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string MobileNumber { get; set; }
        public BankAccount bankAccount { set; get; }
        public string CustomerInfo()
        {
            return $"@Name: {FirstName} {LastName}        
            Age: {Age}
            Gender: {Gender}
            Mobile: {MobileNumber}
            Account Balance: {bankAccount.AccountBalance}";
    }
    }
