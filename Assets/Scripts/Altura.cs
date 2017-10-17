using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Altura : MonoBehaviour {

	public Transform personagem;
	Text textInterface;

	void Start () {
		textInterface = GetComponent<Text> ();
	}
	
	void Update () {
		//Debug.Log ("Altura: " + personagem.position.y);
		textInterface.text = "Altura: " + Math.Round(personagem.position.y).ToString();
	}
}
