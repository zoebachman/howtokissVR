﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// this line of code will make the Movie Texture begin playing
//(MovieTexture)GetComponent<Renderer>().material.mainTexture.Play();
//RequireComponent(typeof(AudioSource))

public class PlayVideo : MonoBehaviour {
	public MovieTexture movie;
	//private AudioSource audio;

	void Start () {
		GetComponent<RawImage> ().texture = movie as MovieTexture;
//		audio = GetComponent<AudioSource> ();
//		audio.clip = movie.audioClip;
		movie.Play();
//		audio.Play();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && movie.isPlaying) 
		{
			movie.Pause ();
		} else if(Input.GetKeyDown (KeyCode.Space) && !movie.isPlaying)
		{
			movie.Play();
		}
	}
}
