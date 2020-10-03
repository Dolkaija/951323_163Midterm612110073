using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 using UnityEngine.UI; 
using UnityEngine.EventSystems;

public class CreditMenu : MonoBehaviour , IPointerEnterHandler{
 [SerializeField] Button buttonBack;
 

 AudioSource audiosourceButtonUI;
 [SerializeField] AudioClip audioclipHoldOver;
 // Use this for initialization
 void Start () {
 this.audiosourceButtonUI = this.gameObject.AddComponent <AudioSource > ();
 this.audiosourceButtonUI.outputAudioMixerGroup = SingletonSoundManager.Instance.Mixer
.FindMatchingGroups("UI")[0];

 SetupButtonsDelegate ();

 if (!SingletonSoundManager.Instance.BGMSource.isPlaying)
 SingletonSoundManager.Instance.BGMSource.Play();
 }

 public void OnPointerEnter(PointerEventData eventData)
{
 if (audiosourceButtonUI.isPlaying)
 audiosourceButtonUI.Stop ();

 audiosourceButtonUI.PlayOneShot (audioclipHoldOver);
 }

 void SetupButtonsDelegate(){
 buttonBack.onClick.AddListener(delegate{BackButtonClick(buttonBack);});

 
 }

 public void BackButtonClick(Button button) {
 SceneManager.LoadScene("SceneMainMenu");
 }


 }
