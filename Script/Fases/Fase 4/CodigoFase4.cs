using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodigoFase4 : MonoBehaviour
{
 
// variaveis passes para prosseguir no codigo:
     static double chave = 1;
     bool isPause = false;
     public GameObject look;
    public static int penalidade4;
    public GameObject retornarButton;
    //---------------------------------------------------------------------------------------------------------------------------------

    //basicamente a mean: 
    List<string> response = new List<string>();
    public List<string> Interpret(string userInput){
        response.Clear();
        string[] args = userInput.Split();
       

// Ajuda para o private

        if(args[0] == "helpClasse") 
        {
            penalidade4 += 6;
            response.Add("Para criar um classe use:");
            response.Add("public class [nome da classe] {");
            response.Add("[Conteúdo]");    
            response.Add("}");
            response.Add("                                   ");
            response.Add("crie um metodo main: ");
            response.Add("public static void main(String args[]) {");
            response.Add("[Conteúdo]");    
            response.Add("}");
            response.Add("                                   ");
            return response;  
        }       

//-----------------------------------------------------------------------------------------------------------------------------------

//para criar o metodo:

        else if (args[0] == "concluido") 
        {
            response.Add("muito bom!");
            response.Add("                                   ");
          

            response.Add("crie um metodo main para essa classe");
            response.Add("quando finalizado, digite :concluido1");
            response.Add("                                 ");

            response.Add("Para criar um metodo main digite:");
            response.Add("public static void main(String args[]) {");
            response.Add("[Conteúdo]");
            response.Add("}");
            return response;
        }

//para chamar o metodo: 

          else if (args[0] == "concluido1") 
        {
            response.Add("bom trabalho!");
            response.Add("                                   ");
            

//--------------------------------------------------------------------------------------------------------------------------------
            response.Add("baseado-se em tudo que foi treinado iremos criar uma classe");
            response.Add(" que realiaze as 4 operações basicas da matematica");            
            response.Add("crie agora os metodos:");
            response.Add("                      ");

            response.Add("Somar");
            response.Add("Subtrair");
            response.Add("Multiplicar");
            response.Add("Dividir");

            response.Add("                      ");
            response.Add("ps: O simbolo de multiplicar na programação é o asterisco(*)");
            response.Add("e o da divisão é uma barra(/)");
            response.Add("ps: quando acabar digite: concluido2");



            return response;
        }

//para chama o metodo:

          else if (args[0] == "concluido2") 
        {
            
            response.Add("otimo, entender quais são as relações entre:");
            response.Add("classe, metodo e variavel é essencial para o programador");

           


//-------------------------------------------------------------------------------------------------------------------------------
//para cria valendo o metodo:

            response.Add("                                   ");
            response.Add("agora chame os metodos usando a main:");
            response.Add("Para aparecer na sua tela o resultado do metodo");
            response.Add("É só digitar essa função:");
            response.Add("System.out.println([nome do metodo]([parametros do metodo]));");
            response.Add("ps: quando acabar digite: concluido3");

            return response;
        }


          else if (args[0] == "concluido3")
        {
         
            response.Add("excelente!");
            response.Add("                                   ");
            response.Add("como isso vc fecha o conhecimento inicial, e já está apto a criar classes");
         

//--------------------------------------------------------------------------------------------------------------------------------
//chama o primeiro metodo valendo:


            response.Add("lembre-se:");
            response.Add("existe regras para se nomear a classe!");
            response.Add("nomes de metodos são no infinitivo!");
            response.Add("O retorno dos metodos devem ser do mesmo tipo do proprio metodo");
            response.Add("Caso o contrario e código falhara");
            response.Add("ps: análise e modifique no código se necessário, para atender as espectativas:");
            response.Add("ps: quando acabar digite: concluido4");

            return response;
        }


        else if (args[0] == "concluido4") 
        {
          
            response.Add("Ótimo!");
            response.Add("agora você vai poder comparar seu código com um desenvolvido por mim:");
            response.Add("aperte o Control Esquerdo(Ctrl) para ver o código");
            response.Add("                                   ");
            
            if (args[0]=="look")
        {             
            Dijuntor();
        }   
           

            response.Add("ps: quando acabar digite: concluido5");
           

            return response;
        }


         else if (args[0] == "concluido5") 
        {
          
          if (Input.GetKeyDown(KeyCode.LeftControl))
        {             
            Dijuntor();
        }   
            
   
//--------------------------------------------------------------------------------------------------------------------------------

//texto da terceira parte:
            response.Add("                                   ");
            response.Add("compare os códigos e corrija seus erros");
            response.Add("ps: maneiras diferentes de escrita podem resolver o mesmo problema!");
            response.Add("foque nas soluções dos problemas, não igualar as sintaxe");
             response.Add("ps: quando acabar digite: concluido6");
            return response;
        }

//para para escolhas part.1
         else if (args[0] == "concluido6") 
        {
            response.Add("Parabéns sua iniciação está completa!");
            response.Add("vá ao corredor, para ir a sala do chefe!");
            response.Add("fase concluida!");
            retornarButton.SetActive(true);

            return response;
        }
//-------------------------------------------------------------------------------------------------------------------------------------------

//para ajuda 
         else
        {
            penalidade4 += 2;
            response.Add("Algo que você digitou está errado, se precisa de ajuda digite:");
            response.Add("\"helpClasse \"");

           return response;
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------

//para voltar para o lobby
    public void Teleporte() {
        SceneManager.LoadScene("Lobby5");
    }

 void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {             
            Dijuntor();
        }   
    }
    
    void Dijuntor(){
      if(isPause == false)
        {
            look.SetActive(true);
            isPause = true;
        } else if(isPause == true)
            {
                look.SetActive(false);
                isPause = false;
            }
    }
}
