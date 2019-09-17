using System;
using System.Collections.Generic;
using System.Text;
//using Pos.EL.Registration;

namespace Pos.DL.Registration
{
   public class CustomersRegistration
    {
        public Boolean Insert(Pos.EL.Registration.Customer cus)
        {
            return Helper.ExecuteNonQuery
                ("Insert into tbl_customer (Lastname, Firstname, MiddleInitial, ExtensionName,BirthDate, Age, Address, Tribe, Religion, CivilStatus)" +
                " Values ('"+cus.LastName1+ "','" + cus.FirstName1 + "','" + cus.MiddleInitial1 + "','" + cus.ExtensionName1 + "','" + cus.BirthDate1 +
                "','" + cus.Age1 + "','" + cus.Address1 + "','" + cus.Tribe1 + "','" + cus.Religion1 + "','" + cus.CivilStatus1 + "') ");
        }
    }
}
