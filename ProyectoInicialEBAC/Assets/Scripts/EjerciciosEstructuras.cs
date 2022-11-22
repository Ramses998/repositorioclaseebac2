using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EjerciciosEstructuras : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();
    int[] arregloEnteros = new int[10] {1,9,2,8,3,7,4,6,5,10 };
    List<int> listaConNumeros = new List<int> { 1, 2, 2, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };
    Queue<string> colaStrings = new Queue<string> ();
    Stack<string> pilaStrings = new Stack<string>();

    // Start is called before the first frame update
    void Start()
    {

        //Ejercicio 1
        listaNumeros = FuncionEjercicio1(10, 2, 8);
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }

        //Ejercicio 2
        arregloEnteros = FuncionEjercicio2(arregloEnteros);
        foreach (var numero in arregloEnteros)
        {
            Debug.Log(numero);
        }

        //Ejercicio 3
        HashSet<int> hash = FuncionEjercicio3(listaConNumeros);
        for (int i = 0; i < hash.Count; i++) {
            Debug.Log(hash.ElementAt(i));
        }

        //Ejercicio 4
        pilaStrings.Push("Mario"); pilaStrings.Push("Luigi"); pilaStrings.Push("Peach"); pilaStrings.Push("Daisy"); pilaStrings.Push("Toad");
        FuncionEjercicio4(pilaStrings);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<int> FuncionEjercicio1(int tamano,int rango1,int rango2) {

        for (int i = 0; i < tamano; i++) {
            listaNumeros.Add(Random.Range(rango1, rango2));
        }
        return listaNumeros;
    }

    public int[] FuncionEjercicio2(int[] arreglo) {
        int[] nuevoArreglo = arreglo.OrderByDescending(x => x).ToArray();

        return nuevoArreglo;
    }

    public HashSet<int> FuncionEjercicio3(List<int> lista) {
        HashSet<int>  hash= new HashSet<int>();

        for (int i = 0; i < lista.Count; i++) {
            if (!hash.Contains(lista[i])) {
                hash.Add(lista[i]);
            }
        }

        return hash;
    }

    public void FuncionEjercicio4(Stack<string> pila) {
        int cantidadPila = pila.Count;
        for (int i = 0; i < cantidadPila; i++) {
            Debug.Log(pila.Peek());
            colaStrings.Enqueue(pila.Peek());
            pila.Pop();
        }

        int cantidadCola = colaStrings.Count;
        for (int i = 0; i < cantidadCola; i++) {
            Debug.Log(colaStrings.Peek());
            colaStrings.Dequeue();
        }
    }
}
