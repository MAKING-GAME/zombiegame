using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Player의 조작을 제어하는 스크립트*/
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20f; //플레이어 이동속도
    PlayerWearEquipment playerWearEquipment;
    Transform moveTransform;
    Animator animator;

    void Start()
    {
        moveTransform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        playerWearEquipment = GetComponent<PlayerWearEquipment>();
        gameObject.SetActive(true);
    }

    void Update()
    {
        Move();
        if (Input.GetMouseButtonDown(0))
        {
            playerWearEquipment.handEquipment.attack();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ((RangedWeapon)playerWearEquipment.handEquipment).reload();
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
