using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio6 : MonoBehaviour
{

    int num;
    int escolha;
    int resultado1;
    int resultado2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= escolha; i++)
        { resultado1 = escolha % 3;
            resultado2 =  escolha % 5;

            if (resultado1 == 0 && resultado2 == 0)
            {
                print("Fizz Buzz");
            }
            else if (resultado1 == 0)
            {
                print("Buzz");
            }
            else if(resultado2 == 0)
            {
                print("Fizz");
            }
            else
            {
                print("Funfo não");
            }
            
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
