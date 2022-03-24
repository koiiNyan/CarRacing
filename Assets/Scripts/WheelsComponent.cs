using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cars
{
    public class WheelsComponent : MonoBehaviour
    {
        private Transform[] _frontMeshes;
        private Transform[] _rearMeshes;

        private WheelCollider[] _frontColliders;
        private WheelCollider[] _rearColliders;
        private WheelCollider[] _allColliders;

        [SerializeField]
        private Transform _leftFrontMesh;
        [SerializeField]
        private Transform _rightFrontMesh;
        [SerializeField]
        private Transform _leftRearMesh;
        [SerializeField]
        private Transform _rightRearMesh;

        [Space, SerializeField]
        private WheelCollider _leftFrontCollider;
        [SerializeField]
        private WheelCollider _rightFrontCollider;
        [SerializeField]
        private WheelCollider _leftRearCollider;
        [SerializeField]
        private WheelCollider _rightRearCollider;


        public WheelCollider[] GetFrontWheelColliders => _frontColliders;
        public WheelCollider[] GetRearWheelColliders => _rearColliders;
        public WheelCollider[] GetAllWheelColliders => _allColliders;


        public void UpdateVisual(float angle)
        {
            for(int i=0; i < _frontMeshes.Length; i++)
            {
                _frontColliders[i].steerAngle = angle;
                _frontColliders[i].GetWorldPose(out var position, out var rotation);
                _frontMeshes[i].position = position;
                _frontMeshes[i].rotation = rotation;


                _rearColliders[i].GetWorldPose(out position, out rotation);
                _rearMeshes[i].position = position;
                _rearMeshes[i].rotation = rotation;

            }
        }


        private void Start()
        {
            _frontMeshes = new Transform[] { _leftFrontMesh, _rightFrontMesh };
            _rearMeshes = new Transform[] { _leftRearMesh, _rightRearMesh };

            _frontColliders = new WheelCollider[] { _leftFrontCollider, _rightFrontCollider };
            _rearColliders = new WheelCollider[] { _leftRearCollider, _rightRearCollider };
            _allColliders = new WheelCollider[] { _leftFrontCollider, _rightFrontCollider, _leftRearCollider, _rightRearCollider };
        }
    }
}
