using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Add script component to Main Camera
// Bind a Canvas -> Text onto Time Text box
/*
public class Timer : MonoBehaviour
{

    public Text TimeText;
    public float TimeStamp;

    // Start is called before the first frame update
    void Start()
    {
        // Time limit for the level
        TimeStamp = 5;
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
*/
public class Timer : MonoBehaviour
{

    public Text TimeText;
    public float TimeStamp;

    // Start is called before the first frame update
    void Start()
    {
        // Time limit for the level
        TimeStamp = 30;
    }

    // Update is called once per frame
    void Update()
    {
        float t = TimeStamp - Time.timeSinceLevelLoad;
        if (t <= 0)
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}