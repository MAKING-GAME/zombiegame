using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet1 : MonoBehaviour
{
    public float speed;
    public float length;


    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", length);
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.rotation.y == 0)
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(transform.right * -1 * speed * Time.deltaTime);
        }
       
    }
    void DestroyBullet()
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider != null)
        {
            DestroyBullet();
        }
    }
    
    
}
