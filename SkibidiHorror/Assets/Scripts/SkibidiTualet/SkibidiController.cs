using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkibidiController : MonoBehaviour
{
    public Transform checkpoint;
    public static int toPlayerChance;
    [SerializeField] private Transform[] point;
    [SerializeField] private GameObject pointLight;

    private void Awake()
    {
        Invoke("Move", 5f);
    }
    private void Update()
    {
        if(checkpoint == point[1])
        {
            pointLight.SetActive(true);
            transform.eulerAngles = point[1].eulerAngles;
            transform.localScale = new Vector3(point[1].localScale.x, point[1].localScale.y, point[1].localScale.z);
        }
        else
        {
            pointLight.SetActive(false);
        }
        if (checkpoint == point[2])
        {
            transform.localScale = new Vector3(point[2].localScale.x, point[2].localScale.y, point[2].localScale.z);
            transform.eulerAngles = point[2].eulerAngles;
        }
            if (checkpoint == point[3])
        {
            transform.localScale = new Vector3(point[3].localScale.x, point[3].localScale.y, point[3].localScale.z);
            transform.eulerAngles = point[3].eulerAngles;
        }
        if (checkpoint == point[4])
        {
            transform.localScale = new Vector3(point[4].localScale.x, point[4].localScale.y, point[4].localScale.z);
            transform.eulerAngles = point[4].eulerAngles;
        }
        if (checkpoint == point[5])
        {
            transform.localScale = new Vector3(point[5].localScale.x, point[5].localScale.y, point[5].localScale.z);
            transform.eulerAngles = point[5].eulerAngles;
        }
    }
    public void Move()
    {
        NextPoint point = checkpoint.GetComponent<NextPoint>();
        checkpoint = point.getNext();
        transform.position = new Vector3(checkpoint.position.x, checkpoint.position.y, checkpoint.position.z);
        Invoke("Move", 5f);
    }
}
