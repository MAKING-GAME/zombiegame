using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    

    public Slider player_hpbar;
    public Image deadalert;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        player_hpbar.value = player_hpbar.maxValue;
        player_hpbar.gameObject.SetActive(true);
        deadalert.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("cbnd");
        if (collision.gameObject.tag == "enemy")
        {
            if (player_hpbar.value <= 0)
            {
                gameObject.SetActive(false);
                player_hpbar.gameObject.SetActive(false);
                deadalert.gameObject.SetActive(true);

            }
            player_hpbar.value = player_hpbar.value - 1;
        }
    }
}
