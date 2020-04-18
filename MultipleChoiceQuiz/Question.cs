using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceQuiz
{
  class Question
  {
    public string QuestionText { get; set; }
    public string CorrectAnswer { get; set; }
    public string UserAnswer { get; set; }
    public List<string> WrongAnswers { get; set; }
    private int points;
    public int Points 
    { get { return points; } set
      {
        if (value < 0)
        {
          throw new System.ArgumentOutOfRangeException("Point value cannot be negative.");
        }
        else
        {
          points = value;
        }
      } 
    }
    public bool Scored { get; set; } = false;

    public Question (string questionText, string correctAnswer, List<string> wrongAnswers, int points = 1)
    {
      QuestionText = questionText;
      CorrectAnswer = correctAnswer;
      WrongAnswers = wrongAnswers;
      Points = points;
    }

    public bool IsCorrect
    {
      get
      {
        return UserAnswer == CorrectAnswer;
      }
    }

    public List<string> AllAnswers
    {
      get
      {
        List<string> allAnswers = new List<string>();
        allAnswers.Add(CorrectAnswer);
        allAnswers.AddRange(WrongAnswers);

        Random random = new Random();
        List<string> shuffledAnswers = new List<string>();
        while(allAnswers.Count > 0)
        {
          // I got rid of assigning the question to a random spot in shuffled's index as adding a random question to a list is already shuffling things.
          int index = random.Next(allAnswers.Count) ;
          shuffledAnswers.Add(allAnswers[index]);
          allAnswers.RemoveAt(index);
        }
        return shuffledAnswers;
      }
    }
  }
}
