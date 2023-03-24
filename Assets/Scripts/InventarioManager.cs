using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioManager : MonoBehaviour
{
    public static InventarioManager instance;
    public ScriptableWeapon[] weapons;
    public Text[] weaponsNames;
    public Image[] weaponSprite;

    void Awake()
    {
        instance = this;
    }

    public void AddWeapon (ScriptableWeapon weapon)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons [i] == null)
            {
                weapons [i] = weapon;
                weaponsNames [i].text = weapon.weaponName;
                weaponSprite[i].sprite = weapon.weaponSprite;

                return;
            }
        }
    }
}
    

