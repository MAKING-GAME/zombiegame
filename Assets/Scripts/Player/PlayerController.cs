using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20f;
    public Weapon weapon;
    Transform moveTransform;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        moveTransform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        gameObject.SetActive(true);
    }

    void Update()
    {
        Move();
        if (Input.GetMouseButtonDown(0))
        {
            weapon.attack();
        }
        else if (Input.GetKeyDown(KeyCode.R) && weapon.GetType().Name == "Gun")
        {
            ((Gun)weapon).reloading();
        }
        
    }
    void Move()
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
