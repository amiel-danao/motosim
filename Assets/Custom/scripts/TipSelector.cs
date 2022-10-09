using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TipSelector : MonoBehaviour
{
    [SerializeField] private List<GameObject> _allTipsGameObjects;
    [MultilineAttribute]
    [SerializeField] private List<string> _tips;
    [SerializeField] private TMP_Text _tipsText;

    private int _currentIndex = 0;


    public void NextTipGameObject(){
        if((_currentIndex + 1) >= _allTipsGameObjects.Count){
            _currentIndex = 0;
        }
        else{
            _currentIndex++;
        }
        foreach(var obj in _allTipsGameObjects){
            if(obj != null){
                obj.SetActive(false);
            }
        }

        try{
            _allTipsGameObjects[_currentIndex].SetActive(true);
        }
        catch (System.Exception)
        {

        }
        _tipsText.text = _tips[_currentIndex];
    }

    public void PreviousTipGameObject(){
        if((_currentIndex - 1) < 0){
            _currentIndex = _allTipsGameObjects.Count-1;
        }
        else{
            _currentIndex--;
        }
        foreach(var obj in _allTipsGameObjects){
            if(obj != null){
                obj.SetActive(false);
            }
        }
        try{
            _allTipsGameObjects[_currentIndex].SetActive(true);
        }
        catch(System.Exception exception){

        }
        _tipsText.text = _tips[_currentIndex];
    }
}
