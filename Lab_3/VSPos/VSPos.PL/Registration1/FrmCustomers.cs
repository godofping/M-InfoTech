using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;

namespace VSPos.PL.Registration1
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            Pos.EL.Registration.Customer CustomerInfo = new Pos.EL.Registration.Customer();
            CustomerInfo.LastName1 = tb_lastname.Text;
            CustomerInfo.FirstName1 = tb_firstname.Text;
            CustomerInfo.MiddleInitial1 =tb_middleinitial.Text;
            CustomerInfo.Age1 = Convert.ToInt32(tb_age.Text);
            CustomerInfo.Address1 = tb_address.Text;
            CustomerInfo.Tribe1 = tb_tribe.Text;
            CustomerInfo.ExtensionName1 = tb_extensionname.Text;
            CustomerInfo.Religion1 = tb_religion.Text;
            CustomerInfo.BirthDate1 = dateTimePicker1.Text;
            CustomerInfo.CivilStatus1 = tb_civilstatus.Text;
            Pos.BL.Registration.Customer CustomerBL = new Pos.BL.Registration.Customer();
            bool isSuccessfull = CustomerBL.Insert(CustomerInfo);
            if (isSuccessfull)
            {
                MessageBox.Show("Record Successfully Addded!");
            }
            else
            {

                MessageBox.Show("Addding Record Failed!");
            }
        }
    }
}
