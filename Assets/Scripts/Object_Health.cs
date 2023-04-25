using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Health : MonoBehaviour
{
    public int maxHealth;
    private int currHealth; 
    public State object_State = State.ALIVE;
    public float sinkSpeed; 

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
            transform.Translate(new Vector3(0, -sinkDistance, 0));
        }
    }

    public void Hurt(int damage)
    {
        if (object_State == State.ALIVE)
        {
            //animator.SetTrigger("Hurt");
            currHealth -= damage; 
            if (currHealth <= 0)
            {
                Die(); 
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
    }

    public void StartSinking()
    {

    }
}
