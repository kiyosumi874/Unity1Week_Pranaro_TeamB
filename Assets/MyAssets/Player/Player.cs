using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float lerpPower = 5.0f;
    [SerializeField] private SceneChanger sceneChanger = null;
    [SerializeField] private StateManager stateManager = null;
    [SerializeField] private O2Gauge o2Gauge = null;

    // �ʒu���W
    private Vector3 position;
    // �X�N���[�����W�����[���h���W�ɕϊ������ʒu���W
    private Vector3 screenToWorldPointPosition;
    private State state = null;

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
            // Vector3�Ń}�E�X�ʒu���W���擾����
            position = Input.mousePosition;
            // Z���C��
            position.z = 10f;
            // �}�E�X�ʒu���W���X�N���[�����W���烏�[���h���W�ɕϊ�����
            screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
            var posX = Vector3.Lerp(this.transform.position, screenToWorldPointPosition, Time.deltaTime * lerpPower).x;
            // ���[���h���W�ɕϊ����ꂽ�}�E�X���W����
            this.transform.position = new Vector3(posX, this.transform.position.y, this.transform.position.z);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal"))
        {
            collision.enabled = false;
            stateManager.SetStateAll(State.StateType.Stop);
            sceneChanger.ChangeScene();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        o2Gauge.ChangeO2Gauge(-0.2f);
    }

}
