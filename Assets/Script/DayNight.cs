using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    [SerializeField] private Sprite _bgnight;
    [SerializeField] private SpriteRenderer _bgday;

    private void Awake()
    {
        if (DateTime.Now.Hour >= 19 && DateTime.Now.Hour <= 24 || DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 5.5f)
        {
            _bgday.sprite = _bgnight;
        }
    }
}
