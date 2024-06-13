using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationApp_Pamittan_PaulaHewlett
{
    public partial class frmRegistration : Form
    {
        
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            
            grdData.Columns.Add("fname","First Name");
            grdData.Columns.Add("lname","Last Name");
            grdData.Columns.Add("crs", "Course");
            grdData.Columns.Add("dept", "Department");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdData.Rows.Add(txtFname.Text, txtLname.Text, txtCourse.Text, cboDept.Text);
       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grdData.Rows.Clear();
            
        }

    }
}
