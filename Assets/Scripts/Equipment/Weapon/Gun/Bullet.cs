using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 총알이 일정길이를 가면 destroy 됨.
// 총알이 enemy의 태그를 가진 오브젝트에 도달해도 destroy
public class Bullet : MonoBehaviour
{
    public float length;
    public float speed;

    // Start is called before the first frame update
    void Awake()
    {
        Invoke("DestroyBullet", length);
    }


    void DestroyBullet()
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "enemy")
        {
            DestroyBullet();
        }
    }
    
    
}
