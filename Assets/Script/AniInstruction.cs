using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniInstruction : MonoBehaviour
{
    public GameObject tap;
    public GameObject touch;
    public GameObject flap;
    public GameObject bird;
    public GameObject tap1;
    public GameObject tap2;
    public GameObject demo;

    // Update is called once per frame
    void Update()
    {
        if (Bird._isplay == true)
        {
            ani();
            destroyy();
        }
    }
    void destroyy()
    {
        Destroy(tap.gameObject);
        Destroy(touch.gameObject);
        Destroy(gameObject, 1);
    }
    void ani()
    {
        bird.transform.Translate(Vector2.right * 3 * Time.deltaTime);
        flap.transform.Translate(Vector2.up * 5 * Time.deltaTime);
        tap1.transform.Translate(Vector2.left * 4 * Time.deltaTime);
        tap2.transform.Translate(Vector2.right * 4 * Time.deltaTime);
        demo.transform.Translate(new Vector2(0.6f ,1)  *4 * Time.deltaTime);
    }
}
