using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    public float reloadingSpeed;
    public float maxAmmo;
    public float restAmmo;
    public float range;
    public float bulletSpeed = 5f;

    public GameObject bulletPrefab;
    private Transform muzzle; // �ѱ�

    public float fireCoolTime;// �� �� ��Ÿ��
    private float curtime = 0;// ��Ÿ���ٶ� ���� �ð��� ������ �ʿ�����

    private void Awake()
    {
        muzzle = transform.Find("Muzzle");
    }

    public override void attack()
    {
        fire();
    }

    private void Update()
    {
        curtime += Time.deltaTime;
    }

    public void fire()
    {
        if (curtime > fireCoolTime)
        {
            GameObject bullet = Instantiate(bulletPrefab, muzzle.position, gameObject.transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(muzzle.right * bulletSpeed, ForceMode2D.Impulse);
            curtime = 0;
        }
        
    }


}
