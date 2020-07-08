namespace Proekt_Georgi_Dimitrov_1901682009
{
    partial class EnterInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.btnSaveToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.btnNewToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBoxName = new System.Windows.Forms.TextBox();
			this.txtBoxFamily = new System.Windows.Forms.TextBox();
			this.txtBoxNumber = new System.Windows.Forms.TextBox();
			this.comboBoxBrand = new System.Windows.Forms.ComboBox();
			this.comboBoxModel = new System.Windows.Forms.ComboBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.lblInfoCars = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.lblEquipmentPrice = new System.Windows.Forms.Label();
			this.lblDiscountInfo = new System.Windows.Forms.Label();
			this.checkedListBoxEquipment = new System.Windows.Forms.CheckedListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButtonCreditCard = new System.Windows.Forms.RadioButton();
			this.radioButtonBank = new System.Windows.Forms.RadioButton();
			this.radioButtonCash = new System.Windows.Forms.RadioButton();
			this.btnFinalPrice = new System.Windows.Forms.Button();
			this.lblFinalPrice = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblShowInfo = new System.Windows.Forms.Label();
			this.pictureBoxCars = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.PapayaWhip;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveToolStripMenu,
            this.btnNewToolStripMenu,
            this.closeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(700, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btnSaveToolStripMenu
			// 
			this.btnSaveToolStripMenu.Name = "btnSaveToolStripMenu";
			this.btnSaveToolStripMenu.Size = new System.Drawing.Size(43, 20);
			this.btnSaveToolStripMenu.Text = "Save";
			this.btnSaveToolStripMenu.Click += new System.EventHandler(this.btnSaveToolStripMenu_Click);
			// 
			// btnNewToolStripMenu
			// 
			this.btnNewToolStripMenu.Name = "btnNewToolStripMenu";
			this.btnNewToolStripMenu.Size = new System.Drawing.Size(43, 20);
			this.btnNewToolStripMenu.Text = "New";
			this.btnNewToolStripMenu.Click += new System.EventHandler(this.btnNewToolStripMenu_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "First Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Last Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Phone Number: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Brand:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Model:";
			// 
			// txtBoxName
			// 
			this.txtBoxName.Location = new System.Drawing.Point(86, 48);
			this.txtBoxName.Name = "txtBoxName";
			this.txtBoxName.Size = new System.Drawing.Size(145, 20);
			this.txtBoxName.TabIndex = 6;
			this.txtBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxName_KeyPress);
			// 
			// txtBoxFamily
			// 
			this.txtBoxFamily.Location = new System.Drawing.Point(87, 92);
			this.txtBoxFamily.Name = "txtBoxFamily";
			this.txtBoxFamily.Size = new System.Drawing.Size(145, 20);
			this.txtBoxFamily.TabIndex = 7;
			this.txtBoxFamily.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFamily_KeyPress);
			// 
			// txtBoxNumber
			// 
			this.txtBoxNumber.Location = new System.Drawing.Point(110, 136);
			this.txtBoxNumber.Name = "txtBoxNumber";
			this.txtBoxNumber.Size = new System.Drawing.Size(145, 20);
			this.txtBoxNumber.TabIndex = 8;
			this.txtBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNumber_KeyPress);
			// 
			// comboBoxBrand
			// 
			this.comboBoxBrand.FormattingEnabled = true;
			this.comboBoxBrand.Items.AddRange(new object[] {
            "Audi",
            "Aston Martin",
            "Bentley",
            "BMW",
            "Cadillac",
            "Chevrolet",
            "Corvette",
            "Dodge",
            "Infinity",
            "Jaguar",
            "Maserati",
            "McLaren",
            "Mercedes-Benz",
            "Porsche",
            "Rolls Royce",
            "Subaru",
            "Tesla",
            "VW"});
			this.comboBoxBrand.Location = new System.Drawing.Point(64, 182);
			this.comboBoxBrand.Name = "comboBoxBrand";
			this.comboBoxBrand.Size = new System.Drawing.Size(120, 21);
			this.comboBoxBrand.TabIndex = 9;
			this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
			// 
			// comboBoxModel
			// 
			this.comboBoxModel.FormattingEnabled = true;
			this.comboBoxModel.Location = new System.Drawing.Point(64, 227);
			this.comboBoxModel.Name = "comboBoxModel";
			this.comboBoxModel.Size = new System.Drawing.Size(120, 21);
			this.comboBoxModel.TabIndex = 10;
			this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(245, 235);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(27, 13);
			this.lblPrice.TabIndex = 12;
			this.lblPrice.Text = "0 lv.";
			// 
			// lblInfoCars
			// 
			this.lblInfoCars.AutoSize = true;
			this.lblInfoCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblInfoCars.Location = new System.Drawing.Point(20, 258);
			this.lblInfoCars.Name = "lblInfoCars";
			this.lblInfoCars.Size = new System.Drawing.Size(264, 16);
			this.lblInfoCars.TabIndex = 13;
			this.lblInfoCars.Text = "The price on the car loan is for 1 day!";
			this.lblInfoCars.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblDiscount);
			this.groupBox1.Controls.Add(this.lblEquipmentPrice);
			this.groupBox1.Controls.Add(this.lblDiscountInfo);
			this.groupBox1.Controls.Add(this.checkedListBoxEquipment);
			this.groupBox1.Location = new System.Drawing.Point(405, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(281, 155);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Additional Equipment";
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblDiscount.ForeColor = System.Drawing.Color.Red;
			this.lblDiscount.Location = new System.Drawing.Point(68, 137);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(149, 15);
			this.lblDiscount.TabIndex = 16;
			this.lblDiscount.Text = "You get 10% discount!";
			this.lblDiscount.Visible = false;
			// 
			// lblEquipmentPrice
			// 
			this.lblEquipmentPrice.AutoSize = true;
			this.lblEquipmentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblEquipmentPrice.Location = new System.Drawing.Point(122, 111);
			this.lblEquipmentPrice.Name = "lblEquipmentPrice";
			this.lblEquipmentPrice.Size = new System.Drawing.Size(32, 13);
			this.lblEquipmentPrice.TabIndex = 15;
			this.lblEquipmentPrice.Text = "0 lv.";
			// 
			// lblDiscountInfo
			// 
			this.lblDiscountInfo.AutoSize = true;
			this.lblDiscountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblDiscountInfo.ForeColor = System.Drawing.Color.Red;
			this.lblDiscountInfo.Location = new System.Drawing.Point(44, 71);
			this.lblDiscountInfo.Name = "lblDiscountInfo";
			this.lblDiscountInfo.Size = new System.Drawing.Size(194, 30);
			this.lblDiscountInfo.TabIndex = 1;
			this.lblDiscountInfo.Text = "If you get the third equipment\r\n   you will get 10% discount!";
			this.lblDiscountInfo.Visible = false;
			// 
			// checkedListBoxEquipment
			// 
			this.checkedListBoxEquipment.FormattingEnabled = true;
			this.checkedListBoxEquipment.Items.AddRange(new object[] {
            "ski rack",
            "snow chains",
            "child chair"});
			this.checkedListBoxEquipment.Location = new System.Drawing.Point(81, 19);
			this.checkedListBoxEquipment.Name = "checkedListBoxEquipment";
			this.checkedListBoxEquipment.Size = new System.Drawing.Size(114, 49);
			this.checkedListBoxEquipment.TabIndex = 0;
			this.checkedListBoxEquipment.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxEquipment_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButtonCreditCard);
			this.groupBox2.Controls.Add(this.radioButtonBank);
			this.groupBox2.Controls.Add(this.radioButtonCash);
			this.groupBox2.Location = new System.Drawing.Point(423, 202);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(263, 86);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Начин на плащане:";
			// 
			// radioButtonCreditCard
			// 
			this.radioButtonCreditCard.AutoSize = true;
			this.radioButtonCreditCard.Location = new System.Drawing.Point(100, 55);
			this.radioButtonCreditCard.Name = "radioButtonCreditCard";
			this.radioButtonCreditCard.Size = new System.Drawing.Size(77, 17);
			this.radioButtonCreditCard.TabIndex = 2;
			this.radioButtonCreditCard.TabStop = true;
			this.radioButtonCreditCard.Text = "Credit Card";
			this.radioButtonCreditCard.UseVisualStyleBackColor = true;
			this.radioButtonCreditCard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonCreditCard_MouseClick);
			// 
			// radioButtonBank
			// 
			this.radioButtonBank.AutoSize = true;
			this.radioButtonBank.Location = new System.Drawing.Point(196, 26);
			this.radioButtonBank.Name = "radioButtonBank";
			this.radioButtonBank.Size = new System.Drawing.Size(50, 17);
			this.radioButtonBank.TabIndex = 1;
			this.radioButtonBank.TabStop = true;
			this.radioButtonBank.Text = "Bank";
			this.radioButtonBank.UseVisualStyleBackColor = true;
			this.radioButtonBank.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonBank_MouseClick);
			// 
			// radioButtonCash
			// 
			this.radioButtonCash.AutoSize = true;
			this.radioButtonCash.Location = new System.Drawing.Point(23, 26);
			this.radioButtonCash.Name = "radioButtonCash";
			this.radioButtonCash.Size = new System.Drawing.Size(60, 17);
			this.radioButtonCash.TabIndex = 0;
			this.radioButtonCash.TabStop = true;
			this.radioButtonCash.Text = "In cash";
			this.radioButtonCash.UseVisualStyleBackColor = true;
			this.radioButtonCash.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonCash_MouseClick);
			// 
			// btnFinalPrice
			// 
			this.btnFinalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnFinalPrice.Location = new System.Drawing.Point(446, 294);
			this.btnFinalPrice.Name = "btnFinalPrice";
			this.btnFinalPrice.Size = new System.Drawing.Size(129, 52);
			this.btnFinalPrice.TabIndex = 16;
			this.btnFinalPrice.Text = "Calculate final price";
			this.btnFinalPrice.UseVisualStyleBackColor = false;
			this.btnFinalPrice.Click += new System.EventHandler(this.btnFinalPrice_Click);
			// 
			// lblFinalPrice
			// 
			this.lblFinalPrice.AutoSize = true;
			this.lblFinalPrice.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblFinalPrice.Location = new System.Drawing.Point(590, 304);
			this.lblFinalPrice.Name = "lblFinalPrice";
			this.lblFinalPrice.Size = new System.Drawing.Size(53, 27);
			this.lblFinalPrice.TabIndex = 17;
			this.lblFinalPrice.Text = "0 lv.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(195, 233);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 15);
			this.label6.TabIndex = 18;
			this.label6.Text = "Price:";
			// 
			// lblShowInfo
			// 
			this.lblShowInfo.AutoSize = true;
			this.lblShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblShowInfo.Location = new System.Drawing.Point(423, 361);
			this.lblShowInfo.Name = "lblShowInfo";
			this.lblShowInfo.Size = new System.Drawing.Size(246, 75);
			this.lblShowInfo.TabIndex = 19;
			this.lblShowInfo.Text = "You pay the price written above\r\nonly the first day of the rent!\r\nThe remainig ti" +
    "me of the rent you\r\npay only the price of the car for a day!\r\n\r\n";
			this.lblShowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblShowInfo.Visible = false;
			// 
			// pictureBoxCars
			// 
			this.pictureBoxCars.InitialImage = global::Proekt_Georgi_Dimitrov_1901682009.Properties.Resources.T5_Multivan;
			this.pictureBoxCars.Location = new System.Drawing.Point(23, 283);
			this.pictureBoxCars.Name = "pictureBoxCars";
			this.pictureBoxCars.Size = new System.Drawing.Size(310, 160);
			this.pictureBoxCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxCars.TabIndex = 11;
			this.pictureBoxCars.TabStop = false;
			// 
			// EnterInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 445);
			this.Controls.Add(this.lblShowInfo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblFinalPrice);
			this.Controls.Add(this.btnFinalPrice);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblInfoCars);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.pictureBoxCars);
			this.Controls.Add(this.comboBoxModel);
			this.Controls.Add(this.comboBoxBrand);
			this.Controls.Add(this.txtBoxNumber);
			this.Controls.Add(this.txtBoxFamily);
			this.Controls.Add(this.txtBoxName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "EnterInformation";
			this.Text = "Enter Information";
			this.Load += new System.EventHandler(this.EnterInformation_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSaveToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem btnNewToolStripMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxFamily;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.PictureBox pictureBoxCars;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInfoCars;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxEquipment;
        private System.Windows.Forms.Label lblDiscountInfo;
        private System.Windows.Forms.Label lblEquipmentPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonCreditCard;
        private System.Windows.Forms.RadioButton radioButtonBank;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.Button btnFinalPrice;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblShowInfo;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
	}
}