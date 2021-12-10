using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class ShakingController : MonoBehaviour
{
    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin;
    private float shakeTimer;
    public float startingIntensity;
    private float shakeTimerTotal;
    public static ShakingController Instance  {get; private set; }

    private void Start() {
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        Instance = this;
    }

    public void ShakeCamera(float startIntensity, float intensity, float time) {
        if (AerationZone.Instance.isOnZone == true) {
            cinemachineBasicMultiChannelPerlin = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

            cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intensity;
            startingIntensity = startIntensity;
            shakeTimerTotal = time;
            shakeTimer = time;
        }
    }

    private void Update() {
        if (shakeTimer > 0) {
            shakeTimer -= Time.deltaTime;
            if (shakeTimer <= 0) {
                cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = Mathf.Lerp(startingIntensity, .1f, shakeTimer / shakeTimerTotal);
            }
        }
    }
}
