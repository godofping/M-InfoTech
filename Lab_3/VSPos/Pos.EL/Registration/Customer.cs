namespace Pos.EL.Registration
{
    public class Customer
    {

        int CustomerID;
        string LastName;
        string FirstName;
        string MiddleInitial;
        string ExtensionName;
        string BirthDate;
        int Age;
        string Address;
        string Tribe;
        string Religion;
        string CivilStatus;

        public string LastName1
        {
            get => LastName;
            set => LastName = value;
        }
        public string FirstName1
        {
            get => FirstName;
            set => FirstName = value;
        }
        public string MiddleInitial1
        {
            get => MiddleInitial;
            set => MiddleInitial = value;
        }
        public string ExtensionName1
        {
            get => ExtensionName;
            set => ExtensionName = value;
        }
        public string BirthDate1
        {
            get => BirthDate;
            set => BirthDate = value;
        }
        public int Age1
        {
            get => Age;
            set => Age = value;
        }
        public string Address1
        {
            get => Address;
            set => Address = value;
        }
        public string Tribe1
        {
            get => Tribe;
            set => Tribe = value;
        }
        public string CivilStatus1
        {
            get => CivilStatus;
            set => CivilStatus = value;
        }
        public string Religion1 { get => Religion; set => Religion = value; }



        /*
         public int CustomerID
         {
            get
                {
                    return CustomerID;
                }

            set
                {
                    CustomerID = value;
                }
          }

         */


    }
}
