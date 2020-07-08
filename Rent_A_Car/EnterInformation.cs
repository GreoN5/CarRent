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
    public partial class EnterInformation : Form
    {
        public static string FirstName;
        public static string Family;
        public static string Number;
        public static int price = 0;
        public static int priceEquipment = 0;
        public static float priceSummary = 0;
        public static string brand;
        public static string model;
        public static bool card = false;
        public static bool cash = false;
        public static bool bank = false;
        public static bool chains;
        public static bool ski;
        public static bool chair;

        public EnterInformation()
        {
            InitializeComponent();
        }

        private void EnterInformation_Load(object sender, EventArgs e)
        {
            txtBoxNumber.MaxLength = 10;
        }

        private void txtBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Enter && e.KeyChar != (Char)Keys.Back && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxFamily_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Enter && e.KeyChar != (Char)Keys.Back && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Enter && e.KeyChar != (Char)Keys.Back && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxBrand.SelectedItem)
            {
                case "Audi":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("A5");
                    comboBoxModel.Items.Add("A6");
                    comboBoxModel.Items.Add("A7");
                    comboBoxModel.Items.Add("A8");
                    comboBoxModel.Items.Add("Q7");
                    comboBoxModel.Items.Add("Q8");
                    comboBoxModel.Items.Add("S7");
                    comboBoxModel.Items.Add("RS5");
                    comboBoxModel.Items.Add("RS6");
                    break;

                case "Aston Martin":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("DB11");
                    comboBoxModel.Items.Add("V8 Vantage");
                    break;

                case "Bentley":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Continental");
                    comboBoxModel.Items.Add("Flying Spur");
                    comboBoxModel.Items.Add("Mulsanne");
                    break;

                case "BMW":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("530");
                    comboBoxModel.Items.Add("535");
                    comboBoxModel.Items.Add("635");
                    comboBoxModel.Items.Add("750");
                    comboBoxModel.Items.Add("850");
                    comboBoxModel.Items.Add("i8");
                    comboBoxModel.Items.Add("M4");
                    comboBoxModel.Items.Add("M5");
                    comboBoxModel.Items.Add("Z4");
                    break;

                case "Cadillac":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("ATS");
                    comboBoxModel.Items.Add("CTS");
                    comboBoxModel.Items.Add("Deville");
                    comboBoxModel.Items.Add("Eldorado");
                    comboBoxModel.Items.Add("Fleetwood");
                    break;

                case "Chevrolet":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Camaro");
                    break;

                case "Corvette":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("C6");
                    break;

                case "Dodge":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Challenger");
                    comboBoxModel.Items.Add("Charger");
                    comboBoxModel.Items.Add("Durango");
                    break;

                case "Infinity":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("QX70");
                    break;

                case "Jaguar":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Daimler");
                    comboBoxModel.Items.Add("E-type");
                    comboBoxModel.Items.Add("F-type");
                    break;

                case "Maserati":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Levante");
                    comboBoxModel.Items.Add("Ghibli");
                    comboBoxModel.Items.Add("Granturismo");
                    break;

                case "McLaren":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("560");
                    break;

                case "Mercedes-Benz":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("A250 AMG");
                    comboBoxModel.Items.Add("C450 AMG");
                    comboBoxModel.Items.Add("C63 AMG");
                    comboBoxModel.Items.Add("CL63 AMG");
                    comboBoxModel.Items.Add("CLA45 AMG");
                    comboBoxModel.Items.Add("CLA220");
                    comboBoxModel.Items.Add("E63 AMG");
                    comboBoxModel.Items.Add("G350");
                    comboBoxModel.Items.Add("G500");
                    comboBoxModel.Items.Add("GL63 AMG");
                    comboBoxModel.Items.Add("S65 AMG");
                    comboBoxModel.Items.Add("S560");
                    comboBoxModel.Items.Add("S600");
                    break;

                case "Porsche":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("911");
                    comboBoxModel.Items.Add("924");
                    comboBoxModel.Items.Add("Panamera");
                    comboBoxModel.Items.Add("Cayenne");
                    comboBoxModel.Items.Add("Cayman");
                    break;

                case "Rolls Royce":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Cullinan");
                    comboBoxModel.Items.Add("Silver Shadow");
                    comboBoxModel.Items.Add("Silver Dawn");
                    comboBoxModel.Items.Add("Phantom");
                    break;

                case "Subaru":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Outback");
                    comboBoxModel.Items.Add("WRX");
                    comboBoxModel.Items.Add("XV");
                    break;

                case "Tesla":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Roadster");
                    comboBoxModel.Items.Add("Model 3");
                    comboBoxModel.Items.Add("Model X");
                    comboBoxModel.Items.Add("Model S");
                    break;

                case "VW":
                    comboBoxModel.Items.Clear();
                    comboBoxModel.Items.Add("Amarok");
                    comboBoxModel.Items.Add("Arteon");
                    comboBoxModel.Items.Add("Caravelle");
                    comboBoxModel.Items.Add("Corado");
                    comboBoxModel.Items.Add("Country");
                    comboBoxModel.Items.Add("Golf VIII");
                    comboBoxModel.Items.Add("Passat B8");
                    comboBoxModel.Items.Add("Passat Alltrack");
                    comboBoxModel.Items.Add("Passat CC");
                    comboBoxModel.Items.Add("Phaeton");
                    comboBoxModel.Items.Add("Scirocco");
                    comboBoxModel.Items.Add("T-Cross");
                    comboBoxModel.Items.Add("T-Roc");
                    comboBoxModel.Items.Add("T5 Multivan");
                    comboBoxModel.Items.Add("Tiguan");
                    comboBoxModel.Items.Add("Touareg");
                    break;
                default:
                    comboBoxModel.Items.Clear();
                    break;
            }
            brand = comboBoxBrand.SelectedItem.ToString();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxModel.SelectedItem)
            {
                case "A5":
                    price = 60;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.A5;
                    break;
                case "A6":
                    price = 50;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.A6;
                    break;
                case "A7":
                    price = 58;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.A7;
                    break;
                case "A8":
                    price = 45;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.A8;
                    break;
                case "Q7":
                    price = 36;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Q7;
                    break;
                case "Q8":
                    price = 49;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Q8;
                    break;
                case "S7":
                    price = 67;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.S7;
                    break;
                case "RS5":
                    price = 60;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.RS5;
                    break;
                case "RS6":
                    price = 73;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.RS6;
                    break;
                case "DB11":
                    price = 70;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.DB11;
                    break;
                case "V8 Vantage":
                    price = 72;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.V8_Vantage;
                    break;
                case "Continental":
                    price = 64;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.continental;
                    break;
                case "Flying Spur":
                    price = 89;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.flying_spur;
                    break;
                case "Mulsanne":
                    price = 78;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.mulsanne;
                    break;
                case "530":
                    price = 45;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.B530;
                    break;
                case "535":
                    price = 50;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.B535;
                    break;
                case "635":
                    price = 54;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.B635;
                    break;
                case "750":
                    price = 71;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.B750;
                    break;
                case "850":
                    price = 80;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.B850;
                    break;
                case "i8":
                    price = 150;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.i8;
                    break;
                case "M4":
                    price = 80;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.M4;
                    break;
                case "M5":
                    price = 90;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.M5;
                    break;
                case "Z4":
                    price = 85;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Z4;
                    break;
                case "ATS":
                    price = 68;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.ATS;
                    break;
                case "CTS":
                    price = 70;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.CTS;
                    break;
                case "Deville":
                    price = 86;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Deville;
                    break;
                case "Eldorado":
                    price = 84;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Eldorado;
                    break;
                case "Fleetwood":
                    price = 100;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Fleetwood;
                    break;
                case "Camaro":
                    price = 90;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.camaro;
                    break;
                case "C6":
                    price = 80;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.C6;
                    break;
                case "Challenger":
                    price = 100;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.challenger;
                    break;
                case "Charger":
                    price = 120;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.charger;
                    break;
                case "Durango":
                    price = 80;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.durango;
                    break;
                case "QX70":
                    price = 40;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.QX70;
                    break;
                case "Daimler":
                    price = 57;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.daimler;
                    break;
                case "E-type":
                    price = 75;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.E_Type;
                    break;
                case "F-type":
                    price = 96;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.F_Type;
                    break;
                case "Levante":
                    price = 86;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Levante;
                    break;
                case "Ghibli":
                    price = 90;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Ghibli;
                    break;
                case "Granturismo":
                    price = 114;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Granturismo;
                    break;
                case "560":
                    price = 142;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.McLaren_560;
                    break;
                case "A250 AMG":
                    price = 78;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.A250_AMG;
                    break;
                case "C450 AMG":
                    price = 50;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.C450_AMG;
                    break;
                case "C63 AMG":
                    price = 90;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.C63_AMG;
                    break;
                case "CL63 AMG":
                    price = 91;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.CL63_AMG;
                    break;
                case "CLA45 AMG":
                    price = 89;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.CLA45_AMG;
                    break;
                case "CLA220":
                    price = 60;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.CLA220;
                    break;
                case "E63 AMG":
                    price = 90;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.E63_AMG;
                    break;
                case "G350":
                    price = 90;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.G350;
                    break;
                case "G500":
                    price = 130;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.G500;
                    break;
                case "GL63 AMG":
                    price = 87;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.GL63_AMG;
                    break;
                case "S65 AMG":
                    price = 120;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.S65_AMG;
                    break;
                case "S560":
                    price = 97;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.S560;
                    break;
                case "S600":
                    price = 124;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.S600;
                    break;
                case "911":
                    price = 98;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.P911;
                    break;
                case "924":
                    price = 106;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.P924;
                    break;
                case "Panamera":
                    price = 110;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Panamera;
                    break;
                case "Cayenne":
                    price = 90;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Cayenne;
                    break;
                case "Cayman":
                    price = 89;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Cayman;
                    break;
                case "Cullinan":
                    price = 100;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Cullinan;
                    break;
                case "Silver Shadow":
                    price = 96;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Silver_Shadow;
                    break;
                case "Silver Dawn":
                    price = 110;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Silver_Dawn;
                    break;
                case "Phantom":
                    price = 140;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Phantom;
                    break;
                case "Outback":
                    price = 60;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Outback;
                    break;
                case "WRX":
                    price = 80;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.WRX;
                    break;
                case "XV":
                    price = 50;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.XV;
                    break;
                case "Roadster":
                    price = 50;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Roadster;
                    break;
                case "Model X":
                    price = 55;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Model_X;
                    break;
                case "Model S":
                    price = 50;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Model_S;
                    break;
                case "Model 3":
                    price = 45;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Model_3;
                    break;
                case "Amarok":
                    price = 60;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Amarok;
                    break;
                case "Arteon":
                    price = 70;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Arteon;
                    break;
                case "Caravelle":
                    price = 50;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Caravelle;
                    break;
                case "Corado":
                    price = 40;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Corrado;
                    break;
                case "Country":
                    price = 40;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Country;
                    break;
                case "Golf VIII":
                    price = 50;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Golf_8;
                    break;
                case "Passat B8":
                    price = 60;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Passat_B8;
                    break;
                case "Passat Alltrack":
                    price = 62;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Passat_Alltrack;
                    break;
                case "Passat CC":
                    price = 65;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Passat_CC;
                    break;
                case "Phaeton":
                    price = 76;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Phaeton;
                    break;
                case "Scirocco":
                    price = 50;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Scirocco;
                    break;
                case "T-Cross":
                    price = 50;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.T_Cross;
                    break;
                case "T-Roc":
                    price = 50;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.T_Roc;
                    break;
                case "T5 Multivan":
                    price = 54;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.T5_Multivan;
                    break;
                case "Tiguan":
                    price = 54;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Tiguan;
                    break;
                case "Touareg":
                    price = 60;
                    lblPrice.Text = price + " lv.";
                    lblInfoCars.Visible = true;
                    pictureBoxCars.Image = Properties.Resources.Touareg;
                    break;
                default:
                    lblPrice.Text = "0 lv.";
                    lblInfoCars.Visible = false;
                    pictureBoxCars.Image = null;
                    break;
            }
            model = comboBoxModel.SelectedItem.ToString();
        }

        private void checkedListBoxEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int priceForEquipment = 0;

            if (checkedListBoxEquipment.CheckedItems.Count.Equals(2))
            {
                lblDiscountInfo.Visible = true;
                lblDiscount.Visible = false;
            }
            else if (checkedListBoxEquipment.CheckedItems.Count.Equals(3))
            {             
                lblDiscountInfo.Visible = false;
                lblDiscount.Visible = true;
            }
            else
            {
                lblDiscountInfo.Visible = false;
                lblDiscount.Visible = false;
            }


            if (checkedListBoxEquipment.GetItemChecked(0))
            {
                priceForEquipment = priceForEquipment + 200;
                lblEquipmentPrice.Text = priceForEquipment.ToString() + " lv.";
            }
            if (checkedListBoxEquipment.GetItemChecked(1))
            {
                priceForEquipment = priceForEquipment + 100;
                lblEquipmentPrice.Text = priceForEquipment.ToString() + " lv.";
            }
            if (checkedListBoxEquipment.GetItemChecked(2))
            {
                priceForEquipment = priceForEquipment + 90;
                lblEquipmentPrice.Text = priceForEquipment.ToString() + " lv.";
            }
        }

        private void radioButtonCash_MouseClick(object sender, MouseEventArgs e)
        {
            cash = true;
            radioButtonCash.Checked = cash;
        }

        private void radioButtonBank_MouseClick(object sender, MouseEventArgs e)
        {
            bank = true;
            radioButtonBank.Checked = bank;
        }

        private void radioButtonCreditCard_MouseClick(object sender, MouseEventArgs e)
        {
            card = true;
            radioButtonCreditCard.Checked = card;
        }

        private void btnFinalPrice_Click(object sender, EventArgs e)
        {
            if (checkedListBoxEquipment.GetItemChecked(0))
            {
                priceEquipment = priceEquipment + 200;
                lblEquipmentPrice.Text = priceEquipment.ToString() + " lv.";
            }

            if (checkedListBoxEquipment.GetItemChecked(1))
            {
                priceEquipment = priceEquipment + 100;
                lblEquipmentPrice.Text = priceEquipment.ToString() + " lv.";
            }
            if (checkedListBoxEquipment.GetItemChecked(2))
            {
                priceEquipment = priceEquipment + 90;
                lblEquipmentPrice.Text = priceEquipment.ToString() + " lv.";
            }

            priceSummary = price + priceEquipment;
            if (checkedListBoxEquipment.GetItemChecked(0) && 
                checkedListBoxEquipment.GetItemChecked(1) && 
                checkedListBoxEquipment.GetItemChecked(2))
            {
                priceSummary = priceSummary - (priceSummary * 0.1f);
            }
            lblFinalPrice.Text = priceSummary.ToString() + " lv.";

            if (checkedListBoxEquipment.GetItemChecked(0) || 
                checkedListBoxEquipment.GetItemChecked(1) || 
                checkedListBoxEquipment.GetItemChecked(2))
            {
                lblShowInfo.Visible = true;
            }
            else
            {
                lblShowInfo.Visible = false;
            }
        }

        private void btnSaveToolStripMenu_Click(object sender, EventArgs e)
        {
            FirstName = txtBoxName.Text;
            Family = txtBoxFamily.Text;
            Number = txtBoxNumber.Text;

            if (txtBoxNumber.Text.Length != 10)
            {
                MessageBox.Show("Please enter a valid phone number!",
                                "Invalid phone number",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            if (comboBoxModel.SelectedItem == null || 
                comboBoxBrand.SelectedItem == null ||
                comboBoxBrand.Text == "" ||
                comboBoxModel.Text == "")
            {
                MessageBox.Show("Please choose brand or model!",
                                "You did not choose brand or model",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return;
            }

            radioButtonCreditCard.Checked = card;
            radioButtonCash.Checked = cash;
            radioButtonBank.Checked = bank;
            
            chains = checkedListBoxEquipment.GetItemChecked(0);
            ski = checkedListBoxEquipment.GetItemChecked(1);
            chair = checkedListBoxEquipment.GetItemChecked(2);

            Summary s = new Summary();
            s.ShowDialog();
        }

        private void btnNewToolStripMenu_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = " ";
            txtBoxFamily.Text = " ";
            txtBoxNumber.Text = " ";
            lblDiscount.Visible = false;
            lblDiscountInfo.Visible = false;
            lblInfoCars.Visible = false;
            lblPrice.Text = 0 + " lv.";
            lblFinalPrice.Text = 0 + " lv.";
            lblEquipmentPrice.Text = 0 + " lv.";
            price = 0;
            priceEquipment = 0;
            priceSummary = 0;
            foreach (int i in checkedListBoxEquipment.CheckedIndices)
            {
                checkedListBoxEquipment.SetItemCheckState(i, CheckState.Unchecked);
            }
            model = " ";
            brand = " ";
            card = false;
            bank = false;
            cash = false;
            radioButtonBank.Checked = false;
            radioButtonCash.Checked = false;
            radioButtonCreditCard.Checked = false;
            pictureBoxCars.Image = null;
            comboBoxBrand.Text = "";
            comboBoxModel.Text = "";
            lblShowInfo.Visible = false;
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
