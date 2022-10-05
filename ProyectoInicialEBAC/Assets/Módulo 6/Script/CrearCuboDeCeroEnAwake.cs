using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboDeCeroEnAwake : MonoBehaviour
{
    public GameObject PrefabCube;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;

    void Awake()
    {
        listaDeCubos = new List<GameObject>();
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        tempGameObject.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listaDeCubos.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }

    void OnEnable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        Color c = Color.green;
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }

    void OnDisable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        Color c = Color.red;
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
