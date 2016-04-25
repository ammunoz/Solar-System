using UnityEngine;
using System.Collections;

// template code provided in Game Development online course by Michigan State University
// edited by Alfonso Munoz

public class RotateAround : MonoBehaviour {

    public Transform target; // the object to rotate around
    public Vector3 axis; // axis on which object rotates
    public float speed; // the speed of rotation - degree of rotation per second
    public float speed_multiplier;

    void Start() {
        if (!target) target = this.gameObject.transform;
        if (axis.Equals(new Vector3(0, 0, 0))) axis = target.transform.up;
        if (speed_multiplier==0) speed_multiplier = 1;
    }

    // RotateAround takes three arguments, first is the Vector to rotate around
    // second is a vector that axis to rotate around
    // third is the degrees to rotate, in this case the speed per second
    void Update() {
        transform.RotateAround(target.transform.position, axis, -(speed*speed_multiplier) * Time.deltaTime);
    }

    public float SpeedMultiplier{
        set{ speed_multiplier = value; }
    }
}
