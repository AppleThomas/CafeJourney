using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    private Animator animator;
    private CapsuleCollider2D capsuleCollider;
    public GameObject BoxcastCenter;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }


    private void FixedUpdate()
    {

        Movement();
    }

    private void Movement()
    {
        //Get the input X,Y 
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        //Cache it in a Vector
        Vector2 moveDelta = new Vector2(moveX, moveY);

        //Collision check
        RaycastHit2D castResult;
        //Check if we are hitting something in the X Axis
        castResult = Physics2D.BoxCast(BoxcastCenter.transform.position, capsuleCollider.size, 0, new Vector2(moveX, 0), Mathf.Abs(moveX * Time.fixedDeltaTime * moveSpeed), LayerMask.GetMask("Collidable", "Interactable"));
        if (castResult.collider)
        {
            //STOP MOVING ON THE X AXIS
            moveDelta.x = 0;
        }

        //Check if we are hitting something in the Y Axis
        castResult = Physics2D.BoxCast(BoxcastCenter.transform.position, capsuleCollider.size, 0, new Vector2(0, moveY), Mathf.Abs(moveY * Time.fixedDeltaTime * moveSpeed), LayerMask.GetMask("Collidable", "Interactable"));
        if (castResult.collider)
        {
            //STOP MOVING ON THE Y AXIS
            moveDelta.y = 0;
        }

        if (moveDelta.magnitude > 0)
        {
            if (moveDelta.x > 0)
            {
                animator.SetBool("isMovingRight", false);
                animator.SetBool("isMovingLeft", false);
                animator.SetBool("isMovingUp", false);
                animator.SetBool("isMovingDown", false);
                animator.SetBool("isMovingRight", true);
            }
            else if (moveDelta.x < 0)
            {
                animator.SetBool("isMovingRight", false);
                animator.SetBool("isMovingLeft", false);
                animator.SetBool("isMovingUp", false);
                animator.SetBool("isMovingDown", false);
                animator.SetBool("isMovingLeft", true);
            }
            else if (moveDelta.y > 0)
            {
                animator.SetBool("isMovingRight", false);
                animator.SetBool("isMovingLeft", false);
                animator.SetBool("isMovingUp", false);
                animator.SetBool("isMovingDown", false);
                animator.SetBool("isMovingUp", true);
            }
            else if (moveDelta.y < 0)
            {
                animator.SetBool("isMovingRight", false);
                animator.SetBool("isMovingLeft", false);
                animator.SetBool("isMovingUp", false);
                animator.SetBool("isMovingDown", false);
                animator.SetBool("isMovingDown", true);
            }
        }
        else
        {
            animator.SetBool("isMovingRight", false);
            animator.SetBool("isMovingLeft", false);
            animator.SetBool("isMovingUp", false);
            animator.SetBool("isMovingDown", false);
        }

        //transform.Translate(moveDelta * Time.fixedDeltaTime * moveSpeed);
        rb.MovePosition(rb.position + moveDelta * moveSpeed * Time.fixedDeltaTime);
    }

}