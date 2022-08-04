using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon, RangedWeapon
{
    [Header("Gun Spec")]
    public float reloadingSpeed; //장전속도
    public float range; //사거리
    public float bulletSpeed = 5f; //탄속

    [Header("Custom Part")]
    public Magazine magazine; // 탄창
    public GameObject bulletPrefab; // 총알



    private Transform muzzle; // 총구
    private float curtime = 0;// 쿨타임줄때 현재 시간의 변수가 필요햇음    

    private void Awake()
    {
        muzzle = transform.Find("Muzzle"); //총구세팅(총 프리팹의 하위 오브젝트에 저장된 총구정보를 가저온다
    }

    public override void showInfo()
    {
        PlayerInterfaceController.PIController.changeAmmo(magazine.restAmmo, magazine.maxAmmo);
    }

    public override void attack()
    {
        if (magazine.restAmmo > 0) //탄창의 남은 총알이 1발 이상일 경우에만 사격 가능
        {
            fire();
            magazine.restAmmo--;
            PlayerInterfaceController.PIController.changeAmmo(magazine.restAmmo, magazine.maxAmmo);
        }
        else // 아니면 장전
        {
            reload();
        }
    }

    public void reload() // 장전메서드, 탄창의 총알을 최대로 채우고 변화한 탄창 정보를 UI에 표시
    {
        magazine.restAmmo = magazine.maxAmmo;
        PlayerInterfaceController.PIController.changeAmmo(magazine.restAmmo, magazine.maxAmmo);
    }

    private void Update()
    {
        curtime += Time.deltaTime;
    }

    public void fire() // 원거리 무기 발사 메서드를 오버라이드
    {
        if (curtime > attackSpeed) //연사속도가 반영된다
        {
            GameObject bullet = Instantiate(bulletPrefab, muzzle.position, gameObject.transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(muzzle.right * bulletSpeed, ForceMode2D.Impulse);
            curtime = 0;
        }
        
    }


}
