using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controlim;
    public Transform pe;
    public float velocidade;
    Animator _animaPlayer;
    public bool taNoChao;
    float _gravidade = -1f;
    public int Loucura;

    void Start()
    {
        controlim = GetComponent<CharacterController>();
        _animaPlayer = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * x) + (transform.forward * z) + (transform.up * _gravidade);

        _animaPlayer.SetFloat("Horizontal", x);
        _animaPlayer.SetFloat("Vertical", z);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _animaPlayer.SetBool("taCorrendo", true);
            velocidade = 10f;
        }
        else
        {
            _animaPlayer.SetBool("taCorrendo", false);
            velocidade = 8f;
        }

        controlim.Move(move * (velocidade * Time.deltaTime));

    }
}
