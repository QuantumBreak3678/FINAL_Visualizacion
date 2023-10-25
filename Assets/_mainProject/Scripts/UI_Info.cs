using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class UI_Info : MonoBehaviour
{
    public GameObject UI_Infographic;
    public Vector3 vector; 
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
            UI_Infographic.SetActive(true);
            UI_Infographic.transform.DOScale(vector, 0.5f); 

        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UI_Infographic.transform.DOScale(new Vector3(0,0,0), 0.5f); 
            UI_Infographic.SetActive(false);
          
        }
    }
}