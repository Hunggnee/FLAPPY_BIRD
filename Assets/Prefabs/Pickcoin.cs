using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickcoin : MonoBehaviour
{

    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "bird")
        {
            animator.SetBool("true", true);
            Destroy(gameObject, 1);
        }
    }
}
