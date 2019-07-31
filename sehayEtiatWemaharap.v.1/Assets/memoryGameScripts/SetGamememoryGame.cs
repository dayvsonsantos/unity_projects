using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetGamememoryGame : MonoBehaviour
{
    public float tempo = 60;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("game", "LevelList_MemoryGame");
    }

    private void Update()
    {
        if (tempo > 0)
        {
            tempo -= Time.deltaTime;
        }
        if (tempo <= 0)
        {
            SceneManager.LoadScene("TelaFeedback1");
        }
    }
}
