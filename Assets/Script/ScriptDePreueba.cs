using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDePrueba : MonoBehaviour
{

    public int vidasPersonaje = 5; 
    public int vidaPersonaje2 = 3;
    public float numeroDecimal = 4.5f;
    public string nombrePersonaje = "Nombre del personaje";
    private bool interuptor = false;

    // Start is called before the first frame update
    void Start()
    {
        vidasPersonaje = 10;
        numeroDecimal = 7.54f;
        nombrePersonaje = "Mario";
        interuptor = true;

        int suma = vidasPersonaje + vidaPersonaje2;
        Debug.Log(suma);
        string sumaTextos = nombrePersonaje + "aaaaaaaa";
        Debug.Log (sumaTextos);

        Debug.Log(nombrePersonaje);
        Debug.Log(vidasPersonaje);
        Debug.Log(numeroDecimal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
