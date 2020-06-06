using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsClass
{
    public class Osoba
    {
        public string login { get; set; }
        public string haslo { get; set; }
        public string nazwisko { get; set; }
    }

    public class Pracownik : Osoba
    {
        public string secure 
        {
            get => haslo;

            set
            {
                //if (value.Length < 6)
                //{
                //    throw new Exception(String.Format("Hasło musi zawierać conajmniej 6 znaków!!!", value.Length));
                //    throw new NullReferenceException("Tam musi być jakaś cywilizacja!!!");
                //    throw new ArgumentOutOfRangeException("Hasło musi składać się z conajmniej 6 znaków");
                //}
                //else
                { 
                    //value = haslo;
                    
                        int length = 7;

                    // creating a StringBuilder object() https://www.educative.io/edpresso/how-to-generate-a-random-string-in-c-sharp
                    StringBuilder password = new StringBuilder();
                        Random random = new Random();

                        char letter;

                        for (int i = 0; i < length; i++)
                        {
                            double flt = random.NextDouble();
                            int shift = Convert.ToInt32(Math.Floor(25 * flt));
                            letter = Convert.ToChar(shift + 65);
                        password.Append(letter);
                        }
                    haslo = password.ToString();
                    //Console.Write(value);
                    
                }


            }
        }


        public string departament { get; set; }

    }


}
