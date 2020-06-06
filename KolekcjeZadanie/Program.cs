using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PersonsClass;



namespace KolekcjeZadanie
{

    //class Osoba
    //{
    //    public string login { get; set; }
    //    public string haslo { get; set; }
    //    public string nazwisko { get; set; }
    //}

    //class Pracownik : Osoba
    //{ 
    //    public string secure
    //    {
    //        get => (haslo);

    //        set
    //        {
    //            if (value.Length < 6)
    //            {
    //                throw new Exception(String.Format( "Hasło musi zawierać conajmniej 6 znaków!!!", value.Length) );
    //                throw new NullReferenceException("Tam musi być jakaś cywilizacja!!!");
    //                throw new ArgumentOutOfRangeException("Hasło musi składać się z conajmniej 6 znaków");
    //            }
    //            else
    //            value = haslo;

    //        }
    //    }

                
    //    public string departament { get; set; }

    //}

    class Program
    {
        static void Main(string[] args)
        {
           List<Pracownik> osoba1 = new List<Pracownik>()
            {
                new Pracownik() {login = "qwert", secure = "653604", nazwisko = "Kowalski", departament="Ksiegowość" },
                new Pracownik() {login = "66533", secure = "162356", nazwisko = "Nowak" , departament = "zarządzanie"},
                new Pracownik() {login = "4452fs", secure = "123456", nazwisko = "Fikus" , departament = "umniedziała"},
                new Pracownik() {login = "pokand", secure = "773628", nazwisko = "Pokrzywa" , departament = "IT"},
                new Pracownik() {login = "wartom", secure = "555563", nazwisko = "Warzecha" , departament = "HR"},
                new Pracownik() {login = "kotpit", secure = "522322", nazwisko = "Duda" , departament = "IT"}

            };

        // klasy w osobnym projekcie
        //Utwrzyć kolekcję pracowników i za pomocą LINQ:
        // odczytać alafabetycznie posortowaną listę nazwisk
        //Ustawić losowe hasło wszytkim użytkownikom
        //​Wybrać osoby które pracują w departamentach IT lub HR
            
            // LINQ Query

            var workers = from Pracownik in osoba1
                          where Pracownik.departament == "IT" ^ Pracownik.departament == "HR"
                          orderby Pracownik.nazwisko //sortowanie
                          select new { Employee = Pracownik.nazwisko, dept = Pracownik.departament, passgen = Pracownik.secure };


            foreach (var item in workers)
                Console.WriteLine(item.Employee +" "+ item.dept +" "+ item.passgen);

            Console.ReadKey();

            



        }
    }
}

