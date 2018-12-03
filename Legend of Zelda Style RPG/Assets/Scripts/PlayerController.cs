using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Vector2 direction;

    public Animator animator;
    

    // Use this for initialization
    void Start()
    {
        direction = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Move();
    }

    void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {
        direction = Vector2.zero;
        if(Input.GetKey(KeyCode.A))
        {
            
            direction += Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            
            direction += Vector2.right;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("WKey", true);
            direction += Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("SKey", true);
            direction += Vector2.down;
        }
        else
        {
            animator.SetBool("WKey", false);
            animator.SetBool("SKey", false);
        }
        
    }
}
