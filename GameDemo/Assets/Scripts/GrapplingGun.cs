using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingGun : MonoBehaviour
{

    //public static bool GameIsPaused = false;
    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask whatIsGrappleable;
    public Transform gunTip, camera, player;
    private float maxDistance = 100f;
    private SpringJoint joint;
    private bool canGrapple;

    //Sound
    AudioSource m_MyAudioSource;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Start() {
        m_MyAudioSource = GetComponent<AudioSource>();
        StartCoroutine(grappleWait());
        canGrapple = false;
    }

    void Update()
    {

        // if(Input.GetKeyDown(KeyCode.Escape)){
        //     if (GameIsPaused){
        //             GameIsPaused = false;
        //         }
        //         else{
        //             GameIsPaused = true;
        //         }
        // }

        if(!PauseMenu.GameIsPaused && canGrapple == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                StartGrapple();
            }
            else if (Input.GetMouseButtonUp(1))
            {
                StopGrapple();
            }
        }

    }

    IEnumerator grappleWait()
    {
        yield return new WaitForSeconds(1f);
        canGrapple = true;
    }

    void LateUpdate()
    {
        DrawRope();
    }


    void StartGrapple()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.position, camera.forward, out hit, maxDistance, whatIsGrappleable))
        {
            m_MyAudioSource.Play();
            grapplePoint = hit.point;
            joint = player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = grapplePoint;

            float distanceFromPoint = Vector3.Distance(player.position, grapplePoint);

            joint.maxDistance = distanceFromPoint * 0.8f;
            joint.minDistance = distanceFromPoint * 0.25f;

            joint.spring = 4.5f;
            joint.damper = 7f;
            joint.massScale = 4.5f;

            lr.positionCount = 2;
        }
    }

    void StopGrapple()
    {
        m_MyAudioSource.Stop();
        lr.positionCount = 0;
        Destroy(joint);
    }

    void DrawRope()
    {
        //If not grappling, don't draw rope
        if (!joint) return;

        lr.SetPosition(0, gunTip.position);
        lr.SetPosition(1, grapplePoint);
    }

    public bool IsGrappling()
    {
        return joint != null;
    }

    public Vector3 getGrapplePoint()
    {
        return grapplePoint;
    }

}
