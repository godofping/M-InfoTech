using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class BackPhase : Form
    {
        public BackPhase()
        {
            InitializeComponent();
        }

        private void BackPhase_Load(object sender, EventArgs e)
        {

            lblln.Text = FrontPhase.SetValueForText1;
            lblfn.Text = FrontPhase.SetValueForText2;
            lblmn.Text = FrontPhase.SetValueForText3;
            lblp.Text = FrontPhase.SetValueForText4;
            lblrw.Text = FrontPhase.SetValueForText5;
            lbltax.Text = FrontPhase.SetValueForText6;
            lblsss.Text = FrontPhase.SetValueForText7;
            lblgsis.Text = FrontPhase.SetValueForText8;
            lblpgbg.Text = FrontPhase.SetValueForText9;
            lblphlhlth.Text = FrontPhase.SetValueForText10;
            lblothr.Text = FrontPhase.SetValueForText11;
            lbltnhp.Text = FrontPhase.SetValueForText12;

            lblwb.Text = FrontPhase.SetValueForText13;
            lbleb.Text = FrontPhase.SetValueForText14;
            lblgcry.Text = FrontPhase.SetValueForText15;
            lblcontgncy.Text = FrontPhase.SetValueForText16;
            lbloverall.Text = FrontPhase.SetValueForText17;
        }
    }
}
