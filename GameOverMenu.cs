using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {

	public void ReplayGmae()
	{
		SceneManager.LoadScene ("GameScene");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
