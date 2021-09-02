
namespace ExamManagement.TeacherUC
{
    partial class UCUpdateQuestion
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUpdateQuestion));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboSet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboQuestion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOption1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOption3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOption2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOption4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnSyn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Questions";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(216, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set";
            // 
            // comboSet
            // 
            this.comboSet.BackColor = System.Drawing.Color.Transparent;
            this.comboSet.BorderColor = System.Drawing.Color.Black;
            this.comboSet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSet.FocusedState.Parent = this.comboSet;
            this.comboSet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboSet.ForeColor = System.Drawing.Color.Black;
            this.comboSet.HoverState.Parent = this.comboSet;
            this.comboSet.ItemHeight = 30;
            this.comboSet.ItemsAppearance.Parent = this.comboSet;
            this.comboSet.Location = new System.Drawing.Point(221, 240);
            this.comboSet.Name = "comboSet";
            this.comboSet.ShadowDecoration.Parent = this.comboSet;
            this.comboSet.Size = new System.Drawing.Size(365, 36);
            this.comboSet.TabIndex = 2;
            this.comboSet.SelectedIndexChanged += new System.EventHandler(this.comboSet_SelectedIndexChanged);
            // 
            // comboQuestion
            // 
            this.comboQuestion.BackColor = System.Drawing.Color.Transparent;
            this.comboQuestion.BorderColor = System.Drawing.Color.Black;
            this.comboQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQuestion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboQuestion.FocusedState.Parent = this.comboQuestion;
            this.comboQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboQuestion.ForeColor = System.Drawing.Color.Black;
            this.comboQuestion.HoverState.Parent = this.comboQuestion;
            this.comboQuestion.ItemHeight = 30;
            this.comboQuestion.ItemsAppearance.Parent = this.comboQuestion;
            this.comboQuestion.Location = new System.Drawing.Point(668, 240);
            this.comboQuestion.Name = "comboQuestion";
            this.comboQuestion.ShadowDecoration.Parent = this.comboQuestion;
            this.comboQuestion.Size = new System.Drawing.Size(365, 36);
            this.comboQuestion.TabIndex = 4;
            this.comboQuestion.SelectedIndexChanged += new System.EventHandler(this.comboQuestion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(637, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Question No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(569, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Question:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.BorderColor = System.Drawing.Color.Black;
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuestion.DefaultText = "";
            this.txtQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestion.DisabledState.Parent = this.txtQuestion;
            this.txtQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestion.FocusedState.Parent = this.txtQuestion;
            this.txtQuestion.ForeColor = System.Drawing.Color.Black;
            this.txtQuestion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestion.HoverState.Parent = this.txtQuestion;
            this.txtQuestion.Location = new System.Drawing.Point(221, 354);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.PlaceholderText = "";
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.ShadowDecoration.Parent = this.txtQuestion;
            this.txtQuestion.Size = new System.Drawing.Size(812, 36);
            this.txtQuestion.TabIndex = 6;
            // 
            // txtOption1
            // 
            this.txtOption1.BorderColor = System.Drawing.Color.Black;
            this.txtOption1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption1.DefaultText = "";
            this.txtOption1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption1.DisabledState.Parent = this.txtOption1;
            this.txtOption1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption1.FocusedState.Parent = this.txtOption1;
            this.txtOption1.ForeColor = System.Drawing.Color.Black;
            this.txtOption1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption1.HoverState.Parent = this.txtOption1;
            this.txtOption1.Location = new System.Drawing.Point(221, 474);
            this.txtOption1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.PasswordChar = '\0';
            this.txtOption1.PlaceholderText = "";
            this.txtOption1.SelectedText = "";
            this.txtOption1.ShadowDecoration.Parent = this.txtOption1;
            this.txtOption1.Size = new System.Drawing.Size(355, 36);
            this.txtOption1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(216, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Option 1:";
            // 
            // txtOption3
            // 
            this.txtOption3.BorderColor = System.Drawing.Color.Black;
            this.txtOption3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption3.DefaultText = "";
            this.txtOption3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption3.DisabledState.Parent = this.txtOption3;
            this.txtOption3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption3.FocusedState.Parent = this.txtOption3;
            this.txtOption3.ForeColor = System.Drawing.Color.Black;
            this.txtOption3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption3.HoverState.Parent = this.txtOption3;
            this.txtOption3.Location = new System.Drawing.Point(680, 474);
            this.txtOption3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.PasswordChar = '\0';
            this.txtOption3.PlaceholderText = "";
            this.txtOption3.SelectedText = "";
            this.txtOption3.ShadowDecoration.Parent = this.txtOption3;
            this.txtOption3.Size = new System.Drawing.Size(355, 36);
            this.txtOption3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(675, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Option 3:";
            // 
            // txtOption2
            // 
            this.txtOption2.BorderColor = System.Drawing.Color.Black;
            this.txtOption2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption2.DefaultText = "";
            this.txtOption2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption2.DisabledState.Parent = this.txtOption2;
            this.txtOption2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption2.FocusedState.Parent = this.txtOption2;
            this.txtOption2.ForeColor = System.Drawing.Color.Black;
            this.txtOption2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption2.HoverState.Parent = this.txtOption2;
            this.txtOption2.Location = new System.Drawing.Point(221, 613);
            this.txtOption2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.PasswordChar = '\0';
            this.txtOption2.PlaceholderText = "";
            this.txtOption2.SelectedText = "";
            this.txtOption2.ShadowDecoration.Parent = this.txtOption2;
            this.txtOption2.Size = new System.Drawing.Size(355, 36);
            this.txtOption2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(216, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Option 2:";
            // 
            // txtOption4
            // 
            this.txtOption4.BorderColor = System.Drawing.Color.Black;
            this.txtOption4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption4.DefaultText = "";
            this.txtOption4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption4.DisabledState.Parent = this.txtOption4;
            this.txtOption4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption4.FocusedState.Parent = this.txtOption4;
            this.txtOption4.ForeColor = System.Drawing.Color.Black;
            this.txtOption4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption4.HoverState.Parent = this.txtOption4;
            this.txtOption4.Location = new System.Drawing.Point(680, 613);
            this.txtOption4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.PasswordChar = '\0';
            this.txtOption4.PlaceholderText = "";
            this.txtOption4.SelectedText = "";
            this.txtOption4.ShadowDecoration.Parent = this.txtOption4;
            this.txtOption4.Size = new System.Drawing.Size(355, 36);
            this.txtOption4.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(675, 571);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Option 4:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BorderColor = System.Drawing.Color.Black;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.DefaultText = "";
            this.txtAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.DisabledState.Parent = this.txtAnswer;
            this.txtAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.FocusedState.Parent = this.txtAnswer;
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.HoverState.Parent = this.txtAnswer;
            this.txtAnswer.Location = new System.Drawing.Point(221, 717);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.PlaceholderText = "";
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.ShadowDecoration.Parent = this.txtAnswer;
            this.txtAnswer.Size = new System.Drawing.Size(812, 36);
            this.txtAnswer.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(569, 685);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Answer:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 18;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(432, 789);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(154, 54);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 18;
            this.btnReset.BorderThickness = 1;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnReset.HoverState.FillColor = System.Drawing.Color.White;
            this.btnReset.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(642, 789);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(154, 54);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSyn
            // 
            this.btnSyn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSyn.CheckedState.Parent = this.btnSyn;
            this.btnSyn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSyn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSyn.HoverState.Parent = this.btnSyn;
            this.btnSyn.Image = ((System.Drawing.Image)(resources.GetObject("btnSyn.Image")));
            this.btnSyn.ImageRotate = 0F;
            this.btnSyn.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSyn.Location = new System.Drawing.Point(374, 36);
            this.btnSyn.Name = "btnSyn";
            this.btnSyn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSyn.PressedState.Parent = this.btnSyn;
            this.btnSyn.Size = new System.Drawing.Size(122, 82);
            this.btnSyn.TabIndex = 19;
            this.btnSyn.Click += new System.EventHandler(this.btnSyn_Click);
            // 
            // UCUpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSyn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOption4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOption2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOption3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOption1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCUpdateQuestion";
            this.Size = new System.Drawing.Size(1640, 1102);
            this.Load += new System.EventHandler(this.UCUpdateQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtOption1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtQuestion;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox comboQuestion;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox comboSet;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtAnswer;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtOption4;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtOption2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtOption3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2ImageButton btnSyn;
    }
}
