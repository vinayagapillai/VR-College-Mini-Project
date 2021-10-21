using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;

    public void TeleportPlayer()
    {
        StartCoroutine(waiter());
        
        //player.transform.GetChild(0).transform.rotation = Quaternion.identity;
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(1.5f);
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);

    }
}
