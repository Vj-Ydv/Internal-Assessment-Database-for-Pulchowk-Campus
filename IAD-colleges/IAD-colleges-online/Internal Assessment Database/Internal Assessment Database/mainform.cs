using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;
using DGVPrinterHelper;

namespace Internal_Assessment_Database
{
    public partial class mainform : Form
    {
        public mainform(string str1,string str2)
        {
            InitializeComponent();
            autocompletetxt();
            // autocomplete_collegename();
            user.Text = str1;
            comboBox7.Text = str2;
           
        }

        void fillcombobox_program()
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select distinct ProgramCode from internals.program;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string sprogram = myReader.GetString("ProgramCode");
                    comboBox1.Items.Add(sprogram);
                }
                conDataBase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillcombobox_batch()
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select distinct Batch from internals.student;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                    string sbatch = myReader.GetString("Batch");
                    comboBox2.Items.Add(sbatch);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillcombobox_groupname()
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select distinct GroupName from internals.student;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                    string sgroup = myReader.GetString("GroupName");
                    comboBox4.Items.Add(sgroup);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillcombobox_subjectcode()
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select distinct SubjectCode from internals.subject;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                    string ssub = myReader.GetString("SubjectCode");
                    comboBox3.Items.Add(ssub);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillcombobox_subjectname()
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select distinct SubjectName from internals.subject;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                    string ssub = myReader.GetString("SubjectName");
                    comboBox6.Items.Add(ssub);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillcombobox_collegecode()
        {

           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select distinct CollegeName from internals.college;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                    string college= myReader.GetString("CollegeName");
                    comboBox8.Items.Add(college);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        DataTable dbdataset;

        void load_theoryobtained()
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select t.RollNo,t.Fname,t.MiddleName,t.Lname,m.TheoryObtained as MarksObtained,m.TheoryInWords as InWords,m.TheoryRemarks as Remarks from (select s.RollNO,s.Fname,s.MiddleName,s.Lname from internals.student s where s.CollegeCode='"+comboBox7.Text+"' and s.ProgramCode='" + comboBox1.Text + "' and s.Batch='" + comboBox2.Text + "' and s.GroupName='" + comboBox4.Text + "' ) as t inner join internals.marks m on t.RollNo=m.RollNo where m.SubjectCode='" + comboBox3.Text + "';", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;

                sda.Update(dbdataset);

                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void load_theoryobtained_with_username()
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select t.RollNo,t.Fname,t.MiddleName,t.Lname,m.TheoryObtained as MarksObtained,m.TheoryInWords as InWords,m.TheoryRemarks as Remarks,m.UserName,m.TheoryStatus from (select s.RollNO,s.Fname,s.MiddleName,s.Lname from internals.student s where s.CollegeCode='" + comboBox7.Text + "' and s.ProgramCode='" + comboBox1.Text + "' and s.Batch='" + comboBox2.Text + "' and s.GroupName='" + comboBox4.Text + "' ) as t inner join internals.marks m on t.RollNo=m.RollNo where m.SubjectCode='" + comboBox3.Text + "';", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;

                sda.Update(dbdataset);
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void load_practicalobtained()
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select t.RollNo,t.Fname,t.MiddleName,t.Lname,m.PracticalObtained as MarksObtained,m.PracticalInWords as InWords,m.PracticalRemarks as Remarks from (select s.RollNO,s.Fname,s.MiddleName,s.Lname from internals.student s where s.CollegeCode='"+comboBox7.Text+"' and s.ProgramCode='" + comboBox1.Text + "' and s.Batch='" + comboBox2.Text + "' and s.GroupName='" + comboBox4.Text + "' ) as t inner join internals.marks m on t.RollNo=m.RollNo where m.SubjectCode='" + comboBox3.Text + "';", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;

                sda.Update(dbdataset);
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void load_practicalobtained_with_username()
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select t.RollNo,t.Fname,t.MiddleName,t.Lname,m.PracticalObtained as MarksObtained,m.PracticalInWords as InWords,m.PracticalRemarks as Remarks,m.UserName,m.PracticalStatus from (select s.RollNO,s.Fname,s.MiddleName,s.Lname from internals.student s where s.CollegeCode='" + comboBox7.Text + "' and s.ProgramCode='" + comboBox1.Text + "' and s.Batch='" + comboBox2.Text + "' and s.GroupName='" + comboBox4.Text + "' ) as t inner join internals.marks m on t.RollNo=m.RollNo where m.SubjectCode='" + comboBox3.Text + "';", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;

                sda.Update(dbdataset);
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void loadtable_to_addmarks()
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select s.RollNo,s.Fname,s.MiddleName,s.Lname from internals.student s where CollegeCode='"+comboBox7.Text+"' and s.ProgramCode='" + comboBox1.Text + "' and s.Batch='" + comboBox2.Text + "' and s.GroupName='" + comboBox4.Text + "';", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;

                sda.Update(dbdataset);
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void autocompletetxt()
        {
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox6.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox6.AutoCompleteSource = AutoCompleteSource.CustomSource;
           
            AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection col2 = new AutoCompleteStringCollection();
            

           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select SubjectCode,SubjectName from internals.subject", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string ssubcode = myReader.GetString("SubjectCode");
                    col1.Add(ssubcode);
                    string ssubname = myReader.GetString("SubjectName");
                    col2.Add(ssubname);
                }
                conDataBase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox3.AutoCompleteCustomSource = col1;

            comboBox6.AutoCompleteCustomSource = col2;


        }

        void autocomplete_collegename()
        {
            comboBox8.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox8.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();
          String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select CollegeName from internals.college", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string cname = myReader.GetString("CollegeName");
                    col1.Add(cname);
                    
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox8.AutoCompleteCustomSource = col1;

          
        }

        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "Zero";

            if (number < 0)
                return "Minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        void select_collegecode()
        {
            try
            {
               String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand("select CollegeName from internals.college s where CollegeCode='" + comboBox7.Text + "';", conDataBase);
                MySqlDataReader myReader;
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (myReader.Read())
                {
                    String tfull = myReader.GetString("CollegeName");
                    comboBox8.Text = tfull;


                }

                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            select_collegecode();
            panel1.Height = 635;
            dataGridView1.Height = 623;
            
            fillcombobox_program();
            fillcombobox_batch();
            fillcombobox_groupname();
            fillcombobox_subjectcode();
            fillcombobox_subjectname();
           // fillcombobox_collegecode();
           

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
           
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            
        }


        void remark_theory_through_add()
        {

            int counterror = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                if (remarks == "")
                {
                    dataGridView1.Rows[i].Cells[5].Value = "0";

                }
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string skip = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                if (skip == "0")
                {
                    dataGridView1.Rows[i].Cells[6].Value = "-";
                    dataGridView1.Rows[i].Cells[7].Value = "Absent";
                    continue;
                }

                int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                if (p > 0 && p < Convert.ToInt32(textBox2.Text))
                {
                    string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                    inwords = NumberToWords(p);
                    dataGridView1.Rows[i].Cells[6].Value = inwords;

                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                    remarks = "Fail";
                    dataGridView1.Rows[i].Cells[7].Value = remarks;
                }
                else if (p >= Convert.ToInt32(textBox2.Text) && p <= Convert.ToInt32(textBox1.Text))
                {

                    string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                    inwords = NumberToWords(p);
                    dataGridView1.Rows[i].Cells[6].Value = inwords;

                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                    remarks = "Pass";
                    dataGridView1.Rows[i].Cells[7].Value = remarks;
                }
                else
                {
                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                    remarks = "Invalid mark";
                    dataGridView1.Rows[i].Cells[6].Value = remarks;
                    dataGridView1.Rows[i].Cells[7].Value = remarks;
                    counterror = counterror + 1;
                }
            }

            if (counterror == 0)
            {
                errorflag = 0;
            }
            else
            {
                errorflag = 1;
            }
            counterror = 0;

        }

        void remark_practical_through_add()
        {

            int counterror = 0;
            try
            {




                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                    if (remarks == "")
                    {
                        dataGridView1.Rows[i].Cells[5].Value = "0";

                    }
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {


                    string skip = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                    if (skip == "0")
                    {
                        dataGridView1.Rows[i].Cells[6].Value = "-";
                        dataGridView1.Rows[i].Cells[7].Value = "Absent";
                        continue;
                    }

                    int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    if (p > 0 && p < Convert.ToInt32(textBox2.Text))
                    {
                        string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                        inwords = NumberToWords(p);
                        dataGridView1.Rows[i].Cells[6].Value = inwords;

                        string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                        remarks = "Fail";
                        dataGridView1.Rows[i].Cells[7].Value = remarks;
                    }
                    else if (p >= Convert.ToInt32(textBox2.Text) && p <= Convert.ToInt32(textBox1.Text))
                    {

                        string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                        inwords = NumberToWords(p);
                        dataGridView1.Rows[i].Cells[6].Value = inwords;

                        string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                        remarks = "Pass";
                        dataGridView1.Rows[i].Cells[7].Value = remarks;
                    }
                    else
                    {
                        string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                        remarks = "Invalid mark";
                        dataGridView1.Rows[i].Cells[6].Value = remarks;
                        dataGridView1.Rows[i].Cells[7].Value = remarks;

                        counterror = counterror + 1;
                    }
                }


                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[8].Value);
                    if (remarks == "")
                    {
                        dataGridView1.Rows[i].Cells[8].Value = "0";

                    }
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string skip = Convert.ToString(dataGridView1.Rows[i].Cells[8].Value);
                    if (skip == "0")
                    {
                        dataGridView1.Rows[i].Cells[9].Value = "-";
                        dataGridView1.Rows[i].Cells[10].Value = "Absent";
                        continue;
                    }
                    int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
                    if (p > 0 && p < Convert.ToInt32(textBox4.Text))
                    {
                        string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[9].Value);
                        inwords = NumberToWords(p);
                        dataGridView1.Rows[i].Cells[9].Value = inwords;

                        string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[10].Value);
                        remarks = "Fail";
                        dataGridView1.Rows[i].Cells[10].Value = remarks;
                    }
                    else if (p >= Convert.ToInt32(textBox4.Text) && p <= Convert.ToInt32(textBox3.Text))
                    {
                        string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[9].Value);
                        inwords = NumberToWords(p);
                        dataGridView1.Rows[i].Cells[9].Value = inwords;

                        string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[10].Value);
                        remarks = "Pass";
                        dataGridView1.Rows[i].Cells[10].Value = remarks;
                    }

                    else
                    {
                        string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[10].Value);
                        remarks = "Invalid mark";
                        dataGridView1.Rows[i].Cells[9].Value = remarks;
                        dataGridView1.Rows[i].Cells[10].Value = remarks;



                        counterror = counterror + 1;
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (counterror == 0)
            {
                errorflag = 0;
            }
            else
            {
                errorflag = 1;
            }
            counterror = 0;


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            int counterror = 0;
            try
            {


                if (comboBox5.Text == "Theory")
                {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                        if (remarks == "")
                        {
                            dataGridView1.Rows[i].Cells[5].Value = "0";

                        }
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                        string skip = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                        if (skip == "0")
                        {
                            dataGridView1.Rows[i].Cells[6].Value = "-";
                            dataGridView1.Rows[i].Cells[7].Value = "Absent";
                            continue;
                        }

                       
                       if (p >=0 && p < Convert.ToInt32(textBox2.Text))
                       {
                            
                            string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                            inwords = NumberToWords(p);
                            dataGridView1.Rows[i].Cells[6].Value = inwords;

                            string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                            remarks = "Fail";
                            dataGridView1.Rows[i].Cells[7].Value = remarks;
                       }
                        else if (p >= Convert.ToInt32(textBox2.Text) && p <= Convert.ToInt32(textBox1.Text))
                        {
                            
                            string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                            inwords = NumberToWords(p);
                            dataGridView1.Rows[i].Cells[6].Value = inwords;

                            string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                            remarks = "Pass";
                            dataGridView1.Rows[i].Cells[7].Value = remarks;
                        }
                        else
                        {
                            string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                            remarks = "Invalid mark";
                            dataGridView1.Rows[i].Cells[6].Value = remarks;
                            dataGridView1.Rows[i].Cells[7].Value = remarks;

                            counterror = counterror + 1;
                        }
                    }
                }
                else if (comboBox5.Text == "Practical")
                {


                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[8].Value);
                        if (remarks == "")
                        {
                            dataGridView1.Rows[i].Cells[8].Value = "0";

                        }
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
                        string skip = Convert.ToString(dataGridView1.Rows[i].Cells[8].Value);
                        if (skip == "0")
                        {
                            dataGridView1.Rows[i].Cells[9].Value = "-";
                            dataGridView1.Rows[i].Cells[10].Value = "Absent";
                            continue;
                        }
                        
                       if (p >=0 && p < Convert.ToInt32(textBox4.Text))
                       {
                            string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[9].Value);
                            inwords = NumberToWords(p);
                            dataGridView1.Rows[i].Cells[9].Value = inwords;

                            string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[10].Value);
                            remarks = "Fail";
                            dataGridView1.Rows[i].Cells[10].Value = remarks;
                       }
                        else if (p >= Convert.ToInt32(textBox4.Text) && p <= Convert.ToInt32(textBox3.Text))
                        {
                            string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[9].Value);
                            inwords = NumberToWords(p);
                            dataGridView1.Rows[i].Cells[9].Value = inwords;

                            string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[10].Value);
                            remarks = "Pass";
                            dataGridView1.Rows[i].Cells[10].Value = remarks;
                        }

                        else
                        {
                            string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[10].Value);
                            remarks = "Invalid mark";
                            dataGridView1.Rows[i].Cells[9].Value = remarks;
                            dataGridView1.Rows[i].Cells[10].Value = remarks;



                            counterror = counterror + 1;
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (counterror == 0)
            {
                errorflag = 0;
            }
            else
            {
                errorflag = 1;
            }
            counterror = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                if (comboBox5.Text == "Theory")
                {
                    try
                    {
                        int n = dataGridView1.Columns.Count;

                        for (int j = 1; j < n; j++)
                        {
                            dataGridView1.Columns.RemoveAt(1);
                        }

                        load_theoryobtained_with_username();
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {

                            int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            p = i + 1;
                            dataGridView1.Rows[i].Cells[0].Value = p;


                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
                else if (comboBox5.Text == "Practical")
                {
                    try
                    {
                        int n = dataGridView1.Columns.Count;

                        for (int j = 1; j < n; j++)
                        {
                            dataGridView1.Columns.RemoveAt(1);
                        }

                        load_practicalobtained_with_username();
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {

                            int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            p = i + 1;
                            dataGridView1.Rows[i].Cells[0].Value = p;
                            //dataGridView1.Rows[i].Cells[4].Value = "0";

                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                }

            }
            else
            {
                if (comboBox5.Text == "Theory")
                {
                    try
                    {
                        int n = dataGridView1.Columns.Count;

                        for (int j = 1; j < n; j++)
                        {
                            dataGridView1.Columns.RemoveAt(1);
                        }

                        load_theoryobtained();
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {

                            int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            p = i + 1;
                            dataGridView1.Rows[i].Cells[0].Value = p;


                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
                else if (comboBox5.Text == "Practical")
                {
                    try
                    {
                        int n = dataGridView1.Columns.Count;

                        for (int j = 1; j < n; j++)
                        {
                            dataGridView1.Columns.RemoveAt(1);
                        }

                        load_practicalobtained();
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {

                            int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            p = i + 1;
                            dataGridView1.Rows[i].Cells[0].Value = p;
                            //dataGridView1.Rows[i].Cells[4].Value = "0";

                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dataGridView1.Columns.Count;

                for (int j = 1; j < n; j++)
                {
                    dataGridView1.Columns.RemoveAt(1);
                }

                if (textBox1.Text == "0")
                {
                    loadtable_to_addmarks();
                    dbdataset.Columns.Add(new DataColumn("Practical Obtained", typeof(string)));
                    dbdataset.Columns.Add(new DataColumn("Prac In Words", typeof(string)));
                    dbdataset.Columns.Add(new DataColumn("Practical Remarks", typeof(string)));
                }
                else if (textBox3.Text == "0")
                {
                    loadtable_to_addmarks();
                    dbdataset.Columns.Add(new DataColumn("Theory Obtained", typeof(string)));
                    dbdataset.Columns.Add(new DataColumn("Theory In Words", typeof(string)));
                    dbdataset.Columns.Add(new DataColumn("Theory Remarks", typeof(string)));
                }
                else
                {
                    loadtable_to_addmarks();
                    dbdataset.Columns.Add(new DataColumn("Theory Obtained", typeof(string)));
                    dbdataset.Columns.Add(new DataColumn("Theory In Words", typeof(string)));
                    dbdataset.Columns.Add(new DataColumn("Theory Remarks", typeof(string)));
                    dbdataset.Columns.Add(new DataColumn("Practical Obtained", typeof(string)));
                    dbdataset.Columns.Add(new DataColumn("Prac In Words", typeof(string)));
                    dbdataset.Columns.Add(new DataColumn("Practical Remarks", typeof(string)));
                    //dataGridView1.Columns.Add("newColumnName", "Column Name in Text");
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    p = i + 1;
                    dataGridView1.Rows[i].Cells[0].Value = p;
                    //dataGridView1.Rows[i].Cells[4].Value = "0";

                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                

            }

        }

        
        int errorflag = 0;

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                if (textBox1.Text == "0")
                {
                    remark_theory_through_add();

                    if (errorflag == 1)
                    {
                        MessageBox.Show("Sorry, operation cannot be completed. First correct all the errors.");
                    }
                    else
                    {
                       String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
                        MySqlConnection conDataBase = new MySqlConnection(constring);

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            MySqlCommand cmdDataBase = new MySqlCommand("insert into internals.marks (RollNo,PracticalObtained,PracticalInWords,PracticalRemarks,SubjectCode,UserName,PracticalStatus) values('" + this.dataGridView1.Rows[i].Cells[1].Value + "','" + this.dataGridView1.Rows[i].Cells[5].Value + "','" + this.dataGridView1.Rows[i].Cells[6].Value + "','" + this.dataGridView1.Rows[i].Cells[7].Value + "','" + this.comboBox3.Text + "','" + this.user.Text + "','" + this.one.Text + "')", conDataBase);
                            MySqlDataReader myReader;
                            try
                            {
                                conDataBase.Open();
                                myReader = cmdDataBase.ExecuteReader();

                                while (myReader.Read())
                                {
                                }
                                conDataBase.Close();
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                     

                        }
                        MessageBox.Show("Marks successfully Added.");
                    }


                }

                else if (textBox3.Text == "0")
                {
                    remark_theory_through_add();
                    if (errorflag == 1)
                    {
                        MessageBox.Show("Sorry, operation cannot be completed. First correct all the errors.");
                    }
                    else
                    {
                       String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
                        MySqlConnection conDataBase = new MySqlConnection(constring);

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            MySqlCommand cmdDataBase = new MySqlCommand("insert into internals.marks (RollNo,TheoryObtained,TheoryInWords,TheoryRemarks,SubjectCode,UserName,TheoryStatus) values('" + this.dataGridView1.Rows[i].Cells[1].Value + "','" + this.dataGridView1.Rows[i].Cells[5].Value + "','" + this.dataGridView1.Rows[i].Cells[6].Value + "','" + this.dataGridView1.Rows[i].Cells[7].Value + "','" + this.comboBox3.Text + "','" + this.user.Text + "','" + this.one.Text + "')", conDataBase);
                            MySqlDataReader myReader;
                            try
                            {
                                conDataBase.Open();
                                myReader = cmdDataBase.ExecuteReader();

                                while (myReader.Read())
                                {
                                }

                                conDataBase.Close();
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        

                        }
                        MessageBox.Show("Marks successfully Added.");
                    }


                }
                else
                {
                    remark_practical_through_add();

                    if (errorflag == 1)
                    {
                        MessageBox.Show("Sorry, operation cannot be completed. First correct all the errors.");
                    }
                    else
                    {
                       String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
                        MySqlConnection conDataBase = new MySqlConnection(constring);

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            MySqlCommand cmdDataBase = new MySqlCommand("insert into internals.marks (RollNo,TheoryObtained,TheoryInWords,TheoryRemarks,PracticalObtained,PracticalInWords,PracticalRemarks,SubjectCode,UserName,TheoryStatus,PracticalStatus) values('" + this.dataGridView1.Rows[i].Cells[1].Value + "','" + this.dataGridView1.Rows[i].Cells[5].Value + "','" + this.dataGridView1.Rows[i].Cells[6].Value + "','" + this.dataGridView1.Rows[i].Cells[7].Value + "','" + this.dataGridView1.Rows[i].Cells[8].Value + "','" + this.dataGridView1.Rows[i].Cells[9].Value + "','" + this.dataGridView1.Rows[i].Cells[10].Value + "','" + this.comboBox3.Text + "','" + this.user.Text + "','" + this.one.Text + "','" + this.one.Text + "')", conDataBase);
                            MySqlDataReader myReader;
                            try
                            {
                                conDataBase.Open();
                                myReader = cmdDataBase.ExecuteReader();

                                while (myReader.Read())
                                {
                                }

                                conDataBase.Close();
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                           

                        }
                        MessageBox.Show("Marks successfully Added.");
                    }


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }
        
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select SubjectCode from internals.subject where SubjectName='" + comboBox6.Text + "';", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (myReader.Read())
                {
                    String scode = myReader.GetString("SubjectCode");
                    comboBox3.Text = scode;


                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comboBox5.Items.Clear();
            if(textBox1.Text=="0")
            {
                comboBox5.Items.Add("Practical");
            }
            else if(textBox3.Text=="0")
            {
                comboBox5.Items.Add("Theory");
            }
            else
            {
                comboBox5.Items.Add("Theory");
                comboBox5.Items.Add("Practical");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select TheoryFull,TheoryPass,PracticalFull,PracticalPass,SubjectName from internals.subject where SubjectCode='" + comboBox3.Text + "';", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (myReader.Read())
                {
                    String tfull = myReader.GetString("TheoryFull");
                    textBox1.Text = tfull;
                    String tpass = myReader.GetString("TheoryPass");
                    textBox2.Text = tpass;
                    String pfull = myReader.GetString("PracticalFull");
                    textBox3.Text = pfull;
                    String ppass = myReader.GetString("PracticalPass");
                    textBox4.Text = ppass;
                    String sname = myReader.GetString("SubjectName");
                    comboBox6.Text = sname;

                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comboBox5.Items.Clear();
            if (textBox1.Text == "0")
            {
                comboBox5.Items.Add("Practical");
            }
            else if (textBox3.Text == "0")
            {
                comboBox5.Items.Add("Theory");
            }
            else
            {
                comboBox5.Items.Add("Theory");
                comboBox5.Items.Add("Practical");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opemfiledialog = new OpenFileDialog();
            if (opemfiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox5.Text = opemfiledialog.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;


            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                dataGridView1.Rows.RemoveAt(j);
                j--;
                while (dataGridView1.Rows.Count == 0)
                    continue;
            }

            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbooks workbooks = app.Workbooks;

            Excel.Workbook workbook = workbooks.Open(textBox5.Text);
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            if (textBox1.Text == "0")
            {

                try
                {
                    int rcount = worksheet.UsedRange.Rows.Count;

                    int i = 0;

                    //Initializing Columns
                    dataGridView1.ColumnCount = worksheet.UsedRange.Columns.Count;

                    dataGridView1.Columns[0].Name = "SN";
                    dataGridView1.Columns[1].Name = "RollNo";
                    dataGridView1.Columns[2].Name = "Fname";
                    dataGridView1.Columns[3].Name = "MiddleName";
                    dataGridView1.Columns[4].Name = "Lname";

                    dataGridView1.Columns[5].Name = "PracticalObtained";
                    dataGridView1.Columns[6].Name = "Prac. in Words";
                    dataGridView1.Columns[7].Name = "PracticalRemark";

                    for (i = 1; i < rcount; i++)
                    {
                        // dataGridView1.Rows[i].Cells["Column1"].Value = worksheet.Cells[i + 1, 1].Value;
                        // dataGridView1.Rows[i].Cells["Column2"].Value = worksheet.Cells[i + 1, 2].Value;
                        dataGridView1.Rows.Add(worksheet.Cells[i + 1, 1].Value, worksheet.Cells[i + 1, 2].Value, worksheet.Cells[i + 1, 3].Value, worksheet.Cells[i + 1, 4].Value, worksheet.Cells[i + 1, 5].Value, worksheet.Cells[i + 1, 6].Value, worksheet.Cells[i + 1, 7].Value);
                    }

                    workbook.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(workbooks);
                    Marshal.ReleaseComObject(worksheet);
                    // Marshal.ReleaseComObject(rcount);




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    workbook.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(workbooks);
                    Marshal.ReleaseComObject(worksheet);
                }

            }
            else if (textBox3.Text == "0")
            {
                try
                {
                    int rcount = worksheet.UsedRange.Rows.Count;

                    int i = 0;

                    //Initializing Columns
                    dataGridView1.ColumnCount = worksheet.UsedRange.Columns.Count;

                    dataGridView1.Columns[0].Name = "SN";
                    dataGridView1.Columns[1].Name = "RollNo";
                    dataGridView1.Columns[2].Name = "Fname";
                    dataGridView1.Columns[3].Name = "MiddleName";
                    dataGridView1.Columns[4].Name = "Lname";

                    dataGridView1.Columns[5].Name = "TheoryObtained";
                    dataGridView1.Columns[6].Name = "Theory in Words";
                    dataGridView1.Columns[7].Name = "TheoryRemark";

                    for (i = 1; i < rcount; i++)
                    {
                        // dataGridView1.Rows[i].Cells["Column1"].Value = worksheet.Cells[i + 1, 1].Value;
                        // dataGridView1.Rows[i].Cells["Column2"].Value = worksheet.Cells[i + 1, 2].Value;
                        dataGridView1.Rows.Add(worksheet.Cells[i + 1, 1].Value, worksheet.Cells[i + 1, 2].Value, worksheet.Cells[i + 1, 3].Value, worksheet.Cells[i + 1, 4].Value, worksheet.Cells[i + 1, 5].Value, worksheet.Cells[i + 1, 6].Value, worksheet.Cells[i + 1, 7].Value);
                    }

                    workbook.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(workbooks);
                    Marshal.ReleaseComObject(worksheet);
                    // Marshal.ReleaseComObject(rcount);




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    workbook.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(workbooks);
                    Marshal.ReleaseComObject(worksheet);
                }

            }

            else
            {
                try
                {
                    int rcount = worksheet.UsedRange.Rows.Count;

                    int i = 0;

                    //Initializing Columns
                    dataGridView1.ColumnCount = worksheet.UsedRange.Columns.Count;

                    dataGridView1.Columns[0].Name = "SN";
                    dataGridView1.Columns[1].Name = "RollNo";
                    dataGridView1.Columns[2].Name = "Fname";
                    dataGridView1.Columns[3].Name = "MiddleName";
                    dataGridView1.Columns[4].Name = "Lname";
                    dataGridView1.Columns[5].Name = "TheoryObtained";
                    dataGridView1.Columns[6].Name = "Theory in Words";
                    dataGridView1.Columns[7].Name = "TheoryRemark";
                    dataGridView1.Columns[8].Name = "PracticalObtained";
                    dataGridView1.Columns[9].Name = "Prac. in Words";
                    dataGridView1.Columns[10].Name = "PracticalRemark";

                    for (i = 1; i < rcount; i++)
                    {
                        // dataGridView1.Rows[i].Cells["Column1"].Value = worksheet.Cells[i + 1, 1].Value;
                        // dataGridView1.Rows[i].Cells["Column2"].Value = worksheet.Cells[i + 1, 2].Value;
                        dataGridView1.Rows.Add(worksheet.Cells[i + 1, 1].Value, worksheet.Cells[i + 1, 2].Value, worksheet.Cells[i + 1, 3].Value, worksheet.Cells[i + 1, 4].Value, worksheet.Cells[i + 1, 5].Value, worksheet.Cells[i + 1, 6].Value, worksheet.Cells[i + 1, 7].Value, worksheet.Cells[i + 1, 8].Value, worksheet.Cells[i + 1, 9].Value, worksheet.Cells[i + 1, 10].Value, worksheet.Cells[i + 1, 11].Value);
                    }

                    workbook.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(workbooks);
                    Marshal.ReleaseComObject(worksheet);
                    // Marshal.ReleaseComObject(rcount);




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    workbook.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(workbooks);
                    Marshal.ReleaseComObject(worksheet);
                }
            }
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // xlWorkBook.Close();
                //  xlexcel.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                
                  
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                
                  

            }
        }

        private void mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        void theory_update()
        {

            int counterror = 0;
            
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                    if (remarks == "")
                    {
                        dataGridView1.Rows[i].Cells[5].Value = "0";

                    }
                }  

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                string skip = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                if (skip== "0" )
                {
                    dataGridView1.Rows[i].Cells[6].Value = "-";
                    dataGridView1.Rows[i].Cells[7].Value = "Absent";
                    continue;
                }

                
                if (p>0 && p < Convert.ToInt32(textBox2.Text))
                {
                    string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                    inwords = NumberToWords(p);
                    dataGridView1.Rows[i].Cells[6].Value = inwords;

                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                    remarks = "Fail";
                    dataGridView1.Rows[i].Cells[7].Value = remarks;
                }
                else if (p >= Convert.ToInt32(textBox2.Text) && p <= Convert.ToInt32(textBox1.Text))
                {

                    string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                    inwords = NumberToWords(p);
                    dataGridView1.Rows[i].Cells[6].Value = inwords;

                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                    remarks = "Pass";
                    dataGridView1.Rows[i].Cells[7].Value = remarks;
                }
                else
                {
                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                    remarks = "Invalid mark";
                    dataGridView1.Rows[i].Cells[6].Value = remarks;
                    dataGridView1.Rows[i].Cells[7].Value = remarks;
                    counterror = counterror + 1;
                }
            }

            if (counterror == 0)
            {
                errorflag = 0;
            }
            else
            {
                errorflag = 1;
            }
            counterror = 0;


        }

        void refresh_update()
        {

            if (comboBox5.Text == "Theory")
            {
                try
                {
                    int n = dataGridView1.Columns.Count;

                    for (int j = 1; j < n; j++)
                    {
                        dataGridView1.Columns.RemoveAt(1);
                    }

                    load_theoryobtained();
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        p = i + 1;
                        dataGridView1.Rows[i].Cells[0].Value = p;


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (comboBox5.Text == "Practical")
            {
                try
                {
                    int n = dataGridView1.Columns.Count;

                    for (int j = 1; j < n; j++)
                    {
                        dataGridView1.Columns.RemoveAt(1);
                    }

                    load_practicalobtained();
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        p = i + 1;
                        dataGridView1.Rows[i].Cells[0].Value = p;
                        

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox5.Text == "Theory")
                {
                    theory_update();
                    if (errorflag == 1)
                    {
                        MessageBox.Show("Sorry, operation cannot be completed. First correct all the errors.");
                    }
                    else
                    {

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
                            MySqlConnection conDataBase = new MySqlConnection(constring);
                            MySqlCommand cmdDataBase = new MySqlCommand("update internals.marks set TheoryObtained='" + this.dataGridView1.Rows[i].Cells[5].Value + "',TheoryInWords='" + this.dataGridView1.Rows[i].Cells[6].Value + "',TheoryRemarks='" + this.dataGridView1.Rows[i].Cells[7].Value + "',UserName='" + this.user.Text + "' where RollNo='" + this.dataGridView1.Rows[i].Cells[1].Value + "' and SubjectCode='" + comboBox3.Text + "' and TheoryStatus='1';", conDataBase);
                            MySqlDataReader myReader;
                            try
                            {
                                conDataBase.Open();
                                myReader = cmdDataBase.ExecuteReader();
                                while (myReader.Read())
                                {
                                }
                                conDataBase.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        load_theoryobtained();
                        MessageBox.Show("Informations not confirmed by admin successfully updated. The confirmed informations cannot be updated. Contact your admin for any query.");
                    }
                }
                else if (comboBox5.Text == "Practical")
                {
                    practical_update();
                    if (errorflag == 1)
                    {
                        MessageBox.Show("Sorry, operation cannot be completed. First correct all the errors.");
                    }
                    else
                    {

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
                            MySqlConnection conDataBase = new MySqlConnection(constring);
                            MySqlCommand cmdDataBase = new MySqlCommand("update internals.marks set PracticalObtained='" + this.dataGridView1.Rows[i].Cells[5].Value + "',PracticalInWords='" + this.dataGridView1.Rows[i].Cells[6].Value + "',PracticalRemarks='" + this.dataGridView1.Rows[i].Cells[7].Value + "',UserName='" + this.user.Text + "' where RollNo='" + this.dataGridView1.Rows[i].Cells[1].Value + "' and SubjectCode='" + comboBox3.Text + "' and PracticalStatus='1';", conDataBase);
                            MySqlDataReader myReader;
                            try
                            {
                                conDataBase.Open();
                                myReader = cmdDataBase.ExecuteReader();
                                while (myReader.Read())
                                {
                                }
                                conDataBase.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        load_practicalobtained();
                        MessageBox.Show("Informations not confirmed by admin successfully updated. The confirmed informations cannot be updated. Contact your admin for any query.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                int n = dataGridView1.Columns.Count;

                for (int j = 1; j < n; j++)
                {
                    dataGridView1.Columns.RemoveAt(1);
                }

                load_practicalobtained();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    p = i + 1;
                    dataGridView1.Rows[i].Cells[0].Value = p;
                    //dataGridView1.Rows[i].Cells[4].Value = "0";

                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }


        }

        void practical_update()
        {
            int counterror = 0;
            
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                if (remarks == "")
                {
                    dataGridView1.Rows[i].Cells[5].Value = "0";

                }
            }   

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                string skip = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                if (skip == "0")
                {
                    dataGridView1.Rows[i].Cells[6].Value = "-";
                    dataGridView1.Rows[i].Cells[7].Value = "Absent";
                    continue;
                }
                
               if (p>0 && p < Convert.ToInt32(textBox4.Text))
                {
                    string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                    inwords = NumberToWords(p);
                    dataGridView1.Rows[i].Cells[6].Value = inwords;

                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                    remarks = "Fail";
                    dataGridView1.Rows[i].Cells[7].Value = remarks;
                }
                else if (p >= Convert.ToInt32(textBox4.Text) && p <= Convert.ToInt32(textBox3.Text))
                {
                    string inwords = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                    inwords = NumberToWords(p);
                    dataGridView1.Rows[i].Cells[6].Value = inwords;

                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                    remarks = "Pass";
                    dataGridView1.Rows[i].Cells[7].Value = remarks;
                }

                else
                {
                    string remarks = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                    remarks = "Invalid mark";
                    dataGridView1.Rows[i].Cells[6].Value = remarks;
                    dataGridView1.Rows[i].Cells[7].Value = remarks;
                    
                    counterror = counterror + 1;
                }

            }

            if (counterror == 0)
            {
                errorflag = 0;
            }
            else
            {
                errorflag = 1;
            }
            counterror = 0;




        }

        private void button9_Click(object sender, EventArgs e)
        {
            practical_update();
            if (errorflag == 1)
            {
                MessageBox.Show("Sorry, operation cannot be completed. First correct all the errors.");
            }
            else
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                   String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand("update internals.marks set PracticalObtained='" + this.dataGridView1.Rows[i].Cells[4].Value + "',PracticalRemarks='" + this.dataGridView1.Rows[i].Cells[5].Value + "' where RollNo='" + this.dataGridView1.Rows[i].Cells[1].Value + "' and SubjectCode='" + comboBox3.Text + "';", conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        while (myReader.Read())
                        {
                        }
                        conDataBase.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                MessageBox.Show("Informations successfully Updated.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           

            if (comboBox5.Text == "Theory")
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "TRIBHUWAN UNIVERSITY" + "\n" + "INSTITUTE OF ENGINEERING";//Header
                printer.SubTitle = "Pulchowk campus " + "\n" + "Bachelor's Degree in " + label11.Text+" Engineering" +"\n" + "Group: " + comboBox4.Text +"\n"+"Year: "+comboBox9.Text+"        "+"Part: " + comboBox10.Text + "       "+"Batch: " + comboBox2.Text +"\n" + "Full Marks: " + textBox1.Text +"                                                                                                          "+"Code No.: "+comboBox3.Text+ "\n" + "Subject: " + comboBox6.Text +"\n"+ "Pass Marks: " + textBox2.Text + "                                                                                                      " + "Prac/Theory:" + comboBox5.Text+"\n\n" ;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                // printer.PageNumbers = true;
                //printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Signature: ______" + "\n" + "Name of Examiner: " + "\n" + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));

                printer.FooterSpacing = 15;
                //Print landscape mode
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(dataGridView1);

                
            }
            else if(comboBox5.Text=="Practical")
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "TRIBHUWAN UNIVERSITY" + "\n" + "INSTITUTE OF ENGINEERING";//Header
                printer.SubTitle = "Pulchowk campus " + "\n" + "Bachelor's Degree in " + label11.Text + " Engineering" + "\n" + "Group: " + comboBox4.Text + "\n" + "Year: " + comboBox9.Text + "        " + "Part: " + comboBox10.Text + "       " + "Batch: " + comboBox2.Text + "\n" + "Full Marks: " + textBox3.Text + "                                                                                                          " + "Code No.: " + comboBox3.Text + "\n" + "Subject: " + comboBox6.Text + "\n" + "Pass Marks: " + textBox4.Text + "                                                                                                      " + "Prac/Theory:" + comboBox5.Text + "\n\n";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                // printer.PageNumbers = true;
                //printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Signature: ______" + "\n" + "Name of Examiner: "+"\n"+ string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"))  ;

                printer.FooterSpacing = 15;
                //Print landscape mode
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(dataGridView1);

                

              
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select ProgramName from internals.program where ProgramCode='" + comboBox1.Text + "';", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (myReader.Read())
                {
                    String pcode = myReader.GetString("ProgramName");
                    label11.Text = pcode;


                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
           String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select CollegeCode from internals.college where CollegeName='" + comboBox8.Text + "';", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                if (myReader.Read())
                {
                    String ccode = myReader.GetString("CollegeCode");
                    comboBox7.Text = ccode;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void mainform_DoubleClick(object sender, EventArgs e)
        {
           
           
            
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (label17.Text == ">>")
            {
                label17.Text = "<<";
               
                panel1.Width = 1158;
                dataGridView1.Width = 1152;
              
                panel3.Visible = false;
            }
            else if (label17.Text == "<<")
            {
                label17.Text = ">>";
               
                panel1.Width = 831;
                dataGridView1.Width = 825;
              
                panel3.Visible = true;
            }
        }

        void confirm_theory()
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
               String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand("update internals.marks set TheoryStatus='" + this.dataGridView1.Rows[i].Cells[5].Value + "' where RollNo='" + this.dataGridView1.Rows[i].Cells[1].Value + "' and SubjectCode='" + this.dataGridView1.Rows[i].Cells[2].Value + "';", conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read())
                    {
                    }
                    conDataBase.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            MessageBox.Show("Successfully Confirmed.");
        }

        void confirm_practical()
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
               String constring = "SERVER=db4free.net;UID=internals;PWD=peaceinheaven;PORT=3306;DATABASE=internals;old guids=true";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand("update internals.marks set PracticalStatus='" + this.dataGridView1.Rows[i].Cells[5].Value + "' where RollNo='" + this.dataGridView1.Rows[i].Cells[1].Value + "' and SubjectCode='" + this.dataGridView1.Rows[i].Cells[2].Value + "';", conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    while (myReader.Read())
                    {
                    }
                    conDataBase.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            MessageBox.Show("Successfully Confirmed.");

        }


        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState==CheckState.Checked)
            {

                panel4.Visible = true;

            }
            else if(checkBox1.CheckState==CheckState.Unchecked)
            {

                panel4.Visible = false;

            }
        }

        private void user_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            login lgn = new login();
            lgn.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }
    }
}
