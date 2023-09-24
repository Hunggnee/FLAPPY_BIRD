using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniIn : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Bird._isplay == true)
        {
            animator.enabled = false; 
        }
    }
}
