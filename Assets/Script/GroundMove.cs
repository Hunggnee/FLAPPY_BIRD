using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField] private float _movespeed = 2;
    private Vector2  _setposition;
    private float _timeloop = 1.2f;
    private float _Timeloop = 1.2f;
    private void Awake()
    {
        _setposition = transform.position;
    }
    private void Update()
    {
        transform.Translate(Vector2.left * _movespeed * Time.deltaTime);
        Settime();
    }
    public void Settime()
    {       
        _timeloop -= Time.deltaTime;
        if( _timeloop <= 0)
        {
            _timeloop = _Timeloop;
            transform.position = _setposition;
        }
    }
}
