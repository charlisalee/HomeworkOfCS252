using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150508
{
    public partial class Form1 : Form
    {
        private Employee Charlisa;



        //建構式
        public Form1()
        {
            InitializeComponent();
            Charlisa = new Employee();

        }

        private void setSalaryButtonA_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(salaryTextBox.Text);
            Charlisa.setSalary(salary);

            MessageBox.Show("Charlisa's salary is:" + Charlisa.getSalary(salary).ToString());

        }

        private void setSalaryButtonB_Click(object sender, EventArgs e)
        {

        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

