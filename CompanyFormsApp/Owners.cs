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
    public partial class Owners : Form
    {

        CentralDBEntities dbcontext = new CentralDBEntities();
        int OwnerId = 0;

        public Owners()
        {
            InitializeComponent();
        }

        private void Owners_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            List<Owner> datas = dbcontext.Owners.OrderBy(a => a.ID).ToList();
            dgvOwners.DataSource = datas;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OwnerId = Convert.ToInt32(dgvOwners.CurrentRow.Cells[0].Value);

            Owner ownerModel = dbcontext.Owners
                                  .Where(a => a.ID == OwnerId).FirstOrDefault();
            Company companyModel = dbcontext.Companies
                                  .Where(a => a.OwnerId == ownerModel.ID).FirstOrDefault();


            if (companyModel == null)
            {
                dbcontext.Owners.Remove(ownerModel);
                dbcontext.SaveChanges();
                MessageBox.Show("Data deleted Successfully");
                load();
            }

            else MessageBox.Show("Sorry Buddy. Can't do this..!");
            
        }
    }
}
