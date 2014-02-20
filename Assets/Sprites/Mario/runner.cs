using UnityEngine;
using System.Collections;

public class runner : MonoBehaviour {
	
	public float speed = 2.0f;
	public float acceleration;
	public static float distanceTraveled;
	
	void Update () {
		transform.Translate(speed * Time.deltaTime, 0f, 0f);
		distanceTraveled = transform.localPosition.x;
	}
}