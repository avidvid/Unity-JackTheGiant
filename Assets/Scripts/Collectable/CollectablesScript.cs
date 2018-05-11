using UnityEngine;
using System.Collections;

public class CollectablesScript : MonoBehaviour {

	// Use this for initialization
	void OnEnable () {
		//invoke call the method inside it after the delay 
		Invoke ("DestroyCollectable", 6.0f);
	}

	void DestroyCollectable() {
		gameObject.SetActive (false);
	}

}
