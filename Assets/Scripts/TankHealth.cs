using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour
{

    public GameObject TankBomb;
    public float Health = 100f;

    public AudioClip BombAudio;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void Shoot() {
        if (Health < 0) return;
        Health -= Random.Range(10, 20);

        if (Health < 0)
        {
            AudioSource.PlayClipAtPoint(BombAudio, transform.position);
            GameObject.Instantiate(TankBomb, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(gameObject);
        }
    }
}
