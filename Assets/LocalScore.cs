using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalScore : MonoBehaviour
{
    public InputField numberIn;
    public Text numberOut;
    private string key = "0num";

    // clickers score amount
    private float score;

    public void SaveNumber()
    {
        //int i = int.Parse(score);
        //PlayerPrefs.SetInt(key,i);

        // saves score for future playtime
        //PlayerPrefs.SetFloat("score", score);
    }
    public void AddScore()
    {
        // finds saved score
        score = PlayerPrefs.GetFloat("score");
        // adds score everytime you click on it
        score++;
        // saves the score on every click
        PlayerPrefs.SetFloat("score", score);
        // show number in real time
        numberOut.text = score.ToString();
    }

    public void ShowNumber()
    {
        numberOut.text = PlayerPrefs.GetFloat("score").ToString();
    }


    public void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
        numberOut.text = PlayerPrefs.GetInt("score").ToString();
    }
}
