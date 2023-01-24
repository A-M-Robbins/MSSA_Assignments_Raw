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

namespace MSSAassignment5dot2dot
{
    public partial class Phonebook : Form
    {
        DataTable contacts = new DataTable();
        IDictionary<string, string> PhoneBookDictionary = new Dictionary<string, string>();
        bool userEditing = false;
        Person prsn = new Person();
        public Phonebook()
        {
            InitializeComponent();
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

        private void Phonebook_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("First Name");
            contacts.Columns.Add("Last Name");
            contacts.Columns.Add(" Mobile Phone");
            contacts.Columns.Add("Work Number");
            contacts.Columns.Add("Address");

        }
        private void SaveToExcell()
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook2 = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet1 = null;


                app.Visible = true;
                worksheet1 = workbook2.Sheets["Sheet2"];
                worksheet1 = workbook2.ActiveSheet;
                worksheet1.Name = "My PhoneBook";
                
                for (int i = 0; i < contactsDataGrid.Columns.Count; i++)
                {
                    //worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < contactsDataGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < contactsDataGrid.Columns.Count; j++)
                    {
                        worksheet1.Cells[i + 2, j + 1] = contactsDataGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void contactsDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addCntctBtn_Click(object sender, EventArgs e)
        {
            prsn.FirstName = frstNmeTxtBx.Text;
            prsn.LastName = lastNmeTxtBx.Text;
            prsn.MobilePhone = mblPhneTxtBx.Text;
            prsn.WorkPhone = wrkPhneTxtBx.Text;
            prsn.Address = addrssTxtBx.Text;
            addToDict();
            ClearTextBoxes();
        }
        private void addToDict()
        {
            PhoneBookDictionary.Add(prsn.FirstName, ("" + prsn.FirstName + "," + prsn.LastName + "," + prsn.MobilePhone + "," + prsn.WorkPhone + "," + prsn.Address));
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            frstNmeTxtBx.Clear();
            lastNmeTxtBx.Clear();
            mblPhneTxtBx.Clear();
            wrkPhneTxtBx.Clear();
            addrssTxtBx.Clear();
        }
        private void delContactBtn_Click(object sender, EventArgs e)
        {


        }

        private void dsplayBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}