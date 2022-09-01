using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GatilhoSimples : MonoBehaviour
{
    public GameObject _obj;
    public bool pegouLoucura;
    public bool _puzzlePiece = false; //ligue caso seja um item pegavel de puzzle
    private bool podeInteragir = false; //verifica se o jogador ta na área de interação

    void Update()
    {
        
        if (podeInteragir && Input.GetKeyDown(KeyCode.E))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            GameManager.instance._chave1 = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !pegouLoucura && !_puzzlePiece)
        {
            GameManager.instance._PlayerMovement.Loucura += 1;
            pegouLoucura = true;
        }

        if (other.tag == "Player" && _puzzlePiece)
        {
            podeInteragir = true;
        }
    }
}
