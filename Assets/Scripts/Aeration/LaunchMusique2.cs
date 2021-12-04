using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchMusique2 : MonoBehaviour
{

    private AudioSource Musique2;
    // Start is called before the first frame update
    void Start()
    {
        Musique2 = GetComponent<AudioSource>();
        AerationZone.onAerationZoneEnter += LaunchNextSong;
    }

    void LaunchNextSong() {
        Musique2.Play();
    } 
}
