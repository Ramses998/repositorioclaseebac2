using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptDeCubo : MonoBehaviour
{
    public bool esBlanco = false;

    void Awake()
    {
        /*
        Color c = new Color(Random.value, Random.value, Random.value);
        this.GetComponent<MeshRenderer>().material.color = c;
        */
    }
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
        if (!esBlanco)
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
