using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableDirectorExtension : MonoBehaviour
{
    [SerializeField] private List<PlayableDirector> _playableDirectors;

    public void SetStartTime(float startTime){
        foreach(var director in _playableDirectors){
            director.initialTime = startTime;
        }
    }
    
}
