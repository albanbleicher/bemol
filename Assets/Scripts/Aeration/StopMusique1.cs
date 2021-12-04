using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusique1 : MonoBehaviour
{
    private AudioSource Musique1;
    // Start is called before the first frame update
    void Start()
    {
        Musique1 = GetComponent<AudioSource>();
        AerationZone.onAerationZoneEnter += StopSong;
    }

    void StopSong() {
        Musique1.Stop();
    } 
}
