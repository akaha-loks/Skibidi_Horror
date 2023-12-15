using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSystem : MonoBehaviour
{
    public Transform[] camspos;
    [SerializeField] private GameObject[] lights;
    public int cams;

    private void Awake()
    {
        lights[0].SetActive(false);
        lights[1].SetActive(false);
        cams = 3;
    }
    public void GetCam(int cam)
    {
        if(cam == 0)
        {
            cams = cam;
            transform.position = new Vector3(camspos[0].position.x, camspos[0].position.y, camspos[0].position.z);
            transform.rotation = Quaternion.Euler(camspos[0].eulerAngles);
        }
        if(cam == 1)
        {
            cams = cam;
            transform.position = new Vector3(camspos[1].position.x, camspos[1].position.y, camspos[1].position.z);
            transform.rotation = Quaternion.Euler(camspos[1].eulerAngles);
            lights[0].SetActive(true);
            lights[1].SetActive(false);
        }
        if( cam == 2)
        {
            cams = cam;
            transform.position = new Vector3(camspos[2].position.x, camspos[2].position.y, camspos[2].position.z);
            transform.rotation = Quaternion.Euler(camspos[2].eulerAngles);
            lights[1].SetActive(true);
            lights[0].SetActive(false);
        }
        if(cam == 3)
        {
            cams = cam;
            transform.position = new Vector3(camspos[3].position.x, camspos[3].position.y, camspos[3].position.z);
            transform.rotation = Quaternion.Euler(camspos[3].eulerAngles);
            lights[0].SetActive(false);
            lights[1].SetActive(false);
        }
    }
}
