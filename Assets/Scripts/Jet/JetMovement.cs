using UnityEngine;

namespace ArcadeJets
{
   [RequireComponent(typeof(Rigidbody))]
   public class JetMovement : MonoBehaviour
   {
        [SerializeField] bool isGearDown = false;
        [SerializeField] bool isBraking = false;
        public bool IsGearDown
        {
            get { return isGearDown; }
            set { isGearDown = value; }
        }
        public bool IsBraking
        {
            get { return isBraking; }
            set { isBraking = value; }
        }

      [Tooltip("Controller for the jet.")]
      public StickInput input;

        [Header("X:Pitch / Y:Yaw / Z:Roll")]
      [Tooltip("How powerfully the plane can maneuver in each axis.\n\nX: Pitch\nY: Yaw\nZ: Roll")]
      public Vector3 turnTorques = new Vector3(60.0f, 10.0f, 90.0f);
      [Tooltip("Torque used by the magic banking force that rotates the plane when the plane is banked.")]
      public float bankTorque = 5.0f;
      [Tooltip("Power of the engine at max throttle.")]
      public float maxThrust = 3000.0f;
      [Tooltip("How quickly the jet can accelerate and decelerate.")]
      public float acceleration = 10.0f;
      [Tooltip("How quickly the jet will brake when the throttle goes below neutral.")]
      public float brakeDrag = 5.0f;
      [SerializeField] float brakeDragMultiplier = 2f;

        [Tooltip("How powerfull are this plane's aerobrakes.")]
        [SerializeField] float aerobrakesPower = 0.7f;
        [Tooltip("Power Loose when going up aggressively")]
        [SerializeField] float powerLoseRate = 0.001f;
        [Tooltip("How much velocity is affected when Gear Down.")]
        [SerializeField] float gearDragPower = 0.8f;

        public float originalBrakeDrag;
      public float originalMaxThrust;
      public float originalAcceleration;


        [SerializeField] Animator planeAnimator; //en el inspector. para el tren de aterrizaje
       
        private Rigidbody rigid;

      [SerializeField] float throttleTrue = StickInput.ThrottleNeutral;
        public float ThrottleTrue
        {
            get { return throttleTrue; }
        }

      // Heavy things often require big numbers. It's nice to keep this multiplier on the
      // same scale as your mass to keep numbers small and manageable. For example, if your
      // game has mass in the hundreds, then use 100. If thousands, then 1000, etc.
      private const float FORCE_MULT = 100.0f;

      public Rigidbody Rigidbody { get { return rigid; } }
      public StickInput StickInput { get { return input; } }

      private void Awake()
      {
         rigid = GetComponent<Rigidbody>();
            originalBrakeDrag = brakeDrag;
            originalMaxThrust = maxThrust;
            originalAcceleration = acceleration;
      }

      private void Start()
      {
         if (input == null)
            Debug.LogWarning(name + ": JetMovement has no input assigned!");

         // Making the center of mass the object's pivot makes its flight behavior much more
         // predictable and less reliant on the layout of its colliders.
         rigid.centerOfMass = Vector3.zero;

            // While I haven't done it here, you can also use Rigidbody.inertiaTensor to do the
            // same but for rotations. Without it, the forces required to rotate on each axis vary
            // depending on the shape of the colliders.
             rigid.inertiaTensor = Vector3.one * rigid.mass * 5.0f;

            //SET ENGINE STOPPED
            throttleTrue = 0;

            if(IsGearDown)
            {
                maxThrust = originalMaxThrust * gearDragPower;
            }
            
      }

