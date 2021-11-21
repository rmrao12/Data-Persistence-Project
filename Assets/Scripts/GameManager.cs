using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public string newPlayerName;
    public string playerName;
    public int score;

    void Awake()
    {
        // if(Instance!=null)
        // {
        //     Destroy(gameObject);
        //     return;
        // }
        
        Debug.Log("Here");

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadBestScore();
        

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Serializable]
    class BestScore
    {
        public string name;
        public int score;
    }

    public void SaveBestScore()
    {
        BestScore data = new BestScore();
        data.score = score;
        data.name = newPlayerName;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath+"/score.json", json);

        
    }

    public void LoadBestScore()
    {

        string path = Application.persistentDataPath+"/score.json";

        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);

            BestScore data = JsonUtility.FromJson<BestScore>(json);

            score = data.score;
            playerName = data.name;
        }


    }



}
