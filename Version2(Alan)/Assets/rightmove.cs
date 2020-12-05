using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightmove : MonoBehaviour
{

    public float speed = 3f;
    private Vector3 endPosition = new Vector3(1.44f, -0.85f, 0);
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, 69.26f);
        this.transform.position = new Vector3(.06f, 2.27f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != endPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);//moving wall in y direction
        }
        else
        {
            Destroy(gameObject);
        }

        transform.localScale = transform.localScale + new Vector3(1 * Time.deltaTime, 1 * Time.deltaTime, 0); //wall object increases in size as it moves


    }
}