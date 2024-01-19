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

    //de max values invoeren van de auto
    public float maxAcceleration = 90.0f;
    public float breakAcceleration = 50.0f;

    public float turnSensitivity = 1.0f;
    public float maxSteerAngle = 30f;

    public Vector3 _centerOfMass;

    //lijst voor de wielen zodat je ze individueel kan invoeren en gebruiken
    public List<Wheel> wheels;

    float moveInput;
    float steerInput;

    private Rigidbody carRb;

    void Start()
    {
        carRb = GetComponent<Rigidbody>();
        carRb.centerOfMass = _centerOfMass;
    }

    void Update()
    {
        GetInputs();
    }

    void LateUpdate()
    {
        // functies uitvoeren
        Move();
        Steer();
        Brake();
    }

    void GetInputs()
    {
        //move inputs over nemen en gebruiken
        moveInput = Input.GetAxis("Vertical");
        steerInput = Input.GetAxis("Horizontal");
    }

    void Move()
    {
        foreach(var wheel in wheels)
        {
            // elk wiel laten rijden
            wheel.wheelCollider.motorTorque = moveInput * 600 * maxAcceleration * Time.deltaTime;
        }
    }

    void Steer()
    {
        foreach(var wheel in wheels)
        {
            if(wheel.axel == Axel.Front)
            {
                // elk wiel laten sturen
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
                //wielen laten remmen
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
}
