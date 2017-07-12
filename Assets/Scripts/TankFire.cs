using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFire : MonoBehaviour {

    public KeyCode FireKey = KeyCode.Space;
    public GameObject FireObject;
    public float shellSpeed = 20;

    private Transform firePosition;

	// Use this for initialization
	void Start () {
        firePosition = transform.Find("FirePosition");
  
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(FireKey)) {
            Rigidbody rigidbody= GameObject.Instantiate(FireObject, firePosition.position, firePosition.rotation).GetComponent<Rigidbody>();
            rigidbody.velocity = transform.forward * shellSpeed;
        }
	}
}
