using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	private float speed =5;
	public AudioClip bGM;


	//public AudioClip successSound;
	//public AudioClip failSound;
	//public AudioClip earningItemSound;

	void Start () {
		GetComponent<AudioSource> ().clip = bGM;
		GetComponent<AudioSource> ().Play ();
	}
	

	void Update () {
		this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
}
