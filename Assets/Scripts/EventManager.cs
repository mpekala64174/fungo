using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EventManager : MonoBehaviour
{
    public int maxDistance = 104;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void ActivateEvent(int eventID){
        if(eventID == 1){
            SceneManager.LoadScene("Test");
        }
        else if(eventID == 2){
            SceneManager.LoadScene("Test 1");
        }
    }
}
