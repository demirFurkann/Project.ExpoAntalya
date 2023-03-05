using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Issue> Issues = new List<Issue> 
            {
                new Issue {IssueType="Elektirik"},
                new Issue {IssueType="Tuvalet"},
                new Issue {IssueType="Hava"},
                new Issue {IssueType="Projeksiyon"},


            };
            foreach (Issue item in Issues)
            {
                cmbIssueType.Items.Add(item);
            }

            List<Saloon> Salonlar = new List<Saloon>
            {
                new Saloon {SaloonName="Normal Oda",UnitPrice=50,Description ="Her kaliteye hizmet eder"},
                new Saloon {SaloonName="Suit Oda", UnitPrice =100,Description ="Orta sınıf iyiliğinde"},
                
                new Saloon {SaloonName="Kral Oda", UnitPrice=150,Description ="Yüksek kalite"}
            };
            foreach (Saloon item in Salonlar)
            {
                cmbSaloon.Items.Add(item);
            }

        }

        private void cmbSaloon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSaloon.SelectedIndex>-1)
            {
                lblDescription.Text = (cmbSaloon.SelectedItem as Saloon).BilgiGoster();
            }

            else
            {
                lblDescription.Text = "";
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            Customer c = new Customer();

            c.CompanyName = txtCompanyName.Text;
            c.PhoneNo = txtPhoneNumber.Text;

            if (cmbSaloon.SelectedItem ==null)
            {
                MessageBox.Show("Salon seçiniz");
                return;
            }
            o.Saloon = cmbSaloon.SelectedItem as Saloon;

            if (rdbMedium.Checked)
            {
                o.Active = ENTITIES.Enums.Activity.Medium;
            }
            else if (rdbHigh.Checked)
            {
                o.Active = ENTITIES.Enums.Activity.High;
            }
            else if (rdbLow.Checked) { o.Active = ENTITIES.Enums.Activity.Low; }

            foreach (CheckBox item in grpExtra.Controls)
            {
                if (item.Checked)
                {
                    Extra ext = new Extra();
                    ext.Name = item.Text;
                    ext.UnitPrice = Convert.ToDecimal(item.Tag);
                    o.Extras.Add(ext);
                }
            }
            o.TutarHesapla();
            lstStands.Items.Add(o);
        }

        private void btnAddIssue_Click(object sender, EventArgs e)
        {
            Issue i = new Issue();

            i.IssueType = (cmbIssueType.SelectedItem as Issue).IssueType;
            i.Description = txtDetails.Text;

            lstIssues.Items.Add(i);
        }

        private void lstIssues_Click(object sender, EventArgs e)
        {

        }
    }
}
