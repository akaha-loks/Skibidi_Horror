using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time = 0;

    private void Update()
    {
        time += Time.deltaTime;
        
    }
}
