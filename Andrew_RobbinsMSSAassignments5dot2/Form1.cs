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
using System.Runtime.CompilerServices;
using System.Reflection;
using Microsoft.Office.Interop.Excel;

namespace MSSAassignment5dot2
{
    public partial class Form1 : Form
    {
        IDictionary<string, List<string>> PhoneBookDict = new Dictionary<string, List<string>>();

        public Form1()
        {
            InitializeComponent();
        }
        private void SaveState()
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "My PhoneBook";

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    //worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        {
                            break;
                        }
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void RemoveDatagridValues()
        {
            string message = "Are you sure you want to delete this row?";
            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)//generates a messagebox that has yes or no buttons and a header of Message with a questionmark icon
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class Person
        {
            public string FirstName
            {
                get;
                set;
            }
            public string LastName
            {
                get;
                set;
            }
            public string MobilePhone
            {
                get;
                set;
            }
            public string WorkPhone
            {
                get;
                set;
            }
            public string Address
            {
                get;
                set;
            }
        }
        private void ClearTextBoxes()
        {

            fNameTxtbx.Clear();
            lasNameTxtbx.Clear();
            mPhneTxtbx.Clear();
            wPhneTxtbx.Clear();
            adrssTxtbx.Clear();
            searchTxtbx.Clear();
        }
        Person prsn = new Person();
        List<string> List_NewPrsonInfo = new List<string>();
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Person prsn = new Person();
                List<string> List_NewPrsonInfo = new List<string>();
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone(); ;
                prsn.FirstName = fNameTxtbx.Text;
                prsn.LastName = lasNameTxtbx.Text;
                prsn.MobilePhone = mPhneTxtbx.Text;
                prsn.WorkPhone = wPhneTxtbx.Text;
                prsn.Address = adrssTxtbx.Text;
                List_NewPrsonInfo.Add(prsn.FirstName);
                List_NewPrsonInfo.Add(prsn.LastName);
                List_NewPrsonInfo.Add(prsn.MobilePhone);
                List_NewPrsonInfo.Add(prsn.WorkPhone);
                List_NewPrsonInfo.Add(prsn.Address);
                PhoneBookDict.Add(prsn.FirstName.ToUpper(), List_NewPrsonInfo);//uses FIRST NAME as a KEY and then the LIST called NewPersonInfo which stores multiple values
                                                                          //     dataGridView1.Rows.Add(prsn.FirstName, prsn.LastName, prsn.MobilePhone, prsn.WorkPhone, prsn.Address);
                var index = dataGridView1.Rows.Add();
                for (int i = 0; i < 5; i++)
                {
                    dataGridView1.Rows[index].Cells[i].Value = List_NewPrsonInfo[i]; //***adds firstname that is stored in the NewPersonInfor List to the first name column in the data grid, and SO ON * **
                }
                ClearTextBoxes();
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void sveToExcellBtn_Click(object sender, EventArgs e)
        {
            SaveState();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            RemoveDatagridValues();
        }
       
        
        
        string allDictValues = "Contact Info :";
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string search = searchTxtbx.Text.ToUpper();
            if (PhoneBookDict.ContainsKey(search))
            {
                try
                {

                    foreach (var keyPair in PhoneBookDict)
                    {
                        if (keyPair.Key == search)
                        {
                            
                            allDictValues = allDictValues + "\nFirst Name: " + keyPair.Value[0] + "\nLast Name: " + keyPair.Value[1] + "\nMobile Number : " + keyPair.Value[2] + "\nWork Number: " + keyPair.Value[3] + "\nAddress: " + keyPair.Value[4];
                        }
                    }
                    MessageBox.Show("Contact found \n" + allDictValues);

                }
                catch (Exception)
                {
                }
            }
            else
            {
                MessageBox.Show("Contact not found please try again");
                ClearTextBoxes();
            }
            ClearTextBoxes();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Remove_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
