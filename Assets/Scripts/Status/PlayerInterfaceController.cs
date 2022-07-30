using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInterfaceController : MonoBehaviour
{
    [SerializeField]
    private Slider HPBar;

    public void changeHPBar(float value)
    {
        HPBar.value = value;
    }
    
}
