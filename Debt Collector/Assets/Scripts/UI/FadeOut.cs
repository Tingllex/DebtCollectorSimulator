using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private bool fadeOut = false;

    public void HideUI()
    {
        fadeOut = true;
    }

    private void Update()
    {
        if (fadeOut)
        {
            if(canvasGroup.alpha >= 0)
            {
                canvasGroup.alpha -= Time.deltaTime;
                if(canvasGroup.alpha == 0)
                    fadeOut = false;
            }
        }
    }
}
