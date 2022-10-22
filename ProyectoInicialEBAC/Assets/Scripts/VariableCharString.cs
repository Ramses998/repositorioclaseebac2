using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableCharString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char c = '6';
        int valorEntero = 0;
        if (!int.TryParse(c.ToString(), out valorEntero)) {
            Debug.Log("Eso no es un tipo de dato valido");
        }
        Debug.Log(valorEntero);
        char miCaracter;
        string miString = "Hola desde EBAC";
        string miSegundoString = miString.ToUpper(); ;
        string tercerString = miString + " " + miSegundoString;
        miCaracter = miString[13];
        string miNombre = "Diego";
        string misApellidos = "Hernandez Reyes";
        string primerApellido = misApellidos.Substring(0, 9);
        string salida = $"Mi nombre es: {miNombre} y mis apellidos son {misApellidos}";
        int longitud = miString.Length;
        Debug.Log(salida);
        Debug.Log(primerApellido);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
