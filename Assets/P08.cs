using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class P08 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI exercise01;
    [SerializeField] private TextMeshProUGUI exercise02;
    [SerializeField] private TextMeshProUGUI exercise03;


    private int contador;
    private int cuentaAtras = 10;
    private int suma;
    private string bottle = "bottles";

    private string exercise3 = "I like videogames";


    void Start()
    {

        StartCoroutine(Exercise01());
        StartCoroutine(Exercise02());
        StartCoroutine(Exercise03());
    }

    private IEnumerator Exercise01()
    {
        while (contador < 11)
        {

            exercise01.text = $"Exercise 01: {suma}";
            yield return new WaitForSeconds(1f);
            contador++;
            suma = suma + contador;
        }
    }

    private IEnumerator Exercise02()
    {
        while (cuentaAtras > 0)
        {

            

            exercise02.text = $"Exercise 02:";
            yield return new WaitForSeconds(0.5f);
            exercise02.text = $"Exercise 02:\r\n {cuentaAtras} green {bottle}";
            yield return new WaitForSeconds(0.5f);
            exercise02.text = $"Exercise 02:\r\n {cuentaAtras} green {bottle}\r\n Hanging on the wall";
            yield return new WaitForSeconds(0.5f);
            exercise02.text = $"Exercise 02:\r\n {cuentaAtras} green {bottle}\r\n Hanging on the wall\r\n";
            yield return new WaitForSeconds(0.5f);
            exercise02.text = $"Exercise 02:\r\n {cuentaAtras} green {bottle}\r\n Hanging on the wall\r\n {cuentaAtras} green {bottle}";
            yield return new WaitForSeconds(0.5f);
            exercise02.text = $"Exercise 02:\r\n {cuentaAtras} green {bottle}\r\n Hanging on the wall\r\n {cuentaAtras} green {bottle}\r\n And if one green bottle ";
            yield return new WaitForSeconds(0.5f);
            exercise02.text = $"Exercise 02:\r\n {cuentaAtras} green {bottle}\r\n Hanging on the wall\r\n {cuentaAtras} green {bottle}\r\n And if one green bottle\r\n Should accidentally fall";
            yield return new WaitForSeconds(0.5f);
            cuentaAtras--;
            if (cuentaAtras < 2) { bottle = "bottle";}
            exercise02.text = $"Exercise 02:\r\n {cuentaAtras} green {bottle}\r\n Hanging on the wall\r\n {cuentaAtras} green {bottle}\r\n And if one green bottle\r\n Should accidentally fall\r\n There’ll be {cuentaAtras} green {bottle}";
            yield return new WaitForSeconds(0.5f);
            exercise02.text = $"Exercise 02:\r\n {cuentaAtras} green {bottle}\r\n Hanging on the wall\r\n {cuentaAtras} green {bottle}\r\n And if one green bottle\r\n Should accidentally fall\r\n There’ll be {cuentaAtras} green {bottle}\r\nHanging on the wall"; ;
            yield return new WaitForSeconds(0.5f);
           


        }
        exercise02.text = $"Exercise 02:\r\n FIN";
        
    }
   
    private IEnumerator Exercise03()
    {
        exercise03.text = $"Exercise 03:\r\n";
        foreach (char c in exercise3)
        {
            exercise03.text += c;
            yield return new WaitForSeconds(0.2f);
        }
    }
}
