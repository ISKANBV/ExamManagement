using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamManagement.TeacherUC
{
    public partial class UCAddNewQuestion : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;
        Int64 questionNo = 1;


        public UCAddNewQuestion()
        {
            InitializeComponent();
        }

        private void UCAddNewQuestion_Load(object sender, EventArgs e)
        {
            query = "select max(qset) from questions";
            ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtset.Text = (id + 1).ToString();
            }
            else
            {
                txtset.Text = "1";
            }
            questionLabel.Text = questionNo.ToString();
            labelNOSET.Visible = false;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String qset = txtset.Text;
            String qNo = questionNo.ToString();
            String question = txtQuestion.Text;
            String option1 = txtOption1.Text;
            String option2 = txtOption2.Text;
            String option3 = txtOption3.Text;
            String option4 = txtOption4.Text;
            String ans = txtAnswer.Text;


            query = "insert into questions (qset,qNo,question,optionA,optionB,optionC,optionD,ans) values ('"+qset+"','"+qNo+"','"+question+"','"+option1+"','"+option2+"','"+option3+"','"+option4+"','"+ans+"')";
            fn.setData(query, "Question Added.");

            //clearAll();

            questionNo++;
            questionLabel.Text = questionNo.ToString();

        }


        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Unsaved Data Will be Lost","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearAll();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Set Will be Changed","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtset.Text = (Int64.Parse(txtset.Text.ToString()) + 1).ToString();
                questionLabel.Text = "1";
            }
        }

        private void txtset_TextChanged(object sender, EventArgs e)
        {
            if(txtset.Text != "")
            {
                clearAll();
                query = "select qNo from questions where qset = '" + txtset.Text + "'";
                ds = fn.getData(query);

                if(ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    questionLabel.Text = (ds.Tables[0].Rows.Count + 1).ToString();
                    questionNo = Int64.Parse(questionLabel.Text.ToString());
                }
                else
                {
                    questionLabel.Text = "1";
                    questionNo = Int64.Parse(questionLabel.Text.ToString());
                    labelNOSET.Visible = true;
                }
            }
        }
    }
}
