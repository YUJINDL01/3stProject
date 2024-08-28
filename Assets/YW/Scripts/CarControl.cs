using UnityEngine;

public class CarControl : MonoBehaviour
{
    ///// 실제 운전처럼 구현하기 위해
    //위쪽 방향키 = 악셀
    // D = 기어 D
    // R = 기어 R
    // 스페이스 = 브레이크

    // ⇒ D + 위쪽 방향키 = 전진
    // ⇒ R + 위쪽 방향키 = 후진
    
    
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
