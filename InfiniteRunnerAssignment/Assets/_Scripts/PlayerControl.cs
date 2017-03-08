using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float MoveSpeed = 5f;

	public float speed = 6.0F;
	public float jumpSpeed = 10.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;

	private CharacterController controller;
	private float groundPosition;

	void Start () {
		controller = GetComponent<CharacterController> ();
		groundPosition = controller.transform.position.y;
	}

	void Update () {
		controller.Move (transform.right * MoveSpeed * Time.deltaTime);

		if (controller.transform.position.y == 1.08f) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;

			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;

		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
		
}
