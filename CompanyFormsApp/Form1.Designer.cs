namespace CompanyFormsApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCompanyLocation = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.txtOwnerFName = new System.Windows.Forms.TextBox();
            this.txtOwnerLName = new System.Windows.Forms.TextBox();
            this.txtOwnerAddress = new System.Windows.Forms.TextBox();
            this.txtOwnerEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEmpNumber = new System.Windows.Forms.Label();
            this.lblOwnerFName = new System.Windows.Forms.Label();
            this.lblOwnerLName = new System.Windows.Forms.Label();
            this.lblOwnerAddress = new System.Windows.Forms.Label();
            this.lblOwnerEmail = new System.Windows.Forms.Label();
            this.btnListOfOwners = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Of Companies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(372, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(670, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(140, 88);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(170, 20);
            this.txtCompanyName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Company Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Company Location :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Owner First Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Owner Last Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Owner Address : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Owner Email : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Number of Employees :";
            // 
            // txtCompanyLocation
            // 
            this.txtCompanyLocation.Location = new System.Drawing.Point(140, 123);
            this.txtCompanyLocation.Name = "txtCompanyLocation";
            this.txtCompanyLocation.Size = new System.Drawing.Size(170, 20);
            this.txtCompanyLocation.TabIndex = 13;
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(140, 158);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(170, 20);
            this.txtEmployeeNumber.TabIndex = 14;
            // 
            // txtOwnerFName
            // 
            this.txtOwnerFName.Location = new System.Drawing.Point(140, 193);
            this.txtOwnerFName.Name = "txtOwnerFName";
            this.txtOwnerFName.Size = new System.Drawing.Size(170, 20);
            this.txtOwnerFName.TabIndex = 15;
            // 
            // txtOwnerLName
            // 
            this.txtOwnerLName.Location = new System.Drawing.Point(140, 228);
            this.txtOwnerLName.Name = "txtOwnerLName";
            this.txtOwnerLName.Size = new System.Drawing.Size(170, 20);
            this.txtOwnerLName.TabIndex = 16;
            // 
            // txtOwnerAddress
            // 
            this.txtOwnerAddress.Location = new System.Drawing.Point(140, 263);
            this.txtOwnerAddress.Name = "txtOwnerAddress";
            this.txtOwnerAddress.Size = new System.Drawing.Size(170, 20);
            this.txtOwnerAddress.TabIndex = 17;
            // 
            // txtOwnerEmail
            // 
            this.txtOwnerEmail.Location = new System.Drawing.Point(140, 298);
            this.txtOwnerEmail.Name = "txtOwnerEmail";
            this.txtOwnerEmail.Size = new System.Drawing.Size(170, 20);
            this.txtOwnerEmail.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 34);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(97, 334);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(259, 334);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(51, 34);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Number of Employees :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Company Location :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Company Name : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(513, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Owner Email : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(513, 406);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Owner Address : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(312, 445);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Owner Last Name :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(312, 406);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Owner First Name :";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(140, 392);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(0, 13);
            this.lblCompanyName.TabIndex = 30;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(140, 426);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 13);
            this.lblLocation.TabIndex = 31;
            // 
            // lblEmpNumber
            // 
            this.lblEmpNumber.AutoSize = true;
            this.lblEmpNumber.Location = new System.Drawing.Point(140, 460);
            this.lblEmpNumber.Name = "lblEmpNumber";
            this.lblEmpNumber.Size = new System.Drawing.Size(0, 13);
            this.lblEmpNumber.TabIndex = 32;
            // 
            // lblOwnerFName
            // 
            this.lblOwnerFName.AutoSize = true;
            this.lblOwnerFName.Location = new System.Drawing.Point(425, 406);
            this.lblOwnerFName.Name = "lblOwnerFName";
            this.lblOwnerFName.Size = new System.Drawing.Size(0, 13);
            this.lblOwnerFName.TabIndex = 33;
            // 
            // lblOwnerLName
            // 
            this.lblOwnerLName.AutoSize = true;
            this.lblOwnerLName.Location = new System.Drawing.Point(425, 445);
            this.lblOwnerLName.Name = "lblOwnerLName";
            this.lblOwnerLName.Size = new System.Drawing.Size(0, 13);
            this.lblOwnerLName.TabIndex = 34;
            // 
            // lblOwnerAddress
            // 
            this.lblOwnerAddress.AutoSize = true;
            this.lblOwnerAddress.Location = new System.Drawing.Point(619, 406);
            this.lblOwnerAddress.Name = "lblOwnerAddress";
            this.lblOwnerAddress.Size = new System.Drawing.Size(0, 13);
            this.lblOwnerAddress.TabIndex = 35;
            // 
            // lblOwnerEmail
            // 
            this.lblOwnerEmail.AutoSize = true;
            this.lblOwnerEmail.Location = new System.Drawing.Point(619, 445);
            this.lblOwnerEmail.Name = "lblOwnerEmail";
            this.lblOwnerEmail.Size = new System.Drawing.Size(0, 13);
            this.lblOwnerEmail.TabIndex = 36;
            // 
            // btnListOfOwners
            // 
            this.btnListOfOwners.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListOfOwners.Location = new System.Drawing.Point(742, 374);
            this.btnListOfOwners.Name = "btnListOfOwners";
            this.btnListOfOwners.Size = new System.Drawing.Size(67, 20);
            this.btnListOfOwners.TabIndex = 37;
            this.btnListOfOwners.Text = "Owners";
            this.btnListOfOwners.UseVisualStyleBackColor = true;
            this.btnListOfOwners.Click += new System.EventHandler(this.btnListOfOwners_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 526);
            this.Controls.Add(this.btnListOfOwners);
            this.Controls.Add(this.lblOwnerEmail);
            this.Controls.Add(this.lblOwnerAddress);
            this.Controls.Add(this.lblOwnerLName);
            this.Controls.Add(this.lblOwnerFName);
            this.Controls.Add(this.lblEmpNumber);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtOwnerEmail);
            this.Controls.Add(this.txtOwnerAddress);
            this.Controls.Add(this.txtOwnerLName);
            this.Controls.Add(this.txtOwnerFName);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.txtCompanyLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCompanyLocation;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.TextBox txtOwnerFName;
        private System.Windows.Forms.TextBox txtOwnerLName;
        private System.Windows.Forms.TextBox txtOwnerAddress;
        private System.Windows.Forms.TextBox txtOwnerEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEmpNumber;
        private System.Windows.Forms.Label lblOwnerFName;
        private System.Windows.Forms.Label lblOwnerLName;
        private System.Windows.Forms.Label lblOwnerAddress;
        private System.Windows.Forms.Label lblOwnerEmail;
        private System.Windows.Forms.Button btnListOfOwners;
    }
}

