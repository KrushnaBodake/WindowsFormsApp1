using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc\Employee.dat", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtid.Text);
                emp.Name = txtname.Text;
                emp.Salary = Convert.ToDouble(txtsalary.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee Record Added to File");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc\Employee.dat", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp=(Employee) binaryFormatter.Deserialize(fs);
                fs.Close();
                txtid.Text = emp.Id.ToString();
                txtname.Text = emp.Name;
                txtsalary.Text = emp.Salary.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc\EmployeeSOAP.soap", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtid.Text);
                emp.Name = txtname.Text;
                emp.Salary = Convert.ToDouble(txtsalary.Text);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee Record Added to File");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc\EmployeeSOAP.soap", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                SoapFormatter soapFormatter = new SoapFormatter();
                emp = (Employee)soapFormatter.Deserialize(fs);
                fs.Close();
                txtid.Text = emp.Id.ToString();
                txtname.Text = emp.Name;
                txtsalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc\EmployeeXml.xml", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtid.Text);
                emp.Name = txtname.Text;
                emp.Salary = Convert.ToDouble(txtsalary.Text);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));  //
                xml.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee Record Added to File");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc\EmployeeXml.xml", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                 XmlSerializer xml = new XmlSerializer(typeof(Employee));
                emp = (Employee)xml.Deserialize(fs);
                fs.Close();
                txtid.Text = emp.Id.ToString();
                txtname.Text = emp.Name;
                txtsalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"E:\SkillMineDoc\EmployeeJSON.json", FileMode.Create, FileAccess.Write);
                // step 2
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtid.Text);
                emp.Name = txtname.Text;
                emp.Salary = Convert.ToInt32(txtsalary.Text);
                // step 3
                JsonSerializer.Serialize<Employee>(fs, emp);
                fs.Close();
                MessageBox.Show("Employee record added to file");
                                             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"E:\SkillMineDoc\EmployeeJSON.json", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3

                emp = JsonSerializer.Deserialize<Employee>(fs);
                fs.Close();

                txtid.Text = emp.Id.ToString();
                txtname.Text = emp.Name;
                txtsalary.Text = emp.Salary.ToString();
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
