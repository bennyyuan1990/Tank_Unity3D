using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{

    public float speed = 10;
    public float angularSpeed = 60;
    public int playerNum = 1;
    private Rigidbody rigidbody;

    public AudioClip drivingAudio;
    public AudioClip idelAudio;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        audioSource = this.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {
        float v = Input.GetAxis("VerticalPlayer" + playerNum);
        rigidbody.velocity = transform.forward * v * speed;

        float h = Input.GetAxis("HorizontalPlayer" + playerNum);
        rigidbody.angularVelocity = transform.up * h * angularSpeed;

        if (Math.Abs(v) > 0.1 || Math.Abs(h) > 0.2)
        {
            audioSource.clip = drivingAudio;
            if (!audioSource.isPlaying) audioSource.Play();
        }
        else
        {
            audioSource.clip = idelAudio;
            if (!audioSource.isPlaying) audioSource.Play();
        }
    }
}
