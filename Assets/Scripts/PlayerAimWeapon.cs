using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimWeapon : MonoBehaviour
{
    public Transform aimTransform;
    public Transform Firepoint;

    public GameObject bullet;

    public Vector3 aimDirection;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleAiming();
        HandleShooting();
    }

    private void HandleAiming(){
        Vector3 mousePosition = GetMouseWorldPostion();
        aimDirection = (mousePosition - aimTransform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0,0,angle);
    }

    private void HandleShooting(){
        if(Input.GetMouseButtonDown(0)){
            Shoot();
        }
    }
    public static Vector3 GetMouseWorldPostion(){
        Vector3 vec = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        vec.z = 0f;
        return vec;
    }

    void Shoot(){
        Instantiate(bullet, Firepoint.position, Firepoint.rotation);
        Debug.Log("working");
    }
}
