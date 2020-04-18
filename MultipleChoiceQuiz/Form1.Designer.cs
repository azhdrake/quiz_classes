namespace MultipleChoiceQuiz
{
  partial class Form1
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.btnCheckAnswer = new System.Windows.Forms.Button();
      this.btnNext = new System.Windows.Forms.Button();
      this.lblQuestion = new System.Windows.Forms.Label();
      this.lblAnswer = new System.Windows.Forms.Label();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radioButton4);
      this.groupBox1.Controls.Add(this.radioButton3);
      this.groupBox1.Controls.Add(this.radioButton2);
      this.groupBox1.Controls.Add(this.radioButton1);
      this.groupBox1.Location = new System.Drawing.Point(7, 180);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(668, 303);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      // 
      // radioButton4
      // 
      this.radioButton4.AutoSize = true;
      this.radioButton4.Enabled = false;
      this.radioButton4.Location = new System.Drawing.Point(7, 240);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(27, 26);
      this.radioButton4.TabIndex = 3;
      this.radioButton4.TabStop = true;
      this.radioButton4.UseVisualStyleBackColor = true;
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Enabled = false;
      this.radioButton3.Location = new System.Drawing.Point(6, 163);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(27, 26);
      this.radioButton3.TabIndex = 2;
      this.radioButton3.TabStop = true;
      this.radioButton3.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Enabled = false;
      this.radioButton2.Location = new System.Drawing.Point(7, 95);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(27, 26);
      this.radioButton2.TabIndex = 1;
      this.radioButton2.TabStop = true;
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Enabled = false;
      this.radioButton1.Location = new System.Drawing.Point(7, 31);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(27, 26);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // btnCheckAnswer
      // 
      this.btnCheckAnswer.Enabled = false;
      this.btnCheckAnswer.Location = new System.Drawing.Point(14, 528);
      this.btnCheckAnswer.Name = "btnCheckAnswer";
      this.btnCheckAnswer.Size = new System.Drawing.Size(200, 49);
      this.btnCheckAnswer.TabIndex = 1;
      this.btnCheckAnswer.Text = "Check Answer";
      this.btnCheckAnswer.UseVisualStyleBackColor = true;
      this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
      // 
      // btnNext
      // 
      this.btnNext.Enabled = false;
      this.btnNext.Location = new System.Drawing.Point(14, 658);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(200, 49);
      this.btnNext.TabIndex = 2;
      this.btnNext.Text = "Next Question";
      this.btnNext.UseVisualStyleBackColor = true;
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // lblQuestion
      // 
      this.lblQuestion.AutoSize = true;
      this.lblQuestion.Location = new System.Drawing.Point(14, 106);
      this.lblQuestion.Name = "lblQuestion";
      this.lblQuestion.Size = new System.Drawing.Size(98, 25);
      this.lblQuestion.TabIndex = 3;
      this.lblQuestion.Text = "Question";
      // 
      // lblAnswer
      // 
      this.lblAnswer.Location = new System.Drawing.Point(238, 506);
      this.lblAnswer.Name = "lblAnswer";
      this.lblAnswer.Size = new System.Drawing.Size(437, 201);
      this.lblAnswer.TabIndex = 4;
      // 
      // txtUserName
      // 
      this.txtUserName.Location = new System.Drawing.Point(375, 24);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(300, 31);
      this.txtUserName.TabIndex = 0;
      this.txtUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyUp);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(19, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(326, 25);
      this.label1.TabIndex = 6;
      this.label1.Text = "Enter your name and press enter";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(687, 726);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtUserName);
      this.Controls.Add(this.lblAnswer);
      this.Controls.Add(this.lblQuestion);
      this.Controls.Add(this.btnNext);
      this.Controls.Add(this.btnCheckAnswer);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Quiz";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
    }
}

