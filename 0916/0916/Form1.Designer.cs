namespace _0916
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
            this.buttonShowCar = new System.Windows.Forms.Button();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonReturnCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxSeats = new System.Windows.Forms.TextBox();
            this.textBoxReg = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxMade = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelReturn = new System.Windows.Forms.Panel();
            this.textBoxThankReturn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxBooked = new System.Windows.Forms.ListBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxThankBook = new System.Windows.Forms.TextBox();
            this.listBoxShow = new System.Windows.Forms.ListBox();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonInitialize = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.panelAdd.SuspendLayout();
            this.panelReturn.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowCar
            // 
            this.buttonShowCar.Location = new System.Drawing.Point(25, 94);
            this.buttonShowCar.Name = "buttonShowCar";
            this.buttonShowCar.Size = new System.Drawing.Size(93, 41);
            this.buttonShowCar.TabIndex = 0;
            this.buttonShowCar.Text = "Show Cars";
            this.buttonShowCar.UseVisualStyleBackColor = true;
            this.buttonShowCar.Click += new System.EventHandler(this.buttonShowCar_Click);
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(124, 94);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(93, 41);
            this.buttonAddCar.TabIndex = 1;
            this.buttonAddCar.Text = "Add a Car";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonReturnCar
            // 
            this.buttonReturnCar.Location = new System.Drawing.Point(223, 94);
            this.buttonReturnCar.Name = "buttonReturnCar";
            this.buttonReturnCar.Size = new System.Drawing.Size(93, 41);
            this.buttonReturnCar.TabIndex = 2;
            this.buttonReturnCar.Text = "Return a Car";
            this.buttonReturnCar.UseVisualStyleBackColor = true;
            this.buttonReturnCar.Click += new System.EventHandler(this.buttonReturnCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.label9);
            this.panelAdd.Controls.Add(this.label7);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.textBoxPrice);
            this.panelAdd.Controls.Add(this.textBoxSeats);
            this.panelAdd.Controls.Add(this.textBoxReg);
            this.panelAdd.Controls.Add(this.textBoxColor);
            this.panelAdd.Controls.Add(this.textBoxModel);
            this.panelAdd.Controls.Add(this.textBoxMade);
            this.panelAdd.Controls.Add(this.buttonAdd);
            this.panelAdd.Location = new System.Drawing.Point(25, 160);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(405, 256);
            this.panelAdd.TabIndex = 5;
            this.panelAdd.Visible = false;
            this.panelAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdd_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Add Car";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Seats:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Reg. Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Made:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(99, 195);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(161, 22);
            this.textBoxPrice.TabIndex = 12;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxSeats
            // 
            this.textBoxSeats.Location = new System.Drawing.Point(99, 167);
            this.textBoxSeats.Name = "textBoxSeats";
            this.textBoxSeats.Size = new System.Drawing.Size(161, 22);
            this.textBoxSeats.TabIndex = 11;
            this.textBoxSeats.TextChanged += new System.EventHandler(this.textBoxSeats_TextChanged);
            // 
            // textBoxReg
            // 
            this.textBoxReg.Location = new System.Drawing.Point(99, 139);
            this.textBoxReg.Name = "textBoxReg";
            this.textBoxReg.Size = new System.Drawing.Size(161, 22);
            this.textBoxReg.TabIndex = 10;
            this.textBoxReg.TextChanged += new System.EventHandler(this.textBoxReg_TextChanged);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(99, 111);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(161, 22);
            this.textBoxColor.TabIndex = 9;
            this.textBoxColor.TextChanged += new System.EventHandler(this.textBoxColor_TextChanged);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(99, 83);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(161, 22);
            this.textBoxModel.TabIndex = 8;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            // 
            // textBoxMade
            // 
            this.textBoxMade.Location = new System.Drawing.Point(99, 55);
            this.textBoxMade.Name = "textBoxMade";
            this.textBoxMade.Size = new System.Drawing.Size(161, 22);
            this.textBoxMade.TabIndex = 7;
            this.textBoxMade.TextChanged += new System.EventHandler(this.textBoxMake_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(272, 196);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(93, 41);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelReturn
            // 
            this.panelReturn.Controls.Add(this.textBoxThankReturn);
            this.panelReturn.Controls.Add(this.label10);
            this.panelReturn.Controls.Add(this.listBoxBooked);
            this.panelReturn.Controls.Add(this.buttonReturn);
            this.panelReturn.Location = new System.Drawing.Point(25, 159);
            this.panelReturn.Name = "panelReturn";
            this.panelReturn.Size = new System.Drawing.Size(405, 256);
            this.panelReturn.TabIndex = 8;
            this.panelReturn.Visible = false;
            this.panelReturn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReturn_Paint);
            // 
            // textBoxThankReturn
            // 
            this.textBoxThankReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxThankReturn.Location = new System.Drawing.Point(262, 25);
            this.textBoxThankReturn.Name = "textBoxThankReturn";
            this.textBoxThankReturn.ReadOnly = true;
            this.textBoxThankReturn.Size = new System.Drawing.Size(143, 21);
            this.textBoxThankReturn.TabIndex = 11;
            this.textBoxThankReturn.Text = "Thanks for the Business!";
            this.textBoxThankReturn.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cars for Return";
            // 
            // listBoxBooked
            // 
            this.listBoxBooked.FormattingEnabled = true;
            this.listBoxBooked.ItemHeight = 16;
            this.listBoxBooked.Location = new System.Drawing.Point(10, 26);
            this.listBoxBooked.Name = "listBoxBooked";
            this.listBoxBooked.Size = new System.Drawing.Size(250, 212);
            this.listBoxBooked.TabIndex = 7;
            this.listBoxBooked.SelectedIndexChanged += new System.EventHandler(this.listBoxBooked_SelectedIndexChanged);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(272, 196);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(93, 41);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.label8);
            this.panelShow.Controls.Add(this.textBoxThankBook);
            this.panelShow.Controls.Add(this.listBoxShow);
            this.panelShow.Controls.Add(this.buttonBook);
            this.panelShow.Location = new System.Drawing.Point(25, 160);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(405, 256);
            this.panelShow.TabIndex = 8;
            this.panelShow.Visible = false;
            this.panelShow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShow_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Available Cars";
            // 
            // textBoxThankBook
            // 
            this.textBoxThankBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxThankBook.Location = new System.Drawing.Point(266, 26);
            this.textBoxThankBook.Name = "textBoxThankBook";
            this.textBoxThankBook.ReadOnly = true;
            this.textBoxThankBook.Size = new System.Drawing.Size(139, 21);
            this.textBoxThankBook.TabIndex = 8;
            this.textBoxThankBook.Text = "Thank you for booking!";
            this.textBoxThankBook.Visible = false;
            // 
            // listBoxShow
            // 
            this.listBoxShow.FormattingEnabled = true;
            this.listBoxShow.ItemHeight = 16;
            this.listBoxShow.Location = new System.Drawing.Point(10, 26);
            this.listBoxShow.Name = "listBoxShow";
            this.listBoxShow.Size = new System.Drawing.Size(250, 212);
            this.listBoxShow.TabIndex = 7;
            this.listBoxShow.SelectedIndexChanged += new System.EventHandler(this.listBoxShow_SelectedIndexChanged);
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(273, 196);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(93, 41);
            this.buttonBook.TabIndex = 6;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonInitialize
            // 
            this.buttonInitialize.Location = new System.Drawing.Point(322, 94);
            this.buttonInitialize.Name = "buttonInitialize";
            this.buttonInitialize.Size = new System.Drawing.Size(93, 41);
            this.buttonInitialize.TabIndex = 10;
            this.buttonInitialize.Text = "Initialize Cars";
            this.buttonInitialize.UseVisualStyleBackColor = true;
            this.buttonInitialize.Click += new System.EventHandler(this.buttonInitialize_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(32, 34);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(96, 16);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Available Cars";
            this.labelAmount.Click += new System.EventHandler(this.labelAmount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 445);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonInitialize);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReturnCar);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.buttonShowCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelReturn.ResumeLayout(false);
            this.panelReturn.PerformLayout();
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowCar;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonReturnCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxSeats;
        private System.Windows.Forms.TextBox textBoxReg;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxMade;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.ListBox listBoxBooked;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.ListBox listBoxShow;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxThankReturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxThankBook;
        private System.Windows.Forms.Button buttonInitialize;
        private System.Windows.Forms.Label labelAmount;
    }
}

