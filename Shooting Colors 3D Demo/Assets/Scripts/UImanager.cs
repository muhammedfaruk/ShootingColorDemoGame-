using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class UImanager : MonoBehaviour
{
    GameObject SoundManager;
    LevelManager levelManager;
    public GameObject soundOn, soundOff, wonPanel, nextLevelButton;

    public Ease animType = Ease.Flash;  // istediğimiz animasyonu seçebiliriz


    private void Start() {
        SoundManager = GameObject.Find("SoundManager");
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    
    }
    public void RestartGame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        Debug.Log("Nex Level");
        PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1); // geçtiğimiz level kayıt ettik bu sayede oyuna geri dönüşlerde kaldığımız yerden devam edecektir.        
        levelManager.LevelControl();   // yeni level oluştur
       
    }
    public void SoundOff()
    {
        SoundManager.GetComponent<AudioSource>().mute = true;
        soundOff.SetActive(false);
        soundOn.SetActive(true);
    }

    public void SoundOnn()
    {
        SoundManager.GetComponent<AudioSource>().mute = false;
        soundOff.SetActive(true);
        soundOn.SetActive(false);
    }

    public void WonPanel()      // level bitişlerinde paneli aktifleştir
    {     
        SoundManager.GetComponent<SoundManager>().PlaySound(2);   
        wonPanel.SetActive(true);   
        Vector3 targetScale = new Vector3(1,1,1);
        nextLevelButton.GetComponent<RectTransform>().DOScale(targetScale, 1).SetEase(animType); // buton animasyonu açılış
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
