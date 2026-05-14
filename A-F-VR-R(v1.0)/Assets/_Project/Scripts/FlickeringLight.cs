// https://www.youtube.com/watch?v=iCCFPOdUaNI
// author: Electronic Brain

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    public Light _Light;

    public float minTime;
    public float maxTime;
    public float timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        FlickerLight();
    }

    void FlickerLight(){
        if (timer > 0){
            timer -= Time.deltaTime;
        }
         
        if (timer <= 0){
            _Light.enabled = !_Light.enabled;
            timer = Random.Range(minTime,maxTime);
        }
    }
}
