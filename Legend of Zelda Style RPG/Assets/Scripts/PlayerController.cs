using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Vector2 direction;

    public Animator animator;

    SpriteRenderer spriteRenderer;
    [SerializeField]
    Sprite leftSprite, rightSprite, downSprite, upSprite;

    // Use this for initialization
    void Start()
    {
        direction = Vector2.zero;
        spriteRenderer = GetComponent<SpriteRenderer>();
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
            animator.SetBool("AKey", true);
            direction += Vector2.left;
            spriteRenderer.sprite = leftSprite;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("DKey", true);
            direction += Vector2.right;
            spriteRenderer.sprite = rightSprite;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("WKey", true);
            direction += Vector2.up;
            spriteRenderer.sprite = upSprite;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("SKey", true);
            direction += Vector2.down;
            spriteRenderer.sprite = downSprite;
        }
        else
        {
            animator.SetBool("AKey", false);
            animator.SetBool("DKey", false);
            animator.SetBool("WKey", false);
            animator.SetBool("SKey", false);
        }
        
    }
}
