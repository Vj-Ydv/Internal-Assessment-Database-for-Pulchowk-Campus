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
using DGVPrinterHelper;
namespace Internal_Assessment_Database
{
    public partial class confirmationpage : Form
    {
        public confirmationpage()
        {
            InitializeComponent();
            autocomplete_collegename();
        }
        DataTable dbdataset;

        void autocomplete_collegename()
        {
            comboBox8.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox8.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();
            String constring = "datasource=localhost;port=3306;username=root;password=vijay";
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

        void fillcombobox_program()
        {
            String constring = "datasource=localhost;port=3306;username=root;password=vijay";
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
            String constring = "datasource=localhost;port=3306;username=root;password=vijay";
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

        void fillcombobox_collegecode()
        {

            String constring = "datasource=localhost;port=3306;username=root;password=vijay";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select distinct CollegeName from internals.college;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                    string college = myReader.GetString("CollegeName");
                    comboBox8.Items.Add(college);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {


            String constring = "datasource=localhost;port=3306;username=root;password=vijay";
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

                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }





        private void confirmationpage_Load(object sender, EventArgs e)
        {
            fillcombobox_program();
            fillcombobox_batch();
            fillcombobox_collegecode();

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);

            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }


        void confirm_theory()
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                String constring = "datasource=localhost;port=3306;username=root;password=vijay";
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conDataBase.Close();
            }

            MessageBox.Show("Successfully done.");
        }

        void confirm_practical()
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                String constring = "datasource=localhost;port=3306;username=root;password=vijay";
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

            MessageBox.Show("Successfully done.");

        }



        private void button13_Click(object sender, EventArgs e)
        {

            try
            {

                if (comboBox5.Text == "Theory")
                {
                    if (button13.Text == "MARKS TO CONFIRM")
                    {
                        int n = dataGridView1.Columns.Count;

                        for (int j = 1; j < n; j++)
                        {
                            dataGridView1.Columns.RemoveAt(1);
                        }

                        String constring = "datasource=localhost;port=3306;username=root;password=vijay";
                        MySqlConnection conDataBase = new MySqlConnection(constring);
                        MySqlCommand cmdDataBase = new MySqlCommand("select m.RollNo,m.SubjectCode,m.TheoryObtained,m.TheoryRemarks,m.TheoryStatus from internals.student s, internals.marks m where m.RollNo=s.RollNo and s.ProgramCode='" + this.comboBox1.Text + "' and s.CollegeCode='" + this.comboBox7.Text + "' and s.Batch='" + this.comboBox2.Text + "' ;", conDataBase);
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

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {

                            int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            p = i + 1;
                            dataGridView1.Rows[i].Cells[0].Value = p;


                        }
                        button13.Text = "CONFIRM";
                    }

                    else if (button13.Text == "CONFIRM")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {


                            string theory = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);


                            if (theory == "Fail")
                            {

                                dataGridView1.Rows[i].Cells[5].Value = "0";

                            }
                            else if (theory == "Absent")
                            {
                                dataGridView1.Rows[i].Cells[5].Value = "1";
                            }

                            else if (theory == "Pass")
                            {
                                dataGridView1.Rows[i].Cells[5].Value = "2";
                            }

                        }

                        confirm_theory();
                        button13.Text = "MARKS TO CONFIRM";


                    }
                }
                else if (comboBox5.Text == "Practical")
                {

                    if (button13.Text == "MARKS TO CONFIRM")
                    {
                        int n = dataGridView1.Columns.Count;

                        for (int j = 1; j < n; j++)
                        {
                            dataGridView1.Columns.RemoveAt(1);
                        }

                        String constring = "datasource=localhost;port=3306;username=root;password=vijay";
                        MySqlConnection conDataBase = new MySqlConnection(constring);
                        MySqlCommand cmdDataBase = new MySqlCommand("select m.RollNo,m.SubjectCode,m.PracticalObtained,m.PracticalRemarks,m.PracticalStatus from internals.student s, internals.marks m where m.RollNo=s.RollNo and s.ProgramCode='" + this.comboBox1.Text + "' and s.CollegeCode='" + this.comboBox7.Text + "' and s.Batch='" + this.comboBox2.Text + "' ;", conDataBase);
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

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {

                            int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            p = i + 1;
                            dataGridView1.Rows[i].Cells[0].Value = p;


                        }
                        button13.Text = "CONFIRM";
                    }

                    else if (button13.Text == "CONFIRM")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {


                            string practical = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);


                            if (practical == "Fail")
                            {

                                dataGridView1.Rows[i].Cells[5].Value = "0";

                            }
                            else if (practical == "Absent")
                            {
                                dataGridView1.Rows[i].Cells[5].Value = "1";
                            }

                            else if (practical == "Pass")
                            {
                                dataGridView1.Rows[i].Cells[5].Value = "2";
                            }

                        }

