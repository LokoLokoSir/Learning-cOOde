using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fase1Codigo : MonoBehaviour
{
    bool aptoMaca = false;
    bool aptoCenoura = false;
    bool aptoBatata = false;
    bool apto50 = false;
    bool apto30 = false;
    bool apto60 = false;
    bool apto80 = false;
    bool apto7 = false;
    bool apto8 = false;
    public static int penalidade1 = 0;
    public GameObject retornarButton;


    List<string> response = new List<string>();
    public List<string> Interpret(string userInput){
        response.Clear();

        string[] args = userInput.Split();
        
 //public static string nome ="s";
 //public static string numero = "j"; 
// Ajuda para o string
        if(args[0] == "helpString") 
        {
            penalidade1 += 4;
            response.Add("Para criar as Strings use: ");
            response.Add("String caixa1 = \"arroz\"; ");
            response.Add("String caixa2 = \"maca\"; ");
            response.Add("String caixa3 = \"cenoura\"; ");
            response.Add("String caixa4 = \"batata\"; ");

            return response;  
        }       
//Ajuda no int
        if(args[0] == "helpInt") 
        {
            penalidade1 += 4;
            response.Add("Para criar os Ints use: ");
            response.Add("int arroz = 80; ");
            response.Add("int maca = 60; ");
            response.Add("int cenoura = 50; ");
            response.Add("int batata = 30; ");
            
            return response;
        }
//Ajuda no array
        if(args[0] == "helpArray") {
            penalidade1 += 4;
            response.Add("Para criar os Arrays use: ");
            response.Add("String[4] secao; ");
            response.Add("Int[4] secao; ");

            return response;
        }
//-----------------------------------------------------------------------------------------------------------------------------------

//para criar a variavel string para arroz
         else if (args[0] == "String" && args[1] == "caixa1" && args[2] == "=" && args[3] == "\"arroz\";") 
        {
            // nome = nome + "r";[]
            aptoMaca = true;
            response.Add("Variavel String criada!");
            response.Add("Atenção, nas variáveis não colocamos acento");
            return response;
        }
//para criar a variavel string para maçã
          else if (args[0] == "String" && args[1] == "caixa2" && args[2] == "=" && args[3] == "\"maca\";" && aptoMaca == true) 
        {
          //  nome = nome + "j";
            aptoCenoura = true;
            response.Add("Variavel String criada!");
            return response;
            }
//para criar a variavel string para cenoura
          else if (args[0] == "String" && args[1] == "caixa3" && args[2] == "=" && args[3] == "\"cenoura\";" && aptoCenoura == true) 
        {
            //nome = nome + "v";
            aptoBatata = true;
            response.Add("Variavel String criada!");
            return response;
            //para criar a variavel string para batata
        }
          else if (args[0] == "String" && args[1] == "caixa4" && args[2] == "=" && args[3] == "\"batata\";" && aptoBatata == true)
        {
            apto50 = true;
            //nome = nome + "v";
            response.Add("Variavel String criada!");
            response.Add("                                    ");

            response.Add("Agora vamos para as variáveis ints.");
            response.Add("Elas são variáveis que contem números ao invés de textos.");
            response.Add("Para aplicá-las é só colocar 'int' no lugar de 'String'.");
            response.Add("                                    ");

            response.Add("Os ints nesse contexto vão nos ajudar para saber a quantidade");
            response.Add("de alimentos em cada caixa, use as etiquetas na imagem de ajuda");
            response.Add("para saber quantos alimentos tem em cada caixa");

            return response;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------

        //para criar a variavel int Arroz
        else if (args[0] == "int" && args[1] == "arroz" && args[2] == "=" && args[3] == "80;" && apto50 == true) 
        {
            // numero = numero + "a";
            apto30 = true;
            response.Add("Variavel int criada!");
            return response;
        }
//para criar a variavel int Maçã
         else if (args[0] == "int" && args[1] == "maca" && args[2] == "=" && args[3] == "60;" && apto30 == true) 
        {
           // numero = numero + "t";
            apto60 = true;
            response.Add("Variavel int criada!");
            return response;
        }
//para criar a variavel int Cenoura
         else if (args[0] == "int" && args[1] == "cenoura" && args[2] == "=" && args[3] == "50;" && apto60 == true) 
        {
           // numero = numero + "3";
            apto80 = true;
            response.Add("Variavel int criada!");
            return response;
        }
        //para criar a variavel int batata
         else if (args[0] == "int" && args[1] == "batata" && args[2] == "=" && args[3] == "30;" && apto80 == true)
        {
            // numero = numero + "3";
            apto7 = true;
            response.Add("Variavel int criada!");
            response.Add("                                    ");

            response.Add("Por ultimo vamos para as variáveis array.");
            response.Add("Elas são variáveis que contem vários tipos de uma variável.");
            response.Add("Para aplicá-las é só colocar um tipo de variável");
            response.Add("junto de dois colchetes ([]) e colocar a quantidade");
            response.Add("de variáveis que você quer colocar dentro do array.");
            response.Add("Por exemplo: 'String[7]' para um array de Strings");
            response.Add("Com 7 espaços para colocar palavras");
            response.Add("                                    ");

            response.Add("Nesse contexto os arrays vão nós ajudar na organização");
            response.Add("Eles vão ser as seções de nossa loja.");
            response.Add("E lembre-se que nas vareáveis não utilizamos acento");
            response.Add("e nem usamos cê-cedilha");
            response.Add("                                    ");

            response.Add("Crie dois arrays. um do tipo String, contendo todos");
            response.Add("os alimentos, com o nome de 'secaoNomes'.");
            response.Add("E outro também contando todos os alimentos");
            response.Add("porém esse é do tipo int e deve se chamar 'secaoQuantidade'");
            return response;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        //para criar o array 
        else if (args[0] == "String[4]" && args[1] == "secaoNomes;" && apto7 == true ) 
        {
            apto8 = true;
            response.Add("Array string Criado");
            return response;

        }
//para criar o array
         else if (args[0] == "int[4]" && args[1] == "secaoQuantidade;" && apto8 == true) 
        {
            response.Add("Array int Criado");
            response.Add("Fase completa!");
            retornarButton.SetActive(true);

            return response;
        }
//-------------------------------------------------------------------------------------------------------------------------------------------

//para colocar 
    //arroz, maçã, cenoura, batata

         else
        {
            penalidade1 += 2;
            response.Add("Algo que você digitou está errado, se precisa de ajuda digite:");
            response.Add("Aperte Control Esquerdo para saber quais variaveis criar:");
            response.Add("\"helpString\" se precisar de ajuda com String ");
            response.Add("\"helpInt\" se a ajuda for pra int ");
            response.Add("\"helpArray\" se a ajuda for pra array: ");
            return response;
        }
    }

    public void Teleporte() {
        SceneManager.LoadScene("Lobby2");
    }
}
