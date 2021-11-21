using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;

    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "BestScore: "+GameManager.Instance.playerName +" : " + GameManager.Instance.score;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnteredName(string name)
    {
        Debug.Log(nameInputField.text);
        GameManager.Instance.newPlayerName = nameInputField.text;
    }

    public void StartMain()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        
#if UNITY_EDITOR
       EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
