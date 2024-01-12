using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveCheckpoint : MonoBehaviour
{
    [SerializeField] Text checkText;
    
    //[SerializeField] Text userPositionText;

    [SerializeField] public string checkpoint;

    [SerializeField]public Vector3 userPosition;

    Isometriccontroller player;


    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Isometriccontroller>();
        LoadData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("name", checkpoint);

        PlayerPrefs.SetFloat("positionX", player.transform.position.x);

        PlayerPrefs.SetFloat("positionY", player.transform.position.y);

        PlayerPrefs.SetFloat("positionZ", player.transform.position.z);

        LoadData();
    }

    void LoadData()
    {
        checkText.text = "Checkpoint: " + PlayerPrefs.GetString("name", "No name");
        
        userPosition = new Vector3 (PlayerPrefs.GetFloat("positionX", 696.3f),PlayerPrefs.GetFloat("positionY", 27.6f),PlayerPrefs.GetFloat("positionZ", -246.5029f));
    }


}
