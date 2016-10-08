using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void StartGame()
	{
		SceneManager.LoadScene ("GameScene");
	}

	public void QuitApp()
	{
		Application.Quit ();
	}
}
