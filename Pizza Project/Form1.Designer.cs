namespace Pizza_Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.grp_Size = new System.Windows.Forms.GroupBox();
            this.rdb_Size_Large = new System.Windows.Forms.RadioButton();
            this.rdb_Size_Med = new System.Windows.Forms.RadioButton();
            this.rdb_Size_Small = new System.Windows.Forms.RadioButton();
            this.grp_Toppers = new System.Windows.Forms.GroupBox();
            this.ckb_Toppings_Green_Peppers = new System.Windows.Forms.CheckBox();
            this.ckb_Toppings_Olives = new System.Windows.Forms.CheckBox();
            this.ckb_Toppings_Onion = new System.Windows.Forms.CheckBox();
            this.ckb_Toppings_Tomatoes = new System.Windows.Forms.CheckBox();
            this.ckb_Toppings_Mashrooms = new System.Windows.Forms.CheckBox();
            this.ckb_Toppings_Extra_Chees = new System.Windows.Forms.CheckBox();
            this.grp_Cust = new System.Windows.Forms.GroupBox();
            this.rdb_Cust_Think = new System.Windows.Forms.RadioButton();
            this.rdb_Cust_Then = new System.Windows.Forms.RadioButton();
            this.grp_Place = new System.Windows.Forms.GroupBox();
            this.rdb_Plase_Out = new System.Windows.Forms.RadioButton();
            this.rdb_Plase_In = new System.Windows.Forms.RadioButton();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Rest_Form = new System.Windows.Forms.Button();
            this.grp_Order_Summary = new System.Windows.Forms.GroupBox();
            this.lbl_Where_To_Eat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Eat_Place = new System.Windows.Forms.Label();
            this.lbl_Cust_Type = new System.Windows.Forms.Label();
            this.lbl_Total_Price_Number = new System.Windows.Forms.Label();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.lbl_Toppings_Answere = new System.Windows.Forms.Label();
            this.lbl_Size_Answere = new System.Windows.Forms.Label();
            this.lbl_Toppings = new System.Windows.Forms.Label();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.grp_Size.SuspendLayout();
            this.grp_Toppers.SuspendLayout();
            this.grp_Cust.SuspendLayout();
            this.grp_Place.SuspendLayout();
            this.grp_Order_Summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(312, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grp_Size
            // 
            this.grp_Size.Controls.Add(this.rdb_Size_Large);
            this.grp_Size.Controls.Add(this.rdb_Size_Med);
            this.grp_Size.Controls.Add(this.rdb_Size_Small);
            this.grp_Size.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Size.Location = new System.Drawing.Point(37, 158);
            this.grp_Size.Name = "grp_Size";
            this.grp_Size.Size = new System.Drawing.Size(190, 242);
            this.grp_Size.TabIndex = 1;
            this.grp_Size.TabStop = false;
            this.grp_Size.Text = "Size";
            this.grp_Size.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdb_Size_Large
            // 
            this.rdb_Size_Large.AutoSize = true;
            this.rdb_Size_Large.Location = new System.Drawing.Point(23, 140);
            this.rdb_Size_Large.Name = "rdb_Size_Large";
            this.rdb_Size_Large.Size = new System.Drawing.Size(67, 21);
            this.rdb_Size_Large.TabIndex = 2;
            this.rdb_Size_Large.TabStop = true;
            this.rdb_Size_Large.Tag = "15";
            this.rdb_Size_Large.Text = "Large";
            this.rdb_Size_Large.UseVisualStyleBackColor = true;
            this.rdb_Size_Large.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdb_Size_Med
            // 
            this.rdb_Size_Med.AutoSize = true;
            this.rdb_Size_Med.Location = new System.Drawing.Point(23, 96);
            this.rdb_Size_Med.Name = "rdb_Size_Med";
            this.rdb_Size_Med.Size = new System.Drawing.Size(87, 21);
            this.rdb_Size_Med.TabIndex = 1;
            this.rdb_Size_Med.TabStop = true;
            this.rdb_Size_Med.Tag = "12";
            this.rdb_Size_Med.Text = "Meduim";
            this.rdb_Size_Med.UseVisualStyleBackColor = true;
            this.rdb_Size_Med.CheckedChanged += new System.EventHandler(this.rdb_Size_Med_CheckedChanged);
            // 
            // rdb_Size_Small
            // 
            this.rdb_Size_Small.AutoSize = true;
            this.rdb_Size_Small.Location = new System.Drawing.Point(23, 48);
            this.rdb_Size_Small.Name = "rdb_Size_Small";
            this.rdb_Size_Small.Size = new System.Drawing.Size(67, 21);
            this.rdb_Size_Small.TabIndex = 0;
            this.rdb_Size_Small.TabStop = true;
            this.rdb_Size_Small.Tag = "10";
            this.rdb_Size_Small.Text = "Small";
            this.rdb_Size_Small.UseVisualStyleBackColor = true;
            this.rdb_Size_Small.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grp_Toppers
            // 
            this.grp_Toppers.Controls.Add(this.ckb_Toppings_Green_Peppers);
            this.grp_Toppers.Controls.Add(this.ckb_Toppings_Olives);
            this.grp_Toppers.Controls.Add(this.ckb_Toppings_Onion);
            this.grp_Toppers.Controls.Add(this.ckb_Toppings_Tomatoes);
            this.grp_Toppers.Controls.Add(this.ckb_Toppings_Mashrooms);
            this.grp_Toppers.Controls.Add(this.ckb_Toppings_Extra_Chees);
            this.grp_Toppers.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Toppers.Location = new System.Drawing.Point(367, 158);
            this.grp_Toppers.Name = "grp_Toppers";
            this.grp_Toppers.Size = new System.Drawing.Size(378, 220);
            this.grp_Toppers.TabIndex = 2;
            this.grp_Toppers.TabStop = false;
            this.grp_Toppers.Text = "Toppings";
            // 
            // ckb_Toppings_Green_Peppers
            // 
            this.ckb_Toppings_Green_Peppers.AutoSize = true;
            this.ckb_Toppings_Green_Peppers.Location = new System.Drawing.Point(185, 138);
            this.ckb_Toppings_Green_Peppers.Name = "ckb_Toppings_Green_Peppers";
            this.ckb_Toppings_Green_Peppers.Size = new System.Drawing.Size(136, 21);
            this.ckb_Toppings_Green_Peppers.TabIndex = 5;
            this.ckb_Toppings_Green_Peppers.Tag = "2";
            this.ckb_Toppings_Green_Peppers.Text = "Green Peppers";
            this.ckb_Toppings_Green_Peppers.UseVisualStyleBackColor = true;
            this.ckb_Toppings_Green_Peppers.CheckedChanged += new System.EventHandler(this.ckb_Toppings_Green_Peppers_CheckedChanged);
            // 
            // ckb_Toppings_Olives
            // 
            this.ckb_Toppings_Olives.AutoSize = true;
            this.ckb_Toppings_Olives.Location = new System.Drawing.Point(185, 97);
            this.ckb_Toppings_Olives.Name = "ckb_Toppings_Olives";
            this.ckb_Toppings_Olives.Size = new System.Drawing.Size(74, 21);
            this.ckb_Toppings_Olives.TabIndex = 4;
            this.ckb_Toppings_Olives.Tag = "3";
            this.ckb_Toppings_Olives.Text = "Olives";
            this.ckb_Toppings_Olives.UseVisualStyleBackColor = true;
            this.ckb_Toppings_Olives.CheckedChanged += new System.EventHandler(this.ckb_Toppings_Olives_CheckedChanged);
            // 
            // ckb_Toppings_Onion
            // 
            this.ckb_Toppings_Onion.AutoSize = true;
            this.ckb_Toppings_Onion.Location = new System.Drawing.Point(185, 46);
            this.ckb_Toppings_Onion.Name = "ckb_Toppings_Onion";
            this.ckb_Toppings_Onion.Size = new System.Drawing.Size(73, 21);
            this.ckb_Toppings_Onion.TabIndex = 3;
            this.ckb_Toppings_Onion.Tag = "2";
            this.ckb_Toppings_Onion.Text = "Onion";
            this.ckb_Toppings_Onion.UseVisualStyleBackColor = true;
            this.ckb_Toppings_Onion.CheckedChanged += new System.EventHandler(this.ckb_Toppings_Onion_CheckedChanged);
            // 
            // ckb_Toppings_Tomatoes
            // 
            this.ckb_Toppings_Tomatoes.AutoSize = true;
            this.ckb_Toppings_Tomatoes.Location = new System.Drawing.Point(24, 141);
            this.ckb_Toppings_Tomatoes.Name = "ckb_Toppings_Tomatoes";
            this.ckb_Toppings_Tomatoes.Size = new System.Drawing.Size(100, 21);
            this.ckb_Toppings_Tomatoes.TabIndex = 2;
            this.ckb_Toppings_Tomatoes.Tag = "1";
            this.ckb_Toppings_Tomatoes.Text = "Tomatoes";
            this.ckb_Toppings_Tomatoes.UseVisualStyleBackColor = true;
            this.ckb_Toppings_Tomatoes.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ckb_Toppings_Mashrooms
            // 
            this.ckb_Toppings_Mashrooms.AutoSize = true;
            this.ckb_Toppings_Mashrooms.Location = new System.Drawing.Point(24, 97);
            this.ckb_Toppings_Mashrooms.Name = "ckb_Toppings_Mashrooms";
            this.ckb_Toppings_Mashrooms.Size = new System.Drawing.Size(116, 21);
            this.ckb_Toppings_Mashrooms.TabIndex = 1;
            this.ckb_Toppings_Mashrooms.Tag = "2";
            this.ckb_Toppings_Mashrooms.Text = "Mushrooms";
            this.ckb_Toppings_Mashrooms.UseVisualStyleBackColor = true;
            this.ckb_Toppings_Mashrooms.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckb_Toppings_Extra_Chees
            // 
            this.ckb_Toppings_Extra_Chees.AutoSize = true;
            this.ckb_Toppings_Extra_Chees.Location = new System.Drawing.Point(24, 49);
            this.ckb_Toppings_Extra_Chees.Name = "ckb_Toppings_Extra_Chees";
            this.ckb_Toppings_Extra_Chees.Size = new System.Drawing.Size(116, 21);
            this.ckb_Toppings_Extra_Chees.TabIndex = 0;
            this.ckb_Toppings_Extra_Chees.Tag = "3";
            this.ckb_Toppings_Extra_Chees.Text = "Extra Chees";
            this.ckb_Toppings_Extra_Chees.UseVisualStyleBackColor = true;
            this.ckb_Toppings_Extra_Chees.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grp_Cust
            // 
            this.grp_Cust.Controls.Add(this.rdb_Cust_Think);
            this.grp_Cust.Controls.Add(this.rdb_Cust_Then);
            this.grp_Cust.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Cust.Location = new System.Drawing.Point(37, 418);
            this.grp_Cust.Name = "grp_Cust";
            this.grp_Cust.Size = new System.Drawing.Size(190, 242);
            this.grp_Cust.TabIndex = 4;
            this.grp_Cust.TabStop = false;
            this.grp_Cust.Text = "Cust Type";
            this.grp_Cust.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // rdb_Cust_Think
            // 
            this.rdb_Cust_Think.AutoSize = true;
            this.rdb_Cust_Think.Location = new System.Drawing.Point(23, 118);
            this.rdb_Cust_Think.Name = "rdb_Cust_Think";
            this.rdb_Cust_Think.Size = new System.Drawing.Size(110, 21);
            this.rdb_Cust_Think.TabIndex = 2;
            this.rdb_Cust_Think.TabStop = true;
            this.rdb_Cust_Think.Tag = "1";
            this.rdb_Cust_Think.Text = "Think Cust";
            this.rdb_Cust_Think.UseVisualStyleBackColor = true;
            this.rdb_Cust_Think.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rdb_Cust_Then
            // 
            this.rdb_Cust_Then.AutoSize = true;
            this.rdb_Cust_Then.Location = new System.Drawing.Point(23, 66);
            this.rdb_Cust_Then.Name = "rdb_Cust_Then";
            this.rdb_Cust_Then.Size = new System.Drawing.Size(104, 21);
            this.rdb_Cust_Then.TabIndex = 1;
            this.rdb_Cust_Then.TabStop = true;
            this.rdb_Cust_Then.Tag = "-2";
            this.rdb_Cust_Then.Text = "Then Cust";
            this.rdb_Cust_Then.UseVisualStyleBackColor = true;
            this.rdb_Cust_Then.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // grp_Place
            // 
            this.grp_Place.Controls.Add(this.rdb_Plase_Out);
            this.grp_Place.Controls.Add(this.rdb_Plase_In);
            this.grp_Place.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Place.Location = new System.Drawing.Point(374, 418);
            this.grp_Place.Name = "grp_Place";
            this.grp_Place.Size = new System.Drawing.Size(378, 81);
            this.grp_Place.TabIndex = 5;
            this.grp_Place.TabStop = false;
            this.grp_Place.Text = "Where to eat";
            // 
            // rdb_Plase_Out
            // 
            this.rdb_Plase_Out.AutoSize = true;
            this.rdb_Plase_Out.Location = new System.Drawing.Point(225, 36);
            this.rdb_Plase_Out.Name = "rdb_Plase_Out";
            this.rdb_Plase_Out.Size = new System.Drawing.Size(99, 21);
            this.rdb_Plase_Out.TabIndex = 3;
            this.rdb_Plase_Out.TabStop = true;
            this.rdb_Plase_Out.Text = "Take Out ";
            this.rdb_Plase_Out.UseVisualStyleBackColor = true;
            this.rdb_Plase_Out.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rdb_Plase_In
            // 
            this.rdb_Plase_In.AutoSize = true;
            this.rdb_Plase_In.Location = new System.Drawing.Point(24, 36);
            this.rdb_Plase_In.Name = "rdb_Plase_In";
            this.rdb_Plase_In.Size = new System.Drawing.Size(81, 21);
            this.rdb_Plase_In.TabIndex = 2;
            this.rdb_Plase_In.TabStop = true;
            this.rdb_Plase_In.Text = "Take in";
            this.rdb_Plase_In.UseVisualStyleBackColor = true;
            this.rdb_Plase_In.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.Location = new System.Drawing.Point(374, 555);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(149, 60);
            this.btn_Order.TabIndex = 6;
            this.btn_Order.Text = "Order Pizza";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            this.btn_Order.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Rest_Mouse_Down);
            // 
            // btn_Rest_Form
            // 
            this.btn_Rest_Form.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Rest_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rest_Form.Location = new System.Drawing.Point(603, 555);
            this.btn_Rest_Form.Name = "btn_Rest_Form";
            this.btn_Rest_Form.Size = new System.Drawing.Size(149, 60);
            this.btn_Rest_Form.TabIndex = 7;
            this.btn_Rest_Form.Text = "Reset Form";
            this.btn_Rest_Form.UseVisualStyleBackColor = false;
            this.btn_Rest_Form.Click += new System.EventHandler(this.btn_Rest_Form_Click);
            // 
            // grp_Order_Summary
            // 
            this.grp_Order_Summary.AutoSize = true;
            this.grp_Order_Summary.Controls.Add(this.lbl_Where_To_Eat);
            this.grp_Order_Summary.Controls.Add(this.label2);
            this.grp_Order_Summary.Controls.Add(this.lbl_Eat_Place);
            this.grp_Order_Summary.Controls.Add(this.lbl_Cust_Type);
            this.grp_Order_Summary.Controls.Add(this.lbl_Total_Price_Number);
            this.grp_Order_Summary.Controls.Add(this.lbl_Total_Price);
            this.grp_Order_Summary.Controls.Add(this.lbl_Toppings_Answere);
            this.grp_Order_Summary.Controls.Add(this.lbl_Size_Answere);
            this.grp_Order_Summary.Controls.Add(this.lbl_Toppings);
            this.grp_Order_Summary.Controls.Add(this.lbl_Size);
            this.grp_Order_Summary.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Order_Summary.Location = new System.Drawing.Point(898, 158);
            this.grp_Order_Summary.Name = "grp_Order_Summary";
            this.grp_Order_Summary.Size = new System.Drawing.Size(482, 528);
            this.grp_Order_Summary.TabIndex = 3;
            this.grp_Order_Summary.TabStop = false;
            this.grp_Order_Summary.Text = "Order Summary";
            this.grp_Order_Summary.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lbl_Where_To_Eat
            // 
            this.lbl_Where_To_Eat.AutoSize = true;
            this.lbl_Where_To_Eat.Location = new System.Drawing.Point(165, 298);
            this.lbl_Where_To_Eat.Name = "lbl_Where_To_Eat";
            this.lbl_Where_To_Eat.Size = new System.Drawing.Size(13, 17);
            this.lbl_Where_To_Eat.TabIndex = 9;
            this.lbl_Where_To_Eat.Text = " ";
            this.lbl_Where_To_Eat.Click += new System.EventHandler(this.lbl_Where_To_Eatr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = " ";
            // 
            // lbl_Eat_Place
            // 
            this.lbl_Eat_Place.AutoSize = true;
            this.lbl_Eat_Place.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eat_Place.Location = new System.Drawing.Point(23, 298);
            this.lbl_Eat_Place.Name = "lbl_Eat_Place";
            this.lbl_Eat_Place.Size = new System.Drawing.Size(122, 17);
            this.lbl_Eat_Place.TabIndex = 7;
            this.lbl_Eat_Place.Text = "Where To Eat :";
            // 
            // lbl_Cust_Type
            // 
            this.lbl_Cust_Type.AutoSize = true;
            this.lbl_Cust_Type.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cust_Type.Location = new System.Drawing.Point(23, 260);
            this.lbl_Cust_Type.Name = "lbl_Cust_Type";
            this.lbl_Cust_Type.Size = new System.Drawing.Size(102, 17);
            this.lbl_Cust_Type.TabIndex = 6;
            this.lbl_Cust_Type.Text = "Cust Type : ";
            // 
            // lbl_Total_Price_Number
            // 
            this.lbl_Total_Price_Number.AutoSize = true;
            this.lbl_Total_Price_Number.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price_Number.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_Total_Price_Number.Location = new System.Drawing.Point(299, 385);
            this.lbl_Total_Price_Number.Name = "lbl_Total_Price_Number";
            this.lbl_Total_Price_Number.Size = new System.Drawing.Size(114, 79);
            this.lbl_Total_Price_Number.TabIndex = 5;
            this.lbl_Total_Price_Number.Text = " $0";
            this.lbl_Total_Price_Number.Click += new System.EventHandler(this.lbl_Total_Price_Number_Click);
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.Location = new System.Drawing.Point(124, 414);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(130, 22);
            this.lbl_Total_Price.TabIndex = 4;
            this.lbl_Total_Price.Text = "Total Price :";
            // 
            // lbl_Toppings_Answere
            // 
            this.lbl_Toppings_Answere.AutoSize = true;
            this.lbl_Toppings_Answere.Location = new System.Drawing.Point(23, 138);
            this.lbl_Toppings_Answere.Name = "lbl_Toppings_Answere";
            this.lbl_Toppings_Answere.Size = new System.Drawing.Size(13, 17);
            this.lbl_Toppings_Answere.TabIndex = 3;
            this.lbl_Toppings_Answere.Text = " ";
            this.lbl_Toppings_Answere.Click += new System.EventHandler(this.lbl_Toppings_Answere_Click);
            // 
            // lbl_Size_Answere
            // 
            this.lbl_Size_Answere.AutoSize = true;
            this.lbl_Size_Answere.Location = new System.Drawing.Point(125, 56);
            this.lbl_Size_Answere.Name = "lbl_Size_Answere";
            this.lbl_Size_Answere.Size = new System.Drawing.Size(0, 17);
            this.lbl_Size_Answere.TabIndex = 2;
            // 
            // lbl_Toppings
            // 
            this.lbl_Toppings.AutoSize = true;
            this.lbl_Toppings.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Toppings.Location = new System.Drawing.Point(23, 101);
            this.lbl_Toppings.Name = "lbl_Toppings";
            this.lbl_Toppings.Size = new System.Drawing.Size(92, 17);
            this.lbl_Toppings.TabIndex = 1;
            this.lbl_Toppings.Text = "Toppings :";
            this.lbl_Toppings.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.Location = new System.Drawing.Point(23, 56);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(54, 18);
            this.lbl_Size.TabIndex = 0;
            this.lbl_Size.Text = "Size :";
            this.lbl_Size.Click += new System.EventHandler(this.lbl_Size_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1392, 755);
            this.Controls.Add(this.btn_Rest_Form);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.grp_Place);
            this.Controls.Add(this.grp_Cust);
            this.Controls.Add(this.grp_Order_Summary);
            this.Controls.Add(this.grp_Toppers);
            this.Controls.Add(this.grp_Size);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_Size.ResumeLayout(false);
            this.grp_Size.PerformLayout();
            this.grp_Toppers.ResumeLayout(false);
            this.grp_Toppers.PerformLayout();
            this.grp_Cust.ResumeLayout(false);
            this.grp_Cust.PerformLayout();
            this.grp_Place.ResumeLayout(false);
            this.grp_Place.PerformLayout();
            this.grp_Order_Summary.ResumeLayout(false);
            this.grp_Order_Summary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_Size;
        private System.Windows.Forms.GroupBox grp_Toppers;
        private System.Windows.Forms.GroupBox grp_Cust;
        private System.Windows.Forms.GroupBox grp_Place;
        private System.Windows.Forms.RadioButton rdb_Size_Small;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_Rest_Form;
        private System.Windows.Forms.RadioButton rdb_Size_Large;
        private System.Windows.Forms.RadioButton rdb_Size_Med;
        private System.Windows.Forms.CheckBox ckb_Toppings_Tomatoes;
        private System.Windows.Forms.CheckBox ckb_Toppings_Mashrooms;
        private System.Windows.Forms.CheckBox ckb_Toppings_Extra_Chees;
        private System.Windows.Forms.RadioButton rdb_Cust_Think;
        private System.Windows.Forms.RadioButton rdb_Cust_Then;
        private System.Windows.Forms.CheckBox ckb_Toppings_Green_Peppers;
        private System.Windows.Forms.CheckBox ckb_Toppings_Olives;
        private System.Windows.Forms.CheckBox ckb_Toppings_Onion;
        private System.Windows.Forms.RadioButton rdb_Plase_Out;
        private System.Windows.Forms.RadioButton rdb_Plase_In;
        private System.Windows.Forms.GroupBox grp_Order_Summary;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Label lbl_Size_Answere;
        private System.Windows.Forms.Label lbl_Toppings_Answere;
        private System.Windows.Forms.Label lbl_Total_Price_Number;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.Label lbl_Toppings;
        private System.Windows.Forms.Label lbl_Where_To_Eat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Eat_Place;
        private System.Windows.Forms.Label lbl_Cust_Type;
    }
}

