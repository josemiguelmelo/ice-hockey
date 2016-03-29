using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class QuitApplication : MonoBehaviour {

	public void Quit()
	{


			//If we are running in the editor
		#if UNITY_EDITOR
			//Stop playing the scene
			UnityEditor.EditorApplication.isPlaying = false;
		#endif

		//Quit the application
		Application.Quit();
	}


	public void LoadMainScene()
	{
		//Load the selected scene, by scene index number in build settings
		SceneManager.LoadScene(0);
	}
    
}
