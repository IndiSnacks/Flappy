using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour


{   //Gameplay Vars
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject pointtrigger;
    [SerializeField] private GameObject newWall;
    [SerializeField] private GameObject player;


    [SerializeField] private Button startButton;
    [SerializeField] private Button endButton;

    [SerializeField] private GameObject JmpStartUI;
    [SerializeField] private GameObject scoreUI;

    [SerializeField] private float spawnTime = 1f;

    private bool canSpawn = false;

    [SerializeField] private string level;

    private void Start()
    {
        scoreUI.SetActive(false);
    }

    public void gameStart()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void FirstJumpUI()
    {
        JmpStartUI.SetActive(false);
        scoreUI.SetActive(true);
    }

    public void Spawn()
    {
        Vector3 spawnPosition = new Vector3(
            4f, 
            Random.Range(-2.5f, 3f), 
            transform.position.z);
        newWall = Instantiate(wall, spawnPosition, Quaternion.identity);
    }

    public void CanSpawn()
    { 
        canSpawn = true;
    }

    public void endGame()
    {
        SceneManager.LoadScene("End");
    }

    private void FixedUpdate()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0 && canSpawn)
        {
            Spawn();
            spawnTime = Random.Range(1f, 2.5f);
        }
    }
}
