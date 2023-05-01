using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Health : MonoBehaviour
{
    public int maxHealth;
    public int currHealth; 
    public State object_State = State.ALIVE;
    public float sinkSpeed;
    private int delay;

    public AudioSource source;
    public AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (object_State == State.ALIVE)
        {

        }
        else if (object_State == State.SINKING)
        {
            float sinkDistance = sinkSpeed * Time.deltaTime;
            transform.Translate(new Vector3(0, sinkDistance, 0));
        }
    }

    public void Hurt(int damage)
    {
        if (object_State == State.ALIVE)
        {
            currHealth -= damage;
            source.PlayOneShot(clip);
            if (currHealth <= 0)
            {
                object_State = State.DYING;
                Die();

                StartCoroutine(myWaitCoroutine());
                
            }
        }
        
    }

    public enum State
    {
        ALIVE, DYING, SINKING 
    }

    void Die()
    {
        print("Player Slayed The Beast");
        Vector3 newPosition = new Vector3(gameObject.transform.position.x, 3, gameObject.transform.position.z);
        Vector3 newRotation = new Vector3(0, 0, 180);
        gameObject.transform.eulerAngles = newRotation;
        gameObject.transform.localPosition = newPosition;
    }

    public void StartSinking()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Weapon") 
        {
            int weapon_damage = other.GetComponent<WeaponDamage>().damage;
            Hurt(weapon_damage);
        }
    }

    IEnumerator myWaitCoroutine()
    {
        yield return new WaitForSeconds(5f);
        object_State = State.SINKING;
    }
}