                        confirm_practical();
                        button13.Text = "MARKS TO CONFIRM";



                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }



        private void button12_Click(object sender, EventArgs e)
        {

            try
            {

                if (comboBox5.Text == "Theory")
                {
                    if (button12.Text == "UNCONFIRM MARKS")
                    {
                        int n = dataGridView1.Columns.Count;

                        for (int j = 1; j < n; j++)
                        {
                            dataGridView1.Columns.RemoveAt(1);
                        }

                        String constring = "datasource=localhost;port=3306;username=root;password=vijay";
                        MySqlConnection conDataBase = new MySqlConnection(constring);
                        MySqlCommand cmdDataBase = new MySqlCommand("select m.RollNo,m.SubjectCode,m.TheoryObtained,m.TheoryRemarks,m.TheoryStatus from internals.student s, internals.marks m where m.RollNo=s.RollNo and s.ProgramCode='" + this.comboBox1.Text + "' and s.CollegeCode='" + this.comboBox7.Text + "' and s.Batch='" + this.comboBox2.Text + "' ;", conDataBase);
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

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {

                            int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            p = i + 1;
                            dataGridView1.Rows[i].Cells[0].Value = p;


                        }
                        button12.Text = "DONE";
                    }

                    else if (button12.Text == "DONE")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {


                            string theorystatus = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);


                            if (theorystatus == "0")
                            {

                                dataGridView1.Rows[i].Cells[5].Value = "1";

                            }


                        }

                        confirm_theory();
                        button12.Text = "UNCONFIRM MARKS";


                    }
                }
                else if (comboBox5.Text == "Practical")
                {

                    if (button12.Text == "UNCONFIRM MARKS")
                    {
                        int n = dataGridView1.Columns.Count;

                        for (int j = 1; j < n; j++)
                        {
                            dataGridView1.Columns.RemoveAt(1);
                        }

                        String constring = "datasource=localhost;port=3306;username=root;password=vijay";
                        MySqlConnection conDataBase = new MySqlConnection(constring);
                        MySqlCommand cmdDataBase = new MySqlCommand("select m.RollNo,m.SubjectCode,m.PracticalObtained,m.PracticalRemarks,m.PracticalStatus from internals.student s, internals.marks m where m.RollNo=s.RollNo and s.ProgramCode='" + this.comboBox1.Text + "' and s.CollegeCode='" + this.comboBox7.Text + "' and s.Batch='" + this.comboBox2.Text + "' ;", conDataBase);
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

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {

                            int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                            p = i + 1;
                            dataGridView1.Rows[i].Cells[0].Value = p;


                        }
                        button12.Text = "DONE";
                    }

                    else if (button12.Text == "DONE")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {


                            string practicalstatus = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);


                            if (practicalstatus == "0")
                            {

                                dataGridView1.Rows[i].Cells[5].Value = "1";

                            }


                        }

                        confirm_practical();
                        button12.Text = "UNCONFIRM MARKS";



                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }








        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void confirmationpage_DoubleClick(object sender, EventArgs e)
        {
            button13.Text = "MARKS TO CONFIRM";
            button12.Text = "UNCONFIRM MARKS";
            button2.Text = "SHOW CONFIRMED MARKS";
            button1.Text = "SHOW UNCONFIRMED MARKS";
        }

        void show_confirmed_marks()
        {

            try
            {

                if (comboBox5.Text == "Theory")
                {

                    int n = dataGridView1.Columns.Count;

                    for (int j = 1; j < n; j++)
                    {
                        dataGridView1.Columns.RemoveAt(1);
                    }

                    String constring = "datasource=localhost;port=3306;username=root;password=vijay";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand("select m.RollNo,s.Fname,s.MiddleName,s.Lname,s.ProgramCode,b.SubjectName,s.ContactNo from internals.student s, internals.marks m, internals.subject b where m.RollNo=s.RollNo and m.SubjectCode=b.SubjectCode and s.CollegeCode='" + this.comboBox7.Text + "' and s.Batch='" + this.comboBox2.Text + "' and TheoryStatus<>'1' order by s.ProgramCode,m.RollNo ;", conDataBase);
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

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        p = i + 1;
                        dataGridView1.Rows[i].Cells[0].Value = p;


                    }


                }
                else if (comboBox5.Text == "Practical")
                {


                    int n = dataGridView1.Columns.Count;

                    for (int j = 1; j < n; j++)
                    {
                        dataGridView1.Columns.RemoveAt(1);
                    }

                    String constring = "datasource=localhost;port=3306;username=root;password=vijay";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand("select m.RollNo,s.Fname,s.MiddleName,s.Lname,s.ProgramCode,b.SubjectName,s.ContactNo from internals.student s, internals.marks m, internals.subject b where m.RollNo=s.RollNo and m.SubjectCode=b.SubjectCode and s.CollegeCode='" + this.comboBox7.Text + "' and s.Batch='" + this.comboBox2.Text + "' and PracticalStatus<>'1' order by s.ProgramCode,m.RollNo;", conDataBase);
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

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        p = i + 1;
                        dataGridView1.Rows[i].Cells[0].Value = p;


                    }
                   


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        void show_unconfirmed_marks()
        {

            try
            {

                if (comboBox5.Text == "Theory")
                {

                    int n = dataGridView1.Columns.Count;

                    for (int j = 1; j < n; j++)
                    {
                        dataGridView1.Columns.RemoveAt(1);
                    }

                    String constring = "datasource=localhost;port=3306;username=root;password=vijay";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand("select m.RollNo,s.Fname,s.MiddleName,s.Lname,s.ProgramCode,b.SubjectName,s.ContactNo from internals.student s, internals.marks m, internals.subject b where m.RollNo=s.RollNo and m.SubjectCode=b.SubjectCode and s.CollegeCode='" + this.comboBox7.Text + "' and s.Batch='" + this.comboBox2.Text + "' and TheoryStatus='1' order by s.ProgramCode,m.RollNo;", conDataBase);
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

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        p = i + 1;
                        dataGridView1.Rows[i].Cells[0].Value = p;


                    }


                }
                else if (comboBox5.Text == "Practical")
                {


                    int n = dataGridView1.Columns.Count;

                    for (int j = 1; j < n; j++)
                    {
                        dataGridView1.Columns.RemoveAt(1);
                    }

                    String constring = "datasource=localhost;port=3306;username=root;password=vijay";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand("select m.RollNo,s.Fname,s.MiddleName,s.Lname,s.ProgramCode,b.SubjectName,s.ContactNo from internals.student s, internals.marks m, internals.subject b where m.RollNo=s.RollNo and m.SubjectCode=b.SubjectCode and s.CollegeCode='" + this.comboBox7.Text + "' and s.Batch='" + this.comboBox2.Text + "' and PracticalStatus='1' order by s.ProgramCode,m.RollNo;", conDataBase);
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

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        int p = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        p = i + 1;
                        dataGridView1.Rows[i].Cells[0].Value = p;


                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "SHOW CONFIRMED MARKS")
            {

                show_confirmed_marks();
                button2.Text = "PRINT";

            }
            else if (button2.Text == "PRINT")
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "TRIBHUWAN UNIVERSITY" + "\n" + "INSTITUTE OF ENGINEERING";//Header
                printer.SubTitle = "College Name: "+comboBox8.Text + "\n" + "Theory/Practical:  " + comboBox5.Text + "\n"+"Marks Confirmed List"+"\n" + "Batch:  " + comboBox2.Text + "\n\n";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                 printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
               // printer.Footer = "Signature: ______" + "\n" + "Name of Examiner: " + "\n" + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));

                printer.FooterSpacing = 15;
                //Print landscape mode
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(dataGridView1);

                button2.Text = "SHOW CONFIRMED MARKS";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "SHOW UNCONFIRMED MARKS")
            {

                show_unconfirmed_marks();
                button1.Text = "PRINT";

            }
            else if (button1.Text == "PRINT")
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "TRIBHUWAN UNIVERSITY" + "\n" + "INSTITUTE OF ENGINEERING";//Header
                printer.SubTitle = "College Name: " + comboBox8.Text + "\n" + "Theory/Practical:  " + comboBox5.Text +"\n"+"Marks Unconfirmed List" +"\n" + "Batch:  " + comboBox2.Text + "\n\n";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                // printer.Footer = "Signature: ______" + "\n" + "Name of Examiner: " + "\n" + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));

                printer.FooterSpacing = 15;
                //Print landscape mode
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(dataGridView1);

                button1.Text = "SHOW UNCONFIRMED MARKS";

            }


        }

        private void resetAllButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button13.Text = "MARKS TO CONFIRM";
            button12.Text = "UNCONFIRM MARKS";
            button2.Text = "SHOW CONFIRMED MARKS";
            button1.Text = "SHOW UNCONFIRMED MARKS";
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To print confirmed or unconfirmed marks, Program code field is not required.");
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dataGridView1.Columns.Count;

                for (int j = 1; j < n; j++)
                {
                    dataGridView1.Columns.RemoveAt(1);
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;
                    while (dataGridView1.Rows.Count == 0)
                        continue;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
    
}
