using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public float Time = 1.5f;

    // Use this for initialization
    void Start()
    {
        GameObject.Destroy(this.gameObject, Time);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
