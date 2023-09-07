using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour


{   //Gameplay Vars
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject player;
    [SerializeField] private Button startButton;
    [SerializeField] private Button endButton;

    [SerializeField] private float spawnMin = 2f;
    [SerializeField] private float spawnMax = 5f;

    private bool canSpawn = true;

    [SerializeField] private string level;

    public void gameStart()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void Reset()
    {

    }

    public void Spawn()
    {
        if (canSpawn)
        {
            Instantiate(wall, transform.position, Quaternion.identity);
            Invoke("Spawn", Random.Range(spawnMin, spawnMax));
        } 
    }

    public void endGame()
    {
        SceneManager.LoadScene("End");
    }
}
