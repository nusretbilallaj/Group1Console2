// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Group1Console2;

Console.WriteLine("AAB COllege");

//int numri;
//numri = 10;
//string klienti;
//klienti = "Kastriot Gjoka";
//bool kushti;
//kushti = true;

////Console.WriteLine(klienti);
////Console.WriteLine("Blend");
////Console.WriteLine(kushti);
////Console.WriteLine(100);
////Console.WriteLine(false);

////Console.WriteLine("Tungjatjeta Leron");
////Console.WriteLine("Tungjatjeta Kastriot");

//string Emri;
//Emri = "Muhamed";
////Console.WriteLine("-------------------");
////Console.WriteLine($"Tungjatjeta {Emri}");
////Console.WriteLine("-------------------");
//SayHello(Emri);

//Emri = "Leron";
////Console.WriteLine("-------------------");
////Console.WriteLine($"Tungjatjeta {Emri}");
////Console.WriteLine("-------------------");
//SayHello(Emri);

//Emri = "Kastriot";
////Console.WriteLine("-------------------");
////Console.WriteLine($"Tungjatjeta {Emri}");
////Console.WriteLine("-------------------");
//SayHello(Emri);

//void SayHello(string emri)
//{
//    Console.WriteLine("-------------------");
//    Console.WriteLine($"Tungjatjeta {emri}");
//    Console.WriteLine("-------------------");
//}

//void KontrolloNivelin(int mosha)
//{
//    if (mosha<5)
//    {
//        Console.WriteLine("Ju po shkoni ne parashkollor.");
//    }
//    else
//    {
//        Console.WriteLine("Ju po shkoni ne shkolle fillore.");
//    }
//}

//KontrolloNivelin(4);


//KontrolloNivelin(6);

Student studenti1;
studenti1= new Student("Kastriot","Gjoka","Mitrovice");
studenti1.SayHello();

Student studenti2 = new Student("Blend","Krasniqi","Prishtine");
studenti2.SayHello();

var profesori = new Profesor("Leron","Berisha");
profesori.SayHello();


List<Person> personat = new List<Person>();
personat.Add(new Student("Blend","Krasniqi","Prishtine"));
personat.Add(new Profesor("Blend","Krasniqi"));

foreach (var person in personat)
{
    person.SayHello();
}