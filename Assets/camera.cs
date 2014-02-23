using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public float distance;
	public Transform player;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 CamPos = new Vector3(player.transform.position.x,-11,-10);
		camera.transform.position = CamPos;
	}
}
