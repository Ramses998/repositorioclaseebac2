using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclos : MonoBehaviour
{
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        int[] miArreglo = new int[5];
        miArreglo = new int[7];
        string[] diasSemana = new string[7] {"lunes","martes","miercoles","jueves","viernes","sabado","domingo"};
        diasSemana = new string[] { "miercoles", "jueves", "viernes", "sabado", "domingo", "lunes", "martes" };
        
        for(int i = 0; i < diasSemana.Length; i++) {
            miArreglo[i] = i + 1;
            //Debug.Log(diasSemana[i]);
        }
        foreach (int i in miArreglo) {

            Debug.Log(i);
        }
        foreach (string dia in diasSemana)
        {
            Debug.Log(dia);
        }

        /*
        int[,] miMatriz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        for (int j = 0; j < miMatriz.GetLength(0); j++) {
            for (int k = 0; k < miMatriz.GetLength(1); k++) {
                Debug.Log(miMatriz[j, k]);
            }
        }

        int[][] miArregloJagged = new int[][]
        {
            new int[]{ 1,2,3},
            new int[]{ 4,5},
            new int[]{ 6,7,8,9}
        };
        miArregloJagged[1] = new int[] { 10, 11, 12, 13 };

        Debug.Log(miArregloJagged[0][1]);
        for (int x = 0; x < miArregloJagged[x].Length; x++) {
            for (int y = 0; y < miArregloJagged[x].Length; y++) {
                Debug.Log(miArregloJagged[x][y]);
            }
        }
        */

        /*
        bool miBooleano = false;

        while (miBooleano) {
            contador++;
            Debug.Log("Hola");
        }

        do
        {
            Debug.Log("Hola desde do while");
        } while (miBooleano);
        */
    }

    // Update is called once per frame
    void Update()
    {/*
        contador++;
        Debug.Log(contador);*/
    }
}
