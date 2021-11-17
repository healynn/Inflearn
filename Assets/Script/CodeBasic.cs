using UnityEngine;

public class CodeBasic : MonoBehaviour
{
    string name = "박혜린";
    /*int brithday = 970603;
   string Address = "삼선교로 12길 27";
   float i = 3.14f;
   bool a; */

   
   

    void Start()
    {
        int num = 0;

        Debug.Log(name);
        Debug.Log(num);
        Debug.Log("안녕하세요");
        for(num=0; num<2; num++)
        {
            Debug.Log(num);
        }
        
        for( int a=0; a<5; a++)
        {
            for(int b=0; b<5; b++)
            {
                int result = a * b;
                Debug.Log(result);
            }
        }
    }
}
// ctrl은 점이나 공백, 특수문자 단위로 넘어감 
// shift 드래그 기능
// home은 맨 앞  && End 맨 뒤
//F12은 Adress알기 && shift+F12 참조
// ctrl+-

