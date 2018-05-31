using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuDrive : MonoBehaviour {

	public void PlayGame (){
		SceneManager.LoadScene (1);
	}

	public void QuitGame(){
		Debug.Log ("QUIT!");
		Application.Quit ();
	}
}
