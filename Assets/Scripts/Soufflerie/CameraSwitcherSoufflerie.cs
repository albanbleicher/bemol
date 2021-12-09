using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcherSoufflerie : MonoBehaviour
{
   public GameObject ChaufferieCamera;
    public GameObject SecondDoorCamera;
    public GameObject SoufflerieCamera;
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
        ChaufferieCamera.SetActive(false);
        SecondDoorCamera.SetActive(true);

    }
    void OnTriggerExit(Collider other) {
        SecondDoorCamera.SetActive(false);
        SoufflerieCamera.SetActive(true);

    }
}
