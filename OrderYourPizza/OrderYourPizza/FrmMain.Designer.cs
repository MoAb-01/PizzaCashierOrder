namespace OrderYourPizza
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_size = new System.Windows.Forms.GroupBox();
            this.Rad_Larg = new System.Windows.Forms.RadioButton();
            this.Rad_med = new System.Windows.Forms.RadioButton();
            this.Rad_small = new System.Windows.Forms.RadioButton();
            this.gb_toppings = new System.Windows.Forms.GroupBox();
            this.chk_GreenPepper = new System.Windows.Forms.CheckBox();
            this.chk_tomatoes = new System.Windows.Forms.CheckBox();
            this.chk_olives = new System.Windows.Forms.CheckBox();
            this.chk_mush = new System.Windows.Forms.CheckBox();
            this.chk_cheese = new System.Windows.Forms.CheckBox();
            this.chk_onion = new System.Windows.Forms.CheckBox();
            this.gb_crust = new System.Windows.Forms.GroupBox();
            this.Rad_think = new System.Windows.Forms.RadioButton();
            this.Rad_thick = new System.Windows.Forms.RadioButton();
            this.gb_eat = new System.Windows.Forms.GroupBox();
            this.Rad_Eatout = new System.Windows.Forms.RadioButton();
            this.Rad_Eatin = new System.Windows.Forms.RadioButton();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEat = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_box_quantity = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_size.SuspendLayout();
            this.gb_toppings.SuspendLayout();
            this.gb_crust.SuspendLayout();
            this.gb_eat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_box_quantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordering Menu";
            // 
            // gb_size
            // 
            this.gb_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gb_size.BackgroundImage = global::OrderYourPizza.Properties.Resources.size1;
            this.gb_size.Controls.Add(this.Rad_Larg);
            this.gb_size.Controls.Add(this.Rad_med);
            this.gb_size.Controls.Add(this.Rad_small);
            this.gb_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_size.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_size.Location = new System.Drawing.Point(6, 27);
            this.gb_size.Name = "gb_size";
            this.gb_size.Size = new System.Drawing.Size(321, 142);
            this.gb_size.TabIndex = 4;
            this.gb_size.TabStop = false;
            this.gb_size.Text = "size";
            this.gb_size.Enter += new System.EventHandler(this.gb_size_Enter);
            // 
            // Rad_Larg
            // 
            this.Rad_Larg.AutoSize = true;
            this.Rad_Larg.BackColor = System.Drawing.Color.Black;
            this.Rad_Larg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rad_Larg.Location = new System.Drawing.Point(226, 112);
            this.Rad_Larg.Name = "Rad_Larg";
            this.Rad_Larg.Size = new System.Drawing.Size(68, 24);
            this.Rad_Larg.TabIndex = 6;
            this.Rad_Larg.TabStop = true;
            this.Rad_Larg.Tag = "30";
            this.Rad_Larg.Text = "Large";
            this.Rad_Larg.UseVisualStyleBackColor = false;
            this.Rad_Larg.CheckedChanged += new System.EventHandler(this.Rad_Larg_CheckedChanged);
            // 
            // Rad_med
            // 
            this.Rad_med.AutoSize = true;
            this.Rad_med.BackColor = System.Drawing.Color.Black;
            this.Rad_med.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rad_med.Location = new System.Drawing.Point(106, 112);
            this.Rad_med.Name = "Rad_med";
            this.Rad_med.Size = new System.Drawing.Size(83, 24);
            this.Rad_med.TabIndex = 5;
            this.Rad_med.TabStop = true;
            this.Rad_med.Tag = "20";
            this.Rad_med.Text = "Medium";
            this.Rad_med.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rad_med.UseVisualStyleBackColor = false;
            this.Rad_med.CheckedChanged += new System.EventHandler(this.Rad_med_CheckedChanged);
            // 
            // Rad_small
            // 
            this.Rad_small.AutoSize = true;
            this.Rad_small.BackColor = System.Drawing.Color.Black;
            this.Rad_small.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rad_small.Location = new System.Drawing.Point(6, 112);
            this.Rad_small.Name = "Rad_small";
            this.Rad_small.Size = new System.Drawing.Size(66, 24);
            this.Rad_small.TabIndex = 4;
            this.Rad_small.TabStop = true;
            this.Rad_small.Tag = "10";
            this.Rad_small.Text = "Small";
            this.Rad_small.UseVisualStyleBackColor = false;
            this.Rad_small.CheckedChanged += new System.EventHandler(this.Rad_small_CheckedChanged);
            // 
            // gb_toppings
            // 
            this.gb_toppings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gb_toppings.BackgroundImage = global::OrderYourPizza.Properties.Resources.toppings;
            this.gb_toppings.Controls.Add(this.chk_GreenPepper);
            this.gb_toppings.Controls.Add(this.chk_tomatoes);
            this.gb_toppings.Controls.Add(this.chk_olives);
            this.gb_toppings.Controls.Add(this.chk_mush);
            this.gb_toppings.Controls.Add(this.chk_cheese);
            this.gb_toppings.Controls.Add(this.chk_onion);
            this.gb_toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_toppings.Location = new System.Drawing.Point(6, 193);
            this.gb_toppings.Name = "gb_toppings";
            this.gb_toppings.Size = new System.Drawing.Size(321, 142);
            this.gb_toppings.TabIndex = 7;
            this.gb_toppings.TabStop = false;
            this.gb_toppings.Text = "Toppings";
            this.gb_toppings.Enter += new System.EventHandler(this.gb_toppings_Enter);
            // 
            // chk_GreenPepper
            // 
            this.chk_GreenPepper.AutoSize = true;
            this.chk_GreenPepper.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_GreenPepper.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_GreenPepper.Location = new System.Drawing.Point(133, 86);
            this.chk_GreenPepper.Name = "chk_GreenPepper";
            this.chk_GreenPepper.Size = new System.Drawing.Size(128, 24);
            this.chk_GreenPepper.TabIndex = 5;
            this.chk_GreenPepper.Tag = "5";
            this.chk_GreenPepper.Text = "Green Pepper";
            this.chk_GreenPepper.UseVisualStyleBackColor = false;
            this.chk_GreenPepper.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_tomatoes
            // 
            this.chk_tomatoes.AutoSize = true;
            this.chk_tomatoes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_tomatoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_tomatoes.Location = new System.Drawing.Point(6, 86);
            this.chk_tomatoes.Name = "chk_tomatoes";
            this.chk_tomatoes.Size = new System.Drawing.Size(99, 24);
            this.chk_tomatoes.TabIndex = 4;
            this.chk_tomatoes.Tag = "5";
            this.chk_tomatoes.Text = "Tomatoes";
            this.chk_tomatoes.UseVisualStyleBackColor = false;
            this.chk_tomatoes.CheckedChanged += new System.EventHandler(this.chk_tomatoes_CheckedChanged);
            // 
            // chk_olives
            // 
            this.chk_olives.AutoSize = true;
            this.chk_olives.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_olives.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_olives.Location = new System.Drawing.Point(135, 56);
            this.chk_olives.Name = "chk_olives";
            this.chk_olives.Size = new System.Drawing.Size(67, 24);
            this.chk_olives.TabIndex = 3;
            this.chk_olives.Tag = "5";
            this.chk_olives.Text = "olives";
            this.chk_olives.UseVisualStyleBackColor = false;
            this.chk_olives.CheckedChanged += new System.EventHandler(this.chk_olives_CheckedChanged);
            // 
            // chk_mush
            // 
            this.chk_mush.AutoSize = true;
            this.chk_mush.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_mush.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_mush.Location = new System.Drawing.Point(6, 56);
            this.chk_mush.Name = "chk_mush";
            this.chk_mush.Size = new System.Drawing.Size(111, 24);
            this.chk_mush.TabIndex = 2;
            this.chk_mush.Tag = "5";
            this.chk_mush.Text = "Mushrooms";
            this.chk_mush.UseVisualStyleBackColor = false;
            this.chk_mush.CheckedChanged += new System.EventHandler(this.chk_mush_CheckedChanged);
            // 
            // chk_cheese
            // 
            this.chk_cheese.AutoSize = true;
            this.chk_cheese.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_cheese.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chk_cheese.Location = new System.Drawing.Point(6, 26);
            this.chk_cheese.Name = "chk_cheese";
            this.chk_cheese.Size = new System.Drawing.Size(121, 24);
            this.chk_cheese.TabIndex = 1;
            this.chk_cheese.Tag = "5";
            this.chk_cheese.Text = "Extra cheese";
            this.chk_cheese.UseVisualStyleBackColor = false;
            this.chk_cheese.CheckedChanged += new System.EventHandler(this.chk_cheese_CheckedChanged);
            // 
            // chk_onion
            // 
            this.chk_onion.AutoSize = true;
            this.chk_onion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_onion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_onion.Location = new System.Drawing.Point(133, 25);
            this.chk_onion.Name = "chk_onion";
            this.chk_onion.Size = new System.Drawing.Size(70, 24);
            this.chk_onion.TabIndex = 0;
            this.chk_onion.Tag = "5";
            this.chk_onion.Text = "Onion";
            this.chk_onion.UseVisualStyleBackColor = false;
            this.chk_onion.CheckedChanged += new System.EventHandler(this.chk_onion_CheckedChanged);
            // 
            // gb_crust
            // 
            this.gb_crust.BackgroundImage = global::OrderYourPizza.Properties.Resources.Curst___Copy;
            this.gb_crust.Controls.Add(this.Rad_think);
            this.gb_crust.Controls.Add(this.Rad_thick);
            this.gb_crust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_crust.Location = new System.Drawing.Point(12, 352);
            this.gb_crust.Name = "gb_crust";
            this.gb_crust.Size = new System.Drawing.Size(321, 142);
            this.gb_crust.TabIndex = 8;
            this.gb_crust.TabStop = false;
            this.gb_crust.Text = "Crust";
            // 
            // Rad_think
            // 
            this.Rad_think.AutoSize = true;
            this.Rad_think.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rad_think.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rad_think.Location = new System.Drawing.Point(6, 58);
            this.Rad_think.Name = "Rad_think";
            this.Rad_think.Size = new System.Drawing.Size(57, 24);
            this.Rad_think.TabIndex = 7;
            this.Rad_think.TabStop = true;
            this.Rad_think.Tag = "5";
            this.Rad_think.Text = "Thin";
            this.Rad_think.UseVisualStyleBackColor = false;
            this.Rad_think.CheckedChanged += new System.EventHandler(this.Rad_think_CheckedChanged);
            // 
            // Rad_thick
            // 
            this.Rad_thick.AutoSize = true;
            this.Rad_thick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rad_thick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rad_thick.Location = new System.Drawing.Point(6, 94);
            this.Rad_thick.Name = "Rad_thick";
            this.Rad_thick.Size = new System.Drawing.Size(64, 24);
            this.Rad_thick.TabIndex = 5;
            this.Rad_thick.TabStop = true;
            this.Rad_thick.Tag = "5";
            this.Rad_thick.Text = "Thick";
            this.Rad_thick.UseVisualStyleBackColor = false;
            this.Rad_thick.CheckedChanged += new System.EventHandler(this.Rad_thick_CheckedChanged);
            // 
            // gb_eat
            // 
            this.gb_eat.BackColor = System.Drawing.Color.Transparent;
            this.gb_eat.BackgroundImage = global::OrderYourPizza.Properties.Resources.Where_To_eat___Copy;
            this.gb_eat.Controls.Add(this.Rad_Eatout);
            this.gb_eat.Controls.Add(this.Rad_Eatin);
            this.gb_eat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_eat.Location = new System.Drawing.Point(357, 315);
            this.gb_eat.Name = "gb_eat";
            this.gb_eat.Size = new System.Drawing.Size(216, 104);
            this.gb_eat.TabIndex = 9;
            this.gb_eat.TabStop = false;
            this.gb_eat.Text = "Where to eat";
            // 
            // Rad_Eatout
            // 
            this.Rad_Eatout.AutoSize = true;
            this.Rad_Eatout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rad_Eatout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rad_Eatout.Location = new System.Drawing.Point(131, 47);
            this.Rad_Eatout.Name = "Rad_Eatout";
            this.Rad_Eatout.Size = new System.Drawing.Size(79, 24);
            this.Rad_Eatout.TabIndex = 7;
            this.Rad_Eatout.TabStop = true;
            this.Rad_Eatout.Tag = "0";
            this.Rad_Eatout.Text = "Eat out";
            this.Rad_Eatout.UseVisualStyleBackColor = false;
            this.Rad_Eatout.CheckedChanged += new System.EventHandler(this.Rad_Eatout_CheckedChanged);
            // 
            // Rad_Eatin
            // 
            this.Rad_Eatin.AutoSize = true;
            this.Rad_Eatin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rad_Eatin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rad_Eatin.Location = new System.Drawing.Point(36, 47);
            this.Rad_Eatin.Name = "Rad_Eatin";
            this.Rad_Eatin.Size = new System.Drawing.Size(68, 24);
            this.Rad_Eatin.TabIndex = 5;
            this.Rad_Eatin.TabStop = true;
            this.Rad_Eatin.Tag = "0";
            this.Rad_Eatin.Text = "Eat in";
            this.Rad_Eatin.UseVisualStyleBackColor = false;
            this.Rad_Eatin.CheckedChanged += new System.EventHandler(this.Rad_Eatin_CheckedChanged);
            // 
            // btn_Order
            // 
            this.btn_Order.BackgroundImage = global::OrderYourPizza.Properties.Resources.Shelter22;
            this.btn_Order.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Order.Location = new System.Drawing.Point(294, 529);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(143, 39);
            this.btn_Order.TabIndex = 10;
            this.btn_Order.Text = "Order Pizza";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackgroundImage = global::OrderYourPizza.Properties.Resources.Shelter21;
            this.btn_reset.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F);
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Location = new System.Drawing.Point(484, 529);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(134, 39);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Reset Form";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackgroundImage = global::OrderYourPizza.Properties.Resources.Pink_White_Modern_Receipt_Cosmetics_Shop_Beauty_Instagram_Story2;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblEat);
            this.groupBox1.Controls.Add(this.lblCrust);
            this.groupBox1.Controls.Add(this.lblToppings);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(622, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 403);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Price:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(153, 348);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 33);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "$";
            this.lblPrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(27, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "_______________________";
            // 
            // lblEat
            // 
            this.lblEat.AutoSize = true;
            this.lblEat.BackColor = System.Drawing.Color.Transparent;
            this.lblEat.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEat.Location = new System.Drawing.Point(7, 299);
            this.lblEat.Name = "lblEat";
            this.lblEat.Size = new System.Drawing.Size(130, 20);
            this.lblEat.TabIndex = 3;
            this.lblEat.Text = "Where To eat:";
            this.lblEat.Click += new System.EventHandler(this.lblEat_Click);
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.BackColor = System.Drawing.Color.Transparent;
            this.lblCrust.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCrust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCrust.Location = new System.Drawing.Point(7, 252);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(61, 20);
            this.lblCrust.TabIndex = 2;
            this.lblCrust.Text = "Crust:";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblToppings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToppings.Location = new System.Drawing.Point(3, 93);
            this.lblToppings.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(97, 20);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Toppings:";
            this.lblToppings.Click += new System.EventHandler(this.lblToppings_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSize.Location = new System.Drawing.Point(3, 49);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(51, 20);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size:";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(2, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "_______________________";
            // 
            // gb_box_quantity
            // 
            this.gb_box_quantity.BackColor = System.Drawing.Color.NavajoWhite;
            this.gb_box_quantity.Controls.Add(this.numericUpDown1);
            this.gb_box_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_box_quantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_box_quantity.Location = new System.Drawing.Point(389, 446);
            this.gb_box_quantity.Name = "gb_box_quantity";
            this.gb_box_quantity.Size = new System.Drawing.Size(157, 64);
            this.gb_box_quantity.TabIndex = 9;
            this.gb_box_quantity.TabStop = false;
            this.gb_box_quantity.Text = "Quantity";
            this.gb_box_quantity.Enter += new System.EventHandler(this.gb_box_quantity_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.MistyRose;
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numericUpDown1.Location = new System.Drawing.Point(15, 31);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrderYourPizza.Properties.Resources.Welcome_Screen___Copy__Medium_;
            this.ClientSize = new System.Drawing.Size(886, 580);
            this.ControlBox = false;
            this.Controls.Add(this.gb_box_quantity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.gb_eat);
            this.Controls.Add(this.gb_crust);
            this.Controls.Add(this.gb_toppings);
            this.Controls.Add(this.gb_size);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gb_size.ResumeLayout(false);
            this.gb_size.PerformLayout();
            this.gb_toppings.ResumeLayout(false);
            this.gb_toppings.PerformLayout();
            this.gb_crust.ResumeLayout(false);
            this.gb_crust.PerformLayout();
            this.gb_eat.ResumeLayout(false);
            this.gb_eat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_box_quantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_size;
        private System.Windows.Forms.RadioButton Rad_Larg;
        private System.Windows.Forms.RadioButton Rad_med;
        private System.Windows.Forms.RadioButton Rad_small;
        private System.Windows.Forms.GroupBox gb_toppings;
        private System.Windows.Forms.CheckBox chk_GreenPepper;
        private System.Windows.Forms.CheckBox chk_tomatoes;
        private System.Windows.Forms.CheckBox chk_olives;
        private System.Windows.Forms.CheckBox chk_mush;
        private System.Windows.Forms.CheckBox chk_cheese;
        private System.Windows.Forms.CheckBox chk_onion;
        private System.Windows.Forms.GroupBox gb_crust;
        private System.Windows.Forms.RadioButton Rad_think;
        private System.Windows.Forms.RadioButton Rad_thick;
        private System.Windows.Forms.GroupBox gb_eat;
        private System.Windows.Forms.RadioButton Rad_Eatout;
        private System.Windows.Forms.RadioButton Rad_Eatin;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEat;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_box_quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}