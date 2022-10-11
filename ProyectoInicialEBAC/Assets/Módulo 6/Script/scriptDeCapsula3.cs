using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptDeCapsula3 : MonoBehaviour
{
    public scriptDeCubo go1;
    public scriptDeEsfera go2;
    public scriptDeCapsula2 go3;
    public scriptDeCapsula2 go4;

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

        if (((go1.esBlanco || go2.esBlanco) && go3.esBlanco) || go4.esBlanco )
        {
            Color c = Color.white;
            this.GetComponent<MeshRenderer>().material.color = c;
        }
        else {
            Color c = Color.black;
            this.GetComponent<MeshRenderer>().material.color = c;
        }
    }
}
