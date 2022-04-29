using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScore : MonoBehaviour
{
    [SerializeField] GameObject panel;
    // Update is called once per frame
    void Update()
    {
        if (BriefCase.CollectedCash >= 10)
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
