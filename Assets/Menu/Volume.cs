using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    public int count;
    [SerializeField] private Image Loud;
    [SerializeField] private Sprite[] _loud;
    private void Awake()
    {
        loadVolume();
    }
    public void Update()
    {
        if (volumeSlider.value == 0)
        {
            AudioListener.volume = 0;
            Loud.sprite = _loud[2];
        }
        else 
        {
            if (count == 0)
            {
                AudioListener.volume = volumeSlider.value;
                Loud.sprite = _loud[1];
            }else
            {
                AudioListener.volume = 0;
                Loud.sprite = _loud[0];
            }
        }      
    }
    public void Savevolume()
    {
        SaveData.saveVolume.volume = volumeSlider.value;
        SaveData.saveVolume.check = count;
        SaveData.Save(SaveData.saveVolume, "/volume.json");
        loadVolume();
    }
    void loadVolume()
    {
        SaveData.Load(ref SaveData.saveVolume, "/volume.json");
        count = SaveData.saveVolume.check;
        volumeSlider.value = SaveData.saveVolume.volume;
    }
    
    public void Mute()
    {       
        if (volumeSlider.value > 0)
        {
            if(count == 1) { count--; }else count++;
        }
    }
}

