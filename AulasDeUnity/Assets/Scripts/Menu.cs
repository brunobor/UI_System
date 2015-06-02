using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Menu : MonoBehaviour {

	GameObject timer;
	Text timerText;

	// Use this for initialization
	void Start () {
	
		timer = GameObject.FindGameObjectWithTag ("Timer");
		timerText = timer.GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {

		timerText.text = DateTime.Now.ToString();

	}

	public void GotoApp()
	{
		Application.LoadLevel ("App");
	}

	public void GotoMenu()
	{
		Application.LoadLevel ("Menu");
	}
}
