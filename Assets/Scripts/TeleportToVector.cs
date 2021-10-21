using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToVector : MonoBehaviour
{
    public GameObject player;
    public Vector3 coords;

    public void TeleportPlayer()
    {
        coords.y = coords.y;
        StartCoroutine(waiter());
        //player.transform.GetChild(0).transform.rotation = Quaternion.identity;
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(1.5f);
        player.transform.position = coords;
    }

}
