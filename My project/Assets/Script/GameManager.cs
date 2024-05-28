using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //�������� ����� ���� �̱��� ����
    private static GameManager instance;

    public static GameManager Instance
    {
        get { return instance;  }
    }

    void Awake()
    {
        // SoundManager �ν��Ͻ��� �̹� �ִ��� Ȯ��, �� ���·� ����
        if (instance == null)
            instance = this;

        // �ν��Ͻ��� �̹� �ִ� ��� ������Ʈ ����
        else if (instance != this)
            Destroy(gameObject);

        // �Ҹ� ����
        DontDestroyOnLoad(gameObject);
    }

    //����ȭ�鿡�� �ΰ��� �̵��ϴ� �ڵ�. �ܺο��� ����ϱ� ���� public ����.
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
