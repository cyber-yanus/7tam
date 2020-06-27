using UnityEngine;

using System.IO;

public class StartPointLoader : MonoBehaviour
{

    [SerializeField] private StartPoints[] StartPoints;


    [SerializeField] private string savePath;
    [SerializeField] private string saveFileName = "points.json";

    public StartPoints[] StartPoints1 { get => StartPoints; set => StartPoints = value; }

    private void Awake()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        savePath = Path.Combine(Application.persistentDataPath, saveFileName);
#else
        savePath = Path.Combine(Application.dataPath, saveFileName);
#endif

        loadFromFile();
    }


    public void saveToFile()
    {
        StartPointLoaderStruct startPointLoaderStruct = new StartPointLoaderStruct
        {
            StartPoints = this.StartPoints1
        };

        string json = JsonUtility.ToJson(startPointLoaderStruct, true);

        try
        {
            File.WriteAllText(savePath, json);
        }
        catch
        {
            Debug.Log("ошибка сохранения");
        }
        
    }

    public void loadFromFile()
    {
        if (File.Exists(savePath))
        {
            try
            {
                string json = File.ReadAllText(savePath);

                StartPointLoaderStruct startPointLoaderStruct = JsonUtility.FromJson<StartPointLoaderStruct>(json);

                StartPoints = startPointLoaderStruct.StartPoints;
            }

            catch
            {
                Debug.Log("ошибка загрузки");
            }
        }
    }


    private void OnApplicationQuit()
    {
        //saveToFile();
    }

    private void OnApplicationPause(bool pause)
    {
        //if (Application.platform == RuntimePlatform.Android)
          //  saveToFile();   
    }
}
