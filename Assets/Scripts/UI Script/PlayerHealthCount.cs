using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthCount : MonoBehaviour
{

    public GameObject count;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int health_points = Player.GetComponent<Object_Health>().currHealth;
        count.GetComponent<UnityEngine.UI.Text>().text = "Health Points:" + health_points;
    }
}
