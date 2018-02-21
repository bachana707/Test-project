using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartScene : MonoBehaviour {


   // public ScrollRect scrlRect;
    public Image[] ContentHolder;
    public Text valueTxt;
    public Text toggleValueTxt;
    public AudioSource backSound;
    
    
    // Use this for initialization
    private  Transform content1;
    private Transform content2;
    private Transform content3;
   

    Outline content1Outline;
    Outline content2Outline;
    Outline content3Outline;
    void Start () {
        backSound.Play();
        content1 = ContentHolder[0].GetComponent<Transform>();
        content2 = ContentHolder[1].GetComponent<Transform>();
        content3 = ContentHolder[2].GetComponent<Transform>();

        content1Outline = ContentHolder[0].GetComponent<Outline>();
        content2Outline = ContentHolder[1].GetComponent<Outline>();
        content3Outline = ContentHolder[2].GetComponent<Outline>();
       
    }
	
	// Update is called once per frame
	void Update () {
        ScrollControl();
    }
    private void ScrollControl()
    {
        if (content1.position.x > Screen.width / 2 - 30 && content1.position.x < Screen.width / 2 + 30)
        {
            content1.localScale = new Vector3(1.5f, 1.5f, 0);
            content1Outline.effectColor = Color.yellow;
            valueTxt.text = "1";
        }
        else
        {
            content1.localScale = new Vector3(1f, 1f, 0);
            content1Outline.effectColor = Color.red;
        }

        if (content2.position.x > Screen.width / 2 - 30 && content2.position.x < Screen.width / 2 + 30)
        {
            content2.localScale = new Vector3(1.5f, 1.5f, 0);
            content2Outline.effectColor = Color.yellow;
            valueTxt.text = "2";
        }
        else
        {
            content2.localScale = new Vector3(1f, 1f, 0);
            content2Outline.effectColor = Color.red;

        }
        if (content3.position.x > Screen.width / 2 - 30 && content3.position.x < Screen.width / 2 + 30)
        {
            content3.localScale = new Vector3(1.5f, 1.5f, 0);
            content3Outline.effectColor = Color.yellow;
            valueTxt.text = "3";
        }
        else
        {
            content3.localScale = new Vector3(1f, 1f, 0);
            content3Outline.effectColor = Color.red;

        }


    }

    public void ToggleClick(int togleIndex)
    {
        switch (togleIndex)
        {
            case 1:
                toggleValueTxt.text = "1";

                break;
            case 2:
                toggleValueTxt.text = "2";
                break;
            case 3:
                toggleValueTxt.text = "3";
                break;
            default:
                break;
        }
    }

    public void OnEnterbtnClick()
    {
        SceneManager.LoadScene("Game");
    }
 
}
