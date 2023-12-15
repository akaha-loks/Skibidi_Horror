using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooksLR : MonoBehaviour
{
    [SerializeField] private Transform[] camspos;
   
    public void LookL(int whatLook)
    {
        if(whatLook == 1)
        {
            transform.rotation = Quaternion.Euler(camspos[0].eulerAngles);
        }
        if(whatLook == 2)
        {
            transform.rotation = Quaternion.Euler(camspos[1].eulerAngles);
        }
    }
}
