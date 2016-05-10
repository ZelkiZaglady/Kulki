using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("collision.gameObject.name");
        if (collision.gameObject.name == "Sphere") {
            string levelName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(levelName);    
        }
    }
}
