using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowards : MonoBehaviour
{
    public float movementSpeed = 0.5f;
    public GameObject player;
    bool reached = false;
    Vector3 originalPos;
   
    void Start()
    {
        originalPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != player.transform.position && reached == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, movementSpeed);    
        }
        else
        {
            reached = true;
            transform.position = Vector3.MoveTowards(transform.position, originalPos, movementSpeed);

            if (transform.position == originalPos)
            {
                reached = false;
            }
        }


    }
}
