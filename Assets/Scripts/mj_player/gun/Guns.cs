using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
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
        
    }
}
