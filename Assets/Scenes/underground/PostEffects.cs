using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 편집 모드에서 실행되게 함 
[ExecuteInEditMode]
public class PostEffects : MonoBehaviour
{
    Shader myShader;        // image effect 셰이더  
    Material myMaterial;

    void Start()
    {
        // image effect shader 파일을 생성하고 
        // 셰이터의 경로와 파일을 아래와 같이 수정했어야 함 
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

    // 현재 렌더링 된 씬(원본 픽셀)에 
    // 이미지 효과 (머티리얼-셰이더)를 적용하여  
    // 목표 씬(목표 픽셀)에 표현되도록  
    // Blit 함수로 이미지(데이터 배열)를 복사함  
    // Blit 함수의 0은 표시할 pass 번호  
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, 0);
    }

}