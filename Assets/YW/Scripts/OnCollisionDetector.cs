using System;
using TMPro;
using UnityEngine;

public class OnCollisionDetector : MonoBehaviour
{
   
    // Collider 설정하고
    // On Collision Enter, OnTriggerEnter 통해서 작성


    public TMP_Text collisionText; // 불러올 텍스트 변수 지정

    private void Start()
    {
        if (collisionText != null)  // 텍스트가 비어있지 않을 떄
        {
            collisionText.text = "";  // 게임 시작 시 텍스트 비워두기
        }
    }


    private void OnTriggerEnter(Collider yelloLine)
    {
        if (yelloLine.gameObject.CompareTag("YellowLine")) // 만약 노란선이랑 부딪치면
        {
            Debug.Log("중앙선 침범 감점");
            collisionText.text = "중앙선 침범, -5점 감점"; // 중앙섬 침범 Text 띄우기
            Invoke("ClearText", 2f); // 2초 뒤에 텍스트를 지우는 함수 호출
        }   
        
    }
    

    private void ClearText()
    {
        if (collisionText != null)
        {
            collisionText.text = ""; // 텍스트를 빈 문자열로 설정하여 지우기
        }
    }
    
    
    
    
    
}
