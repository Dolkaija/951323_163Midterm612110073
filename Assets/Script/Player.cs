using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    void OnCollisionEnter (Collision collisionInfo)
   {
       if(collisionInfo.collider.tag == "Obstacle" )
       {
       Debug.Log("HIT");
       SceneManager.UnloadSceneAsync("SceneGameplay 1");
       SceneManager.LoadScene("SceneMainMenu");
       }
       if(collisionInfo.collider.tag == "Win")
       {
       Debug.Log("HIT");
       SceneManager.UnloadSceneAsync("SceneGameplay 1");
       SceneManager.LoadScene("SceneGameplay 3");
       }
       if(collisionInfo.collider.tag == "Obstacle2")
       {
       Debug.Log("HIT");
       SceneManager.UnloadSceneAsync("SceneGameplay 3");
       SceneManager.LoadScene("SceneMainMenu");
       }
       if(collisionInfo.collider.tag == "Win2")
       {
       Debug.Log("HIT");
       SceneManager.UnloadSceneAsync("SceneGameplay 3");
       SceneManager.LoadScene("SceneMainMenu ");
       }
   }
}
