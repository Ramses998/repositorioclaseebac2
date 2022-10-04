using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        Debug.Log("Hola mundo0");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);
        Debug.Log("Hola desde update");
    }

    private void FixedUpdate()
    {
        Debug.Log("Hola desde fixed update. Soy más lento. ");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde late update. Soy el último update.");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado. ¿O sea que no lo estaba?");
    }

    private void OnDisable()
    {
        Debug.LogError("Desactivaste el objeto! Lo tomaré como un error.");
    }
}
