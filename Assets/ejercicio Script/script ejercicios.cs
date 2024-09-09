using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_cube : MonoBehaviour

{
    public string nombre_usuario;
    public int edad;
    public float numero1;
    public float numero2;
    public string operacion;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(nombre_usuario);
        if (edad < 18)
        {
            Debug.Log("Bienvenido Joven padawan");
        }
        if (edad >= 18 && edad < 30)
        {
            Debug.Log("Bienvenido Jedi");
        }
        if (edad >= 30)
        {
            Debug.Log("Bienvenido Maestro:");
        }


        if (operacion == "+")
        {
            float resulado = suma(numero1, numero2);
            Debug.Log("el resultado de la suma es:" + resulado);
        }
        if (operacion == "-")
        {
            float resulado = resta(numero1, numero2);
            Debug.Log("el resultado de la resta es:" + resulado);
        }
        if (operacion == "*")
        {
            float resulado = multiplicacion(numero1, numero2);
            Debug.Log("el resultado de la multiplicacion es:" + resulado);
        }
        if (operacion == "/")
        {
            float resulado = division(numero1, numero2);
            Debug.Log("el resultado de la multiplicacion es:" + resulado);
        }

    }

    // Update is called once per frame
    void Update()
    {
        // print(nombre_usuario);
    }

    float suma(float a, float b)
    {
           return a + b; 

    }
    float resta(float a, float b)
    {
        return a - b;

    }
    float multiplicacion(float a, float b)
    {
        return a * b;

    }
    float division(float a, float b)
    {
        return a / b;

    }
}

