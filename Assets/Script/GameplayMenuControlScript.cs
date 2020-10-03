using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 using UnityEngine.UI;

public class GameplayMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button _State1Button;
    [SerializeField] Button _State2Button;
    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackToMainMenuButtonClick(_backButton); });
        _State1Button.onClick.AddListener(delegate { State1(_State1Button); });
        _State2Button.onClick.AddListener(delegate { _State2(_State2Button); });




    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BackToMainMenuButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneGameplay");
       
        SceneManager.LoadScene("SceneMainMenu");
    }
    public void State1(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneGameplay");
       
        SceneManager.LoadScene("SceneGameplay 1");
    }
    public void _State2(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneGameplay");
       
        SceneManager.LoadScene("SceneGameplay 3");
    }

}