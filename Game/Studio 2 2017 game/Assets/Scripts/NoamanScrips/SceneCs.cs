using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneCs : MonoBehaviour {


	public void LoadScene(string scene)
	{
		// Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
		SceneManager.LoadScene(scene);
	}

	public void quit()
	{
		Application.Quit();
	}

}

