using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationEmployee
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            PartTimeEmployee employee = new PartTimeEmployee();


            employee.Name = TxtFirstName.Text;
            employee.LastName = TxtLastName.Text;
            employee.JobTitle = TxtJobTitle.Text;
            employee.RatePerHour = Convert.ToDouble(TxtRatePerHour.Text);
            employee.HoursWorked = Convert.ToDouble(TxtHoursWorked.Text);


            double salary = employee.CalculateSalary();


            lbl_Result.Text = $"First Name: {employee.Name}\n" +
                $"\nLast Name {employee.LastName}\n" +
                $"\nBasic Salary: {salary:C}";
        }
    }
}
