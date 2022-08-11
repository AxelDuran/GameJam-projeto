using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoLouco : MonoBehaviour
{
    public float ababuble;
    
    void Start()
    {
        
    }
    void Update()
    {
        if (GameManager.instance._PlayerMovement.Loucura >= ababuble)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
