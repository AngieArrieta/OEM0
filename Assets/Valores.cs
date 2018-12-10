using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Valores : MonoBehaviour {

    public GameObject g1, g2;
    public SphereCollider s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30, s31, s32, s33, s34, s35, s36, s37, s38, s39, s40, s41, s42, s43, s44, s45, s46, s47, s48, s49, s50, s51, s52, s53, s54, s55, s56, s57, s58, s59, s60, s61, s62, s63, s64, s65, s66, s67, s68, s69, s70,s71,s72,s73,s74,s75,s76,s77,s78,s79,s80,s81,s82,s83,s84,s85,s86,s87,s88,s89,s90,s91,s92,s93,s94,s95,s96,s97;
    public Text textE, textEm, textF;
    public Text textB;
    public Text textL;
    public Text textK;
    public Text txtBm;
    Vector3 pos;
    public GameObject placa;

    float Tf1, Tf2;
    float l, f, k,Bmax;

    float[] xv = new float[33];
    float[] ve = new float[33];
    float[] vb = new float[33];

    // Use this for initialization

    void Start() {

        g1 = GameObject.FindGameObjectWithTag("numero1");
        g2 = GameObject.FindGameObjectWithTag("numero2");
        // t1 = g1.GetComponent<VariablesGlobales>();
        // t2 = g2.GetComponent<VariablesGlobales>();

        Tf1 = float.Parse(g1.name);
        Tf2 = float.Parse(g2.name);


        l = ecuacionLong();
        Debug.Log(l);

        f = Tf2;
        k = ecuacionK(l);
        Bmax = ecuacionBmax();
        txtBm.text = "Bmax = " + Bmax.ToString() + "V/m";

        for (int i = 0; i < 33; i++)
        {
            xv[i] = ecuacionX(l, i + 1);
            ve[i] = ecuacionE(xv[i], Tf1, Tf2);
            vb[i] = ecuacionB(xv[i] , Bmax , Tf2);
            Debug.Log(i + ".  ." + ve[i]);
        }


        

    }






    float ecuacionX(float l, int paso)
    {
        return (paso * l) / 33;
    }

    float ecuacionE(float x, float a, float f)
    {
        int t = 0, c = 300000;
        return (a * Mathf.Cos((((2 * Mathf.PI * f) / c) * x) - (2 * Mathf.PI * f * t)));
    }
    
    float ecuacionB(float x, float a , float f)
    {
        int t = 0, c = 300000;
        return (a * Mathf.Cos((((2 * Mathf.PI * f) / c) * x) - (2 * Mathf.PI * f * t)));
    }
    float ecuacionLong()
    {
        int c = 300000;
        return c / Tf2;
    }
    float ecuacionK(float longitud)
    {
        return (2 * Mathf.PI) / longitud;
    }
    float ecuacionBmax()
    {
        int c = 300000;
        return Tf1 / c;
    }






    void Update()
    {
        textL.text = "λ = " + l.ToString() + " m";
        textK.text = "K = " + k.ToString() + " rad/m";
        textEm.text = "Emax = " + g1.name + "V/m";
        textF.text = "ט = " + g2.name + "Hz";
        txtBm.text = "Bmax = " + Bmax + "V/m";

        pos = placa.transform.position;

        Debug.Log("--------------------------------" + Bmax);

        if (pos.z >= -3.710001f && pos.z <= -3.550001f)
        {
            textE.text = "E = " + ve[posEsfera(s1)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s1)].ToString() + " v/m";
        }
        else if (pos.z >= -3.550001f && pos.z <= -3.390001f)
        {
            textE.text = "E = " + ve[posEsfera(s2)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s2)].ToString() + " v/m";
        }
        else if (pos.z >= -3.390001f && pos.z <= -3.250001f)
        {
            textE.text = "E = " + ve[posEsfera(s3)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s3)].ToString() + " v/m";
        }
        else if (pos.z >= -3.250001f && pos.z <= -3.170002f)
        {
            textE.text = "E = " + ve[posEsfera(s4)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s4)].ToString() + " v/m";
        }
        else if (pos.z >= -3.170002f && pos.z <= -3.050002f)
        {
            textE.text = "E = " + ve[posEsfera(s5)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s5)].ToString() + " v/m";
        }
        else if (pos.z >= -3.050002f && pos.z <= -2.910002f)
        {
            textE.text = "E = " + ve[posEsfera(s6)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s6)].ToString() + " v/m";
        }
        else if (pos.z >= -2.910002f && pos.z <= -2.790002f)
        {
            textE.text = "E = " + ve[posEsfera(s7)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s7)].ToString() + " v/m";
        }
        else if (pos.z >= -2.790002f && pos.z <= -2.690002f)
        {
            textE.text = "E = " + ve[posEsfera(s8)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s8)].ToString() + " v/m";
        }
        else if (pos.z >= -2.690002f && pos.z <= -2.550002f)
        {
            textE.text = "E = " + ve[posEsfera(s9)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s9)].ToString() + " v/m";
        }
        else if (pos.z >= -2.550002f && pos.z <= -2.510002f)
        {
            textE.text = "E = " + ve[posEsfera(s10)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s10)].ToString() + " v/m";
        }




        else if (pos.z >= -2.510002f && pos.z <= -2.370002f)
        {
            textE.text = "E = " + ve[posEsfera(s11)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s11)].ToString() + " v/m";
        }
        else if (pos.z >= -2.370002f && pos.z <= -2.270002f)
        {
            textE.text = "E = " + ve[posEsfera(s12)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s12)].ToString() + " v/m";
        }
        else if (pos.z >= -2.270002f && pos.z <= -2.170002f)
        {
            textE.text = "E = " + ve[posEsfera(s13)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s13)].ToString() + " v/m";
        }
        else if (pos.z >= -2.170002f && pos.z <= -1.990003f)
        {
            textE.text = "E = " + ve[posEsfera(s14)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s14)].ToString() + " v/m";
        }
        else if (pos.z >= -1.990003f && pos.z <= -1.870003f)
        {
            textE.text = "E = " + ve[posEsfera(s15)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s15)].ToString() + " v/m";
        }
        else if (pos.z >= -1.870003f && pos.z <= -1.670003f)
        {
            textE.text = "E = " + ve[posEsfera(s16)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s16)].ToString() + " v/m";
        }
        else if (pos.z >= -1.670003f && pos.z <= -1.570003f)
        {
            textE.text = "E = " + ve[posEsfera(s17)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s17)].ToString() + " v/m";
        }
        else if (pos.z >= -1.570003f && pos.z <= -1.450003f)
        {
            textE.text = "E = " + ve[posEsfera(s18)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s18)].ToString() + " v/m";
        }
        else if (pos.z >= -1.450003f && pos.z <= -1.250003f)
        {
            textE.text = "E = " + ve[posEsfera(s19)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s19)].ToString() + " v/m";
        }
        else if (pos.z >= -1.250003f && pos.z <= -1.130003f)
        {
            textE.text = "E = " + ve[posEsfera(s20)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s20)].ToString() + " v/m";
        }




        else if (pos.z >= -1.130003f && pos.z <= -1.030004f)
        {
            textE.text = "E = " + ve[posEsfera(s21)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s21)].ToString() + " v/m";
        }
        else if (pos.z >= -1.030004f && pos.z <= -0.9700036f)
        {
            textE.text = "E = " + ve[posEsfera(s22)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s22)].ToString() + " v/m";
        }
        else if (pos.z >= -0.9700036f && pos.z <= -0.8700037f)
        {
            textE.text = "E = " + ve[posEsfera(s23)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s23)].ToString() + " v/m";
        }
        else if (pos.z >= -0.8700037f && pos.z <= -0.7900038f)
        {
            textE.text = "E = " + ve[posEsfera(s24)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s24)].ToString() + " v/m";
        }
        else if (pos.z >= -0.7900038f && pos.z <= -0.7500038f)
        {
            textE.text = "E = " + ve[posEsfera(s25)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s25)].ToString() + " v/m";
        }
        else if (pos.z >= -0.7500038f && pos.z <= -0.6700039f)
        {
            textE.text = "E = " + ve[posEsfera(s26)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s26)].ToString() + " v/m";
        }
        else if (pos.z >= -0.6700039f && pos.z <= -0.590004f)
        {
            textE.text = "E = " + ve[posEsfera(s27)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s27)].ToString() + " v/m";
        }
        else if (pos.z >= -0.590004f && pos.z <= -0.510004f)
        {
            textE.text = "E = " + ve[posEsfera(s28)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s28)].ToString() + " v/m";
        }
        else if (pos.z >= -0.510004f && pos.z <= -0.350004f)
        {
            textE.text = "E = " + ve[posEsfera(s29)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s29)].ToString() + " v/m";
        }
        else if (pos.z >= -0.350004f && pos.z <= -0.2100039f)
        {
            textE.text = "E = " + ve[posEsfera(s30)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s30)].ToString() + " v/m";
        }





        else if (pos.z >= -0.2100039f && pos.z <= 0.009996057f)
        {
            textE.text = "E = " + ve[posEsfera(s31)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s31)].ToString() + " v/m";
        }
        else if (pos.z >= 0.009996057f && pos.z <= 0.209996f)
        {
            textE.text = "E = " + ve[posEsfera(s32)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s32)].ToString() + " v/m";
        }
        else if (pos.z >= 0.209996f && pos.z <= 0.3499961f)
        {
            textE.text = "E = " + ve[posEsfera(s33)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s33)].ToString() + " v/m";
        }
        else if (pos.z >= 0.3499961f && pos.z <= 0.5299961f)
        {
            textE.text = "E = " + ve[posEsfera(s34)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s34)].ToString() + " v/m";
        }
        else if (pos.z >= 0.5299961f && pos.z <= 0.7299959f)
        {
            textE.text = "E = " + ve[posEsfera(s35)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s35)].ToString() + " v/m";
        }

        else if (pos.z >= 0.7299959f && pos.z <= 0.8499958f)
        {
            textE.text = "E = " + ve[posEsfera(s36)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s36)].ToString() + " v/m";
        }
        else if (pos.z >= 0.8499958f && pos.z <= 1.009996f)
        {
            textE.text = "E = " + ve[posEsfera(s37)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s37)].ToString() + " v/m";
        }
        else if (pos.z >= 1.009996f && pos.z <= 1.109996f)
        {
            textE.text = "E = " + ve[posEsfera(s38)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s38)].ToString() + " v/m";
        }
        else if (pos.z >= 1.109996f && pos.z <= 1.229995f)
        {
            textE.text = "E = " + ve[posEsfera(s39)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s39)].ToString() + " v/m";

        }
        else if (pos.z >= 1.229995f && pos.z <= 1.349995f)
        {
            textE.text = "E = " + ve[posEsfera(s40)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s40)].ToString() + " v/m";
        }







        else if (pos.z >= 1.349995f && pos.z <= 1.489995f)
        {
            textE.text = "E = " + ve[posEsfera(s41)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s41)].ToString() + " v/m";
        }
        else if (pos.z >= 1.489995f && pos.z <= 1.649995f)
        {
            textE.text = "E = " + ve[posEsfera(s42)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s42)].ToString() + " v/m";
        }
        else if (pos.z >= 1.649995f && pos.z <= 1.789995f)
        {
            textE.text = "E = " + ve[posEsfera(s43)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s43)].ToString() + " v/m";
        }
        else if (pos.z >= 1.789995f && pos.z <= 1.909995f)
        {
            textE.text = "E = " + ve[posEsfera(s44)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s44)].ToString() + " v/m";
        }
        else if (pos.z >= 1.909995f && pos.z <= 2.029995f)
        {
            textE.text = "E = " + ve[posEsfera(s45)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s45)].ToString() + " v/m";
        }
        else if (pos.z >= 2.029995f && pos.z <= 2.189995f)
        {
            textE.text = "E = " + ve[posEsfera(s46)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s46)].ToString() + " v/m";
        }
        else if (pos.z >= 2.189995f && pos.z <= 2.289994f)
        {
            textE.text = "E = " + ve[posEsfera(s47)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s47)].ToString() + " v/m";
        }
        else if (pos.z >= 2.289994f && pos.z <= 2.409994f)
        {
            textE.text = "E = " + ve[posEsfera(s48)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s48)].ToString() + " v/m";
        }
        else if (pos.z >= 2.409f && pos.z <= 2.569994f)
        {
            textE.text = "E = " + ve[posEsfera(s49)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s49)].ToString() + " v/m";
        }
        else if (pos.z >= 2.569994f && pos.z <= 2.749994f)
        {
            textE.text = "E = " + ve[posEsfera(s50)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s50)].ToString() + " v/m";

        }





        else if (pos.z >= 2.749994f && pos.z <= 2.829994f)
        {
            textE.text = "E = " + ve[posEsfera(s51)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s51)].ToString() + " v/m";
        }
        else if (pos.z >= 2.829994f && pos.z <= 2.949994f)
        {
            textE.text = "E = " + ve[posEsfera(s52)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s52)].ToString() + " v/m";
        }
        else if (pos.z >= 2.949994f && pos.z <= 3.209994f)
        {
            textE.text = "E = " + ve[posEsfera(s53)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s53)].ToString() + " v/m";
        }
        else if (pos.z >= 3.209994f && pos.z <= 3.409993f)
        {
            textE.text = "E = " + ve[posEsfera(s54)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s54)].ToString() + " v/m";
        }
        else if (pos.z >= 3.409993f && pos.z <= 3.529993f)
        {
            textE.text = "E = " + ve[posEsfera(s55)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s55)].ToString() + " v/m";
        }
        else if (pos.z >= 3.529993f && pos.z <= 3.629993f)
        {
            textE.text = "E = " + ve[posEsfera(s56)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s56)].ToString() + " v/m";
        }
        else if (pos.z >= 3.629993f && pos.z <= 3.829993f)
        {
            textE.text = "E = " + ve[posEsfera(s57)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s57)].ToString() + " v/m";
        }
        else if (pos.z >= 3.829993f && pos.z <= 3.989993f)
        {
            textE.text = "E = " + ve[posEsfera(s58)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s58)].ToString() + " v/m";
        }
        else if (pos.z >= 3.989993f && pos.z <= 4.129993f)
        {
            textE.text = "E = " + ve[posEsfera(s59)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s59)].ToString() + " v/m";
        }
        else if (pos.z >= 4.129993f && pos.z <= 4.229993f)
        {
            textE.text = "E = " + ve[posEsfera(s60)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s60)].ToString() + " v/m";
        }




        else if (pos.z >= 4.229993f && pos.z <= 4.309993f)
        {
            textE.text = "E = " + ve[posEsfera(s61)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s61)].ToString() + " v/m";

        }
        else if (pos.z >= 4.309993f && pos.z <= 4.389993f)
        {
            textE.text = "E = " + ve[posEsfera(s62)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s62)].ToString() + " v/m";
        }
        else if (pos.z >= 4.389993f && pos.z <= 4.429993f)
        {
            textE.text = "E = " + ve[posEsfera(s63)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s63)].ToString() + " v/m";
        }
        else if (pos.z >= 4.429993f && pos.z <= 4.549993f)
        {
            textE.text = "E = " + ve[posEsfera(s64)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s64)].ToString() + " v/m";
        }
        else if (pos.z >= 4.549993f && pos.z <= 4.629992f)
        {
            textE.text = "E = " + ve[posEsfera(s65)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s65)].ToString() + " v/m";
        }
        else if (pos.z >= 4.629992f && pos.z <= 4.729992f)
        {
            textE.text = "E = " + ve[posEsfera(s66)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s66)].ToString() + " v/m";
        }
        else if (pos.z >= 4.729992f && pos.z <= 4.829992f)
        {
            textE.text = "E = " + ve[posEsfera(s67)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s67)].ToString() + " v/m";
        }
        else if (pos.z >= 4.829992f && pos.z <= 4.949992f)
        {
            textE.text = "E = " + ve[posEsfera(s68)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s68)].ToString() + " v/m";
        }
        else if (pos.z >= 4.949992f && pos.z <= 5.069992f)
        {
            textE.text = "E = " + ve[posEsfera(s69)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s69)].ToString() + " v/m";
        }
        else if (pos.z >= 5.069992f && pos.z <= 5.189992f)
        {
            textE.text = "E = " + ve[posEsfera(s70)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s70)].ToString() + " v/m";
        }





        else if (pos.z >= 5.189992f && pos.z <= 5.409992f)
        {
            textE.text = "E = " + ve[posEsfera(s71)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s71)].ToString() + " v/m";
        }
        else if (pos.z >= 5.409992f && pos.z <= 5.569992f)
        {
            textE.text = "E = " + ve[posEsfera(s72)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s72)].ToString() + " v/m";

        }
        else if (pos.z >= 5.569992f && pos.z <= 5.669991f)
        {
            textE.text = "E = " + ve[posEsfera(s73)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s73)].ToString() + " v/m";
        }
        else if (pos.z >= 5.669991f && pos.z <= 5.809991f)
        {
            textE.text = "E = " + ve[posEsfera(s74)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s74)].ToString() + " v/m";
        }
        else if (pos.z >= 5.809991f && pos.z <= 5.929991f)
        {
            textE.text = "E = " + ve[posEsfera(s75)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s75)].ToString() + " v/m";
        }
        else if (pos.z >= 5.929991f && pos.z <= 6.049991f)
        {
            textE.text = "E = " + ve[posEsfera(s76)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s76)].ToString() + " v/m";
        }
        else if (pos.z >= 6.049991f && pos.z <= 6.149991f)
        {
            textE.text = "E = " + ve[posEsfera(s77)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s77)].ToString() + " v/m";
        }
        else if (pos.z >= 6.149991f && pos.z <= 6.269991f)
        {
            textE.text = "E = " + ve[posEsfera(s78)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s78)].ToString() + " v/m";
        }
        else if (pos.z >= 6.269991f && pos.z <= 6.389991f)
        {
            textE.text = "E = " + ve[posEsfera(s79)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s79)].ToString() + " v/m";
        }
        else if (pos.z >= 6.389991f && pos.z <= 6.489991f)
        {
            textE.text = "E = " + ve[posEsfera(s80)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s80)].ToString() + " v/m";
        }




        else if (pos.z >= 6.489991f && pos.z <= 6.589991f)
        {
            textE.text = "E = " + ve[posEsfera(s81)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s81)].ToString() + " v/m";
        }
        else if (pos.z >= 6.589991f && pos.z <= 6.689991f)
        {
            textE.text = "E = " + ve[posEsfera(s82)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s82)].ToString() + " v/m";
        }
        else if (pos.z >= 6.689991f && pos.z <= 6.82999f)
        {
            textE.text = "E = " + ve[posEsfera(s83)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s83)].ToString() + " v/m";

        }
        else if (pos.z >= 6.82999f && pos.z <= 6.92999f)
        {
            textE.text = "E = " + ve[posEsfera(s84)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s84)].ToString() + " v/m";
        }
        else if (pos.z >= 6.92999f && pos.z <= 7.16999f)
        {
            textE.text = "E = " + ve[posEsfera(s85)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s85)].ToString() + " v/m";
        }
        else if (pos.z >= 7.16999f && pos.z <= 7.30999f)
        {
            textE.text = "E = " + ve[posEsfera(s86)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s86)].ToString() + " v/m";
        }
        else if (pos.z >= 7.30999f && pos.z <= 7.38999f)
        {
            textE.text = "E = " + ve[posEsfera(s87)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s87)].ToString() + " v/m";
        }
        else if (pos.z >= 7.38999f && pos.z <= 7.54999f)
        {
            textE.text = "E = " + ve[posEsfera(s88)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s88)].ToString() + " v/m";
        }
        else if (pos.z >= 7.54999f && pos.z <= 7.74999f)
        {
            textE.text = "E = " + ve[posEsfera(s89)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s89)].ToString() + " v/m";
        }
        else if (pos.z >= 7.74999f && pos.z <= 7.849989f)
        {
            textE.text = "E = " + ve[posEsfera(s90)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s90)].ToString() + " v/m";
        }




        else if (pos.z >= 7.849989f && pos.z <= 7.96999f)
        {
            textE.text = "E = " + ve[posEsfera(s91)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s91)].ToString() + " v/m";
        }
        else if (pos.z >= 7.96999f && pos.z <= 8.049991f)
        {
            textE.text = "E = " + ve[posEsfera(s92)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s92)].ToString() + " v/m";
        }
        else if (pos.z >= 8.049991f && pos.z <= 8.149993f)
        {
            textE.text = "E = " + ve[posEsfera(s93)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s93)].ToString() + " v/m";
        }
        else if (pos.z >= 8.149993f && pos.z <= 8.269996f)
        {
            textE.text = "E = " + ve[posEsfera(s94)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s94)].ToString() + " v/m";

        }
        else if (pos.z >= 8.269996f && pos.z <= 8.389998f)
        {
            textE.text = "E = " + ve[posEsfera(s95)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s95)].ToString() + " v/m";
        }
        else if (pos.z >= 8.389998f && pos.z <= 8.47f)
        {
            textE.text = "E = " + ve[posEsfera(s96)].ToString() + " v/m";
            textB.text = "B = " + vb[posEsfera(s96)].ToString() + " v/m";
        }


        else
        {
            textE.text = "E = --- ";
            textB.text = "B = --- ";
            textK.text = "K = --- ";
            textL.text = "λ = --- " ;
            txtBm.text = "Bmax = --- " ;

        }


    }

    int posEsfera(SphereCollider sphere)
    {
        Vector3 posS = sphere.transform.position;
        if(posS.y >= 3.38f && posS.y <= 3.57f)
        {
            return 16;
        }
        if (posS.y >= 3.57f && posS.y <= 3.739f)
        {
            return 17;
        }
        if (posS.y >= 3.739f && posS.y <= 3.88f)
        {
            return 18;
        }
        if (posS.y >= 3.88f && posS.y <= 4.04f)
        {
            return 19;

        }
        if (posS.y >= 4.04f && posS.y <= 4.21f)
        {
            return 20;
        }
        if (posS.y >= 4.21f && posS.y <= 4.38f)
        {
            return 21;
        }
        if (posS.y >= 4.38f && posS.y <= 4.53f)
        {
            return 22;
        }
        if (posS.y >= 4.53f && posS.y <= 4.69f)
        {
            return 23;
        }
        if (posS.y >= 4.69f && posS.y <= 4.85f)
        {
            return 24;
        }
        if (posS.y >= 4.85f && posS.y <= 5f)
        {
            return 25;
        }
        if (posS.y >= 5f && posS.y <= 5.17f)
        {
            return 26;
        }
        if (posS.y >= 5.17f && posS.y <= 5.28f)
        {
            return 27;
        }
        if (posS.y >= 5.28f && posS.y <= 5.47f)
        {
            return 28;
        }
        if (posS.y >= 5.47f && posS.y <= 5.61f)
        {
            return 29;
        }
        if (posS.y >= 5.61f && posS.y <= 5.77f)
        {
            return 30;
        }
        if (posS.y >= 5.77f && posS.y <= 5.95f)
        {
            return 31;
        }
        if (posS.y >= 5.95f && posS.y <= 6.11f)
        {
            return 32;
        }
        else
        {
            return 0;
        }
    }
}
  



