using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreUI : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;

    void Start()
    {
        scoreText.text = PlayerPrefs.GetFloat("highScore").ToString();
    }

    public void Reset()
    {
        PlayerPrefs.SetFloat("highscore", 0);
    }
}
