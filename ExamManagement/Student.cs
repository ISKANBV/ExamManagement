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
    public partial class Student : Form
    {
        Function fn = new Function();
        String query;
 

        int QuestionCount = 0;
        int CorrectAnswers = 0;
        int WrongAnswers = 0;
        int CorrectAnswersNumber;
        int SelectedResponce;
        string[] array;


        public Student()
        {
            InitializeComponent();
        }

        public void Start()
        {
            array = new string[10];


            Question();
        }

        public void Question()
        {


        }


        public void AdventureState(object sender, EventArgs e)
        {
            guna2Button1.Enabled = true;
            guna2Button1.Focus();
            RadioButton Switch = (RadioButton)sender;
            var tmp = Switch.Name;
            SelectedResponce = int.Parse(tmp.Substring(9));
        }


        private void Student_Load(object sender, EventArgs e)
        {
            guna2Button1.Text = "Next";
            guna2Button2.Text = "Leave";

            comboSet.Items.Clear();
            query = "select distinct qset from questions";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }


            btnOption1.CheckedChanged += new EventHandler(AdventureState);
            btnOption2.CheckedChanged += new EventHandler(AdventureState);
            btnOption3.CheckedChanged += new EventHandler(AdventureState);
            btnOption4.CheckedChanged += new EventHandler(AdventureState);

            //Start();

        }


        private void comboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboQuestion.Items.Clear();
            query = "select qNo from questions where qset = '" + comboSet.Text + "'";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboQuestion.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            comboSet.Enabled = false;


        }


        private void comboQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select question,optionA,optionB,optionC,optionD,ans from questions where qset = '" + comboSet.Text + "' and qNo = '" + comboQuestion.Text + "'";
            DataSet ds = fn.getData(query);

            labelQuestion.Text = ds.Tables[0].Rows[0][0].ToString();
            btnOption1.Text = ds.Tables[0].Rows[0][1].ToString();
            btnOption2.Text = ds.Tables[0].Rows[0][2].ToString();
            btnOption3.Text = ds.Tables[0].Rows[0][3].ToString();
            btnOption4.Text = ds.Tables[0].Rows[0][4].ToString();

            CorrectAnswersNumber = int.Parse(ds.Tables[0].Rows[0][5].ToString());

            QuestionCount++;


        }





    }
}
