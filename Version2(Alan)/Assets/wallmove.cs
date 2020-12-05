using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmove : MonoBehaviour
{

    public float speed = 3f;
    private Vector3 endPosition = new Vector3(0, -1.63f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != endPosition)
        {
            transform.position=Vector3.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);//moving wall in y direction
        }
        else
        {
            Destroy(gameObject);
        }

        transform.localScale = transform.localScale + new Vector3(1 * Time.deltaTime, 1 * Time.deltaTime, 0); //wall object increases in size as it moves
    }
}
