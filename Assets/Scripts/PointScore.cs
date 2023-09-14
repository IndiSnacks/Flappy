using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PointScore : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private int count = 0;
    [SerializeField] private float highScore;

    private void Start()
    {
        scoreText.text = count.ToString();

    }

    public void score()
    {   
        count++;
        scoreText.text = count.ToString();
    }

    public void saveHighScore()
    {
        float highScore = PlayerPrefs.GetFloat("highScore");
        if(count > highScore) 
        {
            PlayerPrefs.SetFloat("highScore", count);
        }
    }
}
