using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceQuiz
{
  public partial class Form1 : Form
  {
    private List<RadioButton> QuizButtons;
    private List<Question> QuizQuestions;
    private int currentQuestionNumber;
    private int score = 0;

    public Form1()
    {
      InitializeComponent();

      QuizButtons = new List<RadioButton>
      {
        radioButton1, radioButton2, radioButton3, radioButton4
      };

      string questionText = "What is the fastest animal?";
      string questionAnswer = "Peregrine falcon"; // fun fact: the common pigion's average speed, which it can fly for 600-700 miles in a single day, is faster then a cheetah can sprint. Pigeons are the fastest animal in the world when you aren't counting cheaters who make gravity do all the work.
      List<string> wrongAnswers = new List<string> { "Cheetah", "Tardigrade", "Black marlin" };

      Question q1 = new Question(questionText, questionAnswer, wrongAnswers);

      questionText = "What is the longest animal?";
      questionAnswer = "Lion's mane jellyfish";
      wrongAnswers = new List<string> { "Blue whale", "Tardigrade", "Giant Squid" };

      Question q2 = new Question(questionText, questionAnswer, wrongAnswers);

      questionText = "What has the largest specimen?";
      questionAnswer = "Honey Fungis"; // Yes I realize that "largest" isn't super clear on if I mean area, volume, or mass, and that a case for Pando being larger then the humongus fungis could be made, and since I included a blue whale as an option I really should include that one colony of sea grass (why is pando the only one of these things to get a convenient name?), but I like the honey fungis and while it safe to say that the honey fungus' 2200 acers (also acers are a terrible mesurement, 4840 yards^2? What? Who hurt you imperial system?) dwarfs pando's measly 106 and the only way the tree can compete is by throwing it's weight around, I don't know any dimention of the sea grass colony save the length, so I don't actually know how it compares 
      wrongAnswers = new List<string> { "Aspen Tree", "Blue Whale", "Giant Sequoia" };

      Question q3 = new Question(questionText, questionAnswer, wrongAnswers);

      QuizQuestions = new List<Question> { q1, q2, q3 };
     }

    private void Form1_Load(object sender, EventArgs e)
    {
      btnNext.Enabled = false;
      btnCheckAnswer.Focus();
      DisplayQuestion(currentQuestionNumber);
    }

    private void btnCheckAnswer_Click(object sender, EventArgs e)
    {
      // Gets the user's answer and checks to see if it is correct.
      Question currentQuestion = QuizQuestions[currentQuestionNumber];

      foreach (RadioButton rb in QuizButtons)
      {
        if (rb.Checked == true)
        {
          currentQuestion.UserAnswer = rb.Text;
        }
      }
      if (currentQuestion.UserAnswer == null)
      {
        MessageBox.Show("Please select an answer before proceeding.", "Error");
      }
      else
      {
        if (currentQuestion.IsCorrect())
        {
          lblAnswer.Text = "Correct!";
          score++;
        }
        else
        {
          lblAnswer.Text = $"Incorrect. The answer is {currentQuestion.CorrectAnswer}";
        }
        btnCheckAnswer.Enabled = false;
        btnNext.Enabled = true;
        btnNext.Focus();
      }
    }

    private void DisplayQuestion(int questionNumber)
    {
      // Gets the question for the index passed to it, sets question label and radio button's text accordingly.
      Question question = QuizQuestions[questionNumber];
      List<string> answers = question.AllAnswers;

      lblAnswer.Text = "Please select an answer.";

      for(int i=0; i < answers.Count; i++)
      {
        // Consolidated the for loops.
        QuizButtons[i].Checked = false;
        QuizButtons[i].Text = answers[i];
      }

      lblQuestion.Text = question.QuestionText;
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
      // Ups the question counter, checks if there's more questions, either continues the quiz or ends it.
      currentQuestionNumber++;
      if(currentQuestionNumber < QuizQuestions.Count)
      {
        DisplayQuestion(currentQuestionNumber);
        btnNext.Enabled = false;
        btnCheckAnswer.Enabled = true;
        btnCheckAnswer.Focus();
      }
      else
      {
        MessageBox.Show($"End of quiz! Your score is {score} / {QuizQuestions.Count}", "IT'S OVER");
      }
      btnNext.Enabled = false;
    }
  }
}
