using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace ZombieWorld3 {

    internal static class BankSign {
        public static string signString;

        [DllImport("BankSign.dll",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern void Sign(string AANumber,string UANumber,string BankName,string BankData,StringBuilder Destination,int DestinationSize);

        [DllImport("BankSign.dll",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern void SignFromString(string SigInputString,string BankData,StringBuilder Destination,int DestinationSize);

        [DllImport("BankSign.dll",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetSigInputString(string AANumber,string UANumber,string BankName,string BankData,StringBuilder Destination,int DestinationSize);

        [DllImport("BankSign.dll",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetNewSig(string AANumber,string UANumber,string BankName,string BankData,StringBuilder Destination,int DestinationSize);

        [DllImport("BankSign.dll",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetNewSigFromString(string SigInputString,StringBuilder Destination,int DestinationSize);

        [DllImport("BankSign.dll",CharSet = CharSet.Ansi,CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetCurrentSig(string BankData,StringBuilder Destination,int DestinationSize);

        private static int Compare(XElement x,XElement y) {
            int namecomp = x.Name.ToString().CompareTo(y.Name.ToString());
            if (namecomp == 0 && x.HasAttributes && y.HasAttributes) {
                XAttribute xname = x.Attribute("name");
                XAttribute yname = y.Attribute("name");
                if (xname != null && yname != null) {
                    namecomp = string.CompareOrdinal(xname.Value,yname.Value);
                }
            }
            return namecomp;
        }

        public static XElement Alphabetize(XElement el) {
            Comparison<XElement> elementComp = Compare;
            List<XAttribute> attributes = new List<XAttribute>(el.Attributes());
            List<XElement> elements = new List<XElement>(el.Elements());
            attributes.Sort((x,y) => string.CompareOrdinal(x.Name.ToString(),y.Name.ToString()));
            elements.Sort(elementComp);
            XElement newElement = new XElement(el.Name);
            newElement.Add(attributes);
            newElement.Add(elements);
            el.RemoveAttributes();
            el.RemoveNodes();
            el.Add(attributes,elements);
            if (el.HasElements) { foreach (XElement e in el.Elements()) { Alphabetize(e); } }
            return el;
        }

        public static string Format(XElement el) {
            string returnVal = string.Empty;
            if (el.Name != "Section" && el.Name != "Key") {
                returnVal += el.Name;
            }
            if (el.HasAttributes) {
                foreach (XAttribute a in el.Attributes()) {
                    if (a.Name != "name") {
                        returnVal += a.Name;
                    }
                    if (a.Name != "text") {
                        returnVal += a.Value;
                    }
                }
            }
            if (el.HasElements) { foreach (XElement e in el.Elements()) { returnVal += Format(e); } }
            return returnVal;
        }

        public static string FormatHash(byte[] Input) {
            char[] Hex = new char[] { '0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F' };
            string Result = string.Empty;
            foreach (byte b in Input) {
                Result += Hex[b >> 4];
                Result += Hex[b & 0x0F];
            }
            return Result;
        }

        public static string Sign(string AANumber,string UANumber,string BankName,string BankData) {
            StreamReader BankFile = new StreamReader(BankData);
            BankData = BankFile.ReadToEnd();
            BankData = BankData.Replace("\r ","\r\n ").Replace("\r<","\r\n<");
            XDocument doc = XDocument.Parse(BankData);
            XElement root = doc.Root;
            root.SetElementValue("Signature",null);
            Alphabetize(root);
            string HashInput = AANumber + UANumber + BankName;
            foreach (XElement el in root.Elements()) { HashInput += Format(el); }
            byte[] Result;
            using (SHA1 Hash = SHA1.Create()) { Result = Hash.ComputeHash(Encoding.UTF8.GetBytes(HashInput)); }
            signString = FormatHash(Result);
            BankFile.Close();
            return signString;
        }
    }
}