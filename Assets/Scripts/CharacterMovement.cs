using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    private Vector3 movement;
    private float movemntSqrMagnitude;
    public float walkSpeed = 1.75f;

    
    void Update()
    {
        GetMovementInput();
        CharacterPosition();
        CharacterRotation();
        WalkAnimation();
        FootstepAudio();
    }

    public void GetMovementInput()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        movement = Vector3.ClampMagnitude(movement,1.0f);
        movemntSqrMagnitude = movement.sqrMagnitude;
        Debug.Log(movement);

    }
    public void CharacterPosition()
    {
        transform.Translate(movement * walkSpeed * Time.deltaTime,Space.World);
    }
    public void CharacterRotation()
    {
        if(movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movement, Vector3.up);
        }
        
    }
    public void WalkAnimation()
    {

    }
    public void FootstepAudio()
    {

    }
}
