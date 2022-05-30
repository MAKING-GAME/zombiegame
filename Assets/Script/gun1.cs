using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun1 : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletpos;
    public float cooltime;
    private float curtime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.rotation.y == 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        curtime += Time.deltaTime;
        if (curtime > cooltime) { 
            if (Input.GetKey(KeyCode.Z))
            {
                Instantiate(bullet, bulletpos.position, transform.rotation);
                curtime = 0;
            }
        }
 
    }
}
