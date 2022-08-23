using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class LocalScore : MonoBehaviour
{
    public InputField numberIn;
    public Text numberOut;

    // clickers score amount
    public float score;

    public Text cheerText;
    public GameObject winImage;

    public AudioClip button;
    public AudioClip background;

    private void Start()
    {
        cheerText.text = "Click 5000 times and get a surprise";
        cheerText.color = Color.red;
    }

    private IEnumerator TextChange()
    {
        yield return new WaitForSeconds(3f);
        cheerText.text = " :) ";
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

    public void PlayAudio()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = button;
        audio.Play();
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

    public void Update()
    {
        if(score == 50)
        {
            cheerText.text = "Good Job !!";
            cheerText.color = Color.cyan;
            StartCoroutine(TextChange());
        }
        if (score == 250)
        {
            cheerText.text = "Keep Going !!";
            cheerText.color = Color.magenta;
            StartCoroutine(TextChange());
        }
        if (score == 500)
        {
            cheerText.text = "FIVE HUNDRED ALREADY !!";
            cheerText.color = Color.cyan;
            StartCoroutine(TextChange());
        }
        if (score == 1000)
        {
            cheerText.text = "Almost there !!";
            cheerText.color = Color.magenta;
            StartCoroutine(TextChange());
        }
        if (score == 2500)
        {
            cheerText.text = "HALF WAY !! KEEP GOING";
            cheerText.color = Color.cyan;
            StartCoroutine(TextChange());
        }
        if (score == 3000)
        {
            cheerText.text = "Still clicking?";
            cheerText.color = Color.magenta;
            StartCoroutine(TextChange());
        }
        if (score == 4000)
        {
            cheerText.text = "Thousand more...";
            cheerText.color = Color.cyan;
            StartCoroutine(TextChange());
        }
        if (score == 5000)
        {
            cheerText.text = "Congratulations, you did it";
            cheerText.color = Color.black;
            winImage.transform.gameObject.SetActive(true);        
        }
    }
}
