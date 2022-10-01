using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoTest : MonoBehaviour
{
    public Rigidbody2D rgid2d;
    SpriteRenderer sprite2d;
    public GameObject[] x;
    // Start is called before the first frame update
    void Start()
    {
        rgid2d = GetComponent<Rigidbody2D>();
        sprite2d = GetComponent<SpriteRenderer>();
        //GameObject.fin
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
