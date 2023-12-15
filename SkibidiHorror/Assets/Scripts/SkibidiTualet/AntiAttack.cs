using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class AntiAttack : MonoBehaviour
{
    public Door door;
    public SkibidiController controller;

    private void Update()
    {
        
        if(door.isOpen == true)
        {
            
        }
        else
        {
            controller.Move();
        }
    }
}
