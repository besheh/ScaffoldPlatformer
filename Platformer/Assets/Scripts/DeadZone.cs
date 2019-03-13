using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Used to define areas in which the player instantly dies and triggers Game Over sequence
/// </summary>
public class DeadZone : MonoBehaviour {

    public Timer timetext;
    public AudioClip chickenScream;
    private AudioSource bgm;
    private Camera m_MainCamera;

    public GameManager gameManager;
	// Use this for initialization
	void Start () {
		m_MainCamera = Camera.main;
        m_MainCamera.enabled = true;
        bgm = m_MainCamera.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Triggers GameOver if player hits a DeadZone area on the game scene
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("yoooo");
            StartCoroutine(SoundRestart());
        }
       
    }

    IEnumerator SoundRestart()
    {
        bgm.Stop();
        bgm.PlayOneShot(chickenScream);
        yield return new WaitForSeconds(chickenScream.length);
        timetext.FinishAction();
    }
}
