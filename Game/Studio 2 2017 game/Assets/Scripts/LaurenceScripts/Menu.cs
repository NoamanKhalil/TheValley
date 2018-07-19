using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {

    //simple menu switching script

	public void MenuChanger (string MenueSwitch)
    {

		SceneManager.LoadScene (MenueSwitch);

        
	}

	public void Exit()
    {
		Debug.Log ("Request Exit");
		Application.Quit ();

    }

    public void Play()
    {
        Debug.Log("play");
		SceneManager.LoadScene("Scene1");
    }

    public void Help()
    {
        Debug.Log("Help");
		SceneManager.LoadScene("HelpMenu");
    }

    public void MainMenu()
    {
        Debug.Log("Main");
		SceneManager.LoadScene("MainMenu");
    }


}
