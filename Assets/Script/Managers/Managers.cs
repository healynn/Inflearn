using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; //유일성이 보장됨 
    public static Managers Instance { get { Init(); /*instance가 null일때 Init함수 실행*/ return s_instance; } }//유일한 매니저를 가지고 오는 함수:GetInstance

   
    void Start()
    {
        Init();
    }

 
    void Update()
    {
        
    }
    static void Init()
    {
        if(s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null) //Manager라는 gameobject를 생성하지 않을 때 사용
            {
                go = new GameObject { name = "@Managers" };   // unity상에서 Create empty --> GameObject를 만들어 @Managers라는 이름으로 변경을 코딩으로 제작
                go.AddComponent<Managers>(); // Managers script추가 코딩
            }

            DontDestroyOnLoad(go); // 왠만해서 삭제되지 않음
            s_instance = go.GetComponent<Managers>();
        }
    }
}
