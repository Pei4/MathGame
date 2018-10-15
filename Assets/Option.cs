using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour {
    public bool isCorrect;
    public GameObject Core;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        if (isCorrect) {
            GetComponent<TextMesh>().color = Color.green;
        }
        else {
            GetComponent<TextMesh>().color = Color.red;
            Core.GetComponent<GameController>().realAnswer.GetComponent<TextMesh>().color = new Color(255, 69, 0, 1);
        }
    }
}
