using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    // Start is called before the first frame update
    float rot = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rot+=0.1f;
        transform.Rotate(0f, rot, 0f);
    }
}
