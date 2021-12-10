using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
	private Animation anim;

    private AudioSource thunderSound;

    private Light FoudreLight;

    public static Lighting Instance  {get; private set; }


    private void Awake() {
        Instance = this;
    }

    // Start is called before the first frame update
    IEnumerator Start()
    {
        anim = GetComponent<Animation>();
        thunderSound = GetComponent<AudioSource>();
        FoudreLight = GetComponent<Light>();
        FoudreLight.intensity = 0;

        while (true) {
            yield return new WaitForSeconds(Random.Range(15,25));
            // TO DO : Working that shit
            // ShakingController.Instance.ShakeCamera(0.0f, 0.2f, .1f);
            anim.Play();
            yield return new WaitForSeconds(1.5f);
            thunderSound.Play();
        }
    }

    public void setVolume(float volume) {
        thunderSound.volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}