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
    private Transform muzzle; // �ѱ�

    private float fireCoolTime;// �� �� ��Ÿ��
    private float curtime = 0;// ��Ÿ���ٶ� ���� �ð��� ������ �ʿ�����

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
