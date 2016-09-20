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
            this.SupAdd = new System.Windows.Forms.Panel();
            this.SupAddCancel = new System.Windows.Forms.Button();
            this.SupAddSave = new System.Windows.Forms.Button();
            this.CusEdit = new System.Windows.Forms.Panel();
            this.CusEditCancel = new System.Windows.Forms.Button();
            this.CusEditSave = new System.Windows.Forms.Button();
            this.EmpEdit = new System.Windows.Forms.Panel();
            this.EmpEditCancel = new System.Windows.Forms.Button();
            this.EmpEditSave = new System.Windows.Forms.Button();
            this.SupEdit = new System.Windows.Forms.Panel();
            this.SupEditCancel = new System.Windows.Forms.Button();
            this.SupEditSave = new System.Windows.Forms.Button();
            this.EmpAdd.SuspendLayout();
            this.basicLower.SuspendLayout();
            this.CusAdd.SuspendLayout();
            this.basicUpper.SuspendLayout();
            this.SupAdd.SuspendLayout();
            this.CusEdit.SuspendLayout();
            this.EmpEdit.SuspendLayout();
            this.SupEdit.SuspendLayout();
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
            this.EmpAdd.Visible = false;
            this.EmpAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.EmpAdd_Paint);
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
            this.CusAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.CusAdd_Paint);
            // 
            // CusAddCancel
            // 
            this.CusAddCancel.Location = new System.Drawing.Point(432, 111);
            this.CusAddCancel.Name = "CusAddCancel";
            this.CusAddCancel.Size = new System.Drawing.Size(75, 23);
            this.CusAddCancel.TabIndex = 1;
            this.CusAddCancel.Text = "Cancel";
            this.CusAddCancel.UseVisualStyleBackColor = true;
            this.CusAddCancel.Click += new System.EventHandler(this.CusAddCancel_Click);
            // 
            // CusAddSave
            // 
            this.CusAddSave.Location = new System.Drawing.Point(351, 111);
            this.CusAddSave.Name = "CusAddSave";
            this.CusAddSave.Size = new System.Drawing.Size(75, 23);
            this.CusAddSave.TabIndex = 0;
            this.CusAddSave.Text = "Save";
            this.CusAddSave.UseVisualStyleBackColor = true;
            this.CusAddSave.Click += new System.EventHandler(this.CusAddSave_Click);
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
            // SupAdd
            // 
            this.SupAdd.Controls.Add(this.SupAddCancel);
            this.SupAdd.Controls.Add(this.SupAddSave);
            this.SupAdd.Location = new System.Drawing.Point(54, 92);
            this.SupAdd.Name = "SupAdd";
            this.SupAdd.Size = new System.Drawing.Size(510, 137);
            this.SupAdd.TabIndex = 6;
            this.SupAdd.Visible = false;
            this.SupAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.SupAdd_Paint);
            // 
            // SupAddCancel
            // 
            this.SupAddCancel.Location = new System.Drawing.Point(432, 111);
            this.SupAddCancel.Name = "SupAddCancel";
            this.SupAddCancel.Size = new System.Drawing.Size(75, 23);
            this.SupAddCancel.TabIndex = 1;
            this.SupAddCancel.Text = "Cancel";
            this.SupAddCancel.UseVisualStyleBackColor = true;
            this.SupAddCancel.Click += new System.EventHandler(this.SupAddCancel_Click);
            // 
            // SupAddSave
            // 
            this.SupAddSave.Location = new System.Drawing.Point(351, 111);
            this.SupAddSave.Name = "SupAddSave";
            this.SupAddSave.Size = new System.Drawing.Size(75, 23);
            this.SupAddSave.TabIndex = 0;
            this.SupAddSave.Text = "Save";
            this.SupAddSave.UseVisualStyleBackColor = true;
            this.SupAddSave.Click += new System.EventHandler(this.SupAddSave_Click);
            // 
            // CusEdit
            // 
            this.CusEdit.Controls.Add(this.CusEditCancel);
            this.CusEdit.Controls.Add(this.CusEditSave);
            this.CusEdit.Location = new System.Drawing.Point(308, 299);
            this.CusEdit.Name = "CusEdit";
            this.CusEdit.Size = new System.Drawing.Size(256, 329);
            this.CusEdit.TabIndex = 7;
            this.CusEdit.Visible = false;
            this.CusEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.CusEdit_Paint);
            // 
            // CusEditCancel
            // 
            this.CusEditCancel.Location = new System.Drawing.Point(178, 303);
            this.CusEditCancel.Name = "CusEditCancel";
            this.CusEditCancel.Size = new System.Drawing.Size(75, 23);
            this.CusEditCancel.TabIndex = 2;
            this.CusEditCancel.Text = "Cancel";
            this.CusEditCancel.UseVisualStyleBackColor = true;
            this.CusEditCancel.Click += new System.EventHandler(this.CusEditCancel_Click);
            // 
            // CusEditSave
            // 
            this.CusEditSave.Location = new System.Drawing.Point(97, 303);
            this.CusEditSave.Name = "CusEditSave";
            this.CusEditSave.Size = new System.Drawing.Size(75, 23);
            this.CusEditSave.TabIndex = 2;
            this.CusEditSave.Text = "Save";
            this.CusEditSave.UseVisualStyleBackColor = true;
            this.CusEditSave.Click += new System.EventHandler(this.CusEditSave_Click);
            // 
            // EmpEdit
            // 
            this.EmpEdit.Controls.Add(this.EmpEditCancel);
            this.EmpEdit.Controls.Add(this.EmpEditSave);
            this.EmpEdit.Location = new System.Drawing.Point(308, 299);
            this.EmpEdit.Name = "EmpEdit";
            this.EmpEdit.Size = new System.Drawing.Size(256, 329);
            this.EmpEdit.TabIndex = 8;
            this.EmpEdit.Visible = false;
            this.EmpEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.EmpEdit_Paint);
            // 
            // EmpEditCancel
            // 
            this.EmpEditCancel.Location = new System.Drawing.Point(178, 303);
            this.EmpEditCancel.Name = "EmpEditCancel";
            this.EmpEditCancel.Size = new System.Drawing.Size(75, 23);
            this.EmpEditCancel.TabIndex = 2;
            this.EmpEditCancel.Text = "Cancel";
            this.EmpEditCancel.UseVisualStyleBackColor = true;
            this.EmpEditCancel.Click += new System.EventHandler(this.EmpEditCancel_Click);
            // 
            // EmpEditSave
            // 
            this.EmpEditSave.Location = new System.Drawing.Point(97, 303);
            this.EmpEditSave.Name = "EmpEditSave";
            this.EmpEditSave.Size = new System.Drawing.Size(75, 23);
            this.EmpEditSave.TabIndex = 2;
            this.EmpEditSave.Text = "Save";
            this.EmpEditSave.UseVisualStyleBackColor = true;
            this.EmpEditSave.Click += new System.EventHandler(this.EmpEditSave_Click);
            // 
            // SupEdit
            // 
            this.SupEdit.Controls.Add(this.SupEditCancel);
            this.SupEdit.Controls.Add(this.SupEditSave);
            this.SupEdit.Location = new System.Drawing.Point(308, 299);
            this.SupEdit.Name = "SupEdit";
            this.SupEdit.Size = new System.Drawing.Size(256, 329);
            this.SupEdit.TabIndex = 9;
            this.SupEdit.Visible = false;
            this.SupEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.SupEdit_Paint);
            // 
            // SupEditCancel
            // 
            this.SupEditCancel.Location = new System.Drawing.Point(178, 303);
            this.SupEditCancel.Name = "SupEditCancel";
            this.SupEditCancel.Size = new System.Drawing.Size(75, 23);
            this.SupEditCancel.TabIndex = 2;
            this.SupEditCancel.Text = "Cancel";
            this.SupEditCancel.UseVisualStyleBackColor = true;
            this.SupEditCancel.Click += new System.EventHandler(this.SupEditCancel_Click);
            // 
            // SupEditSave
            // 
            this.SupEditSave.Location = new System.Drawing.Point(97, 303);
            this.SupEditSave.Name = "SupEditSave";
            this.SupEditSave.Size = new System.Drawing.Size(75, 23);
            this.SupEditSave.TabIndex = 2;
            this.SupEditSave.Text = "Save";
            this.SupEditSave.UseVisualStyleBackColor = true;
            this.SupEditSave.Click += new System.EventHandler(this.SupEditSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 683);
            this.Controls.Add(this.basicUpper);
            this.Controls.Add(this.CusAdd);
            this.Controls.Add(this.EmpAdd);
            this.Controls.Add(this.SupAdd);
            this.Controls.Add(this.basicLower);
            this.Controls.Add(this.CusEdit);
            this.Controls.Add(this.EmpEdit);
            this.Controls.Add(this.SupEdit);
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
            this.SupAdd.ResumeLayout(false);
            this.CusEdit.ResumeLayout(false);
            this.EmpEdit.ResumeLayout(false);
            this.SupEdit.ResumeLayout(false);
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
        private System.Windows.Forms.Panel SupAdd;
        private System.Windows.Forms.Button SupAddCancel;
        private System.Windows.Forms.Button SupAddSave;
        private System.Windows.Forms.Panel CusEdit;
        private System.Windows.Forms.Button CusEditCancel;
        private System.Windows.Forms.Button CusEditSave;
        private System.Windows.Forms.Panel EmpEdit;
        private System.Windows.Forms.Button EmpEditCancel;
        private System.Windows.Forms.Button EmpEditSave;
        private System.Windows.Forms.Panel SupEdit;
        private System.Windows.Forms.Button SupEditCancel;
        private System.Windows.Forms.Button SupEditSave;
    }
}

