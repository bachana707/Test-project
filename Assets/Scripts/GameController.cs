using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour {

    public AudioSource backSoundl;
    public AudioSource loseSound;
    public AudioSource pushSound;
    public Transform leftPosition;
    public Transform RightPosition;
    public double distance = 0;
    public double speed;
    float  currentTime;
    public Text scoreTxt; 
   

    
    TouchPhase touchPhase = TouchPhase.Ended;
    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        currentTime = 0;
        backSoundl.Play();
    }
    private void SaveData()
    {
        PlayerPrefs.SetInt("Score", (int)distance);
    }
    // Update is called once per frame
    void Update()
    {
        distance = (int)currentTime * speed * 100;
        currentTime += 1*Time.deltaTime;
        scoreTxt.text = "Distance_ "+distance.ToString();
        SaveData();
        if (Input.GetMouseButtonDown(0))
            {
            Debug.Log("Clicked");
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);

            if (hitInfo!=false)
            {
                if (hitInfo.transform.tag == "Cicle" || hitInfo.transform.tag == "Square")
                {
                    //  Destroy(hitInfo.transform.gameObject);

                    Vector3 newVector;
                    newVector.x = Random.Range(leftPosition.transform.position.x, RightPosition.transform.position.x);
                    newVector.y= Random.Range(leftPosition.transform.position.y, RightPosition.transform.position.y);
                    hitInfo.transform.position = new Vector3(newVector.x,newVector.y);
                    if (distance>50 && distance <100)
                    {
                        hitInfo.rigidbody.gravityScale=0.2f;
                    }
                    else if (distance>100)
                    {
                        hitInfo.rigidbody.gravityScale = 1f;
                    }
                    pushSound.Play();
                    
                }
            }
            else
            {
                SaveData();
                loseSound.Play();
               
               SceneManager.LoadScene("Finish");
            }
        }
    }


    





}
