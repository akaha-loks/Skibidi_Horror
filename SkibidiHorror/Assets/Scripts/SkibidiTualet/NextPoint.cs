using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPoint : MonoBehaviour
{
    public Transform[] NextCheckPoints;
    int Chance;
    private void Awake()
    {
        StartChance();
    }
    void StartChance()
    {
        SkibidiController.toPlayerChance = 80;
        Chance = SkibidiController.toPlayerChance;
    } 
    public Transform getNext()
    {
        Chance = SkibidiController.toPlayerChance;
        int rand = Random.Range(1, 100);
        if(rand <= Chance)
        {
            if(NextCheckPoints.Length > 1)
            {
                return NextCheckPoints[Random.Range(1, NextCheckPoints.Length)];
            }
            else
            {
                return NextCheckPoints[0];
            }
        }
        else
        {
            return NextCheckPoints[0];
        }
    }
}
