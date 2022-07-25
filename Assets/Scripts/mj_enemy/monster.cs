using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monster : MonoBehaviour
{
    public Slider monster_hpbar;
    public GameObject player;
    public float limitdistance;
    public float monster_speed;//Ŭ���� ���� �⺻ 50
    private Vector2 unitdir;
    private SpriteRenderer Monsterrenderer;
    private Color originColor;

    // Start is called before the first frame update
    void Start()
    {
        monster_hpbar.value = monster_hpbar.maxValue;
        Monsterrenderer = GetComponent<SpriteRenderer>();
        originColor = Monsterrenderer.color;

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);//몬스터에대해서 플레이어의 방향을 구함
        //print(distance);
        if (distance < limitdistance)
        {
            unitdir = (player.transform.position - transform.position).normalized;//방향을 정규화함
            transform.Translate(unitdir / monster_speed);//정규화한방향에 몬스터스피드를 나눠서 정도를 조절후 방향을 변화함.
            //밑줄도 같은 코드
            //transform.position = new Vector2(transform.position.x + unitdir.x / monster_speed, transform.position.y + unitdir.y / monster_speed

        }

    }

    //�Ѿ� ������ �Ǳ��°�
    void OnTriggerEnter2D(Collider2D collider)//attact tag 에 부딪히면 hp가 줄어듬.
    {
        if (collider.gameObject.tag == "attack")
        {

            if (monster_hpbar.value <= 0)
            {
                Destroy(gameObject);//hp가 0보다 작으면 죽음.
            }
            monster_hpbar.value = monster_hpbar.value - 1;
            
            Monsterrenderer.color = Color.red;
            StartCoroutine(colordelay());
        }
    }
    IEnumerator colordelay()
    {
        yield return new WaitForSeconds(1.5f);
        Monsterrenderer.color = originColor;
    }
}
