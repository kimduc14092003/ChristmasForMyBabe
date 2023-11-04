using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChristmasManager : MonoBehaviour
{
    public Snow[] mainSnowEffect;
    public AudioSource audioSource;
    public GameObject panelMenu;
    private void Start()
    {
        Time.timeScale = 0;
        StartMainSnowEffect();
    }
    public void StartClick()
    {
        Time.timeScale = 1;
        audioSource.gameObject.SetActive(true);
        panelMenu.SetActive(false);
    }
    private void StartMainSnowEffect()
    {
        for (int i = 0; i < mainSnowEffect.Length; i++)
        {
            StartCoroutine(StartSnowEffect(mainSnowEffect[i]));
        }
    }

    IEnumerator StartSnowEffect(Snow snowEffect)
    {
        yield return new WaitForSeconds(snowEffect.delayTime);
        snowEffect.particleSystem.gameObject.SetActive(true);
    }
}

[System.Serializable]
public class Snow
{
    public float delayTime;
    public ParticleSystem particleSystem;
}