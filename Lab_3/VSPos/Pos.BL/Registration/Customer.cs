using System;
using System.Collections.Generic;
using System.Text;

namespace Pos.BL.Registration
{
  public  class Customer
    {
        public bool Insert(Pos.EL.Registration.Customer cus)
        {
            Pos.DL.Registration.CustomersRegistration customerDL = new Pos.DL.Registration.CustomersRegistration();
            if (customerDL.Insert(cus))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
