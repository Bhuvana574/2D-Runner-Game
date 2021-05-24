using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    Rigidbody2D RB;
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RB.velocity = Vector2.left * movespeed;
        if(transform.position.x<-7.89f)
        {
            Destroy(gameObject);
        }
    }
}
