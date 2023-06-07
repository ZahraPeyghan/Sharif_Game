using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ManagePanel : MonoBehaviour, IPointerDownHandler
{
    public GameObject WellcomPanel;
    public GameObject NextPanel;
    public GameObject LernPanel;
    public GameObject HandPic;
    public void OnPointerDown(PointerEventData eventData){
        WellcomPanel.SetActive(false);
        NextPanel.SetActive(true);
    }
    public void EndLernPanel(){
        LernPanel.SetActive(false);
        HandPic.SetActive(true);
    }
}
