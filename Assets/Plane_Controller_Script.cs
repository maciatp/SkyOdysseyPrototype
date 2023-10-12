using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Controller_Script : MonoBehaviour
{
    [SerializeField] float speed = 90;
    [SerializeField] float rotationSpeed = 0.2f;

    private void Update()
    {



        transform.position += transform.forward * Time.deltaTime * speed;

        speed -= transform.forward.y * Time.deltaTime* 50f;

        if(speed < 10)
        {
            speed = 10;
        }
        if(speed > 120)
        {
            speed = 120;
        }
        
        transform.Rotate(Input.GetAxis("Vertical") * rotationSpeed, 0.0f, -Input.GetAxis("Horizontal") * rotationSpeed);



        float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);

        if(terrainHeightWhereWeAre > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,
                                              terrainHeightWhereWeAre,
                                              transform.position.z);
        }
    }

}
