using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private bool activate;
    [SerializeField]private GameObject gameObject;

    private void Start()
    {
        activate = false;
        gameObject.SetActive(activate);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) { 
            activate = !activate;
            gameObject.SetActive(activate);
        }
    }
}
