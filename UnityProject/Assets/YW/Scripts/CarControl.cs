using UnityEngine;

public class CarControl : MonoBehaviour
{
    
    ///// 실제 자동차처럼 기어와 악셀을 같이 실행해야 움직이도록 구현
    /// 위쪽 방향키 = 악셀
    /// D = 기어 D
    /// R = 기어 R
    /// Space = 브레이크
    
    
    
   
    public float moveSpeed = 5f; // 이동 속도

    void Update()
    {
        // 이동 벡터 초기화
        Vector3 moveDirection = Vector3.zero;

        // 위쪽 방향키와 D를 동시에 누를 때
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.D))
        {
            moveDirection = Vector3.forward;
        }
        // 위쪽 방향키와 R을 동시에 누를 때
        else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.R))
        {
            moveDirection = Vector3.back;
        }

        // 스페이스바를 누를 때 이동 중지
        if (Input.GetKey(KeyCode.Space))
        {
            moveDirection = Vector3.zero;
        }

        // 이동 처리
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
    
    
    
    
    
}
