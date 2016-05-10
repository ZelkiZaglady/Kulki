using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelName : MonoBehaviour {

    public TextMesh textMesh;
	
	void Start () {

        string levelName = SceneManager.GetActiveScene().name;

        textMesh.text = levelName;
    }
}
