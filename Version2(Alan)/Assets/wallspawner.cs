using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallspawner : MonoBehaviour
{

    public GameObject wallcenter;
    public GameObject wallleft;
    public GameObject wallright;
    public float maxpos = 2.2f;
    float timer;
    public float delay = 1f;//how often wall is spawned

    // Start is called before the first frame update
    void Start()
    {
        timer = delay;
    }

    void center()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) //when timer is less than zero a wall is spawned
        {
            Vector3 centerpos = new Vector3(0f, transform.position.y, transform.position.z);
            Instantiate(wallcenter, centerpos, transform.rotation);
            timer = delay;
        }
    }

    void left()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) //when timer is less than zero a wall is spawned
        {
            Vector3 leftpos = new Vector3(-.05f, transform.position.y, transform.position.z);
            Instantiate(wallleft, leftpos, transform.rotation);
            timer = delay;
        }
    }

    void right()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) //when timer is less than zero a wall is spawned
        {
            Vector3 rightpos = new Vector3(-.05f, transform.position.y, transform.position.z);
            Instantiate(wallright, rightpos, transform.rotation);
            timer = delay;
        }
    }


    // Update is called once per frame
    void Update()
    {
        center();
        left();
        right();
    }
}
