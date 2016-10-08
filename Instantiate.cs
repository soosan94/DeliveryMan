using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

	public GameObject[] person;
	public GameObject box;
	public GameObject[] house;

	int peopleIdx;
	int houseIdx;

	// Use this for initialization
	void Start () {
		person = Resources.LoadAll<GameObject> ("People");
		peopleIdx = Random.Range (0, person.Length);
		house = Resources.LoadAll<GameObject> ("Houses");
		houseIdx = Random.Range (0, house.Length);

		GameObject instantiatedPerson = Instantiate (person[peopleIdx], this.transform.position, this.transform.rotation) as GameObject;
		GameObject instantiatedBox = Instantiate (box, this.transform.position + new Vector3(-1,3,1), this.transform.rotation) as GameObject;
		GameObject instantiatedHouse = Instantiate (house[houseIdx], this.transform.position + new Vector3(7,0,0), house[houseIdx].transform.rotation) as GameObject;

		instantiatedPerson.transform.parent = this.transform;
		instantiatedBox.transform.parent = this.transform;
		instantiatedHouse.transform.parent = this.transform;
	}

}
