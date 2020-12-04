using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //Speeds
    float horSpeed = 7f;
    float rotSpeed = 200f;

    // Horizontal boundary
    float shipBounRadX = 1.5f;


    // Vertical boundary
    //float shipBounRadY = 4.3f;

    // Vertical speed
    //float verSpeed = 3f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     
        // Z axis rotation
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        
        // X axis movement
        Vector3 posx = transform.position;
        posx.x += Input.GetAxis("Horizontal") * horSpeed * Time.deltaTime;

        // Horizontal screen boundaries
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        if (posx.x + shipBounRadX > widthOrtho)
        {
            posx.x = widthOrtho - shipBounRadX;
        }
        if (posx.x - shipBounRadX < -widthOrtho)
        {
            posx.x = -widthOrtho + shipBounRadX;
        }
        transform.position = posx;


        //Vertical component in case we need it 
        /*
        // Y axis movement
        Vector3 posy = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * verSpeed * Time.deltaTime, 0);
        posy += rot * velocity;

        // Vertical screen boundaries 
        if (posy.y + shipBounRadY > Camera.main.orthographicSize)
        {
            posy.y = Camera.main.orthographicSize - shipBounRadY;
        }
        if (posy.y - shipBounRadY < -Camera.main.orthographicSize)
        {
            posy.y = -Camera.main.orthographicSize + shipBounRadY;
        }
        transform.position = posy;
        */

    }
}
