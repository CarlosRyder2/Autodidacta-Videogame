using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraInsideOutsideData : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0f;
    public string triggerColliderName = "BodyCollider";

    [Header("Data")]
    public VolvoCars.Data.CameraIsInsideCar cameraIsInsideCar;

    private void OnTriggerEnter(Collider other)
    {
        bool changeValue = false;

        if(other.name == triggerColliderName) {
            changeValue = true;
        }else if (other.transform.parent != null) {
            if(other.transform.parent.name == triggerColliderName) {
                changeValue = true;
            }
        }

        if (changeValue) {
            cameraIsInsideCar.Value = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        bool changeValue = false;

        if (other.name == triggerColliderName) {
            changeValue = true;
        } else if (other.transform.parent != null) {
            if (other.transform.parent.name == triggerColliderName) {
                changeValue = true;
            }
        }

        if (changeValue) {
            cameraIsInsideCar.Value = false;
        }
    }
    //void Update()
    //{
    //    float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
    //    float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;
    //    cameraVerticalRotation -= inputY;
    //    cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
    //    transform.localEulerAngles = Vector3.right * cameraVerticalRotation;
    //    player.Rotate(Vector3.up * inputX);
    //}

}
