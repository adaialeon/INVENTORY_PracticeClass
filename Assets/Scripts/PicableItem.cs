using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicableItem : MonoBehaviour
{
    public ScriptableWeapon weapon;
    
    SpriteRenderer sRenderer;

    void Start()
    {
        sRenderer = GetComponent <SpriteRenderer>();

        sRenderer.sprite = weapon.weaponSprite;
    }
}
