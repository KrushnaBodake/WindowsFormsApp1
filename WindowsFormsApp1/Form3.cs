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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtManId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinaryWriter_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtManId.Text));
                bw.Write(txtManName.Text);
                bw.Write(txtManLocation.Text);
                bw.Close();
                fs.Close();
                MessageBox.Show("Data Saved to File");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryReader_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\SkillMineDoc1\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtManId.Text = br.ReadInt32().ToString();
                txtManName.Text = br.ReadString();
                txtManLocation.Text = br.ReadString();
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"E:\SkillMineDoc1");

            try
            {
                if (info.Exists)
                {
                    MessageBox.Show("Directory is already exists");
                }
                else
                {
                    info.Create();
                    MessageBox.Show("Directory created..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            FileInfo fileinfo = new FileInfo(@"E:\SkillMineDoc1\Test1.txt");
            try
            {
                if (fileinfo.Exists)
                {
                    MessageBox.Show("File is already exists");
                }
                else
                {
                    fileinfo.Create();
                    MessageBox.Show("File created");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
