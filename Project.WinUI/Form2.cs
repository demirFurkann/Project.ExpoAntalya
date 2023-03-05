using Project.BLL.GenericRepository.ConcRep;
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
        OrderRepository _orderRep;
        OrderExtraRepository _orderExtrasRep;
        CustomerRepository _customerRep;
        IssueRepository _issueRep;

        public Form2()
        {
            InitializeComponent();
            _orderExtrasRep= new OrderExtraRepository();
            _orderRep = new OrderRepository();
            _customerRep = new CustomerRepository();
            _issueRep = new IssueRepository();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Issue> Issues = new List<Issue> 
            {
                new Issue {IssueType="Elektirik"},
                new Issue {IssueType="Tuvalet"}



            };
            foreach (Issue item in Issues)
            {
                cmbIssueType.Items.Add(item);
            }

            List<Saloon> Salonlar = new List<Saloon>
            {
                new Saloon {SaloonName="100 m2",UnitPrice=50,Description ="Her kaliteye hizmet eder"},
                new Saloon {SaloonName="200 m2", UnitPrice =100,Description ="Orta sınıf iyiliğinde"},              
                new Saloon {SaloonName="300 m2", UnitPrice=150,Description ="Yüksek kalite"}
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
            _customerRep.Add(c);

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
                    OrderExtra ordext = new OrderExtra();
                    ordext.Extra.Name= item.Text;
                    ordext.Extra.UnitPrice = Convert.ToDecimal(item.Tag);
                    o.OrderExtras.Add(ordext);  
                }
            }
            _orderRep.Add(o);
            o.TutarHesapla();
            lstStands.Items.Add(o);
        }

        private void btnAddIssue_Click(object sender, EventArgs e)
        {
            Issue i = new Issue();
            SaloonIssue si = new SaloonIssue();
            
            i.IssueType = (cmbIssueType.SelectedItem as Issue).IssueType;
            i.Description = txtDetails.Text;
            si.Issue = i;
            _issueRep.Add(i);
            lstIssues.Items.Add(i);

        }
        
       
        private void lstIssues_Click(object sender, EventArgs e)
        {



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
