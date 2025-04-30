using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAns = 0;
    int questionsSeen = 0;
    
    //Getter/setter for answers and questions
    public int getCorrectAnswers()
    {
        return correctAns;
    }

    public void IncrementCorrectAns()
    {
        correctAns++;
    }

    public int getQuestionsSeen()
    {
        return questionsSeen;
    }

    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        //Nearest interger percentage
        return Mathf.RoundToInt(correctAns / (float)questionsSeen * 100);
    }
}
