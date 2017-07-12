using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow : MonoBehaviour {


    public Transform Target1;
    public Transform Target2;
    private Vector3 offset;
    public float DistanceSize = 0.8f;

	// Use this for initialization
	void Start () {
        offset = transform.position - (Target1.position + Target2.position) / 2;

    }
	
	// Update is called once per frame
	void Update () {
        if (Target1 == null || Target2 == null) return;

        transform.position = offset + (Target1.position + Target2.position) / 2;
        transform.GetComponent<Camera>().orthographicSize = Vector3.Distance(Target1.position, Target2.position) * DistanceSize;
    }
}
