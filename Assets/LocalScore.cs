using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalScore : MonoBehaviour
{
    public InputField numberIn;
    public Text numberOut;
    private string key = "0num";


    public void SaveNumber()
    {
        int i = int.Parse(numberIn.text);
        PlayerPrefs.SetInt(key,i);
    }


    public void ShowNumber()
    {
        numberOut.text = PlayerPrefs.GetInt(key).ToString();
    }


    public void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
        numberOut.text = PlayerPrefs.GetInt(key).ToString();
    }
}
