using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monster : MonoBehaviour
{
    public Slider monster_hpbar;
    public GameObject player;
    private Vector2 unitdir;

    // Start is called before the first frame update
    void Start()
    {
        monster_hpbar.value = monster_hpbar.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);
        print(distance);
        unitdir = (player.transform.position - transform.position).normalized;
        print(unitdir.x + "//" + unitdir.y + "//" + unitdir);
        transform.Translate(unitdir/50);
        //transform.position = new Vector2(transform.position.x + unitdir.x * 10, transform.position.y + unitdir.y * 10);
        //10안에 들면 추격하자
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "attack")
        {
            if(monster_hpbar.value <= 0)
            {
                Destroy(gameObject);
            }
            monster_hpbar.value = monster_hpbar.value - 1;
        }
    }
}
