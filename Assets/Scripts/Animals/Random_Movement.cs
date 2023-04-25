using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Movement: MonoBehaviour
{ 
    public GameObject animal;

    // x_dir and z_dir are both positions utilized in the creation of a new vector for object movement
    // from point a (original position) to point b (new vector that utilizes x_dir and z_dir)
    private int x_dir = 0;
    private int z_dir = 0;

    // The startMarker is the starting position (basically transform.position), position of origin
    // The endMarker is the final position in which the object will travel to from the startMarker
    private Vector3 startMarker;
    private Vector3 endMarker;

    // lerpTime is the time in which it takes an object to travel from point a to point b
    private float lerpTime = 15;

    private float currentLerpTime = 0;

    public float speed = 10f;

    private bool key = false;
    // Start is called before the first frame update
    void Start()
    {
        x_dir = Random_Distance(); 
        z_dir = Random_Distance();
        startMarker = animal.transform.position;
        endMarker = animal.transform.position + new Vector3(x_dir, 0f, z_dir); 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == endMarker)
        {
            animal.GetComponent<Animator>().enabled = false;
        }

        if (key == true)
        {
            currentLerpTime += Time.deltaTime; 
            if (currentLerpTime >= lerpTime) 
            {
                currentLerpTime = lerpTime;
            }
            float Perc = currentLerpTime * speed / lerpTime;
            animal.transform.position = Vector3.Lerp(startMarker, endMarker, Perc);
        }
    }
   
    // Random_Distance function picks a random number from -50 to 50, which will be used to set x_dir and z_dir for the addition of the 
    // original position and new vector utilizing x_dir and z_dir
    private int Random_Distance()
    {
        int random_number = Random.Range(-50, 50);
        return random_number;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            key = true;
            animal.GetComponent<Animator>().Play("run");
            Vector3 direction = endMarker - startMarker;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = rotation; 
        }
    }

    void OnTriggerExit(Collider other)
    {

    }

}
