using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double basic = Convert.ToDouble(txtBasic.Text);
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtid.Text + " " + txtname.Text + " " + txtsalary.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtsalary.Clear();
        }

        private void btnCalSalary_Click(object sender, EventArgs e)
        {
            double basic = Convert.ToDouble(txtBasic.Text);
            double hra = basic * 0.1;
            double da = basic * 0.05; 
            double pf = basic * 0.12;
            double totalsal = (basic + hra + da) - pf;
            
            txtHRA.Text = hra.ToString();
            txtDA.Text = da.ToString();
            txtPf.Text = pf.ToString();
            txtsalary.Text = totalsal.ToString();           
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"E:\SkillMineDoc";
            try
            {
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory is already exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory created....");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            String path = @"E:\SkillMineDoc\Text.txt";
            try
            {
                if(File.Exists(path))
                {
                    MessageBox.Show("File is Already Exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File is Created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            String path = @"E:\SkillMineDoc\Text.txt";
            try
            {
                if(File.Exists(path))
                {
                    File.Delete(path);
                    MessageBox.Show("file has been removed");
                }
                else
                {
                    MessageBox.Show("file Not Found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryWriter_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtid.Text));
                bw.Write(txtname.Text);
                bw.Write(Convert.ToDouble(txtsalary.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Data Saved to File");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnBinaryReader_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtid.Text = br.ReadInt32().ToString();
                txtname.Text = br.ReadString();
                txtsalary.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
