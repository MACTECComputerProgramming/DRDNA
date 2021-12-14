using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    //public GameObject player;
    public Transform player;
    private Vector3 offset = new Vector3(1, 10, 1);


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = player.transform.position + offset;

        transform.position = new Vector3(player.position.x + 6, 0, -10); // Camera follows the player but 6 to the right
    }
}
