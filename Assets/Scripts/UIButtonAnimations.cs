using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIButtonAnimations : MonoBehaviour
{
    public Animator animator;
    bool isHighligted;

    //Checking what events are happening 
    BaseEventData m_BaseEvent;


    public void OnMouseEnter()
    {
        Debug.Log("Button is Highlighted");
    }


}
