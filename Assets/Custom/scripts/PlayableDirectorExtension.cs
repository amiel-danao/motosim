using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableDirectorExtension : MonoBehaviour
{
    private const string CORRECT_TAG = "CORRECT";
    [SerializeField] private List<PlayableDirector> _playableDirectors;
    [SerializeField] private List<PlayableAsset> _correctAsset;
    [SerializeField] private List<PlayableAsset> _wrongAsset;
    [SerializeField] private GameObject _correctSprite;
    [SerializeField] private GameObject _wrongSprite;
    private string _levelVariant;

    private void Awake(){
        _levelVariant = PlayerPrefs.GetString(LevelSelector.SCENE_VARIANT, CORRECT_TAG);
        Debug.Log(_levelVariant);
        setPlayableAssets();
    }

    private void setPlayableAssets(){
        
        var isCorrectVariant = _levelVariant.Equals(CORRECT_TAG);
        for(var i=0; i < _playableDirectors.Count; i++){
            if(isCorrectVariant){
                _playableDirectors[i].playableAsset = _correctAsset[i];
            }
            else{
                _playableDirectors[i].playableAsset = _wrongAsset[i];
            }
        }

        _correctSprite.SetActive(isCorrectVariant);
        _wrongSprite.SetActive(!isCorrectVariant);

        SetStartTimeAndPlay(0f);
    }

    public void SetStartTimeAndPlay(float startTime){
        foreach(var director in _playableDirectors){
            director.initialTime = startTime;
            director.Play();
        }
    }    
}