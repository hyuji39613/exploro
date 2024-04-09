using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public GameObject player;
    void Update()
    {      
        // x 좌표 값이 +/- 0.5 범위 내에 있는지 확인
        if (player.transform.position.x >= transform.position.x - 0.5 &&
        player.transform.position.x <= transform.position.x + 0.5 && 
        player.transform.position.y < transform.position.y)
        {
            // 오브젝트 삭제
            Destroy(gameObject);
        }  
    }
}