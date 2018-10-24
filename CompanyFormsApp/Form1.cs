using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyFormsApp
{
    public partial class Form1 : Form
    {
        CentralDBEntities dbcontext = new CentralDBEntities();
        int CompanyId = 0;
        int OwnerId = 0;

        public Form1()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            List<Company> datas = dbcontext.Companies.OrderBy(a => a.ID).ToList();
            dataGridView1.DataSource = datas;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Company companyModel = new Company();
            Owner ownerModel = new Owner();
            companyModel.CompanyName = txtCompanyName.Text.Trim();
            companyModel.Location = txtCompanyLocation.Text.Trim();
            companyModel.EmployeeNumber = Convert.ToInt32(txtEmployeeNumber.Text.Trim());
            ownerModel.FirstName = txtOwnerFName.Text.Trim();
            ownerModel.LastName = txtOwnerLName.Text.Trim();
            ownerModel.Address = txtOwnerAddress.Text.Trim();
            ownerModel.Email = txtOwnerEmail.Text.Trim();
            companyModel.OwnerId = ownerModel.ID;

            dbcontext.Companies.Add(companyModel);
            dbcontext.Owners.Add(ownerModel);
            dbcontext.SaveChanges();
            MessageBox.Show("Data added successfully");
            clear();
            load();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            CompanyId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            OwnerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);

            lblCompanyName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblEmpNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lblLocation.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            lblOwnerFName.Text = dbcontext.Owners.Where(a => a.ID == OwnerId)
                                .SingleOrDefault()?.FirstName.ToString();

            lblOwnerLName.Text = dbcontext.Owners.Where(a => a.ID == OwnerId)
                                .SingleOrDefault()?.LastName.ToString();

            lblOwnerAddress.Text = dbcontext.Owners.Where(a => a.ID == OwnerId)
                                .SingleOrDefault()?.Address.ToString();

            lblOwnerEmail.Text = dbcontext.Owners.Where(a => a.ID == OwnerId)
                                .SingleOrDefault()?.Email.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CompanyId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Company companyModel = dbcontext.Companies
                                .Where(a => a.ID == CompanyId).FirstOrDefault();
            Owner ownerModel = dbcontext.Owners
                                .Where(p => p.ID == companyModel.OwnerId).FirstOrDefault();

            dbcontext.Companies.Remove(companyModel);

            if (ownerModel != null) {
                dbcontext.Owners.Remove(ownerModel);
            }
            dbcontext.SaveChanges();
            MessageBox.Show("Data deleted Successfully");
            clear();
            load();
        }

        private void btnListOfOwners_Click(object sender, EventArgs e)
        {
            Owners frm = new Owners();
            frm.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            CompanyId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            OwnerId = Convert.ToInt32(dbcontext.Companies.Where(a => a.ID == CompanyId)
                .SingleOrDefault()?.OwnerId);

            txtCompanyName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCompanyLocation.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmployeeNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            txtOwnerFName.Text = dbcontext.Owners.Where(q => q.ID == OwnerId)
                                .SingleOrDefault()?.FirstName.ToString();

            txtOwnerLName.Text = dbcontext.Owners.Where(q => q.ID == OwnerId)
                                .SingleOrDefault()?.LastName.ToString();

            txtOwnerAddress.Text = dbcontext.Owners.Where(q => q.ID == OwnerId)
                                .SingleOrDefault()?.Address.ToString();

            txtOwnerEmail.Text = dbcontext.Owners.Where(q => q.ID == OwnerId)
                                .SingleOrDefault()?.Email.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Company companyModel = dbcontext.Companies
                .Where(q => q.ID == CompanyId).FirstOrDefault();

            Owner ownerModel = dbcontext.Owners
                .Where(p => p.ID == OwnerId).FirstOrDefault();

            companyModel.CompanyName = txtCompanyName.Text.Trim();
            companyModel.Location = txtCompanyLocation.Text.Trim();
            companyModel.EmployeeNumber = Convert.ToInt32(txtEmployeeNumber.Text.Trim());
            ownerModel.FirstName = txtOwnerFName.Text.Trim();
            ownerModel.LastName = txtOwnerLName.Text.Trim();
            ownerModel.Address = txtOwnerAddress.Text.Trim();
            ownerModel.Email = txtOwnerEmail.Text.Trim();
            
            dbcontext.SaveChanges();
            MessageBox.Show("Data updated successfully");
            clear();
            load();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtCompanyName.Text = null;
            txtCompanyLocation.Text = null;
            txtEmployeeNumber.Text = null;
            txtOwnerAddress.Text = null;
            txtOwnerEmail.Text = null;
            txtOwnerFName.Text = null;
            txtOwnerLName.Text = null;
        }
    }
}
