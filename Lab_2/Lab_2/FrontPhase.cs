using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class FrontPhase : Form
    {
        int IEmployeeIDNum;
        String StrLN;
        String StrFN;
        String StrMN;
        String StrAdd;
        int ITelMobb;
        String StrPosition;


        float DblRRPerHr;
        float DblRRTAHr;

        double DblReg;
        double DblOveTm;

        float DblOTRPerHr;
        float DblOTRTAHr;
        float DblOTime;
        float DblTRWage;
        double DblWHTax;
        float DblNAPaid;
        

       

        Double DblSSSFund;
        Double DblGSISFund;
        Double DblPGIBGFund;
        Double DblPHLHLTHFund;
        Double DblOthers;
        Double DblTDtn;
        Double DblTNAP;

        public FrontPhase()
        {
            InitializeComponent();
        }



        private void TBTAHRRHour_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TBRegular.Text = (float.Parse(TBRRHour.Text) * float.Parse(TBTAHRRHour.Text)).ToString();
            }
            catch
            {
                TBRegular.Text = "00.0";

            }
        }

        private void TBRRHour_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TBRegular.Text = (float.Parse(TBRRHour.Text) * float.Parse(TBTAHRRHour.Text)).ToString();
            }
            catch
            {
                TBRegular.Text = "00.0";

            }
        }



        private void TBTAHOTRHour_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TBOvertime.Text = (float.Parse(TBOTRHour.Text) * float.Parse(TBTAHOTRHour.Text)).ToString();
            }
            catch
            {

                TBOvertime.Text = "00.0";
            }
        }

        private void TBRegular_TextChanged(object sender, EventArgs e)
        {
            TBTRWage.Text = "00.0";
            try
            {

                TBTRWage.Text = (float.Parse(TBRegular.Text) + float.Parse(TBOvertime.Text)).ToString();
            }
            catch
            {
                TBTRWage.Text = "00.0";

            }
        }

<<<<<<< HEAD
        private void TBTRWage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double DblReg = Convert.ToDouble(TBTRWage.Text);
                DblWHTax = DblReg * 0.03;
                TBWHTax.Text = DblWHTax.ToString();
            }
            catch
            {
            }
        }

        private void TBWHTax_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                double DblWHTax = Convert.ToDouble(TBWHTax.Text);
                double DblRegWage = Convert.ToDouble(TBTRWage.Text);

                double DblNAPaid = DblRegWage - DblWHTax;
                TBNAPaid.Text = DblNAPaid.ToString();
            }
            catch
            {
            }
        }
        private void TBTDedtn_TextChanged(object sender, EventArgs e)
        {
            /*   try
                {
                    double last1 = Convert.ToDouble(TBNAPaid.Text);
                    double last2 = Convert.ToDouble(TBTDedtn.Text);
                    double last4 = Convert.ToDouble(tbtExpns.Text);

                    double last = last1 - last2 - last4;
                    TBTNAPaid.Text = last.ToString();

                }
                catch 
                {


                }*/

        }
        private void Dedt()
        {
            TBTDedtn.Text = (float.Parse(TBSSSFund.Text) + float.Parse(TBGSISFund.Text) + float.Parse(TBPIbigFund.Text) + float.Parse(TBPHealthFund.Text) + float.Parse(TBOthers.Text)).ToString();

        }
        private void TBEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }



        }

        private void TBLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }

        }

        private void TBFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TBMName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TBAddress_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TBPosition_KeyPress(object sender, KeyPressEventArgs e)
=======
        private void TBOvertime_TextChanged(object sender, EventArgs e)
>>>>>>> dd5071dd8040abc4bfd394ebcf55f79283a63741
        {
            TBTRWage.Text = "00.0";
            try
            {

                TBTRWage.Text = (float.Parse(TBRegular.Text) + float.Parse(TBOvertime.Text)).ToString();
            }
            catch
            {
                TBTRWage.Text = "00.0";

            }
        }

        

        private void TBWHTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBTRWage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double DblReg = Convert.ToDouble(TBTRWage.Text);
               DblWHTax = DblReg * 0.03;
                TBWHTax.Text = DblWHTax.ToString();
            }
            catch
            {


            }
        }

        private void TBWHTax_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                double DblWHTaxes2 = Convert.ToDouble(TBWHTax.Text);
                double DblNAPaid = DblReg - DblWHTax;

            }
            catch 
            {

               
            }
        }

