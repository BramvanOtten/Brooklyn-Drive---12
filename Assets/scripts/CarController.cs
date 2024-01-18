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
<<<<<<< Updated upstream
        // Move();
=======
        Move();
        Steer();
        Brake();
>>>>>>> Stashed changes
    }

    void GetInputs()
    {
        moveInput = Input.GetAxis("Vertical");
    }

<<<<<<< Updated upstream
    // void Move()
    // {
    //     foreach(var wheel in wheels)
    //     {
    //         wheel.wheelCollider.motorTorque = moveInput * 600 * maxAcceleration * Time.deltaTime;
    //     }
    // }
=======
    void Move()
    {
        foreach(var wheel in wheels)
        {
            wheel.wheelCollider.motorTorque = moveInput * 600 * maxAcceleration * Time.deltaTime;
        }
    }

    void Steer()
    {
        foreach(var wheel in wheels)
        {
            if(wheel.axel == Axel.Front)
            {
                var _steerAngle = steerInput * turnSensitivity * maxSteerAngle;
                wheel.wheelCollider.steerAngle = Mathf.Lerp(wheel.wheelCollider.steerAngle, _steerAngle, 0.6f);
            }
        }
    }

    void Brake()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            foreach(var wheel in wheels)
            {
                wheel.wheelCollider.brakeTorque = 300 * breakAcceleration * Time.deltaTime;
            }
        }
        else
        {
            foreach(var wheel in wheels)
            {
                wheel.wheelCollider.brakeTorque = 0f;
            }
        }
    }
>>>>>>> Stashed changes
}
