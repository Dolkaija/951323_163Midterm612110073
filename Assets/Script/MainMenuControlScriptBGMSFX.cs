using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 using UnityEngine.UI; 
using UnityEngine.EventSystems;

public class MainMenuControlScriptBGMSFX : MonoBehaviour , IPointerEnterHandler{
 [SerializeField] Button buttonStart;
 [SerializeField] Button buttonOptions;
 [SerializeField] Button buttoncredit;
 [SerializeField] Button buttonExit;
 

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
 buttonStart.onClick.AddListener(delegate{StartButtonClick(buttonStart);});
 buttonOptions.onClick.AddListener ( delegate {OptionsButtonClick(buttonOptions);});
 buttoncredit.onClick.AddListener(delegate{CreditButtonClick(buttonStart);});
 
 buttonExit.onClick.AddListener ( delegate {ExitButtonClick(buttonExit);});
 
 }

 public void StartButtonClick(Button button) {
 SceneManager.LoadScene("SceneGameplay");
 }

 public void OptionsButtonClick(Button button) {
 if (!SingletonGameApplicationManager.Instance.IsOptionMenuActive)
 {
 SceneManager.LoadScene("SceneOption", LoadSceneMode.Additive);
 SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;
 }
 }

 public void CreditButtonClick(Button button) {
 SceneManager.LoadScene("SceneGameplay 2");
 }
 public void StartButton1Click(Button button) {
 SceneManager.LoadScene("SceneGameplay 1");
 }
 
public void ExitButtonClick(Button button) {
 Application.Quit();
 }
 }
