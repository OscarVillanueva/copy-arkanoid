using UnityEngine;
using System.Collections;

public class ChangeFade : SaveGame {
    //name of the scene you want to load
    public string scene, nextLevel;
	public Color loadToColor = Color.white;

    [SerializeField] AudioClip _audioClip;
    [SerializeField] [Range(0.0f, 1.0f)] float _volume = 1;                       
    AudioSource _audioSource;
     	
    void Start()
    {
        savePath = Application.persistentDataPath + "/SaveState.txt";
    }

    protected void playAudio(){
        _audioSource = gameObject.AddComponent<AudioSource> ();
        if (_audioClip != null){
            _audioSource.clip = _audioClip;
            _audioSource.playOnAwake = false;
            _audioSource.volume = _volume;
            _audioSource.Play ();
            //currentCoins = restaConchas;
        }

    }

	protected void GoToStore()
    {
        playAudio();
        Initiate.Fade("StoreScene", loadToColor, 1.0f);
    }

	protected void GoToNextLevel()
    {
        LoadData();
        playAudio();
        currentStage++;
        SaveData();
        Debug.Log(currentStage);
        if(currentStage==1) {nextLevel="Level1";}
        if(currentStage==2) {nextLevel="Level2";}
        if(currentStage==3) {nextLevel="Level3";}
        if(currentStage==4) {nextLevel="Level4";}  
        if(currentStage==5) {nextLevel="Level5";}      
        Initiate.Fade(nextLevel, loadToColor, 1.0f);
    }


}
