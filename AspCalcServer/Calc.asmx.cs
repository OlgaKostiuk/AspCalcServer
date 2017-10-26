﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace AspCalcServer
{
    /// <summary>
    /// Summary description for Calc
    /// </summary>
    [WebService(Namespace = "http://localhost:50887/Calc.asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Calc : System.Web.Services.WebService
    {

        [WebMethod, ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]
        public CalcModel Calculate(string num1, string num2, string opr)
        {
            CalcModel values = new CalcModel {num1 = int.Parse(num1), num2 = int.Parse(num2), opr = opr};
            values.CalcRes();
            return values;
            // return "Hello World";
        }
    }
}
