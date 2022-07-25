using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun1 : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletpos;//총알 시작점
    public float gun_cooltime;// 총 쏠때 쿨타임
    private float curtime;// 쿨탕님줄때 현재 시간의 변수가 필요햇음
    public GameObject gunPosition;//gun의 회전 방향을 받아오기위함

    public float bulletForce =20f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        curtime += Time.deltaTime;
        if (curtime > gun_cooltime) { 
            if (Input.GetKey(KeyCode.Q))
            {
                //누를때마다 총알이 생성되고 힘을 줘서 총알 날라가게함
                GameObject madebullet = Instantiate(bullet, bulletpos.position, gunPosition.transform.rotation);
                Rigidbody2D rb = madebullet.GetComponent<Rigidbody2D>();
                rb.AddForce(bulletpos.right*bulletForce,ForceMode2D.Impulse);
                
                curtime = 0;
            }
        }
 
    }
}
