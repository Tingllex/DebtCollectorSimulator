using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerCountdown : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public float timeValue = 120;
    [SerializeField] GameObject panel;

    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0)
        {
            panel.SetActive(false);
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 0f;
            panel.SetActive(true);
        }

        DisplayTime(timeValue);

    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        textDisplay.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
