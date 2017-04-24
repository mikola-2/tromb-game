using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(AudioSource))]

public class katScene : MonoBehaviour {
	public MovieTexture playingMovie;
	public MovieTexture movie;
	public MovieTexture movie2;
	public MovieTexture movie3;
	public MovieTexture movie4;
	public AudioSource sound;
	public int endingInd;

	void Start () {
		var movieList = new List<MovieTexture> (){ movie, movie2, movie3, movie4 };
		endingInd = Random.Range (1, 4);
		PlaySelectedMovie (movieList[endingInd]);
	}

	void Update () {
		if(!playingMovie.isPlaying){
			SceneManager.LoadScene ("menu");
		}
	}

	void PlaySelectedMovie(MovieTexture movie){
		playingMovie = movie;
		GetComponent<RawImage>().texture = playingMovie as MovieTexture;
		sound = GetComponent<AudioSource>();
		sound.clip = playingMovie.audioClip;
		sound.volume = 0.5f;

		playingMovie.Play ();
		sound.Play ();
	}
}
