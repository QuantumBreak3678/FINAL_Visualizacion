using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class UI_Info : MonoBehaviour
{
    public GameObject UI_Infographic;

    public InterfaceAnimManager InterfaceAnimManager; 
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
            InterfaceAnimManager.startAppear();
            UI_Infographic.SetActive(true);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
         
           
            InterfaceAnimManager.startDisappear();
            
          
        }
    }
   
    
}