using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pf;
    [SerializeField] private float spawnMin = 2f;
    [SerializeField] private float spawnMax = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();   
    }

    void Spawn()
    {
        Instantiate(pf, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }

}
