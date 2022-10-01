using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anim;
    float currentMoveValue = 0f;
    float currentJumpValue = 0f;
    public float moveSpeed = 2;
    public float jumpSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentMoveValue = moveSpeed;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                currentMoveValue = -moveSpeed;
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else
            {
                currentMoveValue = 0;
            }
        }
        if (currentMoveValue != 0)
        {
            anim.SetBool("Moving", true);
        }
        else
        {
            anim.SetBool("Moving", false);
            anim.Rebind();
            anim.Update(0f);
            anim.Play("Idle");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentJumpValue = jumpSpeed;
        }
    }

    private void FixedUpdate()
    {
        //rigid.AddForce(new Vector2(currentMoveValue, currentJumpValue));
        rigid.velocity = new Vector2(currentMoveValue, rigid.velocity.y + currentJumpValue);
        currentJumpValue = 0;
    }
}
