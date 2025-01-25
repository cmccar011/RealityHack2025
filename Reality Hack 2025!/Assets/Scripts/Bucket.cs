using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    bool held;
    
    // Start is called before the first frame update
    void Start()
    {
        held = false;   
    }

    // Update is called once per frame
    void Update()
    {
        held = IsHolding();
        if (held)
        {
            Vector3 controllerVelocity = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch);
            Quaternion controllerRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);
            float speed = controllerVelocity.magnitude;
            bool isGoingForward = Vector3.Dot(controllerVelocity.normalized, controllerRotation * Vector3.forward) > 0;

            if (speed > 1.5f && isGoingForward)
            {
                Vector3 controllerPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
                ActivateWater();
            }
        }    
    }

    public void ActivateWater()
    {
        //CORY FILL IN THIS CODE
    }

    public static bool IsHolding()
    {
        Vector3 controllerPos = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);



        return false;
    }



}
