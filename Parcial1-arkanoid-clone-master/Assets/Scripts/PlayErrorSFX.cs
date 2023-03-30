    using UnityEngine;
    using UnityEngine.UI;
     
    public class PlayErrorSFX : SaveGame
    {

        [SerializeField] int tipo_shorts;
        [SerializeField] AudioClip _audioClip;
        [SerializeField] [Range(0.0f, 1.0f)] float _volume = 1;                       
        AudioSource _audioSource;

        int cuentaConchas = 0;
        int restaConchas = 0;

        int costoShortRojo = 5;
        int costoShortAzul = 10;
        int costoShortVerde = 25;


        public void PlaySFX ()
        {
            savePath = Application.persistentDataPath + "/SaveState.txt";            
            LoadData();   
            cuentaConchas = currentCoins;

            if(tipo_shorts == 1){restaConchas = cuentaConchas-costoShortRojo;}
            if(tipo_shorts == 2){restaConchas = cuentaConchas-costoShortAzul;}
            if(tipo_shorts == 3){restaConchas = cuentaConchas-costoShortVerde;}

            if(restaConchas<0){
                _audioSource = gameObject.AddComponent<AudioSource> ();
                if (_audioClip != null){
                    _audioSource.clip = _audioClip;
                _audioSource.playOnAwake = false;
                _audioSource.volume = _volume;
                _audioSource.Play ();
                //currentCoins = restaConchas;
                }
            }
            //GetComponent<Button> ().onClick.AddListener (() => _audioSource.Play ());
        }
    }

