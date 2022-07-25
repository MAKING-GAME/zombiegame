using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
        

    public Slider player_hpbar;
    public Image deadalert;
    private float curtime;
    public float playerhp_cooltime;

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

 
    void OnCollisionEnter2D(Collision2D collision)//부딪힐때
    {
        //enemy테그의 오브젝트에 부딪히면 hp가 깍이고 0이하가 되면 사망.
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
    void OnCollisionStay2D(Collision2D collision)//부딪힘이 유지될때
    {
        curtime += Time.deltaTime;
        print("curtime :" + curtime);
        if (curtime > playerhp_cooltime)//유지될때 hp깍이는 쿨타임줌.
        {
            player_hpbar.value = player_hpbar.value - 1;
            if (player_hpbar.value <= 0)
            {
                gameObject.SetActive(false);
                player_hpbar.gameObject.SetActive(false);
                deadalert.gameObject.SetActive(true);

            }
            curtime = 0;
        }
    }
}
