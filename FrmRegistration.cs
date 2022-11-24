using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Creating_Text_File
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            {
                string SetFilename = txtStudentNo.Text + ".txt";
                String StudentNo = txtStudentNo.Text;
                String LastName = txtLastName.Text;
                String Age = txtAge.Text;
                String Birthday = dateBirthday.Text;
                String Prorgam = comboProgram.Text;
                String FirstName = txtFirstName.Text;
                String MI = txtMI.Text;
                String Gender = comboGender.Text;
                String ContactNo = txtContactNo.Text;

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, SetFilename)))
                {
                    outputFile.WriteLine("Student No.:" + StudentNo);
                    outputFile.WriteLine("Full Name:" + LastName + "," + FirstName + "," + MI);
                    outputFile.WriteLine("Program:" + Prorgam);
                    outputFile.WriteLine("Gender:" + Gender);
                    outputFile.WriteLine("Age:" + Age);
                    outputFile.WriteLine("Birthday:" + Birthday);
                    outputFile.WriteLine("Contact No.:" + ContactNo);
                }
                Close();
            }
        }
    }
}
