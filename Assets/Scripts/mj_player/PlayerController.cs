using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Weapon weapon;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    void Update()
    {
        Move();
        if (Input.GetMouseButtonDown(0))
        {
            weapon.attack();
        }
        
    }
    void Move()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector2(inputX, inputY) * Time.deltaTime * moveSpeed);
    }
}
