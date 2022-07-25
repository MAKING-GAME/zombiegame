using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvas : MonoBehaviour
{
    public float moveSpeed;
    public GameObject gun1;

    //키에따름 플레이어의 이동을 담은 script.

    // Start is called before the first frame update
    void Start()
    {
        
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
        transform.Translate(new Vector2(inputX, inputY) * Time.deltaTime * moveSpeed);
        

    }
    void selectGun()//누르는 키에따라 총이 활성화됐다가말았다가함 . (총기교환 개념을 위해 넣음)
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
