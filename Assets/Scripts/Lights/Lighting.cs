using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
	private Animation anim;

    private AudioSource thunderSound;

    private Light FoudreLight;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        anim = GetComponent<Animation>();
        thunderSound = GetComponent<AudioSource>();
        FoudreLight = GetComponent<Light>();
        FoudreLight.intensity = 0;

        while (true) {
            yield return new WaitForSeconds(Random.Range(15,25));
            Debug.Log("playFoudre");
            anim.Play();
            yield return new WaitForSeconds(1.5f);
            thunderSound.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
