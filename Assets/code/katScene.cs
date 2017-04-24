using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(AudioSource))]

public class katScene : MonoBehaviour {
	public MovieTexture movie;
	public AudioSource sound;

	void Start () {
		GetComponent<RawImage>().texture = movie as MovieTexture;
		sound = GetComponent<AudioSource>();
		sound.clip = movie.audioClip;

		movie.Play();
		sound.Play ();	}

	void Update () {
		if(!movie.isPlaying){
			SceneManager.LoadScene ("menu");
		}
	}
}
