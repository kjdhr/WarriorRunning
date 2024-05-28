using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{

    [SerializeField] private GameObject     endPopUp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
            endPopUp.SetActive(true);
    }

    public void EndGame()
    {
        GameManager.Instance.EndGame();
    }
}
