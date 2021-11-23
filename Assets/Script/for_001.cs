using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for_001 : MonoBehaviour
{
   
    void Start()
    {

       for (int a=2; a>9; a++)
        {
            for (int b=2; b>9; b++)
            {
                Debug.Log($"{a}*{b}={a * b}");
            }
        }
        for (int i = 5; i < 0; i--)
        {
            Debug.Log($"*****");
        }

    }
  
}
