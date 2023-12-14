using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class QuitButtonFunctions : MonoBehaviour, ISelectHandler, IPointerEnterHandler
{
    public Animator animator;
    bool isHighlighted = true;


    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Button is highlighted");
        animator.Play("QuitGameButton");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Button is no longer highlighted");
        animator.Play("QuitGameButton Deselect");
    }

    public void OnSelect(BaseEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Button is no longer highlighted");
        animator.Play("QuitGameButton Idle");
    }
    
}
