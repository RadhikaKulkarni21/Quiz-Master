using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    //To show final score and restart the game
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;

    //Replacing start with awake, if finding objects in start()
    void Awake()
    {
        scoreKeeper = FindAnyObjectByType<ScoreKeeper>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "Congratulations! You scored " + scoreKeeper.CalculateScore() + "%";
    }

   
}
