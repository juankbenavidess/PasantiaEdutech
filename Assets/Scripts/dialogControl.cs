using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class dialogControl : MonoBehaviour
{
    //Singleton
    public static dialogControl singleton;

    public GameObject dialogo;
    public Text txtDialogo;
    [Header("Config de teclado")]
    public KeyCode teclaSiguienteFrase;
    public KeyCode teclaInicioDialogo = KeyCode.Space;
    public KeyCode teclaInicioDialogo2 = KeyCode.A;
    [Header ("Lista Dialogos")]
    public Frase[] dialogoList;

    // Start is called before the first frame update


    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    void Start()
    {
        dialogo.SetActive(false);
    }


    public IEnumerator decir(Frase[] lista)
    {
        dialogo.SetActive(true);
        for (int i = 0; i < lista.Length; i++)
        {
            txtDialogo.text = lista[i].texto;
            yield return new WaitForSeconds(0.5f);
            yield return new WaitUntil(() => Input.GetKeyUp(teclaSiguienteFrase));
        }
        dialogo.SetActive(false);
    }
    [ContextMenu("Activar Prueba")]
    public void Prueba()
    {
        StartCoroutine(decir(dialogoList));
    }


}

//Para que aparezca en el inspector
[System.Serializable]
public class Frase
{
    public string texto;

}

[System.Serializable]
public class EstadoDialogo
{
    public Frase[] lista;
}
