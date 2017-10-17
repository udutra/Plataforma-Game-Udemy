using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Altura : MonoBehaviour {

	public Transform personagem;
	Text textInterface;

	void Start () {
		
	}
	
	void Update () {
		Debug.Log ("Altura: " + personagem.position.y);
	}
}
