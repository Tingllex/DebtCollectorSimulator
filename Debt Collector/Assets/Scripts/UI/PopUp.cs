using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] CanvasGroup canvasGroup;

    private void Update()
    {
        if (TimerCountdown.timeValue > 115)
        {
            canvas.SetActive(true);
        }
        else if (TimerCountdown.timeValue < 115)
        {
            if (canvasGroup.alpha >= 0)
            {
                canvasGroup.alpha -= Time.deltaTime;     
            }
        }
        else if (TimerCountdown.timeValue < 110)
        {
            canvas.SetActive(false);
        }
    }
}
