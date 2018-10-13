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
            if (Core.GetComponent<GameController>().option == 0)
            {
                option1.GetComponent<TextMesh>().color = new Color(255, 69, 0, 1);
                   }
            else if (Core.GetComponent<GameController>().option == 1)
            {
                option2.GetComponent<TextMesh>().color = new Color(255, 69, 0, 1);
            }
            else
            {
                option3.GetComponent<TextMesh>().color = new Color(255, 69, 0, 1);
            }
            GetComponent<TextMesh>().color = Color.red;
        }
    }
}
