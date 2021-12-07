using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject HangarCamera;
    public GameObject ThirdPersonCamera;
    void Start()
    {
        Debug.Log("Door init");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) {
        Debug.Log("Coucou");
        HangarCamera.SetActive(false);
        ThirdPersonCamera.SetActive(true);

    }
}
