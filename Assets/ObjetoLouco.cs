using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoLouco : MonoBehaviour
{
    public float _loucura;
    public bool na;
    
    
    void Start()
    {
        
    }
    void Update()
    {
        if (na)
        {
            if (GameManager.instance._PlayerMovement.Loucura >= _loucura)
            {
                transform.GetChild(0).gameObject.SetActive(false);
            }
        }
        else
        {
            if (GameManager.instance._PlayerMovement.Loucura >= _loucura)
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
        }
        
    }
}
