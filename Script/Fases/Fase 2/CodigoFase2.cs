using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodigoFase2 : MonoBehaviour
{

// variaveis passes para prosseguir no codigo:
     bool chave1 = false;
     bool chave2 = false;
     bool chave3 = false;
     bool chave4 = false;
    bool chave5 = false;
    bool chave6 = false;
    bool chave7 = false;
    bool chave8 = false;
    public static int penalidade2;
    public GameObject retornarButton;

    //---------------------------------------------------------------------------------------------------------------------------------

    //basicamente a mean: 
    List<string> response = new List<string>();
    public List<string> Interpret(string userInput){
        response.Clear();
        string[] args = userInput.Split();
       

// Ajuda para o private

        if(args[0] == "helpAcesso") 
        {
            penalidade2 += 6;
            response.Add("Para tornar uma variável privada use:");
            response.Add("\"private\" antes do tipo de variável");
            response.Add("(Exemplo) private [tipo] [nomeDaVariável] = [valor];");
            response.Add("                                   ");

            response.Add("Para tornar uma variável publica use:");
            response.Add("\"public\" antes do tipo de variável");
            response.Add("(Exemplo) public [tipo] [nomeDaVariável] = [valor];");

            return response;  
        }       

//-----------------------------------------------------------------------------------------------------------------------------------

//para privar a primeira variavel(string): 

        else if (args[0] == "private" && args[1] == "String" && args[2] == "nomeDiretor" && args[3] == "=" && args[4] == "\"Mario\";") 
        {
            response.Add("variável string privada com sucesso!");
            response.Add("                                   ");
            chave1 = true;

            response.Add("Altere o acesso da variável:");
            response.Add("int cpfDiretor = 06879143840;");

            return response;
        }

//para privar a segunda variavel(int): 

          else if (args[0] == "private" && args[1] == "int" && args[2] == "cpfDiretor" && args[3] == "=" && args[4] == "06879143840;" && chave1 == true) 
        {
            response.Add("variável int privada com sucesso!");
            response.Add("                                   ");
            chave2 = true;

            response.Add("Altere o acesso da variável:");
            response.Add("String[] listaDeClientes;");

            return response;
        }

//para privar a terceira variavel(array):

          else if (chave2 == true && args[0] == "private" && args[1] == "String[]" && args[2] == "listaDeClientes;") 
        {
            
            response.Add("Variavel array privada com sucesso!");
            chave3 = true;

//--------------------------------------------------------------------------------------------------------------------------------

//texto da segunda parte
            response.Add("                                   ");
            response.Add("Agora liberaremos o acesso de algumas variáveis");
            response.Add("                                   ");
            response.Add("Deixe Essa variável pública:");
            response.Add("private double precoDoProduto;");

            return response;
        }

//para publicar a primeira variavel(doble)

          else if (args[0] == "public" && args[1] == "double" && args[2] == "precoDoProduto;" && chave3 == true)
        {
         
            response.Add("variável double publicada com sucesso!");
            response.Add("                                   ");
            chave4 = true;

            response.Add("Deixe Essa variável pública:");
            response.Add("private String nomeDoEstabelecimento = \"Shopping ING\";");

            return response;
        }

//para publicar a segunda variavel(string)
        else if (args[0] == "public" && args[1] == "String" && args[2] == "nomeDoEstabelecimento" && args[3] == "=" && args[4] == "\"Shopping" && args[5] == "ING\";" && chave4 == true) 
        {
          
            response.Add("variável string publicada com sucesso!");
            response.Add("                                   ");
            chave5 = true;

            response.Add("Deixe Essa variável pública:");
            response.Add("private int[] listaDeParceiros;");

            return response;
        }

//para publicar a terceira variavel(intArray)
         else if (args[0] == "public" && args[1] == "int[]" && args[2] == "listaDeParceiros;"  && chave5 == true) 
        {
          
            response.Add("variável int publicada com sucesso!");
            response.Add("                                   ");
            chave6 = true;
//--------------------------------------------------------------------------------------------------------------------------------

//texto da terceira parte:
            response.Add("                                   ");
            response.Add("Agora impeça o acesso de variáveis que");
            response.Add("comprometem a segurança do código:");
            response.Add("                                   ");

            response.Add("public int senhaDoCartaoDoCliente;");
            response.Add("public String itensDaCompra;");
            

            return response;
        }

//para para escolhas part.1
         else if (args[0] == "private" && args[1] == "int" && args[2] == "senhaDoCartaoDoCliente;" && chave6 == true) 
        {
            response.Add("Variável privada com sucesso!");
            response.Add("ps: É ideal que o atendente não veja a senha do");
            response.Add("cliente por questão de segurança.");
            response.Add("                                   ");
            
            chave7 = true;

            response.Add("Impeça o acesso de variáveis que");
            response.Add("comprometem a segurança do código:");
            response.Add("                                   ");
            response.Add("public double dataDeValidade;");
            response.Add("public double senhaDoCaixa;");


            return response;
        }

//para para escolhas part.2
         else if (args[0] == "private" && args[1] == "double" && args[2] == "senhaDoCaixa;" && chave7 == true) 
        {
            response.Add("Variável privada com sucesso!");
            response.Add("ps:É ideal que o cliente não veja a senha do caixa do");
            response.Add("shopping por questão de segurança da empresa.");
            response.Add("                                   ");
            
            chave8 = true;

            response.Add("Descubra e altere o acesso da variável");
            response.Add("que compromete a segurança do código:");
            response.Add("                                   ");

            response.Add("public float propagandasDoShopping;");
            response.Add("private int cpfDoCliente;");
            response.Add("private int senhaDeCartaoDoCliente");
            response.Add("public double dataDaBlackFriday;");
            response.Add("public int senhaDoGerente;");
            response.Add("private String nomesDosFuncionario;");

            return response;
        }

//para para escolhas part.3
        
         else if (args[0] == "private" && args[1] == "int" && args[2] == "senhaDoGerente;" && chave8 == true) 
        {
            response.Add("Shopping = seguro;");
            response.Add("fase concluida");
            retornarButton.SetActive(true);

            return response;
        }
//-------------------------------------------------------------------------------------------------------------------------------------------

//para ajuda 
         else
        {
            penalidade2 += 2;
            response.Add("Algo que você digitou está errado, se precisa de ajuda digite:");
            response.Add("\"helpAcesso \"");

           return response;
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------

//para voltar para o lobby
    public void Teleporte() {
        SceneManager.LoadScene("Lobby3");
    }

}
