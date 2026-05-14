// https://www.youtube.com/watch?v=8PCNNro7Rt0&t=197s
// author: Valem Tutorials

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.InputSystem;



public class AnimateHandOnInput : MonoBehaviour

{

    public InputActionProperty PinchAnimatinAction;

    public InputActionProperty gripAnimationAction;

    public Animator handAnimator;



    // Start is called before the first frame update

    void Start()

    {



    }



    // Update is called once per frame

    void Update()

    {

        float triggerValue = PinchAnimatinAction.action.ReadValue<float>();

        handAnimator.SetFloat("Trigger", triggerValue);



        float gripvalue = gripAnimationAction.action.ReadValue<float>();

        handAnimator.SetFloat("Grip", gripvalue);

    }

}