using UnityEngine.UI;
using UnityEngine;
using System;
using System.Collections.Generic;
using TMPro;

public class Medal : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private GameObject _star;
    [SerializeField] private List<TextMeshProUGUI> _text = new List<TextMeshProUGUI>(3);
    Animator _animator;
    public static bool _savecoin;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void Start()
    {
        load();
    }
    private void Update()
    {
        if (_savecoin == true)
        {           
            if (Bird._point >= 10)
            {
                _star.SetActive(true);
                imageMedal();
                save();
                load();
            }    
            _savecoin = false;
        }
    }
    void imageMedal()
    {
        if (Bird._point >= 10 && Bird._point < 20)
        {
            SaveData.coin.b++;
            _animator.SetBool("bronze", true);
        }
        else if (Bird._point >= 20 && Bird._point < 30)
        {
            SaveData.coin.s++;
            _animator.SetBool("silver", true);
        }
        else if (Bird._point >= 30) 
        {
            SaveData.coin.g++;
            _animator.SetBool("gold", true); 
        }
    }
    void save()
    {
        SaveData.Save(SaveData.coin, "/coin.json");
    }
    void load()
    {
        SaveData.Load(ref SaveData.coin, "/coin.json");
        _text[0].text = SaveData.coin.b.ToString();
        _text[1].text = SaveData.coin.s.ToString();
        _text[2].text = SaveData.coin.g.ToString();
    }
}
