using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {
        text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            text.text = "I will now guess the number you have in mind... with no more than 10 guesses!";
        }
	}
}
