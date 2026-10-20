namespace TimerAppRM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AppetizerGB = new GroupBox();
            Salad = new RadioButton();
            Soup = new RadioButton();
            Fries = new RadioButton();
            Bread = new RadioButton();
            EntreeGB = new GroupBox();
            Burger = new RadioButton();
            Pork = new RadioButton();
            Ribs = new RadioButton();
            Steak = new RadioButton();
            DessertGB = new GroupBox();
            Pie = new RadioButton();
            Brownie = new RadioButton();
            Cookie = new RadioButton();
            IceCream = new RadioButton();
            label1 = new Label();
            Order2 = new Button();
            Order1 = new Button();
            Calculate = new Button();
            TotalOrder = new Label();
            TotalOrderTB = new TextBox();
            GratuityTB = new TextBox();
            GrandTotalTB = new TextBox();
            Gratuity = new Label();
            GrandTotal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            WelcomeLabel = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            AppetizerGB.SuspendLayout();
            EntreeGB.SuspendLayout();
            DessertGB.SuspendLayout();
            SuspendLayout();
            // 
            // AppetizerGB
            // 
            AppetizerGB.Controls.Add(Salad);
            AppetizerGB.Controls.Add(Soup);
            AppetizerGB.Controls.Add(Fries);
            AppetizerGB.Controls.Add(Bread);
            AppetizerGB.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppetizerGB.Location = new Point(14, 12);
            AppetizerGB.Name = "AppetizerGB";
            AppetizerGB.Size = new Size(250, 273);
            AppetizerGB.TabIndex = 0;
            AppetizerGB.TabStop = false;
            AppetizerGB.Text = "Please Select Your Appetizers ($21)";
            AppetizerGB.Enter += AppetizerGB_Enter;
            // 
            // Salad
            // 
            Salad.AutoSize = true;
            Salad.Location = new Point(8, 66);
            Salad.Name = "Salad";
            Salad.Size = new Size(180, 29);
            Salad.TabIndex = 11;
            Salad.TabStop = true;
            Salad.Text = "Cezar Salad";
            Salad.UseVisualStyleBackColor = true;
            // 
            // Soup
            // 
            Soup.AutoSize = true;
            Soup.Location = new Point(6, 101);
            Soup.Name = "Soup";
            Soup.Size = new Size(197, 29);
            Soup.TabIndex = 12;
            Soup.TabStop = true;
            Soup.Text = "Wedding Soup";
            Soup.UseVisualStyleBackColor = true;
            // 
            // Fries
            // 
            Fries.AutoSize = true;
            Fries.Location = new Point(6, 136);
            Fries.Name = "Fries";
            Fries.Size = new Size(179, 29);
            Fries.TabIndex = 13;
            Fries.TabStop = true;
            Fries.Text = "Jersey Fries";
            Fries.UseVisualStyleBackColor = true;
            // 
            // Bread
            // 
            Bread.AutoSize = true;
            Bread.Location = new Point(6, 171);
            Bread.Name = "Bread";
            Bread.Size = new Size(176, 29);
            Bread.TabIndex = 14;
            Bread.TabStop = true;
            Bread.Text = "Garlic Bread";
            Bread.UseVisualStyleBackColor = true;
            // 
            // EntreeGB
            // 
            EntreeGB.Controls.Add(Burger);
            EntreeGB.Controls.Add(Pork);
            EntreeGB.Controls.Add(Ribs);
            EntreeGB.Controls.Add(Steak);
            EntreeGB.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EntreeGB.Location = new Point(270, 12);
            EntreeGB.Name = "EntreeGB";
            EntreeGB.Size = new Size(250, 273);
            EntreeGB.TabIndex = 0;
            EntreeGB.TabStop = false;
            EntreeGB.Text = "Please Select Your Entree ($56)";
            EntreeGB.Enter += EntreeGB_Enter;
            // 
            // Burger
            // 
            Burger.AutoSize = true;
            Burger.Location = new Point(12, 171);
            Burger.Name = "Burger";
            Burger.Size = new Size(198, 29);
            Burger.TabIndex = 3;
            Burger.TabStop = true;
            Burger.Text = "Bacon Burger";
            Burger.UseVisualStyleBackColor = true;
            // 
            // Pork
            // 
            Pork.AutoSize = true;
            Pork.Location = new Point(12, 136);
            Pork.Name = "Pork";
            Pork.Size = new Size(178, 29);
            Pork.TabIndex = 2;
            Pork.TabStop = true;
            Pork.Text = "Pulled Pork";
            Pork.UseVisualStyleBackColor = true;
            // 
            // Ribs
            // 
            Ribs.AutoSize = true;
            Ribs.Location = new Point(12, 101);
            Ribs.Name = "Ribs";
            Ribs.Size = new Size(212, 29);
            Ribs.TabIndex = 1;
            Ribs.TabStop = true;
            Ribs.Text = "Baby Back Ribs";
            Ribs.UseVisualStyleBackColor = true;
            // 
            // Steak
            // 
            Steak.AutoSize = true;
            Steak.Location = new Point(12, 66);
            Steak.Name = "Steak";
            Steak.Size = new Size(151, 29);
            Steak.TabIndex = 0;
            Steak.TabStop = true;
            Steak.Text = "Ny Strip";
            Steak.UseVisualStyleBackColor = true;
            // 
            // DessertGB
            // 
            DessertGB.Controls.Add(Pie);
            DessertGB.Controls.Add(Brownie);
            DessertGB.Controls.Add(Cookie);
            DessertGB.Controls.Add(IceCream);
            DessertGB.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DessertGB.Location = new Point(526, 12);
            DessertGB.Name = "DessertGB";
            DessertGB.Size = new Size(250, 273);
            DessertGB.TabIndex = 0;
            DessertGB.TabStop = false;
            DessertGB.Text = "Please Select Your Dessert ($16)";
            DessertGB.Enter += DessertGB_Enter;
            // 
            // Pie
            // 
            Pie.AutoSize = true;
            Pie.Location = new Point(11, 101);
            Pie.Name = "Pie";
            Pie.Size = new Size(163, 29);
            Pie.TabIndex = 3;
            Pie.TabStop = true;
            Pie.Text = "Apple Pie";
            Pie.UseVisualStyleBackColor = true;
            // 
            // Brownie
            // 
            Brownie.AutoSize = true;
            Brownie.Location = new Point(11, 136);
            Brownie.Name = "Brownie";
            Brownie.Size = new Size(152, 29);
            Brownie.TabIndex = 2;
            Brownie.TabStop = true;
            Brownie.Text = "Brownie";
            Brownie.UseVisualStyleBackColor = true;
            // 
            // Cookie
            // 
            Cookie.AutoSize = true;
            Cookie.Location = new Point(11, 171);
            Cookie.Name = "Cookie";
            Cookie.Size = new Size(197, 29);
            Cookie.TabIndex = 1;
            Cookie.TabStop = true;
            Cookie.Text = "Cookie Skillet";
            Cookie.UseVisualStyleBackColor = true;
            // 
            // IceCream
            // 
            IceCream.AutoSize = true;
            IceCream.Location = new Point(11, 66);
            IceCream.Name = "IceCream";
            IceCream.Size = new Size(228, 29);
            IceCream.TabIndex = 0;
            IceCream.TabStop = true;
            IceCream.Text = "Vanilla Ice Cream";
            IceCream.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 288);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 1;
            label1.Text = "Gratuity included (25%)";
            label1.Click += label1_Click;
            // 
            // Order2
            // 
            Order2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Order2.Location = new Point(270, 320);
            Order2.Name = "Order2";
            Order2.Size = new Size(158, 29);
            Order2.TabIndex = 2;
            Order2.Text = "Comlpete Order 2";
            Order2.UseVisualStyleBackColor = true;
            Order2.Click += Order2_Click;
            // 
            // Order1
            // 
            Order1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Order1.Location = new Point(14, 320);
            Order1.Name = "Order1";
            Order1.Size = new Size(154, 29);
            Order1.TabIndex = 3;
            Order1.Text = "Complete Order1";
            Order1.UseVisualStyleBackColor = true;
            Order1.Click += Order1_Click;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Calculate.Location = new Point(526, 320);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(157, 29);
            Calculate.TabIndex = 4;
            Calculate.Text = "Calculate Total(s)";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // TotalOrder
            // 
            TotalOrder.AutoSize = true;
            TotalOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalOrder.Location = new Point(14, 373);
            TotalOrder.Name = "TotalOrder";
            TotalOrder.Size = new Size(88, 20);
            TotalOrder.TabIndex = 5;
            TotalOrder.Text = "Total Order";
            TotalOrder.Click += TotalOrder_Click;
            // 
            // TotalOrderTB
            // 
            TotalOrderTB.Location = new Point(14, 415);
            TotalOrderTB.Name = "TotalOrderTB";
            TotalOrderTB.Size = new Size(125, 27);
            TotalOrderTB.TabIndex = 6;
            TotalOrderTB.TextChanged += TotalOrderTB_TextChanged;
            // 
            // GratuityTB
            // 
            GratuityTB.Location = new Point(270, 415);
            GratuityTB.Name = "GratuityTB";
            GratuityTB.Size = new Size(125, 27);
            GratuityTB.TabIndex = 7;
            GratuityTB.TextChanged += GratuityTB_TextChanged;
            // 
            // GrandTotalTB
            // 
            GrandTotalTB.Location = new Point(526, 415);
            GrandTotalTB.Name = "GrandTotalTB";
            GrandTotalTB.Size = new Size(125, 27);
            GrandTotalTB.TabIndex = 8;
            GrandTotalTB.TextChanged += GrandTotalTB_TextChanged;
            // 
            // Gratuity
            // 
            Gratuity.AutoSize = true;
            Gratuity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gratuity.Location = new Point(270, 373);
            Gratuity.Name = "Gratuity";
            Gratuity.Size = new Size(67, 20);
            Gratuity.TabIndex = 9;
            Gratuity.Text = "Gratuity";
            Gratuity.Click += Gratuity_Click;
            // 
            // GrandTotal
            // 
            GrandTotal.AutoSize = true;
            GrandTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrandTotal.Location = new Point(526, 373);
            GrandTotal.Name = "GrandTotal";
            GrandTotal.Size = new Size(91, 20);
            GrandTotal.TabIndex = 10;
            GrandTotal.Text = "Grand Total";
            GrandTotal.Click += GrandTotal_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(282, 288);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(232, 25);
            WelcomeLabel.TabIndex = 11;
            WelcomeLabel.Text = "Welcome to the Grub Hut!";
            WelcomeLabel.Click += WelcomeLabel_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 477);
            Controls.Add(WelcomeLabel);
            Controls.Add(GrandTotal);
            Controls.Add(Gratuity);
            Controls.Add(GrandTotalTB);
            Controls.Add(GratuityTB);
            Controls.Add(TotalOrderTB);
            Controls.Add(TotalOrder);
            Controls.Add(Calculate);
            Controls.Add(Order1);
            Controls.Add(Order2);
            Controls.Add(label1);
            Controls.Add(EntreeGB);
            Controls.Add(DessertGB);
            Controls.Add(AppetizerGB);
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            AppetizerGB.ResumeLayout(false);
            AppetizerGB.PerformLayout();
            EntreeGB.ResumeLayout(false);
            EntreeGB.PerformLayout();
            DessertGB.ResumeLayout(false);
            DessertGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox AppetizerGB;
        private GroupBox EntreeGB;
        private GroupBox DessertGB;
        private Label label1;
        private Button Order2;
        private Button Order1;
        private Button Calculate;
        private Label TotalOrder;
        private RadioButton Salad;
        private RadioButton Soup;
        private RadioButton Fries;
        private RadioButton Bread;
        private TextBox TotalOrderTB;
        private TextBox GratuityTB;
        private TextBox GrandTotalTB;
        private Label Gratuity;
        private Label GrandTotal;
        private RadioButton Burger;
        private RadioButton Pork;
        private RadioButton Ribs;
        private RadioButton Steak;
        private RadioButton Pie;
        private RadioButton Brownie;
        private RadioButton Cookie;
        private RadioButton IceCream;
        private System.Windows.Forms.Timer timer1;
        private Label WelcomeLabel;
        private System.Windows.Forms.Timer timer2;
    }
}
