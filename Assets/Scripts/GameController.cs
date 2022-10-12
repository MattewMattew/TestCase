using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject prefabCube;
    private Vector3 target;
    private float timer;
    private float time;
    private float speed;
    private float distance;
    private GameObject createdCube;
    public GameObject GOTime;
    public GameObject GOSpeed;
    public GameObject GODistance;
    void Update()
    {
        if(GOTime != null){
            if(GOTime.GetComponent<Text>().text != "" && GOSpeed.GetComponent<Text>().text != "" && GODistance.GetComponent<Text>().text != ""){
                time = float.Parse(GOTime.GetComponent<Text>().text);
                speed = float.Parse(GOSpeed.GetComponent<Text>().text);
                distance = float.Parse(GODistance.GetComponent<Text>().text);
                if(timer > time){
                    timer = 0;
                    var createdCube = Instantiate(prefabCube, transform.position, Quaternion.identity).GetComponent<CubeController>();
                    target = new Vector3(
                        0,
                        1,
                        distance
                    );
                    createdCube.target = target;
                    createdCube.speed = speed;
                }
                else{
                    timer = timer + Time.deltaTime;
                }
            }
        }
    }
}
