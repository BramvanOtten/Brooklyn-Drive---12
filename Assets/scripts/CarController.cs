using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CarController : MonoBehaviour
{
    public enum Axel
    {
        Front,
        Rear
    }
    
    [Serializable]
    public struct Wheel
    {
        public GameObject wheelModel;
        public WheelCollider wheelCollider;
        public Axel axel;
    }
    public float maxAcceleration = 90.0f;
    public float breakAcceleration = 50.0f;

    public List<Wheel> wheels;

    float moveInput;

    private Rigidbody carRb;

    void Start()
    {
        carRb = GetComponent<Rigidbody>();
    }

    void update()
    {
        GetInputs();
    }

    void Update()
    {
        // Move();
    }

    void GetInputs()
    {
        moveInput = Input.GetAxis("Vertical");
    }

    // void Move()
    // {
    //     foreach(var wheel in wheels)
    //     {
    //         wheel.wheelCollider.motorTorque = moveInput * 600 * maxAcceleration * Time.deltaTime;
    //     }
    // }
}
