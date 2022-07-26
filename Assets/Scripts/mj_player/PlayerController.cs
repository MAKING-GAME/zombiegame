using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Gun gun;

    private Transform gunRotatingPos;
    private Transform muzzlePos; //ÃÑ±¸

    public Slider player_hpbar;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        player_hpbar.value = player_hpbar.maxValue;
        player_hpbar.gameObject.SetActive(true);
    }

    void Update()
    {
        Move();
        if (Input.GetMouseButtonDown(0))
        {
            gun.fire();
        }
        gun.gunRotating(Input.mousePosition);
        
    }
    void Move()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector2(inputX, inputY) * Time.deltaTime * moveSpeed);
    }
}
