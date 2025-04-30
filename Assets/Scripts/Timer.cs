using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQ = 30f;
    [SerializeField] float timeToShowCorrectAns = 10f;

    [SerializeField] public bool isAnsweringQ = false;
    [SerializeField] public bool LoadNextQ = false;
    [SerializeField] public float fillFraction;

    float timerValue;
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    //Fractioning out the timer to display decreasing time
    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        if (isAnsweringQ)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQ;
            }
            else
            {
                isAnsweringQ = false;
                timerValue = timeToShowCorrectAns;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAns;
            }
            else
            {
                isAnsweringQ = true;
                timerValue = timeToCompleteQ;
                LoadNextQ = true;
            }
        }      
    }
}
