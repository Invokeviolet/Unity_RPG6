using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster : MonoBehaviour
{
    public bool IsDead { get; set; }

    //MOBINFO mobInfo;
    // ��ǥ �޾ƿ���
    public Vector3 pos { get; set; }
    // ���� �޾ƿ���
    public Color prefabCol { get; set; }
    // ���� �޾ƿ���
    public string monster { get; set; }
    // ü�� �޾ƿ���
    public int HP { get; set; }
    // ����ġ �޾ƿ���
    public int EXP { get; set; }

    // ������ �������� �����ϱ�
    // public MOBINFO MOBINFO { get { return mobInfo; } set { mobInfo = value; } }

    public void IMDEAD()
    {
        IsDead = true;
        Destroy(this.gameObject);
        UIManager.INSTANCE.Check4WhoIsWin(false);
        // 2�� �� ���� ��Ҵٴ� â ����
        Invoke("UIManager.INSTANCE.RESULTSCENE()", 2f);
        // �÷��̾� ����ġ ����
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
