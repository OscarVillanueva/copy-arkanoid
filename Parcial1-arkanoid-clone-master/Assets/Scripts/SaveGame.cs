using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveGame : MonoBehaviour
{
    protected string savePath;

    protected int currentStage = 0;
    protected int currentShorts = 0;
    protected int currentCoins = 0;

    public void Start()
    {
        savePath = Application.persistentDataPath + "/SaveState.txt";
        //SaveData(); <== CHECAR AQUI CONDICION DE JUEGO POR PRIMERA VEZ
        //LoadData();
    }

    //public void SaveData(Herramienta Game)
    public void SaveData()    
    {  /*
        GameData data = new GameData()
        {
            stage = Game.Stage,
            shorts = Game.Shorts,
            moneda = Game.Moneda,
        };
        */
        GameData data = new GameData()
        {
            stage = currentStage,
            shorts = currentShorts,
            moneda = currentCoins,
        };
        
        //GameData data = new GameData(currentScore, currentName, currentTimePlayed);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        using (var fileStream = File.Create(savePath))
        {
            binaryFormatter.Serialize(fileStream, data);
        }
        //Debug.Log("Información guardada con éxito");
    }

//    public void LoadData(Herramienta gamedata)
    public void LoadData()
    {
        if(File.Exists(savePath))
        {
            GameData gameData;

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using(var fileStream = File.Open(savePath, FileMode.Open))
            {
                gameData = (GameData) binaryFormatter.Deserialize(fileStream);
            }
            /*
            gamedata.Stage = gameData.stage;
            gamedata.Shorts = gameData.shorts;
            gamedata.Moneda = gameData.moneda;
            */
            currentStage = gameData.stage;;
            currentShorts = gameData.shorts;
            currentCoins = gameData.moneda;
 
            //Debug.Log(gameData.stage);
            //Debug.Log(gameData.shorts);
            //Debug.Log(gameData.moneda);


            //Debug.Log("Carga correcta");
        }
        else
        {
            Debug.LogWarning("No existe el archivo indicado");
        }
    }
}