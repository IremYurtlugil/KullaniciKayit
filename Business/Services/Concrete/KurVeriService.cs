using Business.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Business.Services.Concrete
{
   public class KurVeriService: IKurVeriService
    {
        //public void KurVeriAl() 
        //{
        //    string exchangeRate = "https://www.tcmb.gov.tr/kurlar/today.xml";
        //    var xmlDoc = new XmlDocument();
        //    xmlDoc.Load(exchangeRate);

        //    DateTime tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
        //}
    }
}
