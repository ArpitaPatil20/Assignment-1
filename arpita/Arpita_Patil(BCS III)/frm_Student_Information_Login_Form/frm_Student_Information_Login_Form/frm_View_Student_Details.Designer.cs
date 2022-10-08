namespace frm_Student_Information_Login_Form
{
    partial class frm_View_Student_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.dgv_Student_Details = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInformationTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_Information_TableDataSet3 = new frm_Student_Information_Login_Form.Student_Information_TableDataSet3();
            this.studentInformationTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Information_TableDataSet2 = new frm_Student_Information_Login_Form.Student_Information_TableDataSet2();
            this.student_Information_TableTableAdapter = new frm_Student_Information_Login_Form.Student_Information_TableDataSet2TableAdapters.Student_Information_TableTableAdapter();
            this.student_Information_TableDataSet = new frm_Student_Information_Login_Form.Student_Information_TableDataSet();
            this.studentInformationTableDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Information_TableTableAdapter1 = new frm_Student_Information_Login_Form.Student_Information_TableDataSet3TableAdapters.Student_Information_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Information_TableDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Information_TableDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Information_TableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTableDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.Location = new System.Drawing.Point(412, 48);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(477, 70);
            this.lbl_View_Student_List.TabIndex = 0;
            this.lbl_View_Student_List.Text = "View Student List";
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(463, 655);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(372, 68);
            this.btn_Add_New_Student.TabIndex = 1;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(1153, 2);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(136, 62);
            this.btn_Log_Out.TabIndex = 2;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // dgv_Student_Details
            // 
            this.dgv_Student_Details.AutoGenerateColumns = false;
            this.dgv_Student_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Student_Details.DataSource = this.studentInformationTableBindingSource1;
            this.dgv_Student_Details.Location = new System.Drawing.Point(105, 172);
            this.dgv_Student_Details.Name = "dgv_Student_Details";
            this.dgv_Student_Details.RowTemplate.Height = 24;
            this.dgv_Student_Details.Size = new System.Drawing.Size(1072, 437);
            this.dgv_Student_Details.TabIndex = 3;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // studentInformationTableBindingSource1
            // 
            this.studentInformationTableBindingSource1.DataMember = "Student_Information_Table";
            this.studentInformationTableBindingSource1.DataSource = this.student_Information_TableDataSet3;
            // 
            // student_Information_TableDataSet3
            // 
            this.student_Information_TableDataSet3.DataSetName = "Student_Information_TableDataSet3";
            this.student_Information_TableDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInformationTableBindingSource
            // 
            this.studentInformationTableBindingSource.DataMember = "Student_Information_Table";
            this.studentInformationTableBindingSource.DataSource = this.student_Information_TableDataSet2;
            // 
            // student_Information_TableDataSet2
            // 
            this.student_Information_TableDataSet2.DataSetName = "Student_Information_TableDataSet2";
            this.student_Information_TableDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_Information_TableTableAdapter
            // 
            this.student_Information_TableTableAdapter.ClearBeforeFill = true;
            // 
            // student_Information_TableDataSet
            // 
            this.student_Information_TableDataSet.DataSetName = "Student_Information_TableDataSet";
            this.student_Information_TableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInformationTableDataSetBindingSource
            // 
            this.studentInformationTableDataSetBindingSource.DataSource = this.student_Information_TableDataSet;
            this.studentInformationTableDataSetBindingSource.Position = 0;
            // 
            // student_Information_TableTableAdapter1
            // 
            this.student_Information_TableTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_View_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 771);
            this.Controls.Add(this.dgv_Student_Details);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.lbl_View_Student_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Student_Details";
            this.Text = "frm_View_Student_Details";
            this.Load += new System.EventHandler(this.frm_View_Student_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Information_TableDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Information_TableDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Information_TableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationTableDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_List;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.DataGridView dgv_Student_Details;
        private Student_Information_TableDataSet2 student_Information_TableDataSet2;
        private System.Windows.Forms.BindingSource studentInformationTableBindingSource;
        private Student_Information_TableDataSet2TableAdapters.Student_Information_TableTableAdapter student_Information_TableTableAdapter;
        private System.Windows.Forms.BindingSource studentInformationTableDataSetBindingSource;
        private Student_Information_TableDataSet student_Information_TableDataSet;
        private Student_Information_TableDataSet3 student_Information_TableDataSet3;
        private System.Windows.Forms.BindingSource studentInformationTableBindingSource1;
        private Student_Information_TableDataSet3TableAdapters.Student_Information_TableTableAdapter student_Information_TableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}