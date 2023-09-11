namespace donguler{


class program{
    //ekrandan girilen sayıya kadar olan tek sayıları yazan program
    static void Main(string[] args){
    
    Console.WriteLine("Bir sayı girin");
    int sayac=int.Parse(Console.ReadLine());

    for(int i =1; i <= sayac; i++){
        if(i%2==1){
            Console.WriteLine(i);
        }
    }


    int sayac2=1000;
    int toplam=0;
    
    for (int i = 1; i <= sayac2; i++)
    {
        if(i%2==0){
            toplam+=i;
        }
    }

    Console.WriteLine("Toplam değer:" + toplam);


        
			//While
			// 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program. // Console.Write("Lütfen bir sayi giriniz: ");
			// int sayi = int.Parse(Console.ReadLine());
			// int sayac = 1;
			// int toplam = 0;
			// while (sayac<<<= sayi)
			// {
			//
			//
			// }
			//toplam += sayac;
			//sayac++;
			// Console.WriteLine(toplam/sayi);
			// // 'a' dan 'z' ye kadar tüm harfleri console a yazdır.
			// char character = 'a';
			// while (character <'z') // {
			//
			// }
			//Console.Write(character); character++;
			Console.Write("***** Foreach *****");
			string[] arabalar = { "BMV", "Ford", "Toyota", "Nissan" };
			foreach (var araba in arabalar)
			{
				Console.WriteLine(araba);
			}

    }
}


}

