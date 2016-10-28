using UnityEngine;
using System.Collections;

// this line of code will make the Movie Texture begin playing
//(MovieTexture)GetComponent<Renderer>().material.mainTexture.Play();

public class PlayMovieOnSpace : MonoBehaviour {
	void Update () {
		if (Input.GetButtonDown ("Jump")) {

			Renderer r = GetComponent<Renderer>();
			MovieTexture movie = (MovieTexture)r.material.mainTexture;

			if (movie.isPlaying) {
				movie.Pause();
			}
			else {
				movie.Play();
			}
		}
	}
}
