using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    private void Awake()
    {
        loadVolume();
    }
    public void Update()
    {
        float volume = volumeSlider.value;
        PlayerPrefs.SetFloat("value", volume);
        loadVolume();
    }
    void loadVolume()
    {
        float volume = PlayerPrefs.GetFloat("value");
        volumeSlider.value = volume;
        AudioListener.volume = volume;
    }
}
