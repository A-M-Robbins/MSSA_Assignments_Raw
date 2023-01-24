using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace MSSAassignment4dot3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitComboBox();

        }
        Student stu = new Student();

        private void InitComboBox()
        {
            foreach (var item in Enum.GetNames(typeof(Student.MonthOfAdmission)))
            {

                comboBox1.Items.Add(item.Replace("_", " "));
            }
            comboBox1.SelectedIndex = (int)Student.MonthOfAdmission.January;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WHY DID YOU DO THAT!?!?!?");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void gridview()
        {
            //dataGridView1.DataSource = MakeMeASandwich();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            stu.StudentID = textBox1.Text;
            stu.Firstname = textBox2.Text;
            stu.Lastname = textBox3.Text;
            stu.Address = (textBox4.Text);
            stu.Grade = (textBox6.Text);
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.Text, textBox6.Text);
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox6.ResetText();
            // dataGridView1.Rows.Add("dog" + "cat" + "pig" );
            //  dataGridView1.Columns.Add("Student ID", "Age");
        }
        private void DeleteRec()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRec();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveState();
        }
        private void SaveState()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;


            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Export from gridview";

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                //worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    struct Student
    {

        private string _studid;
        private string _firstname;
        private string _lastname;
        private string _address;
        private string _grade;

        public string StudentID
        {
            get { return _studid; }
            set { _studid = value; }
        }
        public string Firstname
        { get { return _firstname; } set { _firstname = value; } }
        public string Lastname
        { get { return _lastname; } set { _lastname = value; } }
        public string Address
        { get { return _address; } set { _address = value; } }
        public string Grade
        { get { return _grade; } set { _grade = value; } }
        private MonthOfAdmission _monthOfAdmission
        {
            get;
            set;
        }
        public enum MonthOfAdmission
        {
            MonthNotValid,
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }



        public Student(string StudentId, string FirstName, string LastName, string Address, string Grade, MonthOfAdmission MOA)
        {
            _studid = StudentId;
            _firstname = FirstName;
            _lastname = LastName;
            _address = Address;
            _grade = Grade;
            _monthOfAdmission = MOA;
            //foreach (MonthOfAdmission monthOfAdmission in (MonthOfAdmission[]) Enum.GetValues(typeof(MonthOfAdmission)))
            //{

            //}
        }

    }


}
