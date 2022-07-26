using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class gunRotation : MonoBehaviour
{
    [SerializeField] private Transform muzzlePos;
    private float mouseangle;
    private Transform target;
    private Vector2 mouse;
    private Vector2 mouseposition;
    // Start is called before the first frame update
    void Start()
    {
        target = muzzlePos.GetComponent<Transform>();
    }

    void gunRotating()
    {

    }

    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseposition = new Vector2(mouse.x - target.position.x, mouse.y - target.position.y);
        mouseangle = Mathf.Atan2(mouse.y - target.position.y, mouse.x - target.position.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0f, 0f, mouseangle);//마우스방향에따라 총의 방향이 rotate
    }
}
