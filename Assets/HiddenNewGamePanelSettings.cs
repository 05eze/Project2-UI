using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenNewGamePanelSettings : MonoBehaviour
{
    public GameObject panel;
    Animator animator;
    
    void Start()
    {
        panel.SetActive(true);
        animator.Play("PANEL-NewGame-SlideIN");
    }


    // Update is called once per frame
    void Update()
    {
        panel.SetActive(true);
    }
}
