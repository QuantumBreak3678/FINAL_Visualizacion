using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class UI_Info : MonoBehaviour
{
    public CanvasGroup UI_Infographic;

    public InterfaceAnimManager GlobalInterface; 
    
    public InterfaceAnimManager CrystalInterface;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            UI_Infographic.DOFade(1f, 0f); 
            GLOBALAppear();

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            GlobalInterface.startDisappear();
            
        }
    }

    public void Crystal()
    {
        GlobalInterface.startDisappear();
        CrystalInterface.startAppear();
    }

    public void GLOBALAppear()
    {
        GlobalInterface.startAppear();
        CrystalInterface.startDisappear();
      
    }
   
    
}