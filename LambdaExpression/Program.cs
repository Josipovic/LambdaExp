using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        //static int kvadriraj(int broj) {

        //    return broj * broj;
        //}

        static void Main(string[] args)
        {
            //lambda expression
            //je anonimna funkcija koja nema acces modifier(private/public)
            //nema ime i nema return naredbu
            //omogucuje pisanje manje koda,a postizanje istog rezultata kao i koristenje funkcija
            //Sintaxa: args=>expression
            //cita se:args "goes to" expression

            //int rez = kvadriraj(2);

            //lambda expression za ovu funkciju:
            //broj=>broj*broj;
            //int m=10;

            //ako imamo vise argumenata onda koristimo zagrade
            //(prvi,drugi=>expression
            //prednost lambda expressiona je to sto moze pristupiti varijablama u funkciji u kojoj se lambda 
            //expression koristi:

            //    Func<int,int>x=n => n * m;
            //    int rezultat = x(6);
            //    Console.WriteLine(rezultat);
            //    Console.Read();

             List<Knjiga> knjiga = new List<Knjiga>();
            Knjiga k = new Knjiga();
            k.Naziv = "Sunce";
            k.Cijena = 10f;

            Knjiga k1 = new Knjiga();
            k1.Naziv = "more";
            k1.Cijena = 20f;

            Knjiga k2 = new Knjiga();
            k2.Naziv = "trava";
            k2.Cijena = 30f;

            knjiga.Add(k);
            knjiga.Add(k1);
            knjiga.Add(k2);


            foreach (var a in knjiga) {
                Console.WriteLine(a.Naziv+ "   " + a.Cijena);
            }

            List<Knjiga> JeftineKnjige = new List<Knjiga>();

            //foreach (var b in knjiga) {

            //    if (b.Cijena<10) {
            //        JeftineKnjige.Add(k);
            //    }
            //}

            //JeftineKnjige = JeftineKnjige.FindAll(m => m.Cijena < 100);
            Console.WriteLine("Jeftine knjige su:");
            foreach (var l in knjiga.FindAll(m=>m.Cijena<100)) {

                Console.WriteLine(l.Cijena + "  " +l.Naziv);
            }
            Console.Read();
        }
    }
}
