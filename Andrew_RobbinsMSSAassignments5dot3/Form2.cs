using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSAassignment5._3
{
    public partial class Form2 : Form
    {
        int studentNumber = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        class Student
        {
            public string StudentName
            {
                get;
                set;
            }
            public string StudentId
            {
                get;
                set;
            }
            public double Gpa
            {
                get;
                set;
            }
        }
        Student stu = new Student();
        IDictionary<string, double> GpaDictionary = new Dictionary<string, double>();

        private void entrBtn1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(gpaStudTxtBx1.Text) || !string.IsNullOrWhiteSpace(stdntIdTxtbx1.Text) || !string.IsNullOrWhiteSpace(stdntNameTxtBx1.Text))
            {
                stu.StudentName = stdntNameTxtBx1.Text;
                stu.StudentId = stdntIdTxtbx1.Text;
                StoreGpaWithName();
                dataGridView1.Rows.Add(stu.StudentId.ToUpper(), stu.StudentName, stu.Gpa);
                ClearTxtBoxes();
            }
            else
            {
                
                MessageBox.Show("Error.\n Please enter values for all boxes.");
                ClearTxtBoxes();
            }
            

        }
        private void StoreGpaWithName()
        {
            try
            {
                string allStudentDetails = stu.StudentName + " , " + stu.StudentId + " , ";
                stu.Gpa = Convert.ToDouble(gpaStudTxtBx1.Text);
                GpaDictionary.Add(allStudentDetails, stu.Gpa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Why tho?\n\nFill in the boxes first.", "Don't do that!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private string CheckHighestGpa()// Checks which student has the highest GPA and orders them by decsending
        {
            GpaDictionary = GpaDictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);// sorts from largest to smallest == Index [0] is the LARGEST 
            return GpaDictionary.FirstOrDefault().ToString();
            //^^^^Displays who has the highest GPA...[ Name and then GPA] and returns it
        }
        private void ClearTxtBoxes()
        {
            stdntNameTxtBx1.Clear();
            stdntIdTxtbx1.Clear();
            gpaStudTxtBx1.Clear();
        }
        private void SaveToText()
        {
            string fileName;
            CheckHighestGpa();
            fileName = @"C:\Users\andre\Documents\C_Sharp\5dot3TeachersAddingStudents1111.txt";
            WriteItUp(fileName);
        }

        private void WriteItUp(string fileName)
        {
            int studentSet = 1;
            string header;
            header = "\n-Student Number ";
            if (!File.Exists(fileName))
            {
                StreamWriter write = new StreamWriter(fileName);//how do i make the below forloops into a METHOD?!?!?!
                write.WriteLine("*******LIST OF ALL STUDENTS*******");
                write.WriteLine("--Set of students # {0}--\n", studentSet);//Each time we make a new save
                write.WriteLine("Student Information (Student ID, Student Name, GPA)");//Explains the format data will be saved in
                write.WriteLine("The student with the highest GPA is " + CheckHighestGpa());
                write.WriteLine("************");

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)//RowCount -1 because if not the writer will write the default empty row on datagrid viewer
                {
                    string lines = "";
                    for (int col = 0; col < dataGridView1.ColumnCount; col++)
                    {
                        if (dataGridView1.Rows[i].Cells[col].Value != null)
                        {
                            lines += (string.IsNullOrEmpty(lines) ? " " : ", ") + dataGridView1.Rows[i].Cells[col].Value.ToString();

                        }
                        else
                        {

                        }
                    }
                    studentNumber++;//Counts each student as a new student
                    write.WriteLine(header + studentNumber);
                    write.WriteLine(lines);
                }

                write.Close();
            }
            else
            {
                StreamWriter write = File.AppendText(fileName);
                studentSet++;
                write.WriteLine("\n--Set of students # {0}--\n", studentSet);
                write.WriteLine("Student Information (Student ID, Student Name, GPA)");
                write.WriteLine("The student with the highest GPA is " + CheckHighestGpa());
                write.WriteLine("************");

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    string lines = "";
                    for (int col = 0; col < dataGridView1.ColumnCount; col++)
                    {
                        if (dataGridView1.Rows[i].Cells[col].Value != null)
                        {
                            lines += (string.IsNullOrEmpty(lines) ? " " : ", ") + dataGridView1.Rows[i].Cells[col].Value.ToString();
                        }
                        else
                        {

                        }
                    }

                    studentNumber++;
                    write.WriteLine(header + studentNumber);
                    write.WriteLine(lines);
                }
                write.Close();
            }
            Process.Start(fileName);

        }
        private void saveToTxtdoxBtn_Click(object sender, EventArgs e)
        {
            SaveToText();

        }

        private void deleteBtn1_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete this row?";
            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//generates a messagebox that has yes or no buttons and a header of Message with a questionmark icon
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dataGridView1.Rows.Remove(row);
                }

            }
            else
            {
                MessageBox.Show("Do better");
            }

        }
    }
    
}
