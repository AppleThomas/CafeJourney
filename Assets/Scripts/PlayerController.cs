//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.InputSystem;

//public class PlayerController : MonoBehaviour
//{
//    public float moveSpeed = 10f;
//    private Animator animator;
//    private CapsuleCollider2D capsuleCollider;
//    public GameObject BoxcastCenter;
//    private Rigidbody2D rb;


//    // Start is called before the first frame update
//    void Start()
//    {
//        capsuleCollider = GetComponent<CapsuleCollider2D>();
//        animator = GetComponentInChildren<Animator>();
//        rb = GetComponent<Rigidbody2D>();

//    }


//    private void FixedUpdate()
//    {

//        Movement();
//    }

//    private void Movement()
//    {
//        //Get the input X,Y 
//        float moveX = Input.GetAxisRaw("Horizontal");
//        float moveY = Input.GetAxisRaw("Vertical");

//        //Cache it in a Vector
//        Vector2 moveDelta = new Vector2(moveX, moveY);

//        //Collision check
//        RaycastHit2D castResult;
//        //Check if we are hitting something in the X Axis
//        castResult = Physics2D.BoxCast(BoxcastCenter.transform.position, capsuleCollider.size, 0, new Vector2(moveX, 0), Mathf.Abs(moveX * Time.fixedDeltaTime * moveSpeed), LayerMask.GetMask("Collidable", "Interactable"));
//        if (castResult.collider)
//        {
//            //STOP MOVING ON THE X AXIS
//            moveDelta.x = 0;

//        }

//        //Check if we are hitting something in the Y Axis
//        castResult = Physics2D.BoxCast(BoxcastCenter.transform.position, capsuleCollider.size, 0, new Vector2(0, moveY), Mathf.Abs(moveY * Time.fixedDeltaTime * moveSpeed), LayerMask.GetMask("Collidable", "Interactable"));
//        if (castResult.collider)
//        {
//            //STOP MOVING ON THE Y AXIS
//            moveDelta.y = 0;

//        }

//        if (moveDelta.magnitude > 0)
//        {
//            if (moveDelta.x > 0)
//            {
//                animator.SetBool("isMovingRight", false);
//                animator.SetBool("isMovingLeft", false);
//                animator.SetBool("isMovingUp", false);
//                animator.SetBool("isMovingDown", false);
//                animator.SetBool("isMovingRight", true);
//            }
//            else if (moveDelta.x < 0)
//            {
//                animator.SetBool("isMovingRight", false);
//                animator.SetBool("isMovingLeft", false);
//                animator.SetBool("isMovingUp", false);
//                animator.SetBool("isMovingDown", false);
//                animator.SetBool("isMovingLeft", true);
//            }
//            else if (moveDelta.y > 0)
//            {
//                animator.SetBool("isMovingRight", false);
//                animator.SetBool("isMovingLeft", false);
//                animator.SetBool("isMovingUp", false);
//                animator.SetBool("isMovingDown", false);
//                animator.SetBool("isMovingUp", true);
//            }
//            else if (moveDelta.y < 0)
//            {
//                animator.SetBool("isMovingRight", false);
//                animator.SetBool("isMovingLeft", false);
//                animator.SetBool("isMovingUp", false);
//                animator.SetBool("isMovingDown", false);
//                animator.SetBool("isMovingDown", true);
//            }
//        }
//        else
//        {
//            animator.SetBool("isMovingRight", false);
//            animator.SetBool("isMovingLeft", false);
//            animator.SetBool("isMovingUp", false);
//            animator.SetBool("isMovingDown", false);
//        }

//        //transform.Translate(moveDelta * Time.fixedDeltaTime * moveSpeed);
//        //rb.MovePosition(rb.position + moveDelta * moveSpeed * Time.fixedDeltaTime);
//        Debug.Log(moveDelta);
//        rb.AddForce(moveDelta * moveSpeed * Time.deltaTime);
//    }

//}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;
    Vector2 movementInput;
    Rigidbody2D rb;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    bool canMove = true;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();

    }


    private void FixedUpdate()
    {

        if (canMove)
        {
            // If movement input is not 0, try to move
            if (movementInput != Vector2.zero)
            {

                bool success = TryMove(movementInput);

                if (!success)
                {
                    success = TryMove(new Vector2(movementInput.x, 0));
                }

                if (!success)
                {
                    success = TryMove(new Vector2(0, movementInput.y));
                }

                if (movementInput.x > 0)
                {
                    animator.SetBool("isMovingRight", false);
                    animator.SetBool("isMovingLeft", false);
                    animator.SetBool("isMovingUp", false);
                    animator.SetBool("isMovingDown", false);
                    animator.SetBool("isMovingRight", success);
                }
                else if (movementInput.x < 0)
                {
                    animator.SetBool("isMovingRight", false);
                    animator.SetBool("isMovingLeft", false);
                    animator.SetBool("isMovingUp", false);
                    animator.SetBool("isMovingDown", false);
                    animator.SetBool("isMovingLeft", success);
                }
                else if (movementInput.y > 0)
                {
                    animator.SetBool("isMovingRight", false);
                    animator.SetBool("isMovingLeft", false);
                    animator.SetBool("isMovingUp", false);
                    animator.SetBool("isMovingDown", false);
                    animator.SetBool("isMovingUp", success);
                }
                else if (movementInput.y < 0)
                {
                    animator.SetBool("isMovingRight", false);
                    animator.SetBool("isMovingLeft", false);
                    animator.SetBool("isMovingUp", false);
                    animator.SetBool("isMovingDown", false);
                    animator.SetBool("isMovingDown", success);
                }
            }
            // resets movement when still
            else
            {
                animator.SetBool("isMovingRight", false);
                animator.SetBool("isMovingLeft", false);
                animator.SetBool("isMovingUp", false);
                animator.SetBool("isMovingDown", false);
            }


        }
    }

    private bool TryMove(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            // Check for potential collisions
            int count = rb.Cast(
                direction, // X and Y values between -1 and 1 that represent the direction from the body to look for collisions
                movementFilter, // The settings that determine where a collision can occur on such as layers to collide with
                castCollisions, // List of collisions to store the found collisions into after the Cast is finished
                moveSpeed * Time.fixedDeltaTime + collisionOffset); // The amount to cast equal to the movement plus an offset

            if (count == 0)
            {
                rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            // Can't move if there's no direction to move in
            return false;
        }

    }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }
}