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

    [SerializeField] private string level;

    private void Start()
    {
        endButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        wall.SetActive(true);
        player.SetActive(true);
    }
    public void gameStart()
    {
        endButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        wall.SetActive(true);
        player.SetActive(true);
        Invoke("Spawn", 2);
    }

    public void Reset()
    {
        Invoke("gameStart", 5);
    }

    void Spawn()
    {
        Instantiate(wall, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }

    public void endGame()
    {
        wall.SetActive(false);
        player.SetActive(false);
        endButton.gameObject.SetActive(true);

    }
}
