using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 총알이 일정길이를 가면 destroy 됨.
// 총알이 enemyd의 태그를 가진 오브젝트에 도달해도 destroy
public class bullet1 : MonoBehaviour
{
    public float speed;
    public float length;

    private Vector2 direction;
    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", length);
    }

    // Update is called once per frame
    void Update()
    {

       
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