      private void FixedUpdate()
      {
         // When the throttle goes below neutral, apply increased acceleration to slow down faster.
         float throttleTarget = GetTargetThrottle();
            float brakePower = brakeDrag;// * Mathf.InverseLerp(StickInput.ThrottleNeutral, StickInput.ThrottleMin, throttleTarget);
         float brakeAccel = brakeDrag * brakePower;



         // Throttle has to move slowly so that the plane still accelerates slowly using high
         // drag physics. Without them, the plane would change speed almost instantly.
         throttleTrue = Mathf.MoveTowards(throttleTrue, throttleTarget, ((acceleration + brakeAccel) / FORCE_MULT) * Time.deltaTime);
           
            //para que pierda potencia al ir hacia arriba??
            //throttleTrue -= transform.forward.y * Time.fixedDeltaTime * powerLoseRate;
           
            
            
            // Apply forces to the plane.
            rigid.AddRelativeForce(Vector3.forward * maxThrust * throttleTrue * FORCE_MULT, ForceMode.Force);
         rigid.AddRelativeTorque(MultiplyByComponent(GetStickInput(), turnTorques) * FORCE_MULT, ForceMode.Force);

         // Apply magic forces when the plane is banked because it feels good. The principle
         // is that the plane rotates in the direction you're banked. The more banked you are
         // (up to a max of 90 degrees) the more it magically turns in that direction.

         // This is a weird vector trick where I use the Y value of the plane's right to
         // determine how banked it is. A value of -1/1 implies the plane is flying sideways
         // It also automatically takes care of cases where the plane is flying straight up
         // or down because in those situations your right would have negligible Y value.
         float bankFactor = -transform.right.y;
         rigid.AddRelativeTorque(Vector3.up * bankFactor * bankTorque * FORCE_MULT, ForceMode.Force);
      }

      private Vector3 GetStickInput()
      {
         if (input != null)
            return input.Combined;
         else
            return Vector3.zero;
      }

      public float GetTargetThrottle()
      {
            if (input != null)
            {
                return input.Throttle;

            }
            else
                return StickInput.ThrottleNeutral;
                
      }

      private Vector3 MultiplyByComponent(Vector3 a, Vector3 b)
      {
         Vector3 retVec = a;
         retVec.x *= b.x;
         retVec.y *= b.y;
         retVec.z *= b.z;
         return retVec;
      }

        public void Brake()
        {
            IsBraking = true;

            brakeDrag = originalBrakeDrag * brakeDragMultiplier;
           
            //Le quito poder al motor y bajo potencia, para que baje velocidad límite  y vaya subiendo progresivamente
            if(!IsGearDown)
            {
                maxThrust = originalMaxThrust * aerobrakesPower;

            }
            else
            {
                maxThrust = (originalMaxThrust * gearDragPower) * aerobrakesPower;
            }
            throttleTrue *= aerobrakesPower;
        }
        public void UnBrake()
        {
            IsBraking = false;
            brakeDrag = originalBrakeDrag;
           
            //sólo recupero el thrust, el throttleTrue irá aumentando con el tiempo
            if(IsGearDown)
            {
                maxThrust = originalMaxThrust * gearDragPower;
            }
            else
            {

                maxThrust = originalMaxThrust ;
            }
            
        }

        public void ChangeGear()
        {
            if(IsGearDown)
            {
                GearUp();
            }
            else
            {
                GearDown();
            }
        }

        public void GearUp()
        {
            IsGearDown = false;
            if(!IsBraking)
            {
                maxThrust = originalMaxThrust;

            }
            else
            {
                maxThrust = originalMaxThrust * aerobrakesPower;
            }
            //ACTIVATE ANIM
            if(!planeAnimator.enabled)
            {

                planeAnimator.enabled = true;
            }
            else
            {
            planeAnimator.SetTrigger("ChangeGear");

            }
        }
        public void GearDown()
        {
            IsGearDown = true;
            //ACTIVATE ANIM
            if(!IsBraking)
            {
                maxThrust = originalMaxThrust * gearDragPower;

            }
            else
            {
                maxThrust = (originalMaxThrust * aerobrakesPower)*gearDragPower;
            }
            planeAnimator.SetTrigger("ChangeGear");
        }

   }
}