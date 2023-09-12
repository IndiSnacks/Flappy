using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{ 
    [SerializeField] private float speed = 2f;
    Vector2 move = new Vector2(-1, 0);

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(4f, transform.position.y, transform.position.z);
    }

    void FixedUpdate()
    {
        transform.Translate(move * speed * Time.deltaTime);
    }
}
