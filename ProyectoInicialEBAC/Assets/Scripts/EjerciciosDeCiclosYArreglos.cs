using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosDeCiclosYArreglos : MonoBehaviour
{
    int[] arreglo1 = new int[10];
    int[] arreglo2 = new int[10];
    int[] arregloSuma = new int [10];

    string oracion = "Hola a EBAC, muy buena escuela!";

    int[,] arregloBidireccional = new int[2, 3] { { 1, 2 , 3 }, { 4, 5, 6 }};
    int[] elementos = new int[3] { 7, 8, 9 };

    //string[] 
    // Start is called before the first frame update
    void Start()
    {
        //Pasos de ejercicio 1. Creo que pude haber hecho todo en un solo for, pero siento que le daba más punch primero obtener los números y luego sumarlos.
        for (int i = 0; i < 10; i++) {
            arreglo1[i] = Random.Range(0, 10);
            //Debug.Log("Al valor " + i + "del arreglo 1 le daremos un " + arreglo1[i]);
            arreglo2[i] = Random.Range(0, 10);
            //Debug.Log("Al valor " + i + "del arreglo 2 le daremos un " + arreglo2[i]);
        }

        for (int i = 0; i < 10; i++) {
            arregloSuma[i] = arreglo1[i] + arreglo2[i];
            Debug.Log("La suma de " + arreglo1[i] + " y " + arreglo2[i] + " es: " + arregloSuma[i]);
        }

        //Pasos de ejercicio 2. 
        string[] oracionPorPartes = oracion.Split(' ');

        foreach (string palabra in oracionPorPartes) {
            Debug.Log(palabra);
        }

        int[] total = new int[2];

        for (int i = 0; i < total.GetLength(0); i++) {
            for (int x = 0; x < elementos.Length; x++) {
                total[i] += arregloBidireccional[i,x] * elementos[x];
            }
            Debug.Log(total[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
