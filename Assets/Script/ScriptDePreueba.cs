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

    public int[] arrayNumber; 

    private int[] arrayNumber2 = new int[6];

    private int[] arrayNumber3  [7, 8, 3, 9];

    private string[] arrayString = new string[7];

    private string[] arrayString2 = {"Hola, adios"};

    private int[,] array2Dimensiones = new int [4, 2];

    private int[,] array2Dimensiones2 = [{7, 8, 65, 0}, {9, 2, 545, 8}];

    public List<string> stringList;

    public List<int> intList = new List<int>(7);
    public List<int> intList2 = new List<int>(2. 4, 8, 4, 6);
    // Start is called before the first frame update
    void Start()
    {
        Dabug.Log(arrayNumber[1]);

        Dabug.Log(array2Dimensiones2[0, 1]);

        arrayNumber2[0] = 4;

        array2Dimensiones2[2, 1] = 7777777;

        intList2.Add(10);
        intList2.Insert(5, 888);

        intList2.RemoveAt(2);
    

        /*vidasPersonaje = 10;
        numeroDecimal = 7.54f;
        nombrePersonaje = "Mario";
        interuptor = true;

        int suma = vidasPersonaje + vidaPersonaje2;
        Debug.Log(suma);
        string sumaTextos = nombrePersonaje + "aaaaaaaa";
        Debug.Log (sumaTextos);

        Debug.Log(nombrePersonaje);
        Debug.Log(vidasPersonaje);
        Debug.Log(numeroDecimal);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
