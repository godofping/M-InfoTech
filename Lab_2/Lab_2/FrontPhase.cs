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

        /*  private void TBSSSFund_TextChanged(object sender, EventArgs e)
        {
              TBTDedtn.Text = "00.0";
          try
          {
          TBTDedtn.Text = (float.Parse(TBSSSFund.Text) + float.Parse(TBGSISFund.Text) + float.Parse(TBPIbigFund.Text) + float.Parse(TBPHealthFund.Text) + float.Parse(TBOthers.Text)).ToString();
         
            }
            catch
            {
            TBTDedtn.Text = "00.0";
            }
            }
        */
        private void TBOvertime_TextChanged(object sender, EventArgs e)
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

        private void TBPosition_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBTMNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBRRHour_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBOthers_TextChanged(object sender, EventArgs e)
        {
            TBTDedtn.Text = "00.0";
            try
            {
                TBTDedtn.Text = (float.Parse(TBSSSFund.Text) + float.Parse(TBGSISFund.Text) + float.Parse(TBPIbigFund.Text) + float.Parse(TBPHealthFund.Text) + float.Parse(TBOthers.Text)).ToString();

            }
            catch
            {
                TBTDedtn.Text = "00.0";
            }

        }

        private void TBPHealthFund_TextChanged(object sender, EventArgs e)
        {
            TBTDedtn.Text = "00.0";
            try
            {
                TBTDedtn.Text = (float.Parse(TBSSSFund.Text) + float.Parse(TBGSISFund.Text) + float.Parse(TBPIbigFund.Text) + float.Parse(TBPHealthFund.Text) + float.Parse(TBOthers.Text)).ToString();

            }
            catch
            {
                TBTDedtn.Text = "00.0";
            }

        }

        private void TBPIbigFund_TextChanged(object sender, EventArgs e)
        {
            TBTDedtn.Text = "00.0";
            try
            {
                TBTDedtn.Text = (float.Parse(TBSSSFund.Text) + float.Parse(TBGSISFund.Text) + float.Parse(TBPIbigFund.Text) + float.Parse(TBPHealthFund.Text) + float.Parse(TBOthers.Text)).ToString();

            }
            catch
            {
                TBTDedtn.Text = "00.0";
            }

        }

        private void TBGSISFund_TextChanged(object sender, EventArgs e)
        {
            TBTDedtn.Text = "00.0";
            try
            {
                TBTDedtn.Text = (float.Parse(TBSSSFund.Text) + float.Parse(TBGSISFund.Text) + float.Parse(TBPIbigFund.Text) + float.Parse(TBPHealthFund.Text) + float.Parse(TBOthers.Text)).ToString();

            }
            catch
            {
                TBTDedtn.Text = "00.0";
            }

        }

        private void TBSSSFund_TextChanged(object sender, EventArgs e)
        {
            TBTDedtn.Text = "00.0";
            try
            {
                TBTDedtn.Text = (float.Parse(TBSSSFund.Text) + float.Parse(TBGSISFund.Text) + float.Parse(TBPIbigFund.Text) + float.Parse(TBPHealthFund.Text) + float.Parse(TBOthers.Text)).ToString();

            }
            catch
            {
                TBTDedtn.Text = "00.0";
            }

        }

        private void TBTNAPaid_TextChanged(object sender, EventArgs e)
        {

        }





        /*private void GB1_Enter(object sender, EventArgs e)
        {
          
            
         
            
          
          

            }*/



    }
}
