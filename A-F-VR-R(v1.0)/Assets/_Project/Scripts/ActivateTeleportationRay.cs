// https://www.youtube.com/watch?v=0xt6dACM_1I
// author: Valem Tutorials
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;



public class ActivateTeleportationRay : MonoBehaviour

{
    public GameObject rightTeleportation;
    //public GameObject leftTeleportation;
    public InputActionProperty rightActivate;
    //public InputActionProperty leftActivate;

    // Update is called once per frame
    void Update()
    {
        rightTeleportation.SetActive(rightActivate.action.ReadValue<float>() > 0.1f);
        //leftTeleportation.SetActive(leftActivate.action.ReadValue<float>() > 0.1f);
    }

}