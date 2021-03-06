﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COMP1288.PointClick.Jin
{
    public class Highlighter : MonoBehaviour
    {
        [SerializeField] private Material highlightMat = null;
        Material originalMat;
        MeshRenderer meshRenderer;

        private void Awake()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            originalMat = meshRenderer.material;
        }

        private void OnMouseExit()
        {
            meshRenderer.material = originalMat;
        }

        private void OnMouseOver()
        {
            meshRenderer.material = highlightMat;
        }


    }
}
