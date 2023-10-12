using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArcadeJets
{
    public class Propeller_Script : MonoBehaviour
    {
        [SerializeField] float rotatingSpeed;
        [SerializeField] JetMovement _jetMovement;
        [SerializeField] StickInput _stickInput;
        private void Update()
        {

            transform.Rotate(Vector3.up, rotatingSpeed * _jetMovement.ThrottleTrue * Time.deltaTime, Space.Self);

            //transform.rotation = Quaternion.Euler(0, transform.localRotation.x + rotatingSpeed * _jetMovement.ThrottleTrue, 0);
        }
    }
}