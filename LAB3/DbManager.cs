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
            // tworzymy nowy obiekt klasy ProductCategory 
            DataTable prod = new DataTable();           
            prod.Id = id;
            prod.nazwa = nazwavar;
            Debug.WriteLine(DateTime.Now.Date.ToString().Length);       
        prod.dataa = DateTime.Now.ToString("dd/MM/yyyy");
            prod.godzina = DateTime.Now.ToString("HH:mm:ss");
            prod.usr = uservar;
            prod.roz = rozvar;
            prod.pol = polvar;
            // Wywołujemy metode InsertOnSubmit oraz zaspisujemy dane
            dc.DataTable.InsertOnSubmit(prod);
            dc.SubmitChanges();
            // zwracamy ostatni rekord w celu sprawdzenia powyższego kodu           
            // Wyświetlamy ten element w konsoli

            
        }
        public static void DELETE(DataClasses1DataContext dc, string nazwavar)
        {
            // w pierwszej kolejności zwracamy dane, które chcemy usuanąć
            var data = from p in dc.DataTable
                       where p.nazwa.Contains(nazwavar)
                       select p;
            // kasujemy zwrócone dane z naszej tabeli
            dc.DataTable.DeleteAllOnSubmit(data);
            // zapisujemy zmiany
            dc.SubmitChanges();

        }
        public static void UPDATE(DataClasses1DataContext dc, string nazwavar, int uservar, int rozvar, int polvar)
        {
            // dokonamy update wszystkich rekordow w ktorych nazwa produktu zaiwiera "Tube"
            var update = from p in dc.DataTable
                         where p.nazwa.Contains(nazwavar)
                         select p;
            // Zmieniamy nazwę na inną, przy czym nazwa musi być unikalna
            // wg. projektu tej konkretnej bazy danych
            foreach (var item in update)
            {
                item.usr = uservar;
                item.roz = rozvar;
                item.pol = polvar;
                
            }
            // Zapisujemy zmiany            
            dc.SubmitChanges();           
        }
        public static bool SELECT(DataClasses1DataContext dc, string nazwavar)
        {
            // zwracamy dane z tabeli Product gdzie cena jest większa niż 300
            var data = from p in dc.DataTable
                       where p.nazwa == nazwavar
                       select p;
            foreach (var item in data)
            {
                // Wypisujemy podstawowe informacje
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
            // zwracamy dane z tabeli Product gdzie cena jest większa niż 300
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
            update.usr = update.usr++;
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
            update.pol = update.pol++;
            Debug.WriteLine("Updatuje");
            dc.SubmitChanges();           
        }
    }

    
}