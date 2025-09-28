using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private string[] sceneOrder;

    private int currentSceneIndex = 0;

    public GameObject objectToTeleport = null; //assign it from inspector or code
    public Vector3 destination = new Vector3(0, 0, 0); //assign it from inspector or code

    public float timeRemaining = 150;
    public bool timerIsRunning = false;
    public Text timeText;
    public int pressure = 0;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;

        StartCoroutine(CycleScenes());
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining - (pressure * 2));
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                //Move object
                objectToTeleport.transform.position = destination;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private IEnumerator CycleScenes()
    {
        while (true)
        {
            pressure++;
            yield return new WaitForSeconds(timeRemaining - (pressure * 2));

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
