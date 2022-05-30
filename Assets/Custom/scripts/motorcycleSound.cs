using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motorcycleSound : MonoBehaviour
{	
	[SerializeField] private AudioClip[] audioClips;
	[SerializeField] private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public void PlaySoundAt(int index){
		audioSource.PlayOneShot(audioClips[index]);
	}
	
	public void StopSound(){
		
	}
}
