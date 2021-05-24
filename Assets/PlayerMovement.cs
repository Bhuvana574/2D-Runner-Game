using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public float jumpvelocity;
    bool grounded = true;
    Animator animator;
    public Canvas canvas;
    public SpawnManger obj;
    public RepeatBackGround bg;
    public RepeatBackGround g1;
    public RepeatBackGround g2;

    
    Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bg = GameObject.Find("BackGround").GetComponent<RepeatBackGround>();
        g1 = GameObject.Find("Ground").GetComponent<RepeatBackGround>();
        g2 = GameObject.Find("BottomGround").GetComponent<RepeatBackGround>();



        // Obstacleobject = FindObjectOfType<ObstacleMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //this.GetComponent<Rigidbody2D>().velocity = new Vector2(playerSpeed, 0);
        if (Input.GetButtonDown("Fire1"))
        {
            if (grounded)
            {
                jumpMovement();
                animator.SetTrigger("Jump");

            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            print("Grounded");
            grounded = true;
        }
        if(collision.gameObject.CompareTag("Enemy"))
        {
            animator.SetTrigger("Dead");
          // animator.enabled = false;
            canvas.gameObject.SetActive(true);
            obj.CancelInvoke("Spawn");
            bg.xoffset = 0f;
            g1.xoffset = 0f;
            g2.xoffset = 0f;
            
        }
    }
    

    private void jumpMovement()
    {

        playerRb.velocity = new Vector2(0, jumpvelocity);
        print("Jumped");
        grounded = false;
    }

}
