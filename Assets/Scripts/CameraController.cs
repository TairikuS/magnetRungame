using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    float initZPos;
    // Start is called before the first frame update
    void Start()
    {
        initZPos = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        ChasePlayer();
    }

    void ChasePlayer()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y,initZPos + player.transform.position.z);
    }
}
