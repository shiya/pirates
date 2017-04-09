using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sailing : MonoBehaviour {

	public float movementSpeed = 30;
	public GameObject projectile;
	public float projectileSpeed = 150f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.down * Time.deltaTime * movementSpeed, Space.Self);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up * Time.deltaTime * movementSpeed, Space.Self);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * Time.deltaTime * movementSpeed);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.back * Time.deltaTime * movementSpeed);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Shoot ();
		}
	}

	void Shoot() {
		
		GameObject liveProjectile = Instantiate (projectile, transform);
		liveProjectile.GetComponent<Rigidbody> ().AddForce (transform.forward * projectileSpeed, ForceMode.Impulse);
	}
}
