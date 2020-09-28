using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuore : MonoBehaviour
{
    public AudioSource Heart;
    // Start is called before the first frame update
    void Start()
    {
        Heart = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Heart.Play();
        }

    }
}
