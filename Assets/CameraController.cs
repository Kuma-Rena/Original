using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; 
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = Camera.main.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = player.transform.position;
        if (cameraPos.x <= -8)
        {
                cameraPos.x = -8;
        }
        if (cameraPos.x >= 8)
        {
            cameraPos.x = 8;
        }
        cameraPos.z = -10; 
        Camera.main.gameObject.transform.position = cameraPos;
    }
}
