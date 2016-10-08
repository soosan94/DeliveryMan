using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

	public Button[] _button;
	public Color[] _color;

	// Use this for initialization
	void Start () {
		_color [0] = Color.black;
		_color [1] = Color.blue;
		_color [2] = Color.cyan;
		_color [3] = Color.gray;
		_color [4] = Color.green;
		_color [5] = Color.red;
		_color [6] = Color.magenta;
		_color [7] = Color.white;
		_color [8] = Color.yellow;

		_button [0].image.color = _color [0];
		_button [1].image.color = _color [1];
		_button [2].image.color = _color [2];
		_button [3].image.color = _color [3];
		_button [4].image.color = _color [4];
		_button [5].image.color = _color [5];
		_button [6].image.color = _color [6];
		_button [7].image.color = _color [7];
		_button [8].image.color = _color [8];
	}

}
