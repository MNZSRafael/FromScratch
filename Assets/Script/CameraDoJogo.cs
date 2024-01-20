using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDoJogo : MonoBehaviour
{
    public GameObject protagonista;
    public Vector3 distCompensar;
    // Start is called before the first frame update
    void Start()
    {
        distCompensar = transform.position - protagonista.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = distCompensar + protagonista.transform.position;
    }
}
