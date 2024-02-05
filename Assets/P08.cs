using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class P08 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI exercise01;

    private int contador;



    void Start()
    {

        StartCoroutine(Exercise01());
      
    }

    private IEnumerator Exercise01()
    {
        while (contador < 11)
        {

            exercise01.text = $"Exercise 01: {contador}";
            yield return new WaitForSeconds(1f);
            contador++;
        }
    }
   
}
