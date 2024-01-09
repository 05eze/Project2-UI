using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenNewGamePanelSettings : MonoBehaviour
{
    GameObject panel;
    Animator animator;
    
    void Start()
    {
        panel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (panel.SetActive(true))
        {
            animator.Play("PANEL-NewGame-SlideIN");
        }
    }
}
