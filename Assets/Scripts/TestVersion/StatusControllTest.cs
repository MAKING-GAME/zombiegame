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
            PlayerStatus playerStatus = player.GetComponent<PlayerStatus>();
            IHealth playerHP = playerStatus;
            playerHP.takeDamage(100);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerStatus playerStatus = player.GetComponent<PlayerStatus>();
            IHealth playerHP = playerStatus;
            playerHP.healing(5);
        }
    }
}
