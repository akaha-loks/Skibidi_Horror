using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Batary : MonoBehaviour
{
    public Timer time;
    [SerializeField] Image bar;
    public float HP = 100f;

    private void Update()
    {
        HP -= Time.deltaTime;
        if (time.time > 100)
        {
            SceneManager.LoadScene(0);
        }
        bar.fillAmount = HP/100;
    }
}
