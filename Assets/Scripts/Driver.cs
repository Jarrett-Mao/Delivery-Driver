using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float steerSpeed = 0.1f;
    [SerializeField]
    float moveSpeed = 0.01f;

    //control variables
    float steerAmount;
    float moveAmount;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime; 
        moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        steerAmount = steerAmount * -1;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0f, moveAmount, 0f);
    }
}
