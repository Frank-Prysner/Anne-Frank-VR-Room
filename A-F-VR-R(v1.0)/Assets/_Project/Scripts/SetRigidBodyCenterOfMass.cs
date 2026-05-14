// https://www.youtube.com/watch?v=PE5aEHVWPyM&list=PLfv47SfzalO865Bd_-LO1ympECtWcw6cR&index=49&t=33s
// author: MikeNspired
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetRigidBodyCenterOfMass : MonoBehaviour
{

    [SerializeField] private XRGrabInteractable xrGrabInteractable;
    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private Vector3 newCenterOfMass;

    // Start is called before the first frame update
    void Start()
    {
        OnValidate();
        xrGrabInteractable.onSelectEntered.AddListener((X) => rigidBody.centerOfMass = newCenterOfMass);   
        xrGrabInteractable.onSelectExited.AddListener((X) => rigidBody.ResetCenterOfMass());
    }

    // Update is called once per frame
    private void OnValidate()
    {
        GetComponent<Rigidbody>().maxAngularVelocity = 20f;

        if (!xrGrabInteractable){
            xrGrabInteractable = GetComponent<XRGrabInteractable>();
        }
        if (!rigidBody){
            rigidBody = GetComponent<Rigidbody>();
        }
    }
}
