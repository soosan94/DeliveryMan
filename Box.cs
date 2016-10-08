using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {

	public Color[] _color;
	public GameObject player;
	public GameObject gameMgr;
	public GameMgr gameMgrScript;


	public int count =0;
	private float distance;
	// Use this for initialization
	void Start () {
		gameMgr = GameObject.Find("GameMgr");
		gameMgrScript = gameMgr.GetComponent<GameMgr> ();
		player = GameObject.FindGameObjectWithTag ("PLAYER");

		_color [0] = Color.black;
		_color [1] = Color.blue;
		_color [2] = Color.cyan;
		_color [3] = Color.gray;
		_color [4] = Color.green;
		_color [5] = Color.red;
		_color [6] = Color.magenta;
		_color [7] = Color.white;
		_color [8] = Color.yellow;
		GetComponent<Renderer>().material.color = _color[Random.Range(0,8)];

	}
	
	// Update is called once per frame
	void Update () {
		distance = gameObject.transform.parent.position.z - player.transform.position.z;
		if( distance > 0 && distance<=6.0f)
			this.gameObject.tag = "PACKAGE";
		else
			this.gameObject.tag = "Untagged";
		if (distance < 0 && count == 0 && gameMgrScript.heartCount>0) {
			gameMgrScript.Heart[gameMgrScript.heartCount-1].SetActive(false);
			gameMgrScript.heartCount--;
			count++;
		}
		


	}


}
