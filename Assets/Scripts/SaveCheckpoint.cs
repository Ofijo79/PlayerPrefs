using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveCheckpoint : MonoBehaviour
{
    [SerializeField] Text userPositionText;

    [SerializeField] Vector3 userPosition;

    // Start is called before the first frame update
    void Start()
    {
        LoadData();
    }

    public void SaveData()
    {
        
        PlayerPrefs.SetFloat("positionX", userPosition.x);

        PlayerPrefs.SetFloat("positionY", userPosition.y);

        PlayerPrefs.SetFloat("positionZ", userPosition.z);

        LoadData();
    }

    void LoadData()
    {
        userPositionText.text = "User position: " + PlayerPrefs.GetFloat("positionX", 696.3).ToString() + "x "+

                                PlayerPrefs.GetFloat("positionY", 27.6).ToString() + "y "+

                                PlayerPrefs.GetFloat("positionZ", -246.5029).ToString() + "z ";
    }


}
