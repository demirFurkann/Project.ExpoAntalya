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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
			_emplyProfileRep = new EmployeeRepository();

		}
        EmployeeRepository _emplyProfileRep;


		private void btnLogin_Click(object sender, EventArgs e)
        {

            // if (_emplyProfileRep.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text)) ;



            Employee em = new Employee();
            em.UserName = txtUserName.Text;
            em.Password = txtPassword.Text;

            if (em.UserName == "admin" && em.Password == "123")
            {
                MessageBox.Show("Welcome!");
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or pw..");
                return;
            }
        }
    }
}
