using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametersCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public Material characterMaterial;
    public Color emissionIntensity;
	private Animation anim;
	public AnimationClip flash;
    public AnimationClip flashOnBlowAnim;
    public AnimationClip RewindFlashAfterSuccessClip;
    public static ParametersCharacter Instance  {get; private set; }

    private void Awake() {
        Instance = this;
    }

    void Start() {
        characterMaterial = GetComponent<Renderer>().material;
        anim = GetComponent<Animation>();
        anim.AddClip(flash, "Flash");
        anim.AddClip(flashOnBlowAnim, "FlashOnBlow");
        anim.AddClip(RewindFlashAfterSuccessClip, "RewindFlashAfterSuccessClip");

        // emissionIntensity = characterMaterial.GetColor("_EmissionColor");
        HandleColorSmoke.onSmokeEnter += onSmokeEnter;
    }

    // IEnumerator FlashCharacter() {
    //     characterMaterial.DOColor(emissionIntensity * 4, "_EmissionColor", 0.2f);
    //     yield return new WaitForSeconds(0.2f);
    //     characterMaterial.DOColor(Color.red, "_EmissionColor", 0.8f);
    // }

    void onSmokeEnter() {
        anim.Play("Flash");
        // characterMaterial.DOColor(Color.red, "_EmissionColor", 10f);
        // StartCoroutine(FlashCharacter());
    }

    public void playFlashOnBlow(){
        // anim["FlashOnBlow"].layer = 0;
        anim.Play("FlashOnBlow");
    }

    public IEnumerator stopFlashOnBlow() {

        if(anim.isPlaying == true) {
            anim.Rewind("FlashOnBlow");
            yield return new WaitForSeconds(0.01f);
            anim.Stop("FlashOnBlow");   
        }
    }

    public void RewindFlashAfterSuccess() {
        anim.Play("RewindFlashAfterSuccessClip");
    }
}
