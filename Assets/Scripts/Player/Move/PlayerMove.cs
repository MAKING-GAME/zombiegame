using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 20;
    Transform moveTransform;
    Animator animator;

    private void Start()
    {
        moveTransform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (h != 0 || v != 0)
        {
            animator.SetBool("isMoving", true);
            if (h != 0 && v != 0)
            {
                animator.SetFloat("positionX", h);
                animator.SetFloat("positionY", 0);
            }
            else
            {
                animator.SetFloat("positionX", h);
                animator.SetFloat("positionY", v);
            }
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

        

        moveTransform.position += new Vector3(h, v, moveTransform.localPosition.z).normalized * moveSpeed * Time.deltaTime;
    }

}
