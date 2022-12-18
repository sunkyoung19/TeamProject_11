using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_text : MonoBehaviour
{
    public GameObject MyGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            string name = "sky씬: 재생 버튼을 누르면 음악과 함께 양탄자가 움직이며 양쪽 끝 기둥에 큐브(이해역)와\n 피라미드(조수연)이 나타난다.\n 알라딘 자스민 뒤의 sphere를 누르면 ground씬으로 이동한다.\nground씬: 결혼식 배경음악이 재생되고, \n알라딘과 자스민이 앞으로 걸어간다.\n 피라미드(한선경)가 나타난다. Windzone이 실행된다.\n 피아노 옆의 spere을 누르면 underground 씬으로 변환된다.\nunderground씬: fps컨트롤러의 카메라가 보이며, p버튼을 누르면 지니가 튀어나온다.";

            GetComponent<Text>().text = name;
        }
    }
}
