using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    [Header("Gun Spec")]
    public float reloadingSpeed;
    public float range;
    public float bulletSpeed = 5f;
    public float fireRate;// �� �� ��Ÿ��

    [Header("Custom Part")]
    public Magazine magazine;
    public GameObject bulletPrefab;



    private Transform muzzle; // �ѱ�
    private float curtime = 0;// ��Ÿ���ٶ� ���� �ð��� ������ �ʿ�����    

    private void Awake()
    {
        muzzle = transform.Find("Muzzle");
    }

    public override void attack()
    {
        if (magazine.restAmmo > 0)
        {
            fire();
            magazine.restAmmo--;
        }
    }

    public void reloading()
    {
        magazine.restAmmo = magazine.maxAmmo;
    }

    private void Update()
    {
        curtime += Time.deltaTime;
    }

    public void fire()
    {
        if (curtime > fireRate)
        {
            GameObject bullet = Instantiate(bulletPrefab, muzzle.position, gameObject.transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(muzzle.right * bulletSpeed, ForceMode2D.Impulse);
            curtime = 0;
        }
        
    }


}
