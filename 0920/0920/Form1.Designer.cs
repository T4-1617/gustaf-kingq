namespace _0920
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpAdd = new System.Windows.Forms.Panel();
            this.EmpAddCancel = new System.Windows.Forms.Button();
            this.EmpAddSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.basicLower = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CusAdd = new System.Windows.Forms.Panel();
            this.CusAddCancel = new System.Windows.Forms.Button();
            this.CusAddSave = new System.Windows.Forms.Button();
            this.basicUpper = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.EmpAdd.SuspendLayout();
            this.basicLower.SuspendLayout();
            this.CusAdd.SuspendLayout();
            this.basicUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "I want to add a:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer",
            "Employee",
            "Supplier"});
            this.comboBox1.Location = new System.Drawing.Point(137, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "You have registered 0 Customers, 0 Employees and 0 Suppliers.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmpAdd
            // 
            this.EmpAdd.Controls.Add(this.EmpAddCancel);
            this.EmpAdd.Controls.Add(this.EmpAddSave);
            this.EmpAdd.Location = new System.Drawing.Point(54, 92);
            this.EmpAdd.Name = "EmpAdd";
            this.EmpAdd.Size = new System.Drawing.Size(510, 137);
            this.EmpAdd.TabIndex = 3;
            this.EmpAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmpAddCancel
            // 
            this.EmpAddCancel.Location = new System.Drawing.Point(432, 111);
            this.EmpAddCancel.Name = "EmpAddCancel";
            this.EmpAddCancel.Size = new System.Drawing.Size(75, 23);
            this.EmpAddCancel.TabIndex = 1;
            this.EmpAddCancel.Text = "Cancel";
            this.EmpAddCancel.UseVisualStyleBackColor = true;
            this.EmpAddCancel.Click += new System.EventHandler(this.EmpAddCancel_Click);
            // 
            // EmpAddSave
            // 
            this.EmpAddSave.Location = new System.Drawing.Point(351, 111);
            this.EmpAddSave.Name = "EmpAddSave";
            this.EmpAddSave.Size = new System.Drawing.Size(75, 23);
            this.EmpAddSave.TabIndex = 0;
            this.EmpAddSave.Text = "Save";
            this.EmpAddSave.UseVisualStyleBackColor = true;
            this.EmpAddSave.Click += new System.EventHandler(this.EmpAddSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 299);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 329);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // basicLower
            // 
            this.basicLower.Controls.Add(this.button4);
            this.basicLower.Controls.Add(this.button3);
            this.basicLower.Location = new System.Drawing.Point(308, 299);
            this.basicLower.Name = "basicLower";
            this.basicLower.Size = new System.Drawing.Size(256, 329);
            this.basicLower.TabIndex = 5;
            this.basicLower.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(178, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CusAdd
            // 
            this.CusAdd.Controls.Add(this.CusAddCancel);
            this.CusAdd.Controls.Add(this.CusAddSave);
            this.CusAdd.Location = new System.Drawing.Point(54, 92);
            this.CusAdd.Name = "CusAdd";
            this.CusAdd.Size = new System.Drawing.Size(510, 137);
            this.CusAdd.TabIndex = 4;
            this.CusAdd.Visible = false;
            this.CusAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // CusAddCancel
            // 
            this.CusAddCancel.Location = new System.Drawing.Point(432, 111);
            this.CusAddCancel.Name = "CusAddCancel";
            this.CusAddCancel.Size = new System.Drawing.Size(75, 23);
            this.CusAddCancel.TabIndex = 1;
            this.CusAddCancel.Text = "Cancel";
            this.CusAddCancel.UseVisualStyleBackColor = true;
            this.CusAddCancel.Click += new System.EventHandler(this.button5_Click);
            // 
            // CusAddSave
            // 
            this.CusAddSave.Location = new System.Drawing.Point(351, 111);
            this.CusAddSave.Name = "CusAddSave";
            this.CusAddSave.Size = new System.Drawing.Size(75, 23);
            this.CusAddSave.TabIndex = 0;
            this.CusAddSave.Text = "Save";
            this.CusAddSave.UseVisualStyleBackColor = true;
            this.CusAddSave.Click += new System.EventHandler(this.button6_Click);
            // 
            // basicUpper
            // 
            this.basicUpper.Controls.Add(this.button7);
            this.basicUpper.Controls.Add(this.button8);
            this.basicUpper.Location = new System.Drawing.Point(54, 92);
            this.basicUpper.Name = "basicUpper";
            this.basicUpper.Size = new System.Drawing.Size(510, 137);
            this.basicUpper.TabIndex = 5;
            this.basicUpper.Paint += new System.Windows.Forms.PaintEventHandler(this.basicUpper_Paint);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(432, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(351, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 683);
            this.Controls.Add(this.basicLower);
            this.Controls.Add(this.EmpAdd);
            this.Controls.Add(this.CusAdd);
            this.Controls.Add(this.basicUpper);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.EmpAdd.ResumeLayout(false);
            this.basicLower.ResumeLayout(false);
            this.CusAdd.ResumeLayout(false);
            this.basicUpper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel EmpAdd;
        private System.Windows.Forms.Button EmpAddCancel;
        private System.Windows.Forms.Button EmpAddSave;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel basicLower;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel CusAdd;
        private System.Windows.Forms.Button CusAddCancel;
        private System.Windows.Forms.Button CusAddSave;
        private System.Windows.Forms.Panel basicUpper;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

