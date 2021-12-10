using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{

    [SerializeField]
    private AudioClip leftSoundStep;

    [SerializeField]
    private AudioClip rightSoundStep;

    private AudioSource audioSource;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

    private void rightStep() {
        Debug.Log("right");
        audioSource.PlayOneShot(rightSoundStep);
    }

    private void leftStep() {
        Debug.Log("left");
        audioSource.PlayOneShot(leftSoundStep);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
