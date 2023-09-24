using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleMove : MonoBehaviour
{
    [SerializeField] private float _movespeed = 2; 

    void Update()
    {
        transform.Translate(Vector2.left * _movespeed * Time.deltaTime);
        Destroy(gameObject, 6);
    }
}
