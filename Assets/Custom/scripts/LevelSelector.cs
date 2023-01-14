using Assets.Custom.scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public const string SCENE_VARIANT = "SCENE_VARIANT";
	[SerializeField] private PositionSaver _positionSaver;

    public void SetSceneVariant(string variant){
		PlayerPrefs.SetString(SCENE_VARIANT, variant);
	}
    public void SwitchLevel(string levelName){
		SceneManager.LoadScene(levelName);
	}

	public void Quit(){
		Application.Quit();
	}
	
	public void Restart()
	{
		_positionSaver.Save();

		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
