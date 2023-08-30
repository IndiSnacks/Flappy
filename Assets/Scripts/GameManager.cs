using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour


{   //Gameplay Vars
    [SerializeField] private GameObject pf;
    [SerializeField] private Button startButton;

    [SerializeField] private float spawnMin = 2f;
    [SerializeField] private float spawnMax = 5f;

    [SerializeField] private string level;

    public void gameStart()
    {
        startButton.gameObject.SetActive(false);
        Invoke("Spawn", 2);
    }

    void Spawn()
    {
        Instantiate(pf, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }

    void endGame()
    {

    }
}
