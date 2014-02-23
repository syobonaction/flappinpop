using UnityEngine;
using System.Collections;

public class Spikes : MonoBehaviour {

	public Collider player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D collision) {
		Time.timeScale = 0;
	}
}
