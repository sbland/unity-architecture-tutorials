using System.Collections;
using System.Collections.Generic;
using Valve.VR.InteractionSystem;
using UnityEngine;

public class VrSunControl : MonoBehaviour
{
    public LinearMapping linearMapping;
    public float tolerance = 1;
    public float currentAngle = 0;
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        float value = linearMapping.value;
        if (value == currentAngle) return;
        
        float amount = value - currentAngle;
        

        if (Mathf.Abs(amount) > tolerance)
        {
            transform.Rotate(amount* speed, 0, 0);
            // this.transform.eulerAngles = new Vector3(
            //     value * 180,
            //     this.transform.eulerAngles.y,
            //     this.transform.eulerAngles.z
            // );
            // currentAngle = value;
        } else {
            // Debug.Log(Mathf.Abs(value));
            // Debug.Log(Mathf.Abs(currentAngle));
            // Debug.Log(Mathf.Abs(value - currentAngle) - Mathf.Abs(currentAngle));
        }

    }
}
