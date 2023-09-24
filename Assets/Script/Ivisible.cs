using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ivisible : MonoBehaviour
{
    public int count = 0;
    private void Update()
    {
        if(count == 2)
        {
            Destroy(gameObject);
        }
    }
    private void OnBecameInvisible()
    {
        count++;
        Debug.Log("as");
    }
    private void OnBecameVisible()
    {
        
    }
}
