using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovt : MonoBehaviour
{ //
    public float cameraSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime,0,0);
        
    }
}
