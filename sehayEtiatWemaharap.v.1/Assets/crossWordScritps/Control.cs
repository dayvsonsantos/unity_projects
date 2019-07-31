using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public int score;
    public int maxScore;
    public float time;
    public string level;

    void Update()
    {
        timeControl();
        setVal();
        
    }

    void setVal()
    {
        float perCorr = ((1.0f*score)/maxScore)*100.0f;
        string key = "crossWord_" + level;
        PlayerPrefs.SetFloat(key, perCorr);
        PlayerPrefs.SetString("prevLevel", key);

        Debug.Log("Perr: " + PlayerPrefs.GetFloat(key));
        Debug.Log("Key: " + PlayerPrefs.GetString("prevLevel"));
    }

    void timeControl()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        if (time <= 0 || score == maxScore)
        {
            SceneManager.LoadScene("TelaFeedback2");
        }
    }

    public void carregaCena(string nomeCena)
    {
        Application.LoadLevel(nomeCena);
    }

}
