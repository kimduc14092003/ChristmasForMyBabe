using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChristmasManager : MonoBehaviour
{
    public GameObject[] mainSnowEffect;
    public float delayTime;
    private void Start()
    {
        Invoke("StartMainSnowEffect", delayTime);
    }
    private void StartMainSnowEffect()
    {
        for (int i = 0; i < mainSnowEffect.Length; i++)
        {
            mainSnowEffect[i].SetActive(true);
        }
    }
}
