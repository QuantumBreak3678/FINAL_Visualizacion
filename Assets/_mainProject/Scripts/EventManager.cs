using System;
using System.Collections;
using UnityEngine;
using DG.Tweening; 
using UnityEngine.Playables;
    
public class EventManager : MonoBehaviour
{
    public PlayableDirector MainStart; 
    public PlayableDirector MachineCinematic; 
    public PlayableDirector EndCinematic; 

    public void StartGame()
    {
        MainStart.Play();
    }

    public void StartCinematic()
    {
        MachineCinematic.Play();
    }

    public void EndCinematicFUCTION()
    {
        EndCinematic.Play();
        StartCoroutine(END()); 
    }

    IEnumerator END()
    {
        yield return new WaitForSeconds(2f);

    }

}
