using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 1;
    ushort miShortSinSigno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = long.MaxValue;
    ulong miLongSinSigno = 0;

    // Start is called before the first frame update
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        Debug.Log("El valor de miByteConSigno es: " + miByteConSigno);
        Debug.Log("El valor de miInt es " + miInt);
        miByte = 200;
        miIntSinSigno = miByte;
        miIntSinSigno = (uint)miByteConSigno;
        Debug.Log("El valor de miIntSinSigno es: " + miIntSinSigno);

        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("El valor de miInt es: " + miInt);

        int a, b, c;
        float f;
        a = 5;
        b = 10;
        c = a + b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        f = a / b;
        Debug.Log(f);
        miInt = Random.RandomRange(a, b);
        if (miInt % 2 == 0)
        {
            Debug.Log("El número es par");
        }
        else
        {
            Debug.Log("El número es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        miLong += 2;
        miLong = miLong + 2;
        Debug.Log(miShort);
    }
}
