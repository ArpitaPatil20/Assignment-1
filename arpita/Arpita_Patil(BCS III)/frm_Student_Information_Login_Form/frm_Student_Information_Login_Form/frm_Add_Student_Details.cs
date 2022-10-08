using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frm_Student_Information_Login_Form
{
    public partial class frm_Add_Student_Details : Form
    {
        public frm_Add_Student_Details()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Information_Table;Integrated Security=True");
        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void btn_Veiw_Student_Details_Click(object sender, EventArgs e)
        {
           frm_View_Student_Details VSD = new frm_View_Student_Details();
            VSD.Show();
            this.Hide();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Information_Table(Roll_no,Name,DOB,Mobile_No,Course)Values(@Rno, @Name, @DOB, @Mobile_No , @Course)";
                Cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Mobile_No", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record saved");
                
            }
            else
            {
                MessageBox.Show("Fill all fields");

            }
            Con_Close();


        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar)||(e.KeyChar==(Char)Keys.Back)||(e.KeyChar==(Char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Roll_No.Text="";
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex=-1;
            dtp_DOB.Text="01/06/2007";
        }

        private void frm_Add_Student_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Roll_No.Focus();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login l = new frm_Login();
            l.Show();
            this.Hide();
        }

        }

        }

       


        

      
        

      

       
      
       

           
