using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeDialogo : MonoBehaviour
{
    public int estadoActual = 0;

    public EstadoDialogo[] estados;


    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(dialogControl.singleton.teclaInicioDialogo) || (Input.GetKeyDown(dialogControl.singleton.teclaInicioDialogo2)))
             {
                StartCoroutine(dialogControl.singleton.decir(estados[estadoActual].lista));

            }
        }
    }
}