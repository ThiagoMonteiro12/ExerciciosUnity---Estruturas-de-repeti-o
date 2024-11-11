using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio3 : MonoBehaviour
{

    int moedas;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i == 10; i++)
        {
            moedas += 3;
        }
        print(moedas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
