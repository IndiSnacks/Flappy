using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collsionScript : MonoBehaviour
{

    [SerializeField] private GameObject wall;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "Player")
        {
            Debug.Log("player hit");
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.tag);
        Destroy(wall, Time.deltaTime);
    }
}
