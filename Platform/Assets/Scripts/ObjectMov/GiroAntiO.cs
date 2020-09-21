using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroAntiO : MonoBehaviour
{
    public float Rotazione = 50.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward* Rotazione * Time.deltaTime);
    }
}
