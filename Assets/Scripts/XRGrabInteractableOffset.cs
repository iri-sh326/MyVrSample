using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace MyVrSample
{
    /// <summary>
    /// ������Ʈ�� ���� �� ������ ��ġ ����
    /// </summary>
    public class XRGrabInteractableOffset : XRGrabInteractable
    {
        #region Variables
        private GameObject attachPoint;

        private Vector3 initialLocalPosition;
        private Quaternion initialLocalRotation;
        #endregion

        private void Start()
        {
            if(attachTransform == null)
            {
                attachPoint = new GameObject("Offset Grab Pivot");
                attachPoint.transform.SetParent(transform, false);
                attachTransform = attachPoint.transform;
            }
            else
            {
                initialLocalPosition = attachTransform.localPosition;
                initialLocalRotation = attachTransform.localRotation;
            }
        }

        //protected override void OnSelectEntering(SelectEnterEventArgs args)
        //{
        //    attachTransform.position = args.interactorObject.transform.position;
        //    attachTransform.rotation = args.interactorObject.transform.rotation;

        //    base.OnSelectEntered(args);
        //}


        protected override void OnSelectEntered(SelectEnterEventArgs args)
        {
            if(args.interactorObject is XRDirectInteractor)
            {
                attachTransform.position = args.interactorObject.transform.position;
                attachTransform.rotation = args.interactorObject.transform.rotation;
            }
            else
            {
                attachTransform.localPosition = initialLocalPosition;
                attachTransform.localRotation = initialLocalRotation;
            }
            

            base.OnSelectEntered(args);
        }

    }
}

