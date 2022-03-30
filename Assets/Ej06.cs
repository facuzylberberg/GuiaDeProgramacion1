//Realizá un programa que permita el ingreso por Inspector 
//    de un valor entero mayor que 0 en una variable llamada num1 y muestre un mensaje
//    por pantalla indicando "el  número es par" o "el número es impar".
//    Deberá utilizar el operador “módulo” es el caracter  %.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej06 : MonoBehaviour
{
    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 == 0)
        {
            Debug.Log("El numero debe ser mayor a cero");
        }

        else if ((num1 % 2) == 0)
        {
            Debug.Log("su numero es par");


        }

        else
        {
            Debug.Log("su numero es impar");

        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
