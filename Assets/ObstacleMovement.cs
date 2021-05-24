using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    Rigidbody2D obstacleRB;
  
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        obstacleRB = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        obstacleRB.velocity = new Vector2(-speed,  0);
        

    }
}
