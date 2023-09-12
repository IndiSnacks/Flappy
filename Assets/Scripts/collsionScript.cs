using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collsionScript : MonoBehaviour
{

    [SerializeField] private GameObject wall;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "EndTrigger")
        {
            Destroy(wall, Time.deltaTime);
        }
    }
}
