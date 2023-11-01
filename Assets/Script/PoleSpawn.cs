using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _pipe;

    [SerializeField] private GameObject[] _medal;

    public static int _count;
    private float _random;
    Vector2 _position;

    void Start()
    {
        InvokeRepeating("Spawn", 0, 2f);
        _count = 0;
    }
    void Spawn()
    {
        if (Bird._isplay == true)
        {
            _random = Random.Range(-2f, 2f);
            Vector2 vector2 = new Vector2(transform.position.x, _random);
            _position = new Vector2(transform.position.x + 1, _random);
            /////
            ///

            if (Point.best == _count + 1)
            {
                Instantiate(_pipe[1], vector2, Quaternion.identity);
                _count++;
                voidvoid();
            }
            else
            {
                Instantiate(_pipe[0], vector2, Quaternion.identity);
                _count++;
                voidvoid();

            }
        }
    }
    void voidvoid()
    {
        if (_count == 10)
        {
            Instantiate(_medal[0], _position, Quaternion.identity);
        }
        if(_count == 20)
        {
            Instantiate(_medal[1], _position, Quaternion.identity);
        }
        if(_count == 30)
        {
            Instantiate(_medal[2], _position, Quaternion.identity);
        }
    }
}
