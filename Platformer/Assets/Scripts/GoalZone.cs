using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

/// <summary>
/// Used to define areas in which the player instantly dies and triggers Game Over sequence
/// </summary>
public class GoalZone : MonoBehaviour
{

    public Timer timetext;

    public GameManager gameManager;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Triggers next level if player hits a GoalZone area on the game scene
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("yoooo");
            Scene m_scene = SceneManager.GetActiveScene();
            if (m_scene.name == "Level 1")
            {
                SceneManager.LoadScene("Level 2");
            }
            else if (m_scene.name == "Level 2")
            {
                SceneManager.LoadScene("Level 3");
            }
            else if (m_scene.name == "Level 3")
            {
                SceneManager.LoadScene("End");
            }

        }

    }
}
