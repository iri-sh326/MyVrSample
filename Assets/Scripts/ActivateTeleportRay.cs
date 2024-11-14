using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVrSample
{
    /// <summary>
    /// Teleport Ray를 관리하는 클래스
    /// </summary>
    public class ActivateTeleportRay : MonoBehaviour
    {
        #region Variables
        public GameObject leftTeleportRay;          // 텔레포트 Ray 오브젝트
        public GameObject rightTeleportRay;

        public InputActionProperty leftActivate;    // 컨트롤러의 activate 입력
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
