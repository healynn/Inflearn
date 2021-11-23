using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfEsle : MonoBehaviour
{
    public int socore;

    void Start()
    {
        if (socore >= 90)
        {
            Debug.Log("A등급");
        }
        else if (socore >= 70){
            Debug.Log("B등급");
        }
        else if (socore >= 60)
        {
            Debug.Log("열공상");
        }
        else
        {
            Debug.Log("C등급");
        }

    }
}
