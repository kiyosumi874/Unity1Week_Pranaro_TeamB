using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    // �ʒu���W
    private Vector3 position;
    // �X�N���[�����W�����[���h���W�ɕϊ������ʒu���W
    private Vector3 screenToWorldPointPosition;

    private State state = null;
    [SerializeField] private Transform playerTran;
    // Start is called before the first frame update
    void Start()
    {
        
        state = this.gameObject.AddComponent<State>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state.CompareState(State.StateType.Play))
        {
            var originToPlayer = playerTran.position - this.transform.position;
            originToPlayer = Vector3.Normalize(originToPlayer);
            var axisX = new Vector3(-1.0f, 0.0f, 0.0f);
            var radian = Mathf.Acos(Vector3.Dot(originToPlayer, axisX));
            Debug.Log(radian);
            Debug.Log(playerTran.position);
            // Vector3�Ń}�E�X�ʒu���W���擾����
            position = Input.mousePosition;
            // Z���C��
            position.z = 10f;
            // �}�E�X�ʒu���W���X�N���[�����W���烏�[���h���W�ɕϊ�����
            screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
            this.transform.position = new Vector3(screenToWorldPointPosition.x, this.transform.position.y, this.transform.position.y);
            this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, radian * (180.0f / Mathf.PI) - 90.0f);
        }
    }
}
