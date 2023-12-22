using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    //[SerializeField]
    //private float moveSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position -= new Vector3(0, 10f, 0);
            if (transform.position.y < -10)
            {
                transform.position += new Vector3(0, 90f, 0);
            }
        }

        /*
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if (transform.position.y < -10)
        {
            transform.position += new Vector3(0, 90f, 0);
        }
        */
    }
    
}

    /*
    void Click()
    {
        Instantiate
    }
    */

