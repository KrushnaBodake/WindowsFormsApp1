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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc\Student.dat", FileMode.Create, FileAccess.Write);
                Student stu = new Student();
                stu.StuId = Convert.ToInt32(txtStuId.Text);
                stu.StuName = txtStuName.Text;
                stu.Percentage = Convert.ToDouble(txtPercentage.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, stu);
                fs.Close();
                MessageBox.Show("Student Record Added to File");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc\Student.dat", FileMode.Open, FileAccess.Read);
                Student stu = new Student();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                stu = (Student)binaryFormatter.Deserialize(fs);
                fs.Close();
                txtStuId.Text = stu.StuId.ToString();
                txtStuName.Text = stu.StuName;
                txtPercentage.Text = stu.Percentage.ToString();
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
                FileStream fs = new FileStream(@"E:\SkillMineDoc\StudentXml.xml", FileMode.Create, FileAccess.Write);
                Student stu = new Student();
                stu.StuId= Convert.ToInt32(txtStuId.Text);
                stu.StuName = txtStuName.Text;
                stu.Percentage = Convert.ToDouble(txtPercentage.Text);
                XmlSerializer xml = new XmlSerializer(typeof(Student));  //
                xml.Serialize(fs, stu);
                fs.Close();
                MessageBox.Show("Student Record Added to File");
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
                FileStream fs = new FileStream(@"E:\SkillMineDoc\StudentXml.xml", FileMode.Open, FileAccess.Read);
                Student stu = new Student();
                XmlSerializer xml = new XmlSerializer(typeof(Student));
                stu = (Student)xml.Deserialize(fs);
                fs.Close();
                txtStuId.Text = stu.StuId.ToString();
                txtStuName.Text = stu.StuName;
                txtPercentage.Text = stu.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc\StudentSOAP.soap", FileMode.Create, FileAccess.Write);
                Student stu = new Student();
                stu.StuId = Convert.ToInt32(txtStuId.Text);
                stu.StuName = txtStuName.Text;
                stu.Percentage = Convert.ToDouble(txtPercentage.Text);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, stu);
                fs.Close();
                MessageBox.Show("Student Record Added to File");
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
                FileStream fs = new FileStream(@"E:\SkillMineDoc\StudentSOAP.soap", FileMode.Open, FileAccess.Read);
                Student stu = new Student();
                SoapFormatter soapFormatter = new SoapFormatter();
                stu = (Student)soapFormatter.Deserialize(fs);
                fs.Close();
                txtStuId.Text = stu.StuId.ToString();
                txtStuName.Text = stu.StuName;
                txtPercentage.Text = stu.Percentage.ToString();
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
               
                FileStream fs = new FileStream(@"E:\SkillMineDoc\StudentJSON.json", FileMode.Create, FileAccess.Write);
                
                Student stu = new Student();
                stu.StuId = Convert.ToInt32(txtStuId.Text);
                stu.StuName = txtStuName.Text;
                stu.Percentage = Convert.ToDouble(txtPercentage.Text);
               
                JsonSerializer.Serialize<Student>(fs,stu);
                fs.Close();
                MessageBox.Show("Student record added to file");

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
                FileStream fs = new FileStream(@"E:\SkillMineDoc\StudentJSON.json", FileMode.Open, FileAccess.Read);
                // step 2
                Student stu = new Student();
                // step 3

                stu = JsonSerializer.Deserialize<Student>(fs);
                fs.Close();

                txtStuId.Text = stu.StuId.ToString();
                txtStuName.Text = stu.StuName;
                txtPercentage.Text = stu.Percentage.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
