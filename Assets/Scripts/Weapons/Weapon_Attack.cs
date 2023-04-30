using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Attack : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;
    public GameObject weapon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    public void Attack()
    {
        Vector3 newRotation_1 = new Vector3(0f, 0f , 90f) + weapon.transform.eulerAngles;
        weapon.transform.eulerAngles = newRotation_1;

        source.PlayOneShot(clip);

        StartCoroutine(myWaitCoroutine());
    }

    IEnumerator myWaitCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        Vector3 newRotation_2 = new Vector3(0f, 0f, -90f) + weapon.transform.eulerAngles;
        weapon.transform.eulerAngles = newRotation_2;
    }
}
