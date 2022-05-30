using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public const string SCENE_VARIANT = "SCENE_VARIANT";

    public void SetSceneVariant(string variant){
		PlayerPrefs.SetString(SCENE_VARIANT, variant);
	}
    public void SwitchLevel(string levelName){
		SceneManager.LoadScene(levelName);
	}

	public void Quit(){
		Application.Quit();
	}
}
