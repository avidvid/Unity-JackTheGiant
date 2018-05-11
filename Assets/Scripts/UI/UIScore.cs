using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//We seechanges in the edit mode no need to play
[ExecuteInEditMode]


public class UIScore : MonoBehaviour {


	public float x, y;
	// Use this for initialization
	void Start () {
		transform.position = Camera.main.ViewportToWorldPoint (new Vector3 (x, y, 0));
	}

	// Update is called once per frame
	void Update () {
		transform.position = Camera.main.ViewportToWorldPoint (new Vector3 (x, y, 0));

	}
}
