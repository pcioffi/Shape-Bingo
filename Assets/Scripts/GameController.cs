using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public Button tileButton;
	public List <string> shapeName;
	public List <Sprite> shapeSprite;
	public List <Sprite> highlightSprite;

	// Use this for initialization
	void Start () {
		//Initialize Bingo Tiles with randomly assigned shapes
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeShape(){
		tileButton.transform.Find("Shape").GetComponent<Image>().sprite = shapeSprite[0];
	}
}
