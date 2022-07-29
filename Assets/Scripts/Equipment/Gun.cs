using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon, IGunFire
{
    public float reloadingSpeed;
    public float maxAmmo;
    public float restAmmo;
    public float range;

    public GameObject bulletPrefab;
    private Transform muzzle; // ÃÑ±¸

    private float fireCoolTime;// ÃÑ ½ò¶§ ÄðÅ¸ÀÓ
    private float curtime = 0;// ÄðÅ¸ÀÓÁÙ¶§ ÇöÀç ½Ã°£ÀÇ º¯¼ö°¡ ÇÊ¿äÇÞÀ½

    private void Start()
    {
        muzzle = bulletPrefab.transform.Find("muzzle");
    }

    public override void attack()
    {
        fire();
    }

    private void Update()
    {
        curtime += Time.deltaTime;
    }

    private void fire()
    {
        if (curtime > fireCoolTime)
        {
            GameObject bullet = Instantiate(bulletPrefab, muzzle.position, transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(muzzle.right, ForceMode2D.Impulse);
            curtime = 0;
        }
        
    }


}
