using UnityEngine;

public class MostrarTexto : MonoBehaviour
{
    public GameObject texto;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            texto.SetActive(true);
            Invoke("Esconder", 3f);
        }
    }

    void Esconder()
    {
        texto.SetActive(false);
    }
}