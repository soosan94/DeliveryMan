using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour {

	public GameObject player;
	public Transform playerTr;
	public GameObject package;
	private Image image;
	public GameObject box;
	public GameObject fire;
	public GameObject bullet;
	public GameMgr gameMgrScript;
	private int buttonCount;
	public GameObject openedBox;
	// Use this for initialization
	void Start () {
		playerTr = player.transform;
		image = gameObject.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		package = GameObject.FindGameObjectWithTag ("PACKAGE");
		//상자가 떨어지다가 열린상자로 변신
		if (package && package.transform.position.y <=1.5f) {
			GameObject box2=Instantiate (openedBox, package.transform.position, this.transform.rotation) as GameObject;
			box2.transform.parent = package.gameObject.transform.parent;

			Destroy (package.gameObject);
		}
	}
		
	public void TouchButton()
	{
		//버튼눌렀을 때 점수,하트 변경
		if (package) {
			buttonCount = package.GetComponent<Box> ().count;
			if (buttonCount ==0 && image.color == package.GetComponent<Renderer> ().material.color) {
				package.GetComponent<Rigidbody> ().useGravity = true;
				Debug.Log ("Success!!!!!!!");
				gameMgrScript.score += 5;
				package.GetComponent<Box> ().count++;
			}else if(image.color != package.GetComponent<Renderer> ().material.color && gameMgrScript.heartCount>0){
				gameMgrScript.Heart[gameMgrScript.heartCount-1].SetActive(false);
				gameMgrScript.heartCount--;
			}

		}

		bullet = Instantiate (box, fire.transform.position, fire.transform.rotation)as GameObject;
		bullet.GetComponent<Renderer> ().material.color = image.color;
		bullet.GetComponent<Rigidbody> ().velocity = fire.transform.forward * 30;
		Destroy (bullet, 1.0f);
	}
}
