using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //전역변수 사용을 위한 싱글톤 선언
    private static GameManager instance;

    public static GameManager Instance
    {
        get { return instance;  }
    }

    void Awake()
    {
        // SoundManager 인스턴스가 이미 있는지 확인, 이 상태로 설정
        if (instance == null)
            instance = this;

        // 인스턴스가 이미 있는 경우 오브젝트 제거
        else if (instance != this)
            Destroy(gameObject);

        // 소멸 방지
        DontDestroyOnLoad(gameObject);
    }

    //시작화면에서 인게임 이동하는 코드. 외부에서 사용하기 위한 public 선언.
    public void ToInGameScene()
    {
        SceneManager.LoadScene("InGame");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
