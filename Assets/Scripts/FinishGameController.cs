using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishGameController : MonoBehaviour {

    public Text scoreTxt;
    public AudioSource backAudio;
	// Use this for initialization
	void Start () {
        scoreTxt.text = PlayerPrefs.GetInt("Score").ToString();
        backAudio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
  

    public void OnButtonClick(int index)
    {
        switch (index)
        {
            case 1:
                SceneManager.LoadScene("Start");
                break;

            case 2:
                SceneManager.LoadScene("Game");
                break;
            default:
                break;
        }
    }
}
