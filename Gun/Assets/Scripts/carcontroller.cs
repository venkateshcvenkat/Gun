using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carcontroller : MonoBehaviour
{
    private float inputx, inputy;
    private float currentSteeringAngle, currentBreakForce;
    private bool isBreaking;
    public float accelearation, breakForce, maxsteerAngle;
    public Transform FLwheeltransform,FRwheeltransform, BLwheeltransform, BRwheeltransform;
    public WheelCollider FLCollider, FRCollider, BLCollider, BRCollider;


    private void FixedUpdate()
    {
        GetInput();
        carAccelearation();
        carBreak();
        CarSteering();
        RotateWheels();
    }
    public void GetInput()
    {
      inputx =  Input.GetAxis("Horizontal");
      inputy =  Input.GetAxis("Vertical");
      isBreaking = Input.GetKey(KeyCode.Space);
    }
    public void carAccelearation()
    {
        FLCollider.motorTorque = inputy * accelearation;
        FRCollider.motorTorque = inputy * accelearation;
        BLCollider.motorTorque = inputy * accelearation;
        BRCollider.motorTorque = inputy * accelearation;
        currentBreakForce = isBreaking ? breakForce : 0f;
        carBreak();

    }
    public void carBreak()
    {
        FLCollider.brakeTorque = currentBreakForce;
        FRCollider.brakeTorque = currentBreakForce;
        BLCollider.brakeTorque = currentBreakForce;
        BRCollider.brakeTorque = currentBreakForce;
    }
    public void CarSteering()
    {
        currentSteeringAngle = inputx * maxsteerAngle;
        FLCollider.steerAngle = currentSteeringAngle;
        FRCollider.steerAngle = currentSteeringAngle;
    }
   public void RotateWheels()
    {
        UpdateWheels(FLCollider, FLwheeltransform);
        UpdateWheels(FRCollider, FRwheeltransform);
        UpdateWheels(BLCollider, BLwheeltransform);
        UpdateWheels(BRCollider, BRwheeltransform);
    }
    public void UpdateWheels(WheelCollider collider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        collider.GetWorldPose(out pos, out rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;
       
    }
}
