using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVrSample
{
    /// <summary>
    /// Teleport Ray�� �����ϴ� Ŭ����
    /// </summary>
    public class ActivateTeleportRay : MonoBehaviour
    {
        #region Variables
        public GameObject leftTeleportRay;          // �ڷ���Ʈ Ray ������Ʈ
        public GameObject rightTeleportRay;

        public InputActionProperty leftActivate;    // ��Ʈ�ѷ��� activate �Է�
        public InputActionProperty rightActivate;
        #endregion

        private void Update()
        {
            float leftActivateValue = leftActivate.action.ReadValue<float>();
            float rightActivateValue = rightActivate.action.ReadValue<float>();

            leftTeleportRay.SetActive(leftActivateValue > 0.1f);
            rightTeleportRay.SetActive(rightActivateValue > 0.1f);
        }
    }

}
