using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ��忡�� ����ǰ� �� 
[ExecuteInEditMode]
public class PostEffects : MonoBehaviour
{
    Shader myShader;        // image effect ���̴�  
    Material myMaterial;

    void Start()
    {
        // image effect shader ������ �����ϰ� 
        // �������� ��ο� ������ �Ʒ��� ���� �����߾�� �� 
        myShader = Shader.Find("My/PostEffects/DefaultShader");
        myMaterial = new Material(myShader);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }

    // ���� ������ �� ��(���� �ȼ�)�� 
    // �̹��� ȿ�� (��Ƽ����-���̴�)�� �����Ͽ�  
    // ��ǥ ��(��ǥ �ȼ�)�� ǥ���ǵ���  
    // Blit �Լ��� �̹���(������ �迭)�� ������  
    // Blit �Լ��� 0�� ǥ���� pass ��ȣ  
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, 0);
    }

}