using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    //버튼 이벤트로 실행되는 게임 일시정지 및 실행 함수
    public void Pause()
    {
            Time.timeScale = 0;
    }

    public void Continue()
    {
        Time.timeScale = 1;
    }
}
