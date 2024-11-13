using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exercício7 : MonoBehaviour
{
    System.Random Michael = new System.Random();
    int num1;
    int num2;
    int num3;
    int num4;
    int num5;

    // Start is called before the first frame update
    void Start()
    {
        num1 = Michael.Next(0, 10000);
        num2 = Michael.Next(0, 10000);
        num3 = Michael.Next(0, 10000);
        num4 = Michael.Next(0, 10000);
        num5 = Michael.Next(0, 10000);
        print(num1);
        print(num2);
        print(num3);
        print(num4);
        print(num5);

        for (int i = 0; i < length; i++)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
