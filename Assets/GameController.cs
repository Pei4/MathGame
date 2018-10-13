using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public string randomOperator;
    public int answer;
    public int option;
    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

	// Use this for initialization
	void Start () {
        GenerateQuestion();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GenerateQuestion()
    {
        int a = Random.Range(0, 100);
        int b = Random.Range(0, 100);
        int operatorNumber = Random.Range(0, 3);
        if(operatorNumber == 0)
        {
            randomOperator = "+";
            answer = a + b;
        }
        else if(operatorNumber == 1)
        {
            randomOperator = "-";
            answer = a - b;
        }
        else
        {
            randomOperator = "*";
            answer = a * b;
        }
        option = Random.Range(0, 3);
        string questionText = a + " " + randomOperator + " " + b + " is ?";
        question.GetComponent<TextMesh>().text = questionText;
        option1.GetComponent<TextMesh>().color = Color.white;
        option2.GetComponent<TextMesh>().color = Color.white;
        option3.GetComponent<TextMesh>().color = Color.white;
        if (option == 0)
        {
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(1, 3)).ToString();
            option3.GetComponent<TextMesh>().text = (answer + Random.Range(3, 6)).ToString();
            option1.GetComponent<Option>().isCorrect = true;
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<Option>().isCorrect = false;
        }
        else if (option == 1)
        {
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(-3, 0)).ToString();
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option3.GetComponent<TextMesh>().text = (answer + Random.Range(1, 3)).ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().isCorrect = true;
            option3.GetComponent<Option>().isCorrect = false;
        }
        else
        {
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(-6, -3)).ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(-3, 0)).ToString();
            option3.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<Option>().isCorrect = true;
        }
    }
}
