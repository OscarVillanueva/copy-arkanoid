    using UnityEngine;
    using UnityEngine.UI;
     
    public class PlayCashSFX : SaveGame
    {

        [SerializeField] int tipo_shorts;
        [SerializeField] AudioClip _audioClip;
        [SerializeField] [Range(0.0f, 1.0f)] float _volume = 1;                       
        AudioSource _audioSource;
     
        int playCash = 0;
        int cuentaConchas = 10;
        int restaConchas = 0;

        int costoShortRojo = 5;
        int costoShortAzul = 10;
        int costoShortVerde = 25;

        public void PlaySFX ()
        {
            savePath = Application.persistentDataPath + "/SaveState.txt";
            //Debug.Log(savePath);
                      
            LoadData();   
            //Debug.Log(currentCoins);           
            cuentaConchas = currentCoins;

            if(tipo_shorts == 1){restaConchas = cuentaConchas-costoShortRojo;}
            if(tipo_shorts == 2){restaConchas = cuentaConchas-costoShortAzul;}
            if(tipo_shorts == 3){restaConchas = cuentaConchas-costoShortVerde;}

            if(restaConchas>=0) {playCash=1;}
            else{playCash=0;}
            
            _audioSource = gameObject.AddComponent<AudioSource> ();
            if (_audioClip != null&&playCash==1){
                _audioSource.clip = _audioClip;
                _audioSource.playOnAwake = false;
                _audioSource.volume = _volume;
                _audioSource.Play ();
                currentCoins = restaConchas;
                currentShorts = tipo_shorts;
            }
            Debug.Log("Current Coins:" + currentCoins);   
            Debug.Log("Current Shorts:" + currentShorts);              
            SaveData();

        }
    }

