using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    [Header("Gun Spec")]
    public float reloadingSpeed;
    public float range;
    public float bulletSpeed = 5f;

    [Header("Custom Part")]
    public Magazine magazine;
    public GameObject bulletPrefab;



    private Transform muzzle; // 총구
    private float curtime = 0;// 쿨타임줄때 현재 시간의 변수가 필요햇음    

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
            PlayerInterfaceController.PIController.changeAmmo(magazine.restAmmo, magazine.maxAmmo);
        }
        else
        {
            reloading();
        }
    }

    public void reloading()
    {
        magazine.restAmmo = magazine.maxAmmo;
        PlayerInterfaceController.PIController.changeAmmo(magazine.restAmmo, magazine.maxAmmo);
    }

    private void Update()
    {
        curtime += Time.deltaTime;
    }

    public void fire()
    {
        if (curtime > attackSpeed)
        {
            GameObject bullet = Instantiate(bulletPrefab, muzzle.position, gameObject.transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(muzzle.right * bulletSpeed, ForceMode2D.Impulse);
            curtime = 0;
        }
        
    }


}
