using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class controlLight : MonoBehaviour
{    
    //Line1(SL*7, CL*4)
    Light SL_L1_no1;
    Light SL_L1_no2;
    Light SL_L1_no3;
    Light SL_L1_no4;
    Light SL_L1_no5;
    Light SL_L1_no6;
    Light SL_L1_no7;
    Light CL_L1_no1;
    Light CL_L1_no2;
    Light CL_L1_no3;
    Light CL_L1_no4;

    //Line2(SL*5)
    Light SL_L2_no1;
    Light SL_L2_no2;
    Light SL_L2_no3;
    Light SL_L2_no4;
    Light SL_L2_no5;

    //Line3(SL*8, CL*5)
    Light SL_L3_no1;
    Light SL_L3_no2;
    Light SL_L3_no3;
    Light SL_L3_no4;
    Light SL_L3_no5;
    Light SL_L3_no6;
    Light SL_L3_no7;
    Light SL_L3_no8;
    Light CL_L3_no1;
    Light CL_L3_no2;
    Light CL_L3_no3;
    Light CL_L3_no4;
    Light CL_L3_no5;
    Light CL_L3_no6;

    //Line4(SL_S*5, SL_B*4)
    Light SL_L4_s_no1;
    Light SL_L4_s_no2;
    Light SL_L4_s_no3;
    Light SL_L4_s_no4;
    Light SL_L4_s_no5;
    Light SL_L4_b_no1;
    Light SL_L4_b_no2;
    Light SL_L4_b_no3;
    Light SL_L4_b_no4;



    // Start is called before the first frame update
    void Start()
    {
        // Line1
        SL_L1_no1 = GameObject.Find("SL_L1_no1").GetComponent<Light>();
        SL_L1_no2 = GameObject.Find("SL_L1_no2").GetComponent<Light>();
        SL_L1_no3 = GameObject.Find("SL_L1_no3").GetComponent<Light>();
        SL_L1_no4 = GameObject.Find("SL_L1_no4").GetComponent<Light>();
        SL_L1_no5 = GameObject.Find("SL_L1_no5").GetComponent<Light>();
        SL_L1_no6 = GameObject.Find("SL_L1_no6").GetComponent<Light>();
        SL_L1_no7 = GameObject.Find("SL_L1_no7").GetComponent<Light>();

        CL_L1_no1 = GameObject.Find("CL_L1_no1").GetComponent<Light>();
        CL_L1_no2 = GameObject.Find("CL_L1_no2").GetComponent<Light>();
        CL_L1_no3 = GameObject.Find("CL_L1_no3").GetComponent<Light>();
        CL_L1_no4 = GameObject.Find("CL_L1_no4").GetComponent<Light>();

        //Line2
        SL_L2_no1 = GameObject.Find("SL_L2_no1").GetComponent<Light>();
        SL_L2_no2 = GameObject.Find("SL_L2_no2").GetComponent<Light>();
        SL_L2_no3 = GameObject.Find("SL_L2_no3").GetComponent<Light>();
        SL_L2_no4 = GameObject.Find("SL_L2_no4").GetComponent<Light>();
        SL_L2_no5 = GameObject.Find("SL_L2_no5").GetComponent<Light>();

        //Line3
        SL_L3_no1 = GameObject.Find("SL_L3_no1").GetComponent<Light>();
        SL_L3_no2 = GameObject.Find("SL_L3_no2").GetComponent<Light>();
        SL_L3_no3 = GameObject.Find("SL_L3_no3").GetComponent<Light>();
        SL_L3_no4 = GameObject.Find("SL_L3_no4").GetComponent<Light>();
        SL_L3_no5 = GameObject.Find("SL_L3_no5").GetComponent<Light>();
        SL_L3_no6 = GameObject.Find("SL_L3_no6").GetComponent<Light>();
        SL_L3_no7 = GameObject.Find("SL_L3_no7").GetComponent<Light>();
        SL_L3_no8 = GameObject.Find("SL_L3_no8").GetComponent<Light>();

        CL_L3_no1 = GameObject.Find("CL_L3_no1").GetComponent<Light>();
        CL_L3_no2 = GameObject.Find("CL_L3_no2").GetComponent<Light>();
        CL_L3_no3 = GameObject.Find("CL_L3_no3").GetComponent<Light>();
        CL_L3_no4 = GameObject.Find("CL_L3_no4").GetComponent<Light>();
        CL_L3_no5 = GameObject.Find("CL_L3_no5").GetComponent<Light>();
        CL_L3_no6 = GameObject.Find("CL_L3_no6").GetComponent<Light>();

        //Line4
        SL_L4_s_no1 = GameObject.Find("SL_L4_s_no1").GetComponent<Light>();
        SL_L4_s_no2 = GameObject.Find("SL_L4_s_no2").GetComponent<Light>();
        SL_L4_s_no3 = GameObject.Find("SL_L4_s_no3").GetComponent<Light>();
        SL_L4_s_no4 = GameObject.Find("SL_L4_s_no4").GetComponent<Light>();
        SL_L4_s_no5 = GameObject.Find("SL_L4_s_no5").GetComponent<Light>();
        SL_L4_b_no1 = GameObject.Find("SL_L4_b_no1").GetComponent<Light>();
        SL_L4_b_no2 = GameObject.Find("SL_L4_b_no2").GetComponent<Light>();
        SL_L4_b_no3 = GameObject.Find("SL_L4_b_no3").GetComponent<Light>();
        SL_L4_b_no4 = GameObject.Find("SL_L4_b_no4").GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad0)){ //every light off

            //line1(SL*7, CL*4)
            SL_L1_no1.enabled = !SL_L1_no1.enabled;
            SL_L1_no2.enabled = !SL_L1_no2.enabled;
            SL_L1_no3.enabled = !SL_L1_no3.enabled;
            SL_L1_no4.enabled = !SL_L1_no4.enabled;
            SL_L1_no5.enabled = !SL_L1_no5.enabled;
            SL_L1_no6.enabled = !SL_L1_no6.enabled;
            SL_L1_no7.enabled = !SL_L1_no7.enabled;

            CL_L1_no1.enabled = !CL_L1_no1.enabled;
            CL_L1_no2.enabled = !CL_L1_no2.enabled;
            CL_L1_no3.enabled = !CL_L1_no3.enabled;
            CL_L1_no4.enabled = !CL_L1_no4.enabled;

            //line2(SL*5)
            SL_L2_no1.enabled = !SL_L2_no1.enabled;
            SL_L2_no2.enabled = !SL_L2_no2.enabled;
            SL_L2_no3.enabled = !SL_L2_no3.enabled;
            SL_L2_no4.enabled = !SL_L2_no4.enabled;
            SL_L2_no5.enabled = !SL_L2_no5.enabled;

            //line3(SL*8, CL*5)
            SL_L3_no1.enabled = !SL_L3_no1.enabled;
            SL_L3_no2.enabled = !SL_L3_no2.enabled;
            SL_L3_no3.enabled = !SL_L3_no3.enabled;
            SL_L3_no4.enabled = !SL_L3_no4.enabled;
            SL_L3_no5.enabled = !SL_L3_no5.enabled;
            SL_L3_no6.enabled = !SL_L3_no6.enabled;
            SL_L3_no7.enabled = !SL_L3_no7.enabled;
            SL_L3_no8.enabled = !SL_L3_no8.enabled;

            CL_L3_no1.enabled = !CL_L3_no1.enabled;
            CL_L3_no2.enabled = !CL_L3_no2.enabled;
            CL_L3_no3.enabled = !CL_L3_no3.enabled;
            CL_L3_no4.enabled = !CL_L3_no4.enabled;
            CL_L3_no5.enabled = !CL_L3_no5.enabled;
            CL_L3_no6.enabled = !CL_L3_no6.enabled;


            //line4(sl_s*5, sl_b*4)
            SL_L4_s_no1.enabled = !SL_L4_s_no1.enabled;
            SL_L4_s_no2.enabled = !SL_L4_s_no2.enabled;
            SL_L4_s_no3.enabled = !SL_L4_s_no3.enabled;
            SL_L4_s_no4.enabled = !SL_L4_s_no4.enabled;
            SL_L4_s_no5.enabled = !SL_L4_s_no5.enabled;
            SL_L4_b_no1.enabled = !SL_L4_b_no1.enabled;
            SL_L4_b_no2.enabled = !SL_L4_b_no2.enabled;
            SL_L4_b_no3.enabled = !SL_L4_b_no3.enabled;
            SL_L4_b_no4.enabled = !SL_L4_b_no4.enabled;

        }
        else if(Input.GetKeyDown(KeyCode.Keypad1)){
            //line1(SL*7, CL*4)
            SL_L1_no1.enabled = !SL_L1_no1.enabled;
            //SL_L1_no2.enabled = !SL_L1_no2.enabled;
            //SL_L1_no3.enabled = !SL_L1_no3.enabled;
            SL_L1_no4.enabled = !SL_L1_no4.enabled;
            //SL_L1_no5.enabled = !SL_L1_no5.enabled;
            //SL_L1_no6.enabled = !SL_L1_no6.enabled;
            SL_L1_no7.enabled = !SL_L1_no7.enabled;

            CL_L1_no1.enabled = !CL_L1_no1.enabled;
            CL_L1_no2.enabled = !CL_L1_no2.enabled;
            CL_L1_no3.enabled = !CL_L1_no3.enabled;
            CL_L1_no4.enabled = !CL_L1_no4.enabled;

            //line2(SL*5)
            SL_L2_no1.enabled = !SL_L2_no1.enabled;
            SL_L2_no2.enabled = !SL_L2_no2.enabled;
            SL_L2_no3.enabled = !SL_L2_no3.enabled;
            SL_L2_no4.enabled = !SL_L2_no4.enabled;
            SL_L2_no5.enabled = !SL_L2_no5.enabled;

            //line3(SL*8, CL*5)
            SL_L3_no1.enabled = !SL_L3_no1.enabled;
            SL_L3_no2.enabled = !SL_L3_no2.enabled;
            //SL_L3_no3.enabled = !SL_L3_no3.enabled;
            SL_L3_no4.enabled = !SL_L3_no4.enabled;
            //SL_L3_no5.enabled = !SL_L3_no5.enabled;
            SL_L3_no6.enabled = !SL_L3_no6.enabled;
            SL_L3_no7.enabled = !SL_L3_no7.enabled;
            SL_L3_no8.enabled = !SL_L3_no8.enabled;

            CL_L3_no1.enabled = !CL_L3_no1.enabled;
            CL_L3_no2.enabled = !CL_L3_no2.enabled;
            CL_L3_no3.enabled = !CL_L3_no3.enabled;
            CL_L3_no4.enabled = !CL_L3_no4.enabled;
            CL_L3_no5.enabled = !CL_L3_no5.enabled;
            CL_L3_no6.enabled = !CL_L3_no6.enabled;

            //line4(sl_s*5, sl_b*4)
            SL_L4_s_no1.enabled = !SL_L4_s_no1.enabled;
            SL_L4_s_no2.enabled = !SL_L4_s_no2.enabled;
            SL_L4_s_no3.enabled = !SL_L4_s_no3.enabled;
            SL_L4_s_no4.enabled = !SL_L4_s_no4.enabled;
            SL_L4_s_no5.enabled = !SL_L4_s_no5.enabled;
            SL_L4_b_no1.enabled = !SL_L4_b_no1.enabled;
            SL_L4_b_no2.enabled = !SL_L4_b_no2.enabled;
            SL_L4_b_no3.enabled = !SL_L4_b_no3.enabled;
            SL_L4_b_no4.enabled = !SL_L4_b_no4.enabled;


        }

        else if(Input.GetKeyDown(KeyCode.Keypad2)){
            //line1(SL*7, CL*4)
            SL_L1_no1.enabled = !SL_L1_no1.enabled;
            SL_L1_no2.enabled = !SL_L1_no2.enabled;
            SL_L1_no3.enabled = !SL_L1_no3.enabled;
            SL_L1_no4.enabled = !SL_L1_no4.enabled;
            SL_L1_no5.enabled = !SL_L1_no5.enabled;
            SL_L1_no6.enabled = !SL_L1_no6.enabled;
            SL_L1_no7.enabled = !SL_L1_no7.enabled;

            /*
            CL_L1_no1.enabled = !CL_L1_no1.enabled;
            CL_L1_no2.enabled = !CL_L1_no2.enabled;
            CL_L1_no3.enabled = !CL_L1_no3.enabled;
            CL_L1_no4.enabled = !CL_L1_no4.enabled;
            */


            //line2(SL*5)
            SL_L2_no1.enabled = !SL_L2_no1.enabled;
            SL_L2_no2.enabled = !SL_L2_no2.enabled;
            SL_L2_no3.enabled = !SL_L2_no3.enabled;
            SL_L2_no4.enabled = !SL_L2_no4.enabled;
            SL_L2_no5.enabled = !SL_L2_no5.enabled;

            //line3(SL*8, CL*5)
            SL_L3_no1.enabled = !SL_L3_no1.enabled;
            SL_L3_no2.enabled = !SL_L3_no2.enabled;
            SL_L3_no3.enabled = !SL_L3_no3.enabled;
            SL_L3_no4.enabled = !SL_L3_no4.enabled;
            SL_L3_no5.enabled = !SL_L3_no5.enabled;
            SL_L3_no6.enabled = !SL_L3_no6.enabled;
            SL_L3_no7.enabled = !SL_L3_no7.enabled;
            SL_L3_no8.enabled = !SL_L3_no8.enabled;

            /*
            CL_L3_no1.enabled = !CL_L3_no1.enabled;
            CL_L3_no2.enabled = !CL_L3_no2.enabled;
            CL_L3_no3.enabled = !CL_L3_no3.enabled;
            CL_L3_no4.enabled = !CL_L3_no4.enabled;
            CL_L3_no5.enabled = !CL_L3_no5.enabled;
            CL_L3_no6.enabled = !CL_L3_no6.enabled;
            */

            //line4(sl_s*5, sl_b*4)
            SL_L4_s_no1.enabled = !SL_L4_s_no1.enabled;
            SL_L4_s_no2.enabled = !SL_L4_s_no2.enabled;
            SL_L4_s_no3.enabled = !SL_L4_s_no3.enabled;
            SL_L4_s_no4.enabled = !SL_L4_s_no4.enabled;
            SL_L4_s_no5.enabled = !SL_L4_s_no5.enabled;
            SL_L4_b_no1.enabled = !SL_L4_b_no1.enabled;
            SL_L4_b_no2.enabled = !SL_L4_b_no2.enabled;
            SL_L4_b_no3.enabled = !SL_L4_b_no3.enabled;
            SL_L4_b_no4.enabled = !SL_L4_b_no4.enabled;
        }

        else if(Input.GetKeyDown(KeyCode.Keypad3)){
            //line1(SL*7, CL*4)
            SL_L1_no1.enabled = !SL_L1_no1.enabled;
            SL_L1_no2.enabled = !SL_L1_no2.enabled;
            SL_L1_no3.enabled = !SL_L1_no3.enabled;
            SL_L1_no4.enabled = !SL_L1_no4.enabled;
            SL_L1_no5.enabled = !SL_L1_no5.enabled;
            SL_L1_no6.enabled = !SL_L1_no6.enabled;
            SL_L1_no7.enabled = !SL_L1_no7.enabled;

            CL_L1_no1.enabled = !CL_L1_no1.enabled;
            CL_L1_no2.enabled = !CL_L1_no2.enabled;
            CL_L1_no3.enabled = !CL_L1_no3.enabled;
            CL_L1_no4.enabled = !CL_L1_no4.enabled;

            //line2(SL*5)
            SL_L2_no1.enabled = !SL_L2_no1.enabled;
            SL_L2_no2.enabled = !SL_L2_no2.enabled;
            //SL_L2_no3.enabled = !SL_L2_no3.enabled;
            SL_L2_no4.enabled = !SL_L2_no4.enabled;
            SL_L2_no5.enabled = !SL_L2_no5.enabled;

            //line3(SL*8, CL*5)
            SL_L3_no1.enabled = !SL_L3_no1.enabled;
            SL_L3_no2.enabled = !SL_L3_no2.enabled;
            SL_L3_no3.enabled = !SL_L3_no3.enabled;
            SL_L3_no4.enabled = !SL_L3_no4.enabled;
            SL_L3_no5.enabled = !SL_L3_no5.enabled;
            SL_L3_no6.enabled = !SL_L3_no6.enabled;
            SL_L3_no7.enabled = !SL_L3_no7.enabled;
            SL_L3_no8.enabled = !SL_L3_no8.enabled;

            CL_L3_no1.enabled = !CL_L3_no1.enabled;
            CL_L3_no2.enabled = !CL_L3_no2.enabled;
            CL_L3_no3.enabled = !CL_L3_no3.enabled;
            CL_L3_no4.enabled = !CL_L3_no4.enabled;
            CL_L3_no5.enabled = !CL_L3_no5.enabled;
            CL_L3_no6.enabled = !CL_L3_no6.enabled;


            //line4(sl_s*5, sl_b*4)
            SL_L4_s_no1.enabled = !SL_L4_s_no1.enabled;
            SL_L4_s_no2.enabled = !SL_L4_s_no2.enabled;
            SL_L4_s_no3.enabled = !SL_L4_s_no3.enabled;
            SL_L4_s_no4.enabled = !SL_L4_s_no4.enabled;
            SL_L4_s_no5.enabled = !SL_L4_s_no5.enabled;
            SL_L4_b_no1.enabled = !SL_L4_b_no1.enabled;
            SL_L4_b_no2.enabled = !SL_L4_b_no2.enabled;
            SL_L4_b_no3.enabled = !SL_L4_b_no3.enabled;
            SL_L4_b_no4.enabled = !SL_L4_b_no4.enabled;
        }

        else if(Input.GetKeyDown(KeyCode.R)){
            //line1(SL*7, CL*4)
            /*
            SL_L1_no1.enabled = !SL_L1_no1.enabled;
            SL_L1_no2.enabled = !SL_L1_no2.enabled;
            SL_L1_no3.enabled = !SL_L1_no3.enabled;
            SL_L1_no4.enabled = !SL_L1_no4.enabled;
            SL_L1_no5.enabled = !SL_L1_no5.enabled;
            SL_L1_no6.enabled = !SL_L1_no6.enabled;
            SL_L1_no7.enabled = !SL_L1_no7.enabled;

            CL_L1_no1.enabled = !CL_L1_no1.enabled;
            CL_L1_no2.enabled = !CL_L1_no2.enabled;
            CL_L1_no3.enabled = !CL_L1_no3.enabled;
            CL_L1_no4.enabled = !CL_L1_no4.enabled;

            //line2(SL*5)
            SL_L2_no1.enabled = !SL_L2_no1.enabled;
            SL_L2_no2.enabled = !SL_L2_no2.enabled;
            SL_L2_no3.enabled = !SL_L2_no3.enabled;
            SL_L2_no4.enabled = !SL_L2_no4.enabled;
            SL_L2_no5.enabled = !SL_L2_no5.enabled;

            //line3(SL*8, CL*5)
            SL_L3_no1.enabled = !SL_L3_no1.enabled;
            SL_L3_no2.enabled = !SL_L3_no2.enabled;
            SL_L3_no3.enabled = !SL_L3_no3.enabled;
            SL_L3_no4.enabled = !SL_L3_no4.enabled;
            SL_L3_no5.enabled = !SL_L3_no5.enabled;
            SL_L3_no6.enabled = !SL_L3_no6.enabled;
            SL_L3_no7.enabled = !SL_L3_no7.enabled;
            SL_L3_no8.enabled = !SL_L3_no8.enabled;

            CL_L3_no1.enabled = !CL_L3_no1.enabled;
            CL_L3_no2.enabled = !CL_L3_no2.enabled;
            CL_L3_no3.enabled = !CL_L3_no3.enabled;
            CL_L3_no4.enabled = !CL_L3_no4.enabled;
            CL_L3_no5.enabled = !CL_L3_no5.enabled;
            CL_L3_no6.enabled = !CL_L3_no6.enabled;


            //line4(sl_s*5, sl_b*4)
            SL_L4_s_no1.enabled = !SL_L4_s_no1.enabled;
            SL_L4_s_no2.enabled = !SL_L4_s_no2.enabled;
            SL_L4_s_no3.enabled = !SL_L4_s_no3.enabled;
            SL_L4_s_no4.enabled = !SL_L4_s_no4.enabled;
            SL_L4_s_no5.enabled = !SL_L4_s_no5.enabled;
            SL_L4_b_no1.enabled = !SL_L4_b_no1.enabled;
            SL_L4_b_no2.enabled = !SL_L4_b_no2.enabled;
            SL_L4_b_no3.enabled = !SL_L4_b_no3.enabled;
            SL_L4_b_no4.enabled = !SL_L4_b_no4.enabled;
            */

            CL_L1_no1.color = Color.red;
            CL_L1_no2.color = Color.red;
            CL_L1_no3.color = Color.red;
            CL_L1_no4.color = Color.red;

            CL_L3_no1.color = Color.red;
            CL_L3_no2.color = Color.red;
            CL_L3_no3.color = Color.red;
            CL_L3_no4.color = Color.red;
            CL_L3_no5.color = Color.red;
            CL_L3_no6.color = Color.red;
        }
        else if(Input.GetKeyDown(KeyCode.G)){
            //line1(SL*7, CL*4)
            /*
            SL_L1_no1.enabled = !SL_L1_no1.enabled;
            SL_L1_no2.enabled = !SL_L1_no2.enabled;
            SL_L1_no3.enabled = !SL_L1_no3.enabled;
            SL_L1_no4.enabled = !SL_L1_no4.enabled;
            SL_L1_no5.enabled = !SL_L1_no5.enabled;
            SL_L1_no6.enabled = !SL_L1_no6.enabled;
            SL_L1_no7.enabled = !SL_L1_no7.enabled;

            CL_L1_no1.enabled = !CL_L1_no1.enabled;
            CL_L1_no2.enabled = !CL_L1_no2.enabled;
            CL_L1_no3.enabled = !CL_L1_no3.enabled;
            CL_L1_no4.enabled = !CL_L1_no4.enabled;

            //line2(SL*5)
            SL_L2_no1.enabled = !SL_L2_no1.enabled;
            SL_L2_no2.enabled = !SL_L2_no2.enabled;
            SL_L2_no3.enabled = !SL_L2_no3.enabled;
            SL_L2_no4.enabled = !SL_L2_no4.enabled;
            SL_L2_no5.enabled = !SL_L2_no5.enabled;

            //line3(SL*8, CL*5)
            SL_L3_no1.enabled = !SL_L3_no1.enabled;
            SL_L3_no2.enabled = !SL_L3_no2.enabled;
            SL_L3_no3.enabled = !SL_L3_no3.enabled;
            SL_L3_no4.enabled = !SL_L3_no4.enabled;
            SL_L3_no5.enabled = !SL_L3_no5.enabled;
            SL_L3_no6.enabled = !SL_L3_no6.enabled;
            SL_L3_no7.enabled = !SL_L3_no7.enabled;
            SL_L3_no8.enabled = !SL_L3_no8.enabled;

            CL_L3_no1.enabled = !CL_L3_no1.enabled;
            CL_L3_no2.enabled = !CL_L3_no2.enabled;
            CL_L3_no3.enabled = !CL_L3_no3.enabled;
            CL_L3_no4.enabled = !CL_L3_no4.enabled;
            CL_L3_no5.enabled = !CL_L3_no5.enabled;
            CL_L3_no6.enabled = !CL_L3_no6.enabled;


            //line4(sl_s*5, sl_b*4)
            SL_L4_s_no1.enabled = !SL_L4_s_no1.enabled;
            SL_L4_s_no2.enabled = !SL_L4_s_no2.enabled;
            SL_L4_s_no3.enabled = !SL_L4_s_no3.enabled;
            SL_L4_s_no4.enabled = !SL_L4_s_no4.enabled;
            SL_L4_s_no5.enabled = !SL_L4_s_no5.enabled;
            SL_L4_b_no1.enabled = !SL_L4_b_no1.enabled;
            SL_L4_b_no2.enabled = !SL_L4_b_no2.enabled;
            SL_L4_b_no3.enabled = !SL_L4_b_no3.enabled;
            SL_L4_b_no4.enabled = !SL_L4_b_no4.enabled;
            */

            CL_L1_no1.color = Color.green;
            CL_L1_no2.color = Color.green;
            CL_L1_no3.color = Color.green;
            CL_L1_no4.color = Color.green;

            CL_L3_no1.color = Color.green;
            CL_L3_no2.color = Color.green;
            CL_L3_no3.color = Color.green;
            CL_L3_no4.color = Color.green;
            CL_L3_no5.color = Color.green;
            CL_L3_no6.color = Color.green;
        }

        else if(Input.GetKeyDown(KeyCode.M)){
            //line1(SL*7, CL*4)
            /*
            SL_L1_no1.enabled = !SL_L1_no1.enabled;
            SL_L1_no2.enabled = !SL_L1_no2.enabled;
            SL_L1_no3.enabled = !SL_L1_no3.enabled;
            SL_L1_no4.enabled = !SL_L1_no4.enabled;
            SL_L1_no5.enabled = !SL_L1_no5.enabled;
            SL_L1_no6.enabled = !SL_L1_no6.enabled;
            SL_L1_no7.enabled = !SL_L1_no7.enabled;

            CL_L1_no1.enabled = !CL_L1_no1.enabled;
            CL_L1_no2.enabled = !CL_L1_no2.enabled;
            CL_L1_no3.enabled = !CL_L1_no3.enabled;
            CL_L1_no4.enabled = !CL_L1_no4.enabled;

            //line2(SL*5)
            SL_L2_no1.enabled = !SL_L2_no1.enabled;
            SL_L2_no2.enabled = !SL_L2_no2.enabled;
            SL_L2_no3.enabled = !SL_L2_no3.enabled;
            SL_L2_no4.enabled = !SL_L2_no4.enabled;
            SL_L2_no5.enabled = !SL_L2_no5.enabled;

            //line3(SL*8, CL*5)
            SL_L3_no1.enabled = !SL_L3_no1.enabled;
            SL_L3_no2.enabled = !SL_L3_no2.enabled;
            SL_L3_no3.enabled = !SL_L3_no3.enabled;
            SL_L3_no4.enabled = !SL_L3_no4.enabled;
            SL_L3_no5.enabled = !SL_L3_no5.enabled;
            SL_L3_no6.enabled = !SL_L3_no6.enabled;
            SL_L3_no7.enabled = !SL_L3_no7.enabled;
            SL_L3_no8.enabled = !SL_L3_no8.enabled;

            CL_L3_no1.enabled = !CL_L3_no1.enabled;
            CL_L3_no2.enabled = !CL_L3_no2.enabled;
            CL_L3_no3.enabled = !CL_L3_no3.enabled;
            CL_L3_no4.enabled = !CL_L3_no4.enabled;
            CL_L3_no5.enabled = !CL_L3_no5.enabled;
            CL_L3_no6.enabled = !CL_L3_no6.enabled;


            //line4(sl_s*5, sl_b*4)
            SL_L4_s_no1.enabled = !SL_L4_s_no1.enabled;
            SL_L4_s_no2.enabled = !SL_L4_s_no2.enabled;
            SL_L4_s_no3.enabled = !SL_L4_s_no3.enabled;
            SL_L4_s_no4.enabled = !SL_L4_s_no4.enabled;
            SL_L4_s_no5.enabled = !SL_L4_s_no5.enabled;
            SL_L4_b_no1.enabled = !SL_L4_b_no1.enabled;
            SL_L4_b_no2.enabled = !SL_L4_b_no2.enabled;
            SL_L4_b_no3.enabled = !SL_L4_b_no3.enabled;
            SL_L4_b_no4.enabled = !SL_L4_b_no4.enabled;
            */

            CL_L1_no1.color = Color.magenta;
            CL_L1_no2.color = Color.magenta;
            CL_L1_no3.color = Color.magenta;
            CL_L1_no4.color = Color.magenta;

            CL_L3_no1.color = Color.magenta;
            CL_L3_no2.color = Color.magenta;
            CL_L3_no3.color = Color.magenta;
            CL_L3_no4.color = Color.magenta;
            CL_L3_no5.color = Color.magenta;
            CL_L3_no6.color = Color.magenta;


        }

        else if(Input.GetKeyDown(KeyCode.B)){
            //line1(SL*7, CL*4)
            /*
            SL_L1_no1.enabled = !SL_L1_no1.enabled;
            SL_L1_no2.enabled = !SL_L1_no2.enabled;
            SL_L1_no3.enabled = !SL_L1_no3.enabled;
            SL_L1_no4.enabled = !SL_L1_no4.enabled;
            SL_L1_no5.enabled = !SL_L1_no5.enabled;
            SL_L1_no6.enabled = !SL_L1_no6.enabled;
            SL_L1_no7.enabled = !SL_L1_no7.enabled;

            CL_L1_no1.enabled = !CL_L1_no1.enabled;
            CL_L1_no2.enabled = !CL_L1_no2.enabled;
            CL_L1_no3.enabled = !CL_L1_no3.enabled;
            CL_L1_no4.enabled = !CL_L1_no4.enabled;

            //line2(SL*5)
            SL_L2_no1.enabled = !SL_L2_no1.enabled;
            SL_L2_no2.enabled = !SL_L2_no2.enabled;
            SL_L2_no3.enabled = !SL_L2_no3.enabled;
            SL_L2_no4.enabled = !SL_L2_no4.enabled;
            SL_L2_no5.enabled = !SL_L2_no5.enabled;

            //line3(SL*8, CL*5)
            SL_L3_no1.enabled = !SL_L3_no1.enabled;
            SL_L3_no2.enabled = !SL_L3_no2.enabled;
            SL_L3_no3.enabled = !SL_L3_no3.enabled;
            SL_L3_no4.enabled = !SL_L3_no4.enabled;
            SL_L3_no5.enabled = !SL_L3_no5.enabled;
            SL_L3_no6.enabled = !SL_L3_no6.enabled;
            SL_L3_no7.enabled = !SL_L3_no7.enabled;
            SL_L3_no8.enabled = !SL_L3_no8.enabled;

            CL_L3_no1.enabled = !CL_L3_no1.enabled;
            CL_L3_no2.enabled = !CL_L3_no2.enabled;
            CL_L3_no3.enabled = !CL_L3_no3.enabled;
            CL_L3_no4.enabled = !CL_L3_no4.enabled;
            CL_L3_no5.enabled = !CL_L3_no5.enabled;
            CL_L3_no6.enabled = !CL_L3_no6.enabled;


            //line4(sl_s*5, sl_b*4)
            SL_L4_s_no1.enabled = !SL_L4_s_no1.enabled;
            SL_L4_s_no2.enabled = !SL_L4_s_no2.enabled;
            SL_L4_s_no3.enabled = !SL_L4_s_no3.enabled;
            SL_L4_s_no4.enabled = !SL_L4_s_no4.enabled;
            SL_L4_s_no5.enabled = !SL_L4_s_no5.enabled;
            SL_L4_b_no1.enabled = !SL_L4_b_no1.enabled;
            SL_L4_b_no2.enabled = !SL_L4_b_no2.enabled;
            SL_L4_b_no3.enabled = !SL_L4_b_no3.enabled;
            SL_L4_b_no4.enabled = !SL_L4_b_no4.enabled;
            */

            CL_L1_no1.color = Color.blue;
            CL_L1_no2.color = Color.blue;
            CL_L1_no3.color = Color.blue;
            CL_L1_no4.color = Color.blue;

            CL_L3_no1.color = Color.blue;
            CL_L3_no2.color = Color.blue;
            CL_L3_no3.color = Color.blue;
            CL_L3_no4.color = Color.blue;
            CL_L3_no5.color = Color.blue;
            CL_L3_no6.color = Color.blue;
        }
    }
}
