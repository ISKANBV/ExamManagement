using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamManagement
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            ucAddNewQuestion1.Visible = false;
            ucUpdateQuestion1.Visible = false;
            ucViewDeleteQuestion1.Visible = false;
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            ucAddNewQuestion1.Visible = true;
            ucAddNewQuestion1.BringToFront();
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            ucUpdateQuestion1.Visible = true;
            ucUpdateQuestion1.BringToFront();
        }

        private void btnViewDeleteUestions_Click(object sender, EventArgs e)
        {
            ucViewDeleteQuestion1.Visible = true;
            ucViewDeleteQuestion1.BringToFront();
        }
    }
}
