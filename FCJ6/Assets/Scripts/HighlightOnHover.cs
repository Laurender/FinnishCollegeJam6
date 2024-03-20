using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class HighlightOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //public float scaleFactor;
    public void OnPointerEnter(PointerEventData eventData)
    {
        //this.gameObject.transform.localScale = new Vector3(scaleFactor, scaleFactor, 1f);
        this.gameObject.GetComponent<TMP_Text>().color = new Color(.75f, .75f, .75f);
        //Debug.Log("Mouse enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //this.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        this.gameObject.GetComponent<TMP_Text>().color = new Color(0f, 0f, 0f);
        //Debug.Log("Mouse exit");
    }
}
