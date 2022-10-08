using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frm_Student_Information_Login_Form
{
    public partial class frm_View_Student_Details : Form
    {
        public frm_View_Student_Details()
        {
            InitializeComponent();
        }

        

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login l = new frm_Login();
            l.Show();
            this.Hide();

        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details ASD = new frm_Add_Student_Details();
            ASD.Show();
            this.Hide();
        }

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Information_TableDataSet3.Student_Information_Table' table. You can move, or remove it, as needed.
            this.student_Information_TableTableAdapter1.Fill(this.student_Information_TableDataSet3.Student_Information_Table);

        }
    }
}
