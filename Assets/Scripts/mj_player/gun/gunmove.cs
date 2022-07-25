using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//gun이 마우스의 포인트 방향에 따라 이동
//전체 player담는 PlayerCanvas도 마우스 방향에 따라 좌우 반전됨.
public class gunmove : MonoBehaviour
{
    private float mouseangle;
    private Vector2 target;
    private Vector2 mouse;
    private Vector2 mouseposition;
    public GameObject PlayerCanvas;//player전체 담는 오브젝트
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseposition = new Vector2(mouse.x - target.x, mouse.y - target.y);
        mouseangle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        //print(PlayerCanvas.transform.localScale.x);
        if (mouseangle < 90 && mouseangle > -90)
        {
            PlayerCanvas.transform.localScale=new Vector2(0.05875f, 0.06405f);//좌우반전
            gameObject.transform.localScale=new Vector2(1, 1);//총도 반전
            

            
        }
        if (mouseangle > 90 || mouseangle < -90)
        {
            PlayerCanvas.transform.localScale=new Vector2(-0.05875f, 0.06405f);//좌우반전
            gameObject.transform.localScale=new Vector2(-1, -1);//총도 반전
        }
        this.transform.rotation = Quaternion.Euler(0f, 0f, mouseangle);//마우스방향에따라 총의 방향이 rotate
    }
}
