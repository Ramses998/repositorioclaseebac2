using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    //Para cambiar valores, puede ir al script anidado a maincamera :)

    public int aumentarCadaFrame = 0;
    public float aumentarCadaFixedUpdate = 0;

    public float operador1 = 0;
    public float operador2 = 0;

    public int numeroDeGO = 0;
    public GameObject objetoParOImpar;

    public string palabraParaColor;
    public GameObject cuboParaPalabra;

    public float numeroFlotante = 0;

    void Start()
    {
        //Pasos de ejercicio 2. Los datos se ingresan desde editor.
        float operacion = (operador1 * operador2) / operador1 - (operador2 / 2);
        int resultadoEntero = (int)operacion;
        Debug.Log("El resuldado de la operación con flotante es: " + operacion);
        Debug.Log("El resuldado de la operación con cast es: " + resultadoEntero);

        //Pasos de ejercicio 3. Los datos se ingresan desde editor.
        GameObject objetoParOImpar = GameObject.Find("ObjetoParOImpar");
        int parONon = numeroDeGO % 2;
        if (parONon == 0){
            Debug.Log("El número es par");
            Color c = Color.blue;
            objetoParOImpar.GetComponent<MeshRenderer>().material.color = c;
        }
        else {
            Debug.Log("El número es non");
            Color c = Color.black;
            objetoParOImpar.GetComponent<MeshRenderer>().material.color = c;
        }

        //Pasos de ejercicio 4. Los datos se ingresan desde editor.
        GameObject cuboParaPalabra = GameObject.Find("CuboParaPalabra");
        int noCaracteres = palabraParaColor.Length;
        Color cc;
        switch (noCaracteres) {

            case 4: {cc = Color.red;}break;

            case 5:{cc = Color.blue;}break;

            case 6: { cc = Color.yellow; } break;

            case 7: { cc = Color.green; } break;

            case 8: { cc = Color.cyan; } break;

            case 9: { cc = Color.magenta; } break;

            case 10: { cc = Color.gray; } break;

            default: { cc = Color.black; } break;


        }
        cuboParaPalabra.GetComponent<MeshRenderer>().material.color = cc;

        //Pasos de ejercicio 5. Los datos se ingresan desde editor.

        int x = 0;
        string floatAtString = numeroFlotante.ToString();
        string cadenaAImprimir = "";
        char caracter = ' ';

        try
        {
            while (floatAtString[x] != '.')
            {
                caracter = floatAtString[x];
                Debug.Log("Imprimiendo el caracter no. " + x + ", que es " + caracter);
                cadenaAImprimir += caracter;
                x++;
            }

            for (int i = 0; i <= 4; i++) {
                cadenaAImprimir += floatAtString[x+i];
            }
        }
        catch (Exception ex) {
            Debug.Log("Sin decimales o con menos de 4");
        }
        Debug.Log(cadenaAImprimir);

        //Pasos de ejercicio 6. El dato se ingresó aquí.
        string miNombre = "Ramsés Figueroa Medina";
        string primerNombre = miNombre.Substring(0, 6);
        Debug.Log(primerNombre);
        string apellidoPaterno = miNombre.Substring(7, 8);
        Debug.Log(apellidoPaterno);
        string apellidoMaterno = miNombre.Substring(16, 6);
        Debug.Log(apellidoMaterno);

        string[] nombreFragmentado = miNombre.Split(' ');
        foreach (var sub in nombreFragmentado)
        {
            Debug.Log($"Substring: {sub}");
        }

        //Pasos de ejercicio 7. El dato se ingresó aquí.
        string valoresMiles1 = "54321";
        string valoresMiles2 = "12345";
        int num1 = 0, num2 = 0;
        Int32.TryParse(valoresMiles1, out num1);
        Int32.TryParse(valoresMiles2, out num2);

        int res = num1 - num2;
        Debug.Log(num1 + " + "+num2+" = "+res);

        //Pasos de ejercicio 8.
        string textoAPartir = "Hola Mundo";
        string textoAImprimir = "";
        int y = 0;
        while (y < textoAPartir.Length) {
            if (y % 2 == 0) {
                textoAImprimir += textoAPartir[y];
            }
            y++;
        }
        Debug.Log(textoAImprimir);

        //Pasos de ejercicio 9.
        string oracion = "¿Cómo me rio cuando camino por la playa, en compañía de mis amigos los vikingos?";
        string sinUnosDigitos = oracion.Substring(5, oracion.Length-5);
        Debug.Log(sinUnosDigitos);

    }

    // Start is called before the first frame update
    void Update()
    {
        //Pasos de ejercicio 1. Los datos se ingresan desde editor.
        aumentarCadaFrame *= aumentarCadaFrame;
        //Debug.Log(aumentarCadaFrame);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Pasos de ejercicio 1. Los datos se ingresan desde editor.
        aumentarCadaFixedUpdate *= aumentarCadaFixedUpdate;
        //Debug.Log(aumentarCadaFixedUpdate);
    }
}
