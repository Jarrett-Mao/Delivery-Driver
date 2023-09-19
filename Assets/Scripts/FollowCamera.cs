using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //this things position (camera) should be the same as the car
    [SerializeField]
    GameObject carToFollow; 
    Vector3 offset = new Vector3(0, 0, -10); 

    void LateUpdate()
    {
        transform.position = carToFollow.transform.position + offset;         
    }
}
