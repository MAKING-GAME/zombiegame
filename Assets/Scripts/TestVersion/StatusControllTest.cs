using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusControllTest : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Status playerStatus = player.GetComponent<Status>();
            IHealth playerHP = playerStatus;
            playerHP.takeDamage(100);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Status playerStatus = player.GetComponent<Status>();
            IHealth playerHP = playerStatus;
            playerHP.healing(5);
        }
    }
}
