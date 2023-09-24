using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bird : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField] private float _rotateSpeed = 5; // tốc độ quay

    [SerializeField] private float _velocity = 7;  /// lực nhảy

    private bool _canRotate;

    [SerializeField] private int _point; /// điểm

    public static bool _gameOver; 

    public static bool _isplay; //kiểm tra xem đã bắt đầu chơi chưa

    [SerializeField] private AudioSource[] _flap;

    

    public AudioSource[] flap { get => _flap; set => _flap = value; }
    public int Point { get => _point; set => _point = value; }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Point = 0;
        Time.timeScale = 1;
        _gameOver = false;
        _isplay = false;
    }
    
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (EventSystem.current.IsPointerOverGameObject(touch.fingerId)) { _flap[5].Play(0); return; }

                isplay();
                _flap[0].Play(0);
                _rb.velocity = Vector2.up * _velocity;
            }
        }

    }

    private void FixedUpdate()
    {
        if (_canRotate == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, _rotateSpeed * _rb.velocity.y / 2);
        }
        if (transform.eulerAngles.z <= 300 && transform.eulerAngles.z >= 180)
        {
            _canRotate = false;
            transform.rotation = Quaternion.Euler(0, 0, 300);
        }
    }

    void isplay()
    {
        _isplay = true;

        _canRotate = true;

        _rb.bodyType = RigidbodyType2D.Dynamic;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "point")
        {
            Point++;
            _flap[1].Play(0);
        }
        
        if(collision.tag == "coin")
        {
            _flap[4].Play(0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "die")
        {
            _flap[2].Play(0);
            _flap[3].Play(0);
            _gameOver = true;
        }
    }
}
