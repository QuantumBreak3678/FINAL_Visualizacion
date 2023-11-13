using System;
using UnityEngine;
using DG.Tweening; 
using UnityEngine.Playables;
    
public class EventManager : MonoBehaviour
{
    public PlayableDirector MainStart; 

    public void StartGame()
    {
        MainStart.Play();
    }
    
}
