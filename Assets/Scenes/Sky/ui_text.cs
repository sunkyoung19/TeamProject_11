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
            string name = "sky��: ��� ��ư�� ������ ���ǰ� �Բ� ��ź�ڰ� �����̸� ���� �� ��տ� ť��(���ؿ�)��\n �Ƕ�̵�(������)�� ��Ÿ����.\n �˶�� �ڽ��� ���� sphere�� ������ ground������ �̵��Ѵ�.\nground��: ��ȥ�� ��������� ����ǰ�, \n�˶��� �ڽ����� ������ �ɾ��.\n �Ƕ�̵�(�Ѽ���)�� ��Ÿ����. Windzone�� ����ȴ�.\n �ǾƳ� ���� spere�� ������ underground ������ ��ȯ�ȴ�.\nunderground��: fps��Ʈ�ѷ��� ī�޶� ���̸�, p��ư�� ������ ���ϰ� Ƣ��´�.";

            GetComponent<Text>().text = name;
        }
    }
}
