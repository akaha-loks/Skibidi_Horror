using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    [SerializeField] private float sensitivy = 150f;
    float rotateZone = Screen.width / 5;
    [SerializeField] CamSystem camsys;
    private void Update()
    {
        if (camsys.cams == 3)
        {
            if (Input.mousePosition.x < rotateZone && transform.rotation.eulerAngles.y > 70)
            {
                transform.Rotate(0, -sensitivy * Time.deltaTime, 0);
            }
            if (Input.mousePosition.x > Screen.width - rotateZone && transform.rotation.eulerAngles.y < 110)
            {
                transform.Rotate(0, sensitivy * Time.deltaTime, 0);
            }
        }
    }
}
