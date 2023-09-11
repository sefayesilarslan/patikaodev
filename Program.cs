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

    }
}


}

