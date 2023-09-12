using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointScore : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] BoxCollider2D boxCollider;
    [SerializeField] int count = 0;

    private void Start()
    {
        scoreText.text = count.ToString();

    }

    public void score()
    {   
        count++;
        scoreText.text = count.ToString();
    }
}
