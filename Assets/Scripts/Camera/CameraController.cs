using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour
{
    public float moveSpeed;
    public float zoomSpeed;
    public float minZoomDist;
    public float maxZoomDist;
    public Camera cam;
    private float mouseLastX = 0f;

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        Vector3 dir = this.transform.forward * zInput + this.cam.transform.right * xInput;
        transform.position += dir * moveSpeed * Time.deltaTime;
        if (!EventSystem.current.IsPointerOverGameObject()) {
            float scrollInput = Input.GetAxis("Mouse ScrollWheel");

            float dist = Vector3.Distance(transform.position, this.cam.transform.position);
            if (dist < minZoomDist && scrollInput > 0.0f)
            {
                return;
            }
            else if (dist > maxZoomDist && scrollInput < 0.0f)
            {
                return;
            }
            this.cam.transform.position += scrollInput * zoomSpeed * this.cam.transform.forward;
        }


        if (Input.GetButton("Fire2"))
        {
            float deltaX = Input.mousePosition.x - mouseLastX;
            this.transform.Rotate(0f, deltaX, 0f, Space.World);
        }
        mouseLastX = Input.mousePosition.x;
    }
}
