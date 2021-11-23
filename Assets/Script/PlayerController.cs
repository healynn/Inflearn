using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Vector 사용: 위치벡터= 좌표로 인식 & 방향백터
struct MyVector
{
    public float x;
    public float y;
    public float z;
    

    // public abstract ;


    public float magnitude { get { return Mathf.Sqrt( x * x + y * y + z * z); } }  //피타고라스의 정의를 알면 된다
    public MyVector normalized { get { return new MyVector(x / magnitude, y / magnitude, z / magnitude); } }
    
    public MyVector(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }

    public static MyVector  operator  + (MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    public static MyVector operator * (MyVector a, float d)
    {
        return new MyVector(a.x * d, a.y * d, a.z * d);
    }
}
public class PlayerController : MonoBehaviour
{
    [SerializeField]   //SerializeField을 붙이면 속도 수치 변경가능
    float _speed = 10.0f;
   
    void Start()
    {
        // 방향백터는 방향성 ==> normalized
        // 크기(=거리)를 알 수 있다 ==> Magnitude


        MyVector to = new MyVector(10.0f, 0.0f, 0.0f);
        MyVector form = new MyVector(5.0f, 0.0f, 0.0f);
        MyVector dir = to- form;  // {5.0f, 0.0f, 0.0f} 

        dir = dir.normalized;

        MyVector newPos = form + dir * _speed;
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
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * _speed);

    }
}