<<<<<<< HEAD
        private void TbGrocerries_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbtExpns.Text = (float.Parse(tbElectrictBll.Text) + float.Parse(tbWaterBll.Text) + float.Parse(tbGrocerries.Text) + (float.Parse(tbContengencies.Text) * 0.1).ToString());
            }
            catch
            {


            }
        }

        private void TbtExpns_TextChanged(object sender, EventArgs e)
        {
            double eb = Convert.ToDouble(tbElectrictBll.Text);
            double wb = Convert.ToDouble(tbWaterBll.Text);
            double gb = Convert.ToDouble(tbGrocerries.Text);
            double cb = Convert.ToDouble(tbContengencies.Text);
 
            double last3 = eb + wb + gb + (cb * .1);
            tbtExpns.Text = last3.ToString();

            double last1 = Convert.ToDouble(TBNAPaid.Text);
            double last2 = Convert.ToDouble(TBTDedtn.Text);
           

            double last = last1 - last2 - last3;
            TBTNAPaid.Text = last.ToString();


        }

        private void TbElectrictBll_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbtExpns.Text = (float.Parse(tbElectrictBll.Text) + float.Parse(tbWaterBll.Text) + float.Parse(tbGrocerries.Text) + (float.Parse(tbContengencies.Text) * 0.1).ToString());

            }
            catch
            {


            }
        }

        private void TbContengencies_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbtExpns.Text = (float.Parse(tbElectrictBll.Text) + float.Parse(tbWaterBll.Text) + float.Parse(tbGrocerries.Text) + (float.Parse(tbContengencies.Text) * 0.1).ToString());
            }
            catch
            {


            }
        }

        private void TBTNAPaid_TextChanged(object sender, EventArgs e)
=======
        private void FrontPhase_Load(object sender, EventArgs e)
>>>>>>> dd5071dd8040abc4bfd394ebcf55f79283a63741
        {
            try
            {
                double last1 = Convert.ToDouble(TBNAPaid.Text);
                double last2 = Convert.ToDouble(TBTDedtn.Text);
                double last4 = Convert.ToDouble(tbtExpns.Text);

                double last = last1 - last2 - last4;
                TBTNAPaid.Text = last.ToString();
            }
            catch
            {


            }
        }

<<<<<<< HEAD
        private void Lblsalary_Click(object sender, EventArgs e)
        {
            lblsalary.Text = TBTNAPaid.Text;


        }


        private void Lblsalaryyr_Click(object sender, EventArgs e)
        {


            lblsalaryyr.Text = ((float.Parse(TBTNAPaid.Text)*12).ToString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TbElectrictBll_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TBTAHRRHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TBOTRHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TBTAHOTRHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TBSSSFund_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TBGSISFund_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TBPIbigFund_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TBPHealthFund_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TBOthers_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TbWaterBll_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TbGrocerries_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TbContengencies_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
            catch
            {

            }
        }

        private void TBTNAPaid_TextChanged_1(object sender, EventArgs e)
        {
            lblsalary.Text = TBTNAPaid.Text;
            lblsalaryyr.Text = ((float.Parse(TBTNAPaid.Text) * 12).ToString());

        }
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";
        public static string SetValueForText7 = "";
        public static string SetValueForText8 = "";
        public static string SetValueForText9 = "";
        public static string SetValueForText10 = "";
        public static string SetValueForText11 = "";
        public static string SetValueForText12 = "";

        public static string SetValueForText13 = "";
        public static string SetValueForText14 = "";
        public static string SetValueForText15 = "";
        public static string SetValueForText16 = "";
        public static string SetValueForText17 = "";



        private void Button1_Click_1(object sender, EventArgs e)
        {

            SetValueForText1 = TBLName.Text;
            SetValueForText2 = TBFName.Text;
            SetValueForText3 = TBMName.Text;
            SetValueForText4 = TBPosition.Text;
            SetValueForText5 = TBTRWage.Text;
            SetValueForText6 = TBWHTax.Text;
            SetValueForText7 = TBSSSFund.Text;
            SetValueForText8 = TBGSISFund.Text;
            SetValueForText9 = TBPIbigFund.Text;
            SetValueForText10 = TBPHealthFund.Text;
            SetValueForText11 = TBOthers.Text;
            SetValueForText12 = TBNAPaid.Text;

            SetValueForText13 = tbWaterBll.Text;
            SetValueForText14 = tbElectrictBll.Text;
            SetValueForText15 = tbGrocerries.Text;
            SetValueForText16 = tbContengencies.Text;
            SetValueForText17 = TBTNAPaid.Text;

            BackPhase f2 = new BackPhase();
            f2.ShowDialog();
            
        }






        /*private void GB1_Enter(object sender, EventArgs e)
        {
           tbtExpns.Text = (float.Parse(tbElectrictBll.Text) + float.Parse(tbWaterBll.Text) + float.Parse(tbGrocerries.Text) + (float.Parse(tbContengencies.Text) * 0.1).ToString());
           
             try
            {
                double last1 = Convert.ToDouble(TBNAPaid.Text);
                double last2 = Convert.ToDouble(TBTDedtn.Text);

                double last = last1 - last2 + 0;
                TBTNAPaid.Text = last.ToString();
            }
            catch 
            {

       
            }
         
            
          
          

            }*/



=======
       
>>>>>>> dd5071dd8040abc4bfd394ebcf55f79283a63741
    }
}
