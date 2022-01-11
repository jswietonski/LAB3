using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace LAB3
{
    public class DbManager
    {
        public static void INSERT(DataClasses1DataContext dc, int id, string nazwavar, int uservar = 0, int rozvar = 0, int polvar = 0)
        {

            DataTable prod = new DataTable();           
            prod.Id = id;
            prod.nazwa = nazwavar;
            Debug.WriteLine(DateTime.Now.Date.ToString().Length);       
        prod.dataa = DateTime.Now.ToString("dd/MM/yyyy");
            prod.godzina = DateTime.Now.ToString("HH:mm:ss");
            prod.usr = uservar;
            prod.roz = rozvar;
            prod.pol = polvar;

            dc.DataTable.InsertOnSubmit(prod);
            dc.SubmitChanges();


            
        }
        public static void DELETE(DataClasses1DataContext dc, string nazwavar)
        {

            var data = from p in dc.DataTable
                       where p.nazwa.Contains(nazwavar)
                       select p;
            dc.DataTable.DeleteAllOnSubmit(data);
            dc.SubmitChanges();

        }
        public static void UPDATE(DataClasses1DataContext dc, string nazwavar, int uservar, int rozvar, int polvar)
        {

            var update = from p in dc.DataTable
                         where p.nazwa.Contains(nazwavar)
                         select p;
            foreach (var item in update)
            {
                item.usr = uservar;
                item.roz = rozvar;
                item.pol = polvar;
                
            }          
            dc.SubmitChanges();           
        }
        public static bool SELECT(DataClasses1DataContext dc, string nazwavar)
        {
            var data = from p in dc.DataTable
                       where p.nazwa == nazwavar
                       select p;
            foreach (var item in data)
            {
                Debug.WriteLine(item.nazwa);
            }
            if (data.Count()==0)
            {
                Debug.WriteLine("true");
                return true;
            }
            else
            {
                Debug.WriteLine("false");
                return false;
            }
        }
        public static int SELECTmaxID(DataClasses1DataContext dc)
        {
            var data = from p in dc.DataTable
                       select p.Id;
            try { int maxID = data.Max();
                return maxID;
            }
            catch
            {
                int maxID = 0;
                return maxID;
            }
           
        }

        public static List<string> SELECTrow(DataClasses1DataContext dc, string nazwavar)
        {
            List<string> list = new List<string>();
            var data = (from p in dc.DataTable
                        where p.nazwa == nazwavar
                       select p);
             var item = data.First();
            list.Add(item.nazwa);
            list.Add((item.dataa).ToString());
            list.Add((item.godzina).ToString());
            list.Add(item.usr.ToString());
            list.Add(item.roz.ToString());
            list.Add(item.pol.ToString());
            return list;
        }
        public static void UPDATEusr(DataClasses1DataContext dc, string nazwavar)
        {
            var update = (from p in dc.DataTable
                          where p.nazwa.Contains(nazwavar)
                          select p).First();
            update.usr = update.usr + 1;
            Debug.WriteLine("Updatuje");
            dc.SubmitChanges();
        }

        public static void UPDATEroz(DataClasses1DataContext dc, string nazwavar)
        {
            var update = (from p in dc.DataTable
                          where p.nazwa.Contains(nazwavar)
                          select p).First();
            Debug.WriteLine(update.Id);
            Debug.WriteLine(update.nazwa);
            Debug.WriteLine(update.dataa);
            Debug.WriteLine(update.godzina);
            Debug.WriteLine(update.usr);
            Debug.WriteLine(update.roz);
            Debug.WriteLine(update.pol);
            update.roz = update.roz + 1;
            Debug.WriteLine("rozmiar");
            Debug.WriteLine(update.roz);
            Debug.WriteLine("Updatuje rozmiar");
            dc.SubmitChanges();
            
        }
        public static void UPDATEpol(DataClasses1DataContext dc, string nazwavar)
        {
            var update = (from p in dc.DataTable
                          where p.nazwa.Contains(nazwavar)
                          select p).First();
            update.pol = update.pol + 1;
            Debug.WriteLine("Updatuje");
            dc.SubmitChanges();           
        }

        public static void UPDATEactive(DataClasses1DataContext dc, string nazwavar)
        {
            var update = (from p in dc.DataTable
                          where p.nazwa == nazwavar
                          select p).First();
            update.usr = 1;
            Debug.WriteLine("Updatuje");
            dc.SubmitChanges();
        }

        public static void UPDATEdisactive(DataClasses1DataContext dc, string nazwavar)
        {
            var update = (from p in dc.DataTable
                          where p.nazwa == nazwavar
                          select p).First();
            update.usr = 0;
            Debug.WriteLine("Updatuje");
            dc.SubmitChanges();
        }

        public static int SELECTcount(DataClasses1DataContext dc)
        {

            var data = from p in dc.DataTable
                       select p;
            return data.Count();
        }
        public static int SELECTcountActive(DataClasses1DataContext dc)
        {

            var data = from p in dc.DataTable
                       where p.usr == 1
                       select p;
            return data.Count();
        }


        public static void UPDATEdisactiveAll(DataClasses1DataContext dc)
        {
            var update = (from p in dc.DataTable                         
                          select p);
            foreach (var item in update)
            {
                item.usr = 0;                               
            }
            Debug.WriteLine("Zmieniam kazdemu usr na 0");
            dc.SubmitChanges();
        }

        public static List<String> SELECTusrlist(DataClasses1DataContext dc)
        {
            List<String> lista = new List<String>();
            var data = from p in dc.DataTable
                       where p.usr == 1
                       select p.nazwa;
            foreach (var item in data)
            {
                lista.Add(item);
            }
            return lista;
        }

        public static bool SELECTisActive(DataClasses1DataContext dc, string nazwavar)
        {
            var data = (from p in dc.DataTable
                       where p.nazwa == nazwavar
                       select p.usr).First();
            if (data == 1)
            {
                Debug.WriteLine("true");
                return true;
            }
            else
            {
                Debug.WriteLine("false");
                return false;
            }
        }

    }

    
}