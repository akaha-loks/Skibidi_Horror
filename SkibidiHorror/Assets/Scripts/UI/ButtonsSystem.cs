using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsSystem : MonoBehaviour
{
    [SerializeField] GameObject doorLight;
    Vector3 position;

    private void Awake()
    {
        position = transform.localPosition;
    }
    private void OnMouseDown()
    {
        transform.localPosition = position - transform.right * -0.03f;
        doorLight.SetActive(true);
    }
    private void OnMouseUp()
    {
        transform.localPosition = position;
        doorLight.SetActive(false);
    }
}
