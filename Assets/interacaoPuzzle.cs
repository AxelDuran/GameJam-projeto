using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class interacaoPuzzle : MonoBehaviour
{
    public bool foiAtivado = false; //trava de repetição

    void Update()
    {
        if (GameManager.instance._chave1 && Input.GetKeyDown(KeyCode.E) && !foiAtivado)
        {
            GameManager.instance._PlayerMovement.Loucura += 1;
            foiAtivado = true;
        }

        if (GameManager.instance._chave1 && !foiAtivado)
        {
            GameManager.instance.precionarE.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !foiAtivado)
        {
            GameManager.instance.precionarE.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameManager.instance.precionarE.SetActive(false);
        GameManager.instance.ePrecionado.SetActive(false);
    }
}
