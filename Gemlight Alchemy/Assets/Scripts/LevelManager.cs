using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Loads new scenes based on the scene name rather than the scene ID number
	public void LoadScene (string sceneName){
		Debug.Log ("Requested to load scene: " + sceneName);
		Application.LoadLevel (sceneName);
	}
}
