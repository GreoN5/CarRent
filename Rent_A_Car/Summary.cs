using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt_Georgi_Dimitrov_1901682009
{
    public partial class Summary : Form
    {
        public bool radioButtonBankChecked
        {
            get { return EnterInformation.bank; }
            set { }
        }
        public bool radioButtonCashChecked
        {
            get { return EnterInformation.cash; }
            set { }
        }
        public bool radioButtonCreditCardChecked
        {
            get { return EnterInformation.card; }
            set { }
        }
        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            lblName.Text = EnterInformation.FirstName;
            lblFamily.Text = EnterInformation.Family;
            lblNumber.Text = EnterInformation.Number;

            if (EnterInformation.chains)
            {
                lblSnow.Text = "✓";
                lblSnow.Visible = true;
            }
            if (EnterInformation.chair)
            {
                lblChair.Text = "✓";
                lblChair.Visible = true;
            }
            if (EnterInformation.ski)
            {
                lblSki.Text = "✓";
                lblSki.Visible = true;
            }

            lblFinalPrice.Text = EnterInformation.priceSummary.ToString() + " lv.";

            if (radioButtonBankChecked == true)
            {
                lblPayment.Text = "Bank";
            }
            else if (radioButtonCashChecked == true)
            {
                lblPayment.Text = "In cash";
            }
            else if (radioButtonCreditCardChecked == true)
            {
                lblPayment.Text = "Credit Card";
            }
            else
            {
                lblPayment.Text = "There is no payment way chosen!";
            }

            lblModel.Text = EnterInformation.model;
            lblBrand.Text = EnterInformation.brand;

            switch (lblModel.Text)
            {
                case "A5":
                    pictureBoxFinal.Image = Properties.Resources.A5;
                    break;
                case "A6":
                    pictureBoxFinal.Image = Properties.Resources.A6;
                    break;
                case "A7":
                    pictureBoxFinal.Image = Properties.Resources.A7;
                    break;
                case "A8":
                    pictureBoxFinal.Image = Properties.Resources.A8;
                    break;
                case "Q7":
                    pictureBoxFinal.Image = Properties.Resources.Q7;
                    break;
                case "Q8":
                    pictureBoxFinal.Image = Properties.Resources.Q8;
                    break;
                case "S7":
                    pictureBoxFinal.Image = Properties.Resources.S7;
                    break;
                case "RS5":
                    pictureBoxFinal.Image = Properties.Resources.RS5;
                    break;
                case "RS6":
                    pictureBoxFinal.Image = Properties.Resources.RS6;
                    break;
                case "DB11":
                    pictureBoxFinal.Image = Properties.Resources.DB11;
                    break;
                case "V8 Vantage":
                    pictureBoxFinal.Image = Properties.Resources.V8_Vantage;
                    break;
                case "Continental":
                    pictureBoxFinal.Image = Properties.Resources.continental;
                    break;
                case "Flying Spur":
                    pictureBoxFinal.Image = Properties.Resources.flying_spur;
                    break;
                case "Mulsanne":
                    pictureBoxFinal.Image = Properties.Resources.mulsanne;
                    break;
                case "530":
                    pictureBoxFinal.Image = Properties.Resources.B530;
                    break;
                case "535":
                    pictureBoxFinal.Image = Properties.Resources.B535;
                    break;
                case "635":
                    pictureBoxFinal.Image = Properties.Resources.B635;
                    break;
                case "750":
                    pictureBoxFinal.Image = Properties.Resources.B750;
                    break;
                case "850":
                    pictureBoxFinal.Image = Properties.Resources.B850;
                    break;
                case "i8":
                    pictureBoxFinal.Image = Properties.Resources.i8;
                    break;
                case "M4":
                    pictureBoxFinal.Image = Properties.Resources.M4;
                    break;
                case "M5":
                    pictureBoxFinal.Image = Properties.Resources.M5;
                    break;
                case "Z4":
                    pictureBoxFinal.Image = Properties.Resources.Z4;
                    break;
                case "ATS":
                    pictureBoxFinal.Image = Properties.Resources.ATS;
                    break;
                case "CTS":
                    pictureBoxFinal.Image = Properties.Resources.CTS;
                    break;
                case "Deville":
                    pictureBoxFinal.Image = Properties.Resources.Deville;
                    break;
                case "Eldorado":
                    pictureBoxFinal.Image = Properties.Resources.Eldorado;
                    break;
                case "Fleetwood":
                    pictureBoxFinal.Image = Properties.Resources.Fleetwood;
                    break;
                case "Camaro":
                    pictureBoxFinal.Image = Properties.Resources.camaro;
                    break;
                case "C6":
                    pictureBoxFinal.Image = Properties.Resources.C6;
                    break;
                case "Challenger":
                    pictureBoxFinal.Image = Properties.Resources.challenger;
                    break;
                case "Charger":
                    pictureBoxFinal.Image = Properties.Resources.charger;
                    break;
                case "Durango":
                    pictureBoxFinal.Image = Properties.Resources.durango;
                    break;
                case "QX70":
                    pictureBoxFinal.Image = Properties.Resources.QX70;
                    break;
                case "Daimler":
                    pictureBoxFinal.Image = Properties.Resources.daimler;
                    break;
                case "E-Type":
                    pictureBoxFinal.Image = Properties.Resources.E_Type;
                    break;
                case "F-Type":
                    pictureBoxFinal.Image = Properties.Resources.F_Type;
                    break;
                case "Levante":
                    pictureBoxFinal.Image = Properties.Resources.Levante;
                    break;
                case "Ghibli":
                    pictureBoxFinal.Image = Properties.Resources.Ghibli;
                    break;
                case "Granturismo":
                    pictureBoxFinal.Image = Properties.Resources.Granturismo;
                    break;
                case "560":
                    pictureBoxFinal.Image = Properties.Resources.McLaren_560;
                    break;
                case "A250 AMG":
                    pictureBoxFinal.Image = Properties.Resources.A250_AMG;
                    break;
                case "C450 AMG":
                    pictureBoxFinal.Image = Properties.Resources.C450_AMG;
                    break;
                case "C63 AMG":
                    pictureBoxFinal.Image = Properties.Resources.C63_AMG;
                    break;
                case "CL63 AMG":
                    pictureBoxFinal.Image = Properties.Resources.CL63_AMG;
                    break;
                case "CLA45 AMG":
                    pictureBoxFinal.Image = Properties.Resources.CLA45_AMG;
                    break;
                case "CLA220":
                    pictureBoxFinal.Image = Properties.Resources.CLA220;
                    break;
                case "E63 AMG":
                    pictureBoxFinal.Image = Properties.Resources.E63_AMG;
                    break;
                case "G350":
                    pictureBoxFinal.Image = Properties.Resources.G350;
                    break;
                case "G500":
                    pictureBoxFinal.Image = Properties.Resources.G500;
                    break;
                case "GL63 AMG":
                    pictureBoxFinal.Image = Properties.Resources.GL63_AMG;
                    break;
                case "S65 AMG":
                    pictureBoxFinal.Image = Properties.Resources.S65_AMG;
                    break;
                case "S560":
                    pictureBoxFinal.Image = Properties.Resources.S560;
                    break;
                case "S600":
                    pictureBoxFinal.Image = Properties.Resources.S600;
                    break;
                case "911":
                    pictureBoxFinal.Image = Properties.Resources.P911;
                    break;
                case "924":
                    pictureBoxFinal.Image = Properties.Resources.P924;
                    break;
                case "Panamera":
                    pictureBoxFinal.Image = Properties.Resources.Panamera;
                    break;
                case "Cayenne":
                    pictureBoxFinal.Image = Properties.Resources.Cayenne;
                    break;
                case "Cayman":
                    pictureBoxFinal.Image = Properties.Resources.Cayman;
                    break;
                case "Cullinan":
                    pictureBoxFinal.Image = Properties.Resources.Cullinan;
                    break;
                case "Silver Shadow":
                    pictureBoxFinal.Image = Properties.Resources.Silver_Shadow;
                    break;
                case "Silver Dawn":
                    pictureBoxFinal.Image = Properties.Resources.Silver_Dawn;
                    break;
                case "Phantom":
                    pictureBoxFinal.Image = Properties.Resources.Phantom;
                    break;
                case "Outback":
                    pictureBoxFinal.Image = Properties.Resources.Outback;
                    break;
                case "WRX":
                    pictureBoxFinal.Image = Properties.Resources.WRX;
                    break;
                case "XV":
                    pictureBoxFinal.Image = Properties.Resources.XV;
                    break;
                case "Roadster":
                    pictureBoxFinal.Image = Properties.Resources.Roadster;
                    break;
                case "Model X":
                    pictureBoxFinal.Image = Properties.Resources.Model_X;
                    break;
                case "Model S":
                    pictureBoxFinal.Image = Properties.Resources.Model_S;
                    break;
                case "Model 3":
                    pictureBoxFinal.Image = Properties.Resources.Model_3;
                    break;
                case "Amarok":
                    pictureBoxFinal.Image = Properties.Resources.Amarok;
                    break;
                case "Arteon":
                    pictureBoxFinal.Image = Properties.Resources.Arteon;
                    break;
                case "Caravelle":
                    pictureBoxFinal.Image = Properties.Resources.Caravelle;
                    break;
                case "Corrado":
                    pictureBoxFinal.Image = Properties.Resources.Corrado;
                    break;
                case "Country":
                    pictureBoxFinal.Image = Properties.Resources.Country;
                    break;
                case "Golf VIII":
                    pictureBoxFinal.Image = Properties.Resources.Golf_8;
                    break;
                case "Passat B8":
                    pictureBoxFinal.Image = Properties.Resources.Passat_B8;
                    break;
                case "Passat Alltrack":
                    pictureBoxFinal.Image = Properties.Resources.Passat_Alltrack;
                    break;
                case "Passat CC":
                    pictureBoxFinal.Image = Properties.Resources.Passat_CC;
                    break;
                case "Phaeton":
                    pictureBoxFinal.Image = Properties.Resources.Phaeton;
                    break;
                case "Scirocco":
                    pictureBoxFinal.Image = Properties.Resources.Scirocco;
                    break;
                case "T-Cross":
                    pictureBoxFinal.Image = Properties.Resources.T_Cross;
                    break;
                case "T-Roc":
                    pictureBoxFinal.Image = Properties.Resources.T_Roc;
                    break;
                case "T5 Multivan":
                    pictureBoxFinal.Image = Properties.Resources.T5_Multivan;
                    break;
                case "Tiguan":
                    pictureBoxFinal.Image = Properties.Resources.Tiguan;
                    break;
                case "Touareg":
                    pictureBoxFinal.Image = Properties.Resources.Touareg;
                    break;
                default:
                    pictureBoxFinal.Image = null;
                    break;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
