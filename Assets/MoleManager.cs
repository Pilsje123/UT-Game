using UnityEngine;
using System.Collections;

public class MoleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0.36f, -1.31f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y >= 4) {
			transform.position = new Vector3(0.36f, -1.31f, 0);
		} else {
			transform.Translate(Vector3.up * Time.deltaTime, 0);
		}
	}
}
