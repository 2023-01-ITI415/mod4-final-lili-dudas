using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    //variables 
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Graphic");//error
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 back = -player.transform.forward;
        back.y = 0.5f; // this determines how high. Increase for higher view angle.
        transform.position = player.transform.position - back * distance;

        transform.forward = player.transform.position - transform.position;

        float inputX = Input.GetAxis("Mouse X")*mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y")*mouseSensitivity;

        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -99f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        player.Rotate(Vector3.up * inputX);
    }

}
