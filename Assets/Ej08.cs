using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej08 : MonoBehaviour
{
    public int dia;

    // Start is called before the first frame update
    void Start()
    {
        switch (dia) {

            case 1: Debug.Log("Domingo");
                break;
            case 2: Debug.Ñog("Lunes");
                break;
            case 3: Debug.Log("Martes");
                break;
            case 4: Debug.Log("miercoles");
                break;
            case 5: Debug.Log("Jueves");
                break;
            case 6: Debug.Log("Viernes");
                break;
            case 7: Debug.Log("Sabado");
                break;
            default: Debug.Log("Su numero no crresponde");
                break;

        }
        
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
