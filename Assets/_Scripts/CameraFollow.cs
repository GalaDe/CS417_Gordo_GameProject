using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform player;

	public float cameraY = 4f;
	public float cameraZ = -100f;

	void Start () {
		
	}

	void Update () {
		transform.position = new Vector3(player.position.x, cameraY, cameraZ);
	}
}
