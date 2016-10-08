using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	public GameObject ground;
	public GameObject preGround;
	public GameObject curGround;
	public GameObject nextGround;
	public GameObject player;



	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "GROUND") {
			Debug.Log ("GROUND");
			preGround = curGround;
			if (other.gameObject == nextGround)
				Destroy (preGround, 1.0f);
			curGround = nextGround;
			nextGround = Instantiate (ground, curGround.transform.position + new Vector3 (0.0f, 0.0f, 30.0f), Quaternion.identity)as GameObject;
		}
	}
}
