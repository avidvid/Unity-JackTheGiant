using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeText : MonoBehaviour {

	public int fontSize;
	private Text m_Text;

	// Use this for initialization
	void Start () {

		m_Text = GetComponent<Text>();
		SetFont ();
		UpdateLifes ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateLifes ();
	}


	void UpdateLifes ()
	{
		m_Text.text = "x " + Player.lifeCount;
	}


	void SetFont ()
	{
		m_Text.fontSize = Mathf.Min(Screen.width,Screen.height)/fontSize;
	}
}
