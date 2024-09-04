using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("YellowLine")) // 만약 노란선이랑 부딪치면
        {
            Debug.Log("차선 이탈");
            collisionText.text = "차선 이탈, -15점"; // 차선 이탈 Text 띄우기
            Invoke("ClearText", 3f); // 2초 뒤에 텍스트를 지우는 함수 호출
        }
        else if (other.gameObject.CompareTag("ParkSensor")) // 주차 검지선
        {
            Debug.Log("검지선 접촉");
            collisionText.text = "주차 검지선 접촉, -10점";
            Invoke("ClearText", 3f);
        }
        
      
        
        
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Stone"))  // 연석 탑승
        {
            Debug.Log("연석 탑승");
            collisionText.text = "바퀴가 연석에 접촉할 시 실격입니다.";
            Invoke("ClearText", 3f);
        }
        
        
        
    }


    private void ClearText()
    {
        if (collisionText != null)
        {
            collisionText.text = ""; // 텍스트를 빈 문자열로 설정하여 지우기
        }
    }
    
    
    
    
    
    
    
    
    
    // Switch 써서 각 Case별로 나눠서 태그에 해당하는 UI 띄우기
    // trigger 통해서 나와야 하는 태그들
    // "안전벨트 미착용 시 실격입니다"
    // "바퀴가 연석에 접촉할 시 실격입니다." o
    // "출발 신호 위반 실격입니다."
    // "신호 위반 실격입니다."
    
    
    // "차선 이탈 -15점" o 
    
    // 돌발 시 급정지 미이행 -10점
    // 가속 미이행 -10점
    // (주차)검지선 접촉 -10점, 주차브레이크 미이행 -10점
    
    // 음성지시 미종료 시 차량 조작 -5점
    
    // 과속 -3점
  
   
    
    
    
    
    
}
