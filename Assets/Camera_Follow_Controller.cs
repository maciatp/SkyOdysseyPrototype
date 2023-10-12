using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow_Controller : MonoBehaviour
{

    [SerializeField] Camera currentCamera;
    [SerializeField] Camera[] cameras;
    [SerializeField] List<Camera> CamerasList = new List<Camera>();

    [SerializeField] Camera cameraFarAway;
    [SerializeField] Camera cameraFollowing;
    [SerializeField] Camera cameraOnBoard;
    [SerializeField] Camera cameraCabin;

    [SerializeField] float forwardDistanceWhenMovingCam = 25f;
    [SerializeField] float Updistance = 5f;
    [SerializeField] float forwardDistanceWhenLookingAt = 40f;
    [SerializeField] float bias = 0.98f;

    public Camera CurrentCamera
    {
        get { return currentCamera; }
        set { currentCamera = value; }
    }

    private void Awake()
    {
        CurrentCamera = cameras[0];

        //Camera_ = Camera.main;
        cameraFarAway = GameObject.Find("CameraFar").GetComponent<Camera>();
        cameraOnBoard = gameObject.transform.Find("CameraOnBoard").GetComponent<Camera>();
        cameraFollowing = gameObject.transform.Find("CameraFollowing").GetComponent<Camera>();

    }

    private void FixedUpdate()
    {
        if(CurrentCamera == cameraFarAway)
        {
            //MOVE CAM -> No need to be player's Child
            Vector3 moveCamTo = transform.position - transform.forward * forwardDistanceWhenMovingCam + Vector3.up * Updistance;

            //move when moved more than 2%
            currentCamera.transform.position = currentCamera.transform.position * bias + moveCamTo * (1.0f - bias);

            //LOOK AT PLANE + FORWARD DISTANCE
            currentCamera.transform.LookAt(transform.position + transform.forward * forwardDistanceWhenMovingCam);
        }
    }

    public void ChangeCamera()
    {


        //CurrentCamera = CamerasList



        switch (CurrentCamera.name)
        {

            case "CameraFar":
                cameraFollowing.enabled = true;
                CurrentCamera = cameraFollowing;
                cameraFarAway.enabled = false;
                cameraOnBoard.enabled = false;
                cameraCabin.enabled = false;

                break;

            case "CameraFollowing":
                cameraOnBoard.enabled = true;
                CurrentCamera = cameraOnBoard;
                cameraFarAway.enabled = false;
                cameraFollowing.enabled = false;
                cameraCabin.enabled = false;

                break;

            case "CameraOnBoard":
                cameraCabin.enabled = true;
                CurrentCamera = cameraCabin;
                cameraFarAway.enabled = false;
                cameraFollowing.enabled = false;
                cameraOnBoard.enabled = false;

                break;

            case "CameraCabin":
                cameraFarAway.enabled = true;
                CurrentCamera = cameraFarAway;
                cameraCabin.enabled = false;
                cameraOnBoard.enabled = false;
                cameraFollowing.enabled = false;

                break;


        }



        //if (CurrentCamera == cameraFarAway)
        //{
        //    cameraFollowing.enabled = true;
        //    CurrentCamera = cameraFollowing;
        //    cameraFarAway.enabled = false;
        //    cameraOnBoard.enabled = false;
        //}
        //else if (CurrentCamera == cameraFollowing)
        //{
        //    cameraOnBoard.enabled = true;
        //    CurrentCamera = cameraOnBoard;
        //    cameraFarAway.enabled = false;
        //    cameraFollowing.enabled = false;
        //}
        //else if (CurrentCamera == cameraOnBoard)
        //{
        //    cameraFarAway.enabled = true;
        //    CurrentCamera = cameraFarAway;
        //    cameraOnBoard.enabled = false;
        //    cameraFollowing.enabled = false;
        //}
    }
}
