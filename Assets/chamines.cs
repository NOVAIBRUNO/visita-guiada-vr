using UnityEngine;
using TMPro; // Necessário para mexer no texto da tela

public class PontoChamines : MonoBehaviour
{
    // Arraste o seu Painel (Canvas) para cá no Inspector
    public GameObject painelMensagem;

    // Arraste o Texto que fica dentro do Painel para cá
    public TMP_Text textoDaTela;

    // O texto que vai aparecer já está programado aqui!
    [TextArea(3, 5)]
    public string mensagemChamines = "As chaminés, elas mostram a época em que a força do vapor era o que movia a economia e o trabalho";

    private void OnTriggerEnter(Collider outro)
    {
        // Quando o jogador (Player) pisar na área invisível...
        if (outro.CompareTag("Player"))
        {
            // Muda o texto da tela para a mensagem das chaminés
            textoDaTela.text = mensagemChamines;

            // Faz o painel aparecer na tela
            painelMensagem.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider outro)
    {
        // Quando o jogador sair da área...
        if (outro.CompareTag("Player"))
        {
            // Esconde o painel
            painelMensagem.SetActive(false);
        }
    }
}