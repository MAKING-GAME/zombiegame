using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvas : MonoBehaviour
{
    public float moveSpeed;
    public GameObject gun1;
    // Start is called before the first frame update
    void Start()
    {
        //gun1 = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        selectGun();
    }
    void Move()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        if (inputX > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
            transform.Translate(new Vector2(inputX, inputY) * Time.deltaTime * moveSpeed);
        }
        else if (inputX < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
            transform.Translate(new Vector2(-inputX, inputY) * Time.deltaTime * moveSpeed);
        }
        else
        {
            transform.Translate(new Vector2(inputX, inputY) * Time.deltaTime * moveSpeed);
        }
    }
    void selectGun()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            gun1.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            gun1.SetActive(true);
        }
    }
}
