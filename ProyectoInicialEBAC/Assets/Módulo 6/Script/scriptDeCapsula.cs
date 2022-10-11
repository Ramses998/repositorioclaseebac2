using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptDeCapsula : MonoBehaviour
{
    public scriptDeCubo go1;
    public scriptDeEsfera go2;

    public bool go1EsBlanco;
    public bool go2EsBlanco;

    public bool esBlanco = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        /*
        Color c = new Color(Random.value, Random.value, Random.value);
        this.GetComponent<MeshRenderer>().material.color = c;
        */
        Debug.Log("El valor del booleano del cubo es: "+go1.esBlanco);
        Debug.Log("El valor del booleano de la esfera es: " + go2.esBlanco);

        if (go1.esBlanco && go2.esBlanco)
        {
            Color c = Color.white;
            this.GetComponent<MeshRenderer>().material.color = c;
            esBlanco = true;
        }
        else {
            Color c = Color.black;
            this.GetComponent<MeshRenderer>().material.color = c;
            esBlanco = false;
        }
    }
}
