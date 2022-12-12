using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster : MonoBehaviour
{
    public bool IsDead { get; set; }

    //MOBINFO mobInfo;
    // 좌표 받아오기
    public Vector3 pos { get; set; }
    // 색상 받아오기
    public Color prefabCol { get; set; }
    // 몬스터 받아오기
    public string monster { get; set; }
    // 체력 받아오기
    public int HP { get; set; }
    // 경험치 받아오기
    public int EXP { get; set; }

    // 보스몹 패턴으로 변경하기
    // public MOBINFO MOBINFO { get { return mobInfo; } set { mobInfo = value; } }

    public void IMDEAD()
    {
        IsDead = true;
        Destroy(this.gameObject);
        UIManager.INSTANCE.Check4WhoIsWin(false);
        // 2초 뒤 몬스터 잡았다는 창 띄우기
        Invoke("UIManager.INSTANCE.RESULTSCENE()", 2f);
        // 플레이어 경험치 증가
        Player.INSTANCE.ExpUpdate(10);
    }

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.M))
        {
            AttackPlayer();
        }*/
    }
}
