using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInterfaceController : MonoBehaviour
{
    private static PlayerInterfaceController instance;
    public static PlayerInterfaceController PIController 
    { 
        get 
        { 
            if(instance == null)
            {
                return null;
            }
            return instance;
        } 
    }

    [SerializeField] Slider HPBar;

    [SerializeField] Text ammo;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void changeHPBar(float value)
    {
        HPBar.value = value;
    }

    public void changeAmmo(int restAmmo, int maxAmmo)
    {
        ammo.text = restAmmo.ToString() + "/" + maxAmmo.ToString();
    }

}
