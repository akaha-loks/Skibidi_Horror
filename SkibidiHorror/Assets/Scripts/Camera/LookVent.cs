using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookVent : MonoBehaviour
{
    [SerializeField] Transform[] camspos;
    public void GetLook()
    {
        transform.position = new Vector3(camspos[0].position.x, camspos[0].position.y, camspos[0].position.z);
        transform.rotation = Quaternion.Euler(camspos[0].eulerAngles);
    }
    public void DontGetLook()
    {
        transform.position = new Vector3(camspos[1].position.x, camspos[1].position.y, camspos[1].position.z);
        transform.rotation = Quaternion.Euler(camspos[1].eulerAngles);
    }
}
