using System;
using System.Collections.Generic;
using System.Text;



namespace Encapsulation
{
    class Account
    {
        private decimal balance = 90;




        public string AccountNumber  { get;  }

        private string password;

        public string Password


        {
            get { return password; }
            set {
                if (value.Length >=8) {
               


                    password = value;

                }
                else
                {
                    throw new Exception("Password is too short.");
                }
                }
        }


        public bool WithdrawFounds (decimal amount)
        {



            if (balance < amount)
            
            
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }
    }
}
