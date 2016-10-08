using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMgr : MonoBehaviour {

	public Text scoreText;
	public int score =0;
	public GameObject[] Heart;
	public int heartCount = 5;
	public GameObject player;



	void Update () {
		scoreText.text = "SCORE : " + score.ToString();
		if (heartCount == 0)
			GameOver ();
	}

	void GameOver()
	{
		SceneManager.LoadScene ("GameOverScene");
	}
}
