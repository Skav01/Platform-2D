using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroOrario : MonoBehaviour
{
    public float rotazione = 50.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * rotazione * Time.deltaTime);
    }
}
