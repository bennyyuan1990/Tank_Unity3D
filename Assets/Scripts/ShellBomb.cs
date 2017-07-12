using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellBomb : MonoBehaviour {

    public GameObject BombObject;

    public AudioClip BombAudio;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if ("Tank".Equals(other.tag)) {
            other.GetComponent<TankHealth>().Shoot();
        }
        AudioSource.PlayClipAtPoint(BombAudio, transform.position);
        GameObject.Instantiate(BombObject, this.transform.position, this.transform.rotation);
        GameObject.Destroy(this.gameObject);
    }
}
