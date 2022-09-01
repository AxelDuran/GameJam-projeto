using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public PlayerMovement _PlayerMovement;
    
    //relacionado aos puzzles
    public bool _chave1 = false;

    //Cuida de UI
    public GameObject precionarE;
    public GameObject ePrecionado;
    
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
