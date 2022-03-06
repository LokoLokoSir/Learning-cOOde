using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerminalManagerFase1 : MonoBehaviour
{
    public GameObject directoryLine;
    public GameObject responseLine;
    public InputField terminalInput;
    public GameObject userInputLine;
    public ScrollRect scrollRect;
    public GameObject msgList;
    Fase1Codigo interpreter1;

    private void Start() {
        interpreter1 = GetComponent<Fase1Codigo>();
    }

    private void OnGUI() {
        if(terminalInput.isFocused && terminalInput.text != "" && Input.GetKeyDown(KeyCode.Return)) {

            // Armazena Qualquer texto que o usuario coloca.
            string userInput = terminalInput.text;

            ClearInputField();

            //Fixa as mensagens do usuario no terminal.
            AddDirectoryLine(userInput);

            //Adiciona as linhas para a interpretação.
            int lines = AddInterpreter1Lines(interpreter1.Interpret(userInput));

            //Vai para o fundo das linhas.
            ScrollToBottom(lines);

            //Mandar o input do jogador para o final.
            userInputLine.transform.SetAsLastSibling();

            //Já marcar a nova linha.
            terminalInput.ActivateInputField();
            terminalInput.Select();
        }


    }
    void ClearInputField() {
        terminalInput.text = "";
    }
    void AddDirectoryLine(string userInput)
    {
        //Transforma o tamanho da lista do usuario para que as mensagens caibam.
        Vector2 msgListSize = msgList.GetComponent<RectTransform>().sizeDelta;
        msgList.GetComponent<RectTransform>().sizeDelta = new Vector2(msgListSize.x, msgListSize.y + 35.0f);

        GameObject msg = Instantiate(directoryLine, msgList.transform);

        msg.transform.SetSiblingIndex(msgList.transform.childCount - 1);

        msg.GetComponentsInChildren<Text>()[1].text = userInput;
    }

    int AddInterpreter1Lines(List<string> interpretation){
        for(int i = 0; i < interpretation.Count; i++){
            GameObject res = Instantiate(responseLine, msgList.transform);

            res.transform.SetAsLastSibling();

            Vector2 listSize = msgList.GetComponent<RectTransform>().sizeDelta;
            msgList.GetComponent<RectTransform>().sizeDelta = new Vector2(listSize.x, listSize.y + 35.0f);

            res.GetComponentInChildren<Text>().text = interpretation[i];
        }

        return interpretation.Count;
    }

    void ScrollToBottom(int lines){
        if(lines > 4) {
            scrollRect.velocity = new Vector2(0, 450);
        }else {
            scrollRect.verticalNormalizedPosition = 0;
        }
    }

   
}
