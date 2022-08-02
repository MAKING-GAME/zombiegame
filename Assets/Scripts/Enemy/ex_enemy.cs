using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///수정하기전 script 
public class ex_enemy : MonoBehaviour
{
    // Start is called before the first frame update
//    private Rigidbody2D rigid;
//     private int nextXMove;
//     private int nextYMove;
//     public Slider monster_hpbar;
//     public GameObject player;
//     public float limitdistance;
//     public float monster_speed;//Ŭ���� ���� �⺻ 50
//     private Vector2 unitdir;
//     private SpriteRenderer Monsterrenderer;
//     private Color originColor;
//     private bool flag=true;

//     // Start is called before the first frame update
//     void Start()
//     {
//         rigid = GetComponent<Rigidbody2D>();
//         monster_hpbar.value = monster_hpbar.maxValue;
//         Monsterrenderer = GetComponent<SpriteRenderer>();
//         originColor = Monsterrenderer.color;
//         StartCoroutine(monsternomallymove());

//     }

//     // Update is called once per frame
//     void Update()
//     {
//         float distance = Vector2.Distance(player.transform.position, transform.position);//몬스터에대해서 플레이어의 방향을 구함
//         //print(distance);
        
//         if (distance < limitdistance)
//         {
//             unitdir = (player.transform.position - transform.position).normalized;//방향을 정규화함
//             transform.Translate(unitdir / monster_speed);//정규화한방향에 몬스터스피드를 나눠서 정도를 조절후 방향을 변화함.
//             //밑줄도 같은 코드
//             //transform.position = new Vector2(transform.position.x + unitdir.x / monster_speed, transform.position.y + unitdir.y / monster_speed
//             flag=false;
//         }else
//         {
//             flag=true;
//         }
//         transform.position = Vector2.Lerp(transform.position,new Vector2(nextXMove,nextYMove), Time.deltaTime/3);
//         //지금생각해보니 방향백터만 랜덤으로 해서 바꿔도될듯;
//         //지금한번더생각해보니 걍 도는걸 rotate하게돌아서 foward하게 가도될듯;
        

//     }

//     //�Ѿ� ������ �Ǳ��°�
//     void OnTriggerEnter2D(Collider2D collider)//attact tag 에 부딪히면 hp가 줄어듬.
//     {
//         if (collider.gameObject.tag == "attack")
//         {

//             if (monster_hpbar.value <= 0)
//             {
//                 Destroy(gameObject);//hp가 0보다 작으면 죽음.
//             }
//             monster_hpbar.value = monster_hpbar.value - 1;
            
//             Monsterrenderer.color = Color.red;
//             StartCoroutine(colordelay());
//         }
//     }
//     IEnumerator colordelay()
//     {
//         yield return new WaitForSeconds(1.5f);
//         Monsterrenderer.color = originColor;
//     }

//     IEnumerator monsternomallymove(){
//         int tempX;
//         int tempY;
        
//         tempX= Random.Range(-3, 4); //-1이면 왼쪽, 0이면 멈추기,1이면 오른쪽으로이동
//         tempY= Random.Range(-3, 4); 
//         nextXMove =Mathf.RoundToInt(transform.position.x)+tempX;
//         nextYMove =Mathf.RoundToInt(transform.position.y)+tempY;
//         //print(tempX+" / "+ tempY);
//         if(0>nextXMove ||nextXMove >12){
//             nextXMove =-2*tempX;
//             //print("nextX"+nextXMove );
//         }
//         if(-6>nextYMove ||nextYMove >6){
//             nextYMove =-2*tempY;
//             //print("nextY"+nextYMove );
//         }
//         if(!flag){
//             yield return new WaitUntil(()=>flag ==true);
//             StartCoroutine(monsternomallymove());
//         }

        
//         //transform.position = Vector2.Lerp(transform.position,new Vector2(checkX,checkY), Time.deltaTime);
//         yield return new WaitForSeconds(10);
//         StartCoroutine(monsternomallymove());
//     }

}
