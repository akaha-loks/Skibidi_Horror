using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsDoor : MonoBehaviour
{
    Vector3 position;
    [SerializeField] Door door;

    private void Awake()
    {
        position = transform.localPosition;
    }
    private void OnMouseDown()
    {
        transform.localPosition = position - transform.right * - 0.03f;
        door.ButtonPressed();
        Invoke("MouseUp", 0.1f);
    }
    private void MouseUp()
    {
        transform.localPosition = position;
    }
}
