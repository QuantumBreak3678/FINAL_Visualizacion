using System;
using UnityEngine;
using DG.Tweening; 
using UnityEngine.Playables;
    
public class EventManager : MonoBehaviour
{
    public PlayableDirector MainStart; 
    public PlayableDirector MachineCinematic; 

    public void StartGame()
    {
        MainStart.Play();
    }
    
    public void StartCinematic()
    {
        MachineCinematic.Play();
    }
    
}
