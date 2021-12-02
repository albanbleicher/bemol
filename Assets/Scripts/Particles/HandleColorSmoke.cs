using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleColorSmoke : MonoBehaviour
{
    public delegate void onSmokeEnterAction();
    public static event onSmokeEnterAction onSmokeEnter;

    Material smokeMaterial;
    
    public Material characterMaterial;

    void Start()
    {
        smokeMaterial = GetComponent<Renderer>().material;
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        onSmokeEnter();
    }
}
