using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class goNewScene : MonoBehaviour {

	void Start () {
		DontDestroyOnLoad(transform.gameObject);
	}
		

	public void goToScene1 () {
		UnityEngine.SceneManagement.SceneManager.LoadScene ("scene1");
	}

	public void goToScene2 () {
		UnityEngine.SceneManagement.SceneManager.LoadScene ("scene2");
	}
	public void goToScene3 () {
		UnityEngine.SceneManagement.SceneManager.LoadScene ("scene3");
	}
	public void goToScene4 () {
		UnityEngine.SceneManagement.SceneManager.LoadScene ("scene4");
	}
}

//
//		void goToScene1() {
//		SceneManagement.SceneManager.LoadScene("scene1");
//			}
//	
//		void goToScene2(){
//		SceneManagement.SceneManager.LoadScene("scene2");
//		}
//	
//		void goToScene3(){
//		SceneManagement.SceneManager.LoadScene("scene3");
//		}
//	
//		void goToScene4(){
//		SceneManagement.SceneManager.LoadScene("scene4");
//		}
//	}


	//	void goToScene1() {
	//		Application.LoadLevel("scene1");
	//		}
	//
	//	void goToScene2(){
	//		Application.LoadLevel("scene2");
	//	}
	//
	//	void goToScene3(){
	//		Application.LoadLevel("scene3");
	//	}
	//
	//	void goToScene4(){
	//		Application.LoadLevel("scene4");
	//	}
	//}