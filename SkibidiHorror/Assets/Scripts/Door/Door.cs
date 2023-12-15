using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Vector3 openPosition;
    [SerializeField] Vector3 closePosition;
    public bool isOpen = true;
    [SerializeField] bool action = false;

    public void ButtonPressed()
    {
        isOpen = !isOpen;
        action = true;
    }
    private void Update()
    {
        Vector3 NextPosition;
        
        if (isOpen)
        {
            NextPosition = openPosition;
        }
        else
        {
            NextPosition = closePosition;
        }
        if (action)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, NextPosition, 12f * Time.deltaTime);
            if(Vector3.Distance(transform.localPosition,NextPosition) < 0.01f)
            {
                transform.localPosition = NextPosition;
                action = false;
            }
        }
    }
}
