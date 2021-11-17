using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Vector 사용: 위치벡터= 좌표로 인식 & 방향백터
struct MyVector
{
    public float x;
    public float y;
    public float z;
    
    public MyVector(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }
}
public class PlayerController : MonoBehaviour
{
    [SerializeField]   //SerializeField을 붙이면 속도 수치 변경가능
    float _speed = 10.0f;
   
    void Start()
    {
        
    }

 
    void Update()  // 한 프레임당 호출 되는 함수
    {
        // 거리를 구하는 법: Time.deltaTime(시간)*(속도)
        //Time.deltaTime: 지난시간 이후 경과된 프레임
        //World 좌표계: transform.position    &  Local좌표계: Vector3.forward
        //TransformDirection : Local--> World  && InverseTransformDirection: World --> Local


        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.S))
            transform.position += transform.TransformDirection(Vector3.back * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.A))
            transform.position += transform.TransformDirection(Vector3.left * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.TransformDirection(Vector3.right * Time.deltaTime * _speed);

    }
}

