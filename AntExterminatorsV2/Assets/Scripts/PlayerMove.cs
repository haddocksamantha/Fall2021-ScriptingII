using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour
{
    public float playerSpeed = 1f;
    public Button upButton;
    public Button downButton;
    
    
    
    private float yValue = 1f;
    private Vector3 backward = (-3,0,0);

    // Update is called once per frame
    void Update()
    {
        OutOfBounds();
        CheckForClick();
    }

    void CheckForClick()
    {
        Button downBtn = upButton.GetComponent<Button>();
        downBtn.onClick.AddListener(MoveUp);
        
        Button upBtn = downButton.GetComponent<Button>();
        upBtn.onClick.AddListener(MoveDown);
    }

    void MoveDown()
    {
        Debug.Log("Down");
        //this will allow player to move down on input
        transform.Translate(backward * yValue * Time.deltaTime * playerSpeed);
    }

    void MoveUp()
    {
        Debug.Log("Up");
        //this will allow player to move up on input

    }

    void OutOfBounds()
    {
        //this will make the player stay on the plane
    }


}
