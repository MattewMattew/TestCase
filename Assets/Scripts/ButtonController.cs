using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject panel;
    public GameObject inputFieldTime;
    public GameObject inputFieldSpeed;
    public GameObject inputFieldDistance;
    public void onClick(){
        Text txtButton = transform.Find("Text").GetComponent<Text>();
        if(panel.activeSelf == false){
            panel.SetActive(true);
            inputFieldTime.SetActive(true);
            inputFieldSpeed.SetActive(true);
            inputFieldDistance.SetActive(true);
            txtButton.text = "ПРИМЕНИТЬ";
            Time.timeScale = 0f;
        }
        else{
            Time.timeScale = 1f;
            txtButton.text = "НАСТРОЙКИ";
            panel.SetActive(false);
            inputFieldTime.SetActive(false);
            inputFieldSpeed.SetActive(false);
            inputFieldDistance.SetActive(false);
        }
    }
}
