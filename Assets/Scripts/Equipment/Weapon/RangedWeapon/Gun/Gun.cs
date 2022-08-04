using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon, RangedWeapon
{
    [Header("Gun Spec")]
    public float reloadingSpeed; //�����ӵ�
    public float range; //��Ÿ�
    public float bulletSpeed = 5f; //ź��

    [Header("Custom Part")]
    public Magazine magazine; // źâ
    public GameObject bulletPrefab; // �Ѿ�



    private Transform muzzle; // �ѱ�
    private float curtime = 0;// ��Ÿ���ٶ� ���� �ð��� ������ �ʿ�����    

    private void Awake()
    {
        muzzle = transform.Find("Muzzle"); //�ѱ�����(�� �������� ���� ������Ʈ�� ����� �ѱ������� �����´�
    }

    public override void showInfo()
    {
        PlayerInterfaceController.PIController.changeAmmo(magazine.restAmmo, magazine.maxAmmo);
    }

    public override void attack()
    {
        if (magazine.restAmmo > 0) //źâ�� ���� �Ѿ��� 1�� �̻��� ��쿡�� ��� ����
        {
            fire();
            magazine.restAmmo--;
            PlayerInterfaceController.PIController.changeAmmo(magazine.restAmmo, magazine.maxAmmo);
        }
        else // �ƴϸ� ����
        {
            reload();
        }
    }

    public void reload() // �����޼���, źâ�� �Ѿ��� �ִ�� ä��� ��ȭ�� źâ ������ UI�� ǥ��
    {
        magazine.restAmmo = magazine.maxAmmo;
        PlayerInterfaceController.PIController.changeAmmo(magazine.restAmmo, magazine.maxAmmo);
    }

    private void Update()
    {
        curtime += Time.deltaTime;
    }

    public void fire() // ���Ÿ� ���� �߻� �޼��带 �������̵�
    {
        if (curtime > attackSpeed) //����ӵ��� �ݿ��ȴ�
        {
            GameObject bullet = Instantiate(bulletPrefab, muzzle.position, gameObject.transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(muzzle.right * bulletSpeed, ForceMode2D.Impulse);
            curtime = 0;
        }
        
    }


}
