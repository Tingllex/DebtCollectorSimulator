using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    [SerializeField] GameObject canvas;

    private void Update()
    {
        ActivePopUp();
    }

    void ActivePopUp()
    {
        if(TimerCountdown.timeValue > 115)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
    }
}
