using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text TimeText;
    public float TimeStamp;

    // Start is called before the first frame update
    void Start()
    {
        TimeStamp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        float t = TimeStamp - Time.time;
        if(t <= 0)
        {
            FinishAction();
            return;
        }
        string minutes = ((int)t / 60).ToString("00");
        string seconds = (t % 60).ToString("00");
        TimeText.text = minutes + ":" + seconds;
    }

    // Called when the timer reaches 0
    public void FinishAction()
    {
        Debug.Log("Time's Up");
        TimeText.text = "00:00";
    }
}
