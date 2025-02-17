﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FeedbackSetStar : MonoBehaviour
{
    public GameObject[] stars;
    string game;

    private void Start()
    {
        string level = PlayerPrefs.GetString("prevLevel");
        float perCorrect = PlayerPrefs.GetFloat(level);
        lightUpStar(perCorrect);
    }
    
    public void changeScene()
    {
        game = PlayerPrefs.GetString("game");
        SceneManager.LoadScene(game);
    }

    void lightUpStar(float perCorrect)
    {
        if (perCorrect >= 0.1f && perCorrect < 33.0f)
        {
            stars[0].SetActive(true);
        } else if (perCorrect >= 33.0f && perCorrect < 99.0f)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        } else if (perCorrect >= 99.0f && perCorrect < 101f)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }
    }
}
