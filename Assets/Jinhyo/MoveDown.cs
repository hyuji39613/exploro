using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public GameObject player;
    void Update()
    {      
        // x ��ǥ ���� +/- 0.5 ���� ���� �ִ��� Ȯ��
        if (player.transform.position.x >= transform.position.x - 0.5 &&
        player.transform.position.x <= transform.position.x + 0.5 && 
        player.transform.position.y < transform.position.y)
        {
            // ������Ʈ ����
            Destroy(gameObject);
        }  
    }
}