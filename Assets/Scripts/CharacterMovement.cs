using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    private Vector3 movement;
    private float movemntSqrMagnitude;
    

    
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

    }
    public void CharacterPosition()
    {

    }
    public void CharacterRotation()
    {

    }
    public void WalkAnimation()
    {

    }
    public void FootstepAudio()
    {

    }
}
