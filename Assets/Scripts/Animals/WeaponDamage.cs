using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    public GameObject weapon;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        Collider weapon_collider = weapon.AddComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
