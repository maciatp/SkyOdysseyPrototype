using UnityEngine;
using UnityEngine.InputSystem;


namespace ArcadeJets
{
   public class StickInput : MonoBehaviour
   {

         InputControls MasterControls;

      [Tooltip("When true, pulls input from the player.")]
      public bool isPlayer = false;
      public bool isThrottleUpButtonPressed = false;
      public bool isThrottleDownButtonPressed = false;

      [SerializeField]
      private Vector3 stickInput;
      [SerializeField]
      private float throttle;
       float targetThrottle;

      [SerializeField] HeadsUpDisplay _HUD;

      public float Pitch
      {
         get { return stickInput.x; }
         set { stickInput.x = value; }
      }
      public float Roll
      {
         get { return stickInput.z; }
         set { stickInput.z = value; }
      }
      public float Yaw
      {
         get { return stickInput.y; }
         set { stickInput.y = value; }
      }
      /// <summary>
      /// Pitch, Yaw, and Roll represented as a Vector3, in that order.
      /// </summary>
      public Vector3 Combined
      {
         get { return stickInput; }
         set { stickInput = value; }
      }

      [SerializeField]
      public float Throttle
      {
         get { return throttle; }
         set { throttle = value; }
      }

      // Both of these are here only in case this package is imported as an asset.
      // These controls must be defined manually in the input manager upon import.
      private bool yawDefined = false;
      private bool throttleDefined = false;

        public const float ThrottleNeutral = 0.33f;
        public const float ThrottleMin = 0.0f;  //0.1f original
        [SerializeField] float ThrottleMax = 1f;
      [SerializeField] float ThrottleSpeed = 2f;

        [SerializeField] JetMovement _jetMovement;
       



      private void Awake()
      {
         try
         {
            Input.GetAxis("Yaw");
            yawDefined = true;
         }
         catch (System.ArgumentException e)
         {
            Debug.LogWarning(e);
            Debug.LogWarning(name + ": \"Yaw\" axis not defined in Input Manager. Rudder will not work!");
         }

         try
         {
            Input.GetButton("ThrottleUp");
            Input.GetButton("ThrottleDown");
            throttleDefined = true;
         }
         catch (System.ArgumentException e)
         {
            Debug.LogWarning(e);
            Debug.LogWarning(name + ": \"ThrottleUp\" or \"ThrottleDown\" buttons not defined in Input Manager. Throttle control will not work!");
         }
      }

        //private void Start()
        //{
        //    throttle = 0;
        //}

        private void Update()
        {
        if (isPlayer)
        {
        //Pitch = Input.GetAxis("Vertical");            
        //Roll = -Input.GetAxis("Horizontal");

        // If this project is imported 
        if (yawDefined)
            //Yaw = Input.GetAxis("Yaw");

            // Throttle works using buttons rather than an axis. When the throttle up is held,
            // the throttle moves towards to a max value. When throttle down is held, it goes
            // to an idle setting. When nothing is pressed, it returns to a neutral value.
            if (throttleDefined)
            {
                        
                        targetThrottle = throttle;
                       if(isThrottleUpButtonPressed)
                        {
                            targetThrottle = ThrottleMax;
                        }
                       else if(isThrottleDownButtonPressed)
                        {
                            targetThrottle = ThrottleMin;
                        }


                        //if (Input.GetButton("ThrottleUp"))
                        //    targetThrottle = ThrottleMax;
                        //else if (Input.GetButton("ThrottleDown"))
                        //    targetThrottle = ThrottleMin;

                        throttle = Mathf.MoveTowards(throttle, targetThrottle, ThrottleSpeed * Time.deltaTime);
                    }


            }





      }


        void OnStickInputXY(InputValue joystickValue)
        {
            Pitch = joystickValue.Get<Vector2>().y;
            Roll = joystickValue.Get<Vector2>().x;
        }

        void OnYaw(InputValue axisValue)
        {
            Yaw = axisValue.Get<float>();
            
        }


        //void OnThrottle(InputValue axisValue)
        //{


        //    if(axisValue.Get<float>() < 0)
        //    {
        //        targetThrottle = ThrottleMin; 

        //    }
        //    else
        //    {
        //        targetThrottle = ThrottleMax;
        //    }



        //    //throttle = Mathf.MoveTowards(throttle, targetThrottle, ThrottleSpeed * Time.deltaTime);
        //}


        void OnThrottleUp(InputValue inputValue)
        {
            if(inputValue.isPressed)
            {
                isThrottleUpButtonPressed = true;
            }
            else
            {
                isThrottleUpButtonPressed = false;
            }

            //targetThrottle = ThrottleMax;
            //throttle = Mathf.MoveTowards(throttle, targetThrottle, ThrottleSpeed * Time.deltaTime);
        }

        void OnThrottleDown(InputValue inputValue)
        {
            if (inputValue.isPressed)
            {
                isThrottleDownButtonPressed = true;
            }
            else
            {
                isThrottleDownButtonPressed = false;
            }
            //targetThrottle = ThrottleMin;
            //throttle = Mathf.MoveTowards(throttle, targetThrottle, ThrottleSpeed * Time.deltaTime);
        }

        void OnAerobrake(InputValue buttonValue)
        {
            if(buttonValue.isPressed)
            {
                //DRAG *2
                GetComponent<JetMovement>().Brake();
                print("BRAKE");
                _HUD.ActivateAeroBrakesText();
                
            }
            else if(!buttonValue.isPressed)
            {
                //DRAG NORMAL
                GetComponent<JetMovement>().UnBrake();
                print("NO BRAKE");
                _HUD.DeactivateAeroBrakesText();
            }
        }


        void OnReset(InputValue buttonValue)
        {
            Vector3 startPos =  GameObject.Find("PlaneStartPosition").transform.position;

            transform.position = startPos;
            transform.rotation = GameObject.Find("PlaneStartPosition").transform.rotation;
        }

        void OnChangeCam(InputValue buttonValue)
        {
            GetComponent<Camera_Follow_Controller>().ChangeCamera();
        }


        void OnGearChange(InputValue buttonValue)
        {
            _jetMovement.ChangeGear();
           
        }


        void OnThrottle(InputValue sliderValue)
        {
            throttle = sliderValue.Get<float>();
            Debug.Log(sliderValue.Get<float>());
        }

        //void OnCameraRotation(InputValue joystickValue)
        //{
        //    gameObject.GetComponent<Camera_Follow_Controller>().CurrentCamera.transform.Rotate(Vector3.up, joystickValue.Get<Vector2>().x);
        //    gameObject.GetComponent<Camera_Follow_Controller>().CurrentCamera.transform.Rotate(Vector3.left, joystickValue.Get<Vector2>().y);
        //}


    }
}