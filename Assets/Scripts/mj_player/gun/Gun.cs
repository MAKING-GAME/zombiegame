using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;

    Transform muzzle;
    Transform RotatingPoint;

    [SerializeField] 
    private float fireCoolTime;// 총 쏠때 쿨타임
    private float bulletSpeed = 20f;

    private float curtime;// 쿨타임줄때 현재 시간의 변수가 필요햇음
    void Awake()
    {
        muzzle = transform.Find("Muzzle");
        muzzle = muzzle.GetComponent<Transform>();

        RotatingPoint = transform.Find("RotatingPoint");
        RotatingPoint = RotatingPoint.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        curtime += Time.deltaTime;
    }

    public void gunRotating(Vector2 mousePos)
    {
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        float angle = Mathf.Atan2(mousePos.y - muzzle.position.y, mousePos.x - muzzle.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);//마우스방향에따라 총의 방향이 rotate
    }

    public void fire()
    {
        if (curtime > fireCoolTime)
        {
            createBullet();
            curtime = 0;
        }
    }
    void createBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, muzzle.position, RotatingPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(muzzle.right * bulletSpeed, ForceMode2D.Impulse); ;
    }
}
