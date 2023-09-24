using UnityEngine.UI;
using UnityEngine;
using System;

public class Medal : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private GameObject _star;
    Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Bird._gameOver == true)
        {
            imageMedal();
            if (_bird.Point >= 20)
            {
                _star.SetActive(true);
            }
        }
    }
    void imageMedal()
    {
        if (_bird.Point >= 20 && _bird.Point < 40)
        {
            _animator.SetBool("bronze", true);
        }
        else if (_bird.Point >= 40 && _bird.Point < 75)
        {
            _animator.SetBool("silver", true);
        }
        else if (_bird.Point >= 75) { _animator.SetBool("gold", true); }
    }
}
