using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLMov : MonoBehaviour
{
    public float velox=10.0f;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * velox * Time.deltaTime);
       
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.transform.CompareTag("Change"))
        {
            Debug.Log("Preso");
            //velox *= -1;
 
        }
    }
}
