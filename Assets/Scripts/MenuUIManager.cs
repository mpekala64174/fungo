using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIManager : MonoBehaviour
{
    [SerializeField] private GameObject eventPanelUserInRange;
    [SerializeField] private GameObject eventPanelUserNotInRange;
    bool isUIPanelActive;
    int tempEvent;

    [SerializeField] private EventManager eventManager;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void DisplayStartEventPanel(int eventID)
    {   
        if (isUIPanelActive==false){
            tempEvent = eventID;
            eventPanelUserInRange.SetActive(true);
            isUIPanelActive = true;
        }
        
    }

    public void OnJoinButtonClick(){
        eventManager.ActivateEvent(tempEvent);
    }

    public void DisplayUserNotInRangePanel()
    {
        if(isUIPanelActive==false){
            eventPanelUserNotInRange.SetActive(true);
            isUIPanelActive = true;
        }
        
    }

    public void CloseButtonClick(){
        eventPanelUserInRange.SetActive(false);
        eventPanelUserNotInRange.SetActive(false);
        isUIPanelActive = false;
    }
}