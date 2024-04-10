using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Robo.Grow
{
    public class RoboGrowWayPointStage2Pond : MonoBehaviour
    {
        public Image waypointIMage;
        public Transform target;
        public Camera camToUse;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float minX = waypointIMage.GetPixelAdjustedRect().width / 2;
            float maxX = Screen.width - minX;

            float minY = waypointIMage.GetPixelAdjustedRect().height / 2;
            float maxY = Screen.height - minY;

            Vector2 pos = camToUse.WorldToScreenPoint(target.position);
            if (Vector3.Dot((target.position - transform.position), transform.forward) < 0)
            {
                if(pos.x < Screen.width / 2)
                {
                    pos.x = maxX;
                }

                else
                {
                    pos.x = minX;
                }
            }

            pos.x = Mathf.Clamp(pos.x, minX, maxX);
            pos.y = Mathf.Clamp(pos.y, minY, maxY);

            waypointIMage.transform.position = pos;
        }
    }
}
