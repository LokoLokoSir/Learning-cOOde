using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;
using System.Linq;

public class DataBridge : MonoBehaviour
{
    public InputField nomeInput;
    public InputField score1;
    public InputField score2;
    public InputField score3;
    public InputField score4;
    public InputField scoreTotal;
    public InputField idUser;
    private static int idNumero;

    int Soma1;
    int Soma2;
    int Soma3;
    int Soma4;

    static int resultado1;
    static int resultado2;
    static int resultado3;
    static int resultado4;

    public DatabaseReference DBReference;
    public DependencyStatus dependencyStatus;
    public GameObject scoreElement;
    public Transform scoreboardContent;

    private void Awake()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                InitializeFirebase();
            }
            else
            {
                Debug.LogError("Could not resolve all Firebase dependencies: " + dependencyStatus);
            }
        });
    }

    private void InitializeFirebase()
    {
        Debug.Log("Setting up Firebase Database");
        DBReference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void SaveDataButton()
    {
        StartCoroutine(updateUsernameDatabase(nomeInput.text));
    }

    public void Fase1Button()
    {
        StartCoroutine(updateScore1());
        StartCoroutine(updateScoreTotal());
    }

    public void Fase2Button()
    {
        StartCoroutine(updateScore2());
        StartCoroutine(updateScoreTotal());
    }

    public void Fase3Button()
    {
        StartCoroutine(updateScore3());
        StartCoroutine(updateScoreTotal());
    }

    public void Fase4Button()
    {
        StartCoroutine(updateScore4());
        StartCoroutine(updateScoreTotal());
    }

    public void ScoreboardButton()
    {
        StartCoroutine(LoadScoreboardData());
    }

    public void ipUpdateButton()
    {
        if(idNumero == 1)
        {

        }else
        {
            StartCoroutine(updateIdDatabase());
        }
    }

    private IEnumerator updateIdDatabase()
    {
            idNumero++;
            idUser.text = idNumero.ToString();
            var DBTask = DBReference.Child("users").Child("idUser").SetValueAsync(idUser.text);

            yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

            if (DBTask.Exception != null)
            {
                Debug.LogWarning(message: $"Failed to register task with {DBTask.Exception}");
            }
            else
            {
                //Database username is now updated
            }
    }

    private IEnumerator updateUsernameDatabase(string _nome)
    {

        var DBTask = DBReference.Child("users").Child(idUser.text).Child("username").SetValueAsync(_nome);
        Debug.Log("idNumero: " + idNumero);
        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {DBTask.Exception}");
        }
        else
        {
           //Database username is now updated
        }

    }

    public IEnumerator updateScore1()
    {
        score1.text = "25";
        score2.text = "0";
        score3.text = "0";
        score4.text = "0";
        Soma1 = int.Parse(score1.text);
        resultado1 = Soma1 - Fase1Codigo.penalidade1;
        var DBTask = DBReference.Child("users").Child(idNumero.ToString()).Child("score1").SetValueAsync(resultado1);
        var DBTask1 = DBReference.Child("users").Child(idNumero.ToString()).Child("score2").SetValueAsync(score2.text);
        var DBTask2 = DBReference.Child("users").Child(idNumero.ToString()).Child("score3").SetValueAsync(score3.text);
        var DBTask3 = DBReference.Child("users").Child(idNumero.ToString()).Child("score4").SetValueAsync(score4.text);

        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {DBTask.Exception}");
        }
        else
        {
            //Score now is updated
        }
    }

    public IEnumerator updateScore2()
    {
        score2.text = "25";
        score3.text = "0";
        score4.text = "0";
        Soma2 = int.Parse(score2.text);
        resultado2 = Soma2 - CodigoFase2.penalidade2;
        var DBTask = DBReference.Child("users").Child(idNumero.ToString()).Child("score2").SetValueAsync(resultado2);
        var DBTask2 = DBReference.Child("users").Child(idNumero.ToString()).Child("score3").SetValueAsync(score3.text);
        var DBTask3 = DBReference.Child("users").Child(idNumero.ToString()).Child("score4").SetValueAsync(score4.text);

        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {DBTask.Exception}");
        }
        else
        {
            //Score now is updated
        }
    }

    public IEnumerator updateScore3()
    {
        score3.text = "25";
        score4.text = "0";
        Soma3 = int.Parse(score3.text);
        resultado3 = Soma3 - CodigoFase3.penalidade3;
        var DBTask = DBReference.Child("users").Child(idNumero.ToString()).Child("score3").SetValueAsync(resultado3);
        var DBTask3 = DBReference.Child("users").Child(idNumero.ToString()).Child("score4").SetValueAsync(score4.text);

        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {DBTask.Exception}");
        }
        else
        {
            //Score now is updated
        }
    }

    public IEnumerator updateScore4()
    {
        score4.text = "25";
        Soma4 = int.Parse(score4.text);
        resultado4 = Soma4 - CodigoFase4.penalidade4;
        var DBTask = DBReference.Child("users").Child(idNumero.ToString()).Child("score4").SetValueAsync(resultado4);

        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {DBTask.Exception}");
        }
        else
        {
            //Score now is updated
        }
    }

    private IEnumerator updateScoreTotal()
    {
        scoreTotal.text = "0";
        int resultadoTotal = resultado1 + resultado2 + resultado3 + resultado4;
        scoreTotal.text = resultadoTotal.ToString();

        var DBTask = DBReference.Child("users").Child(idNumero.ToString()).Child("scoreTotal").SetValueAsync(scoreTotal.text);

        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {DBTask.Exception}");
        }
        else
        {
            //Score now is updated
        }
    }

    private IEnumerator LoadUserData()
    {
        var DBTask = DBReference.Child("users").Child(idUser.text).GetValueAsync();

        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {DBTask.Exception}");
        }
        else if (DBTask.Result.Value == null)
        {
            //Não existe data
            int resultado = int.Parse(score1.text + score2.text + score3.text + score4.text);
            scoreTotal.text = resultado.ToString();

        }
        else
        {
            //Pegar data
            DataSnapshot snapshot = DBTask.Result;

            score1.text = snapshot.Child("score1").Value.ToString();
            score2.text = snapshot.Child("score2").Value.ToString();
            score3.text = snapshot.Child("score3").Value.ToString();
            score4.text = snapshot.Child("score4").Value.ToString();
            scoreTotal.text = snapshot.Child("scoreTotal").Value.ToString();
        }
    }

    private IEnumerator LoadScoreboardData()
    {
        //Get all the users data ordered by kills amount
        var DBTask = DBReference.Child("users").OrderByChild("scoreTotal").GetValueAsync();

        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {DBTask.Exception}");
        }
        else
        {
            //Data has been retrieved
            DataSnapshot snapshot = DBTask.Result;

            //Destroy any existing scoreboard elements
            foreach (Transform child in scoreboardContent.transform)
            {
                Destroy(child.gameObject);
            }

            //Loop through every users UID
            foreach (DataSnapshot childSnapshot in snapshot.Children.Reverse<DataSnapshot>())
            {
                string username = childSnapshot.Child("username").Value.ToString();
                int score1 = int.Parse(childSnapshot.Child("score1").Value.ToString());
                int score2 = int.Parse(childSnapshot.Child("score2").Value.ToString());
                int score3 = int.Parse(childSnapshot.Child("score3").Value.ToString());
                int score4 = int.Parse(childSnapshot.Child("score4").Value.ToString());
                int scoreTotal = int.Parse(childSnapshot.Child("scoreTotal").Value.ToString());

                //Instantiate new scoreboard elements
                GameObject scoreboardElement = Instantiate(scoreElement, scoreboardContent);
                scoreboardElement.GetComponent<Player>().NewScoreElement(username, score1, score2, score3, score4, scoreTotal);
            }
        }
    }        
}