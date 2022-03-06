using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodigoFase3 : MonoBehaviour
{

    // variaveis passes para prosseguir no codigo:
    bool chave1 = false;
    bool chave2 = false;
    bool chave3 = false;
    bool chave4 = false;
    bool chave5 = false;
    bool chave6 = false;
    public static int penalidade3;
    public GameObject retornarButton;

    //---------------------------------------------------------------------------------------------------------------------------------

    //basicamente a mean: 
    List<string> response = new List<string>();
    public List<string> Interpret(string userInput){
        response.Clear();
        string[] args = userInput.Split();
       

// Ajuda para o private

        if(args[0] == "helpMetodo") 
        {
            penalidade3 += 6;
            response.Add("Para criar um metodo use:");
            response.Add("Ex: [tipo] [nome]([variavel1], [variavel2]){[funcão] return [variavel];}");
            response.Add("                                   ");

            response.Add("Para chamar um metodo use:");
            response.Add("Ex: [nome]( [variavel1 , [variavel2] );");
            response.Add("                                   ");

            response.Add("Verifique se o metodo precisa de uma ou duas variaveis.");
            response.Add("Atente-se para os espaços, as virgulas e o ponto e virgula.");

            return response;  
        }       

//-----------------------------------------------------------------------------------------------------------------------------------

//para criar o metodo:

        else if (args[0] == "String" && args[1] == "imprimir(String" && args[2] == "palavra)" && args[3] == "{return" && args[4] == "palavra;}" ) 
        {
            response.Add("*metodo criado*");
            response.Add("                                   ");
            chave1 = true;

            response.Add("Agora chame o metodo, você pode escrever qualquer palavra que você quiser.");
            response.Add("Desde que seja apenas uma palavra.");

            return response;
        }

//para chamar o metodo: 

          else if (args[0] == "imprimir(" && args[1] == args[1] && args[2] == ");" && chave1 == true) 
        {
            response.Add("palavra impressa: " + args[1]);
            response.Add("                                   ");
            chave2 = true;

//--------------------------------------------------------------------------------------------------------------------------------
            response.Add("criaremos agora um metodo somar");
            response.Add("crie o metodo 'somar' do tipo int,");
            response.Add("ele recebe as variavel 'int v1, int v2' e retorna 'v1+v2' ");



            return response;
        }

//para criar o metodo:

          else if (chave2 == true && args[0] == "int" && args[1] == "somar(int" && args[2] =="v1," && args[3] =="int" && args[4] =="v2)" && args[5] == "{return" && args[6] =="v1+v2;}") 
        {
            
            response.Add("*metodo criado*");
            chave3 = true;

            response.Add("Agora chame o metodo, você pode escrever qualquer numero que você quiser.");
            response.Add("Desde que seja apenas numeros.");

            return response;

//-------------------------------------------------------------------------------------------------------------------------------
  //para cria valendo o metodo:
        }

        //para chamar o metodo:
        else if (chave3 == true && args[0] == "somar(" && args[1] == args[1] && args[2] == "," && args[3] == args[3] && args[4] == ");" && chave1 == true)
        {
            int number1;
            int number2;

            bool success = Int32.TryParse(args[1], out number1);
            bool success2 = Int32.TryParse(args[3], out number2);
            if (success && success2)
            {
                int soma = number1 + number2;
                response.Add("O calculo é: " + soma);
                response.Add("                                   ");
                chave4 = true;

                response.Add("                                   ");
                response.Add("Agora que já vimos um pouco do que um metodo pode fazer:");
                response.Add("                                   ");
                response.Add("crie um metodo chamado 'abrirPorta' do tipo 'bool' que ");
                response.Add("retorna 'portaAberta = true', recebendo a variavel 'bool portaAberta'");
                response.Add("");


                return response;
            }
            else
            {
                response.Add("O que você digitou provavelmente não é um numero.");

                return response;
            }

        }


        else if (args[0] == "bool" && args[1] == "abrirPorta(bool" && args[2] == "portaAberta)" && args[3] == "{return" && args[4] == "portaAberta" && args[5] == "=" && args[6] == "true;}" && chave3 == true)
        {
         
            response.Add("*metodo criado*");
            response.Add("                                   ");
            chave4 = true;

//--------------------------------------------------------------------------------------------------------------------------------
//chama o primeiro metodo valendo:


            response.Add("Agora que a porta pode ser aberta, falta também poder fechar ela.");
            response.Add("Crie um metodo booleano chamado 'fecharPorta'");
            response.Add("que recebe a variavel booleana 'portaFechada' e retorne ela como true.");

            return response;
        }

        else if(args[0] == "bool" && args[1] == "fecharPorta(bool" && args[2] == "portaFechada)" && args[3] == "{return" && args[4] == "portaFechada" && args[5] == "=" && args[6] == "true;}" && chave4 == true)
        {
            response.Add("*metodo chamado*");
            response.Add("ótimo, isso vai resolver o problema de alguém deixar a porta fechada");
            response.Add("                                   ");
            chave5 = true;

            response.Add("agora ligaremos o computador, usando o metodo 'ligarPc' que é do tipo 'bool',");
            response.Add("retorna 'pcLigado = true', recebendo o parametro 'bool pcLigado'");


            return response;
        }

         else if (args[0] == "bool" && args[1] == "ligarPc(bool" && args[2] == "pcLigado)"  && args[3] == "{return" && args[4] == "pcLigado" && args[5] == "=" && args[6] == "true;}" && chave5 == true) 
        {
          
            response.Add("*metodo criado*");
            response.Add("                                   ");
            chave6 = true;
//--------------------------------------------------------------------------------------------------------------------------------

//texto da terceira parte:
            response.Add("E por ultimo vamos fazer o pc desligar");
            response.Add("Crie o metodo booleano desligarPc com uma variavel também booelana");
            response.Add("chamada 'pcDesligado' e retorne ela como true");

            return response;
        }

//para para escolhas part.1
         else if (args[0] == "bool" && args[1] == "desligarPc(bool" && args[2] == "pcDesligado)" && args[3] == "{return" && args[4] == "pcDesligado" && args[5] == "=" && args[6] == "true;}" && chave6 == true) 
        {
            response.Add("*metodo chamado*");
            response.Add("metodos criados e rodando sem falhas:");
            response.Add("fase concluida!");
            retornarButton.SetActive(true);

            return response;
        }
//-------------------------------------------------------------------------------------------------------------------------------------------

//para ajuda 
         else
        {
            penalidade3 += 2;
            response.Add("Algo que você digitou está errado, se precisa de ajuda digite:");
            response.Add("\"helpMetodo \"");

           return response;
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------

//para voltar para o lobby
    public void Teleporte() {
        SceneManager.LoadScene("Lobby4");
    }

}
