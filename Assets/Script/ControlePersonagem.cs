using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{
    public Rigidbody2D persona;
    public Vector2 direcao;
    public float movimento = 5f;

    public void Awake()
    {
        persona = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    public void Update()
    {
        float eixoX = Input.GetAxis("Horizontal");
        float eixoY = Input.GetAxis("Vertical");

        direcao = new Vector2(eixoX, eixoY);

    }

    public void FixedUpdate()
    {
        persona.MovePosition(persona.position + direcao.normalized * movimento * Time.deltaTime);
    }




}


