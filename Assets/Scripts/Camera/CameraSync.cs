using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSync : MonoBehaviour
{
    private Camera camera;
    public Camera cameraToSync;

    void Awake()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        camera.fieldOfView = cameraToSync.fieldOfView;
        camera.transform.position = cameraToSync.transform.position;
        camera.transform.rotation = cameraToSync.transform.rotation;
    }
}
