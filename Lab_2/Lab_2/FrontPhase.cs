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
    }
}
