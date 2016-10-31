using UnityEngine;
using System.Collections;

public class goNewScene : MonoBehaviour {



void Start () {
	DontDestroyOnLoad(transform.gameObject);
}


public void goToScene1(){
	Application.LoadLevel("scene1");
}


public void goToScene2(){
	Application.LoadLevel("scene2");
}

	public void goToScene3(){
		Application.LoadLevel("scene3");
	}

	public void goToScene4(){
		Application.LoadLevel("scene4");
	}
}