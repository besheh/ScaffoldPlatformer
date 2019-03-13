using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// GameManager handles game logic that involves interactions between multiple objects in the scene such as Game Over and current checkPoint location
/// </summary>
public class GameManager : MonoBehaviour {

    public GameObject player; //The player GameObject on the scene
    private Transform SpawnPosition; //The location that the player will spawn

    Camera m_MainCamera;
    private AudioSource bgm;
	
    // Use this for initialization
	void Start () {
        m_MainCamera = Camera.main;
        m_MainCamera.enabled = true;
        bgm = m_MainCamera.GetComponent<AudioSource>();
	}
	

    //Updates the spawnPosition
    public void UpdateSpawnPosition(Transform newPosition)
    {
        SpawnPosition = newPosition;
    }

    //Moves the player to the SPawnPosition and Calls playerHealth Healing function
    public void GameOver()
    {
        //PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        StartCoroutine(RestartGame());
    }

    //Restarts Players health and position with a .5 second delay
    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(.5f);
        //playerHealth.HealDamage(playerHealth.maxHealth);
        bgm.Stop();
        bgm.Play(); 
        player.transform.position = SpawnPosition.position;

    }
}
