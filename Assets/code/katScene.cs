using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class katScene : MonoBehaviour {
	public MovieTexture vid;
	public AudioSource sound;

	void Start () {
		GetComponent<RawImage>().texture = vid as MovieTexture;
		sound = GetComponent<AudioSource>();
		sound.clip = vid.audioClip;

		vid.Play ();
		sound.Play ();	}

	void Update () {
		if(vid.isPlaying){
			vid.Stop ();
			sound.Stop ();
		}
	}
}
