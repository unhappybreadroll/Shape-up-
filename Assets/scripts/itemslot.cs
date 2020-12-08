using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class itemslot : MonoBehaviour, IDropHandler {


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //this makes the items snapp into place
        }
        // plays audio when placing objoect
        GetComponent <AudioSource>().Play();


    }





    }
