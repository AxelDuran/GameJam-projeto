using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatilhoSimples : MonoBehaviour
{
    public GameObject _obj;
    public bool ativado;

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !ativado)
        {
            GameManager.instance._PlayerMovement.Loucura += 1;
            ativado = true;
        }
    }
}
