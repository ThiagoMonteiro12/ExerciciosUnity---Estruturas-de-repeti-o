using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercício2 : MonoBehaviour
{
    int dano = 0;
    int att = 0;

    // Start is called before the first frame update
    void Start()
    {   
        for (int i = 0; i == 5; i++)
        {
            att += 2;
            dano += att;

            print(dano);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
