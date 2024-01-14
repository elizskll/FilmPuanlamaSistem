
using BookExchangeConsoleApp.models;
using System;
using static BookExchangeConsoleApp.models.Movie;

namespace RepeatUntilQ
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;

            List<User> listUser = new List<User>();  // Kullanıcıların listesini tutar
            List<Movie> listMovie = new List<Movie>();  // Filmlerin listesini tutar

            MovieCollection movieCollection = new MovieCollection(); 
            listMovie = movieCollection.GetAllMovie();

            Console.WriteLine("Film İnceleme Platformuna Hoşgeldiniz");

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");

            Console.WriteLine("Aşagıdaki numaralardan birini seçerek işleminizi gerçekleştirebilirsiniz\n");

            Console.WriteLine("\n\n1 - Kayıt ol");
            Console.WriteLine("2 - Giriş yap");
            Console.WriteLine("3 - Filmmleri listele");
            Console.WriteLine("4 - Filmi puanla");
            Console.WriteLine("5 - Çıkış yapmak için q basınız \n");
           
           

            while (true)

            {   
                Console.WriteLine("Bir karakter girin:");
                input = Console.ReadKey().KeyChar; // consolde kullanıcını girdiği değeri aldım
                //Console.WriteLine(input);

                if (input == '1')
                {
                    Console.WriteLine("\n\n1 - İsminizi girin");
                    string name = Console.ReadLine();

                    Console.WriteLine("2 - Soyadınızı girin");
                    string surname = Console.ReadLine();

                    Console.WriteLine("3 - Email adresinizi girin");
                    string email = Console.ReadLine();

                    Console.WriteLine("4 - Şifrenizi girin");
                    string password = Console.ReadLine();

                    Console.WriteLine("5 - Şifrenizi tekrar girin");
                    string confirmPassword = Console.ReadLine();

                    Console.WriteLine("6 - Telefon numaranızı girin");
                    string phone = Console.ReadLine();

                    /*
                     User nesnesi oluşturuldu
                    Kullanıcıdan alınan verilerle obje oluşturuldu listeye kaydedildi.
                     
                     */


                    User user = new User(1, name, surname, email, password, confirmPassword, phone);
                    listUser.Add(user);
                    Console.WriteLine("\n" 
                    + name  + "\n" 
                    + surname + "\n"
                    + email  + "\n"
                    + password + "\n"
                    + confirmPassword  +"\n"
                    + phone  + "\n"
                    );
                    Console.WriteLine("Kaydınız başarılı bir şekilde yapılmıştır\n");
                   
                    //break;
                    
                };
                if (input == '2')
                {
                   

                    if (listUser.Count == 0) // sistemde kayıt varmı kontrolü yapıldı
                    {
                        Console.WriteLine("\nÖnce kayıt olunuz\n");
                    }
                    else


                    {
                        Console.WriteLine("\n1 - Email adresinizi girin");
                        string login_email = Console.ReadLine();

                        Console.WriteLine("2 - Şifrenizi girin");
                        string login_password = Console.ReadLine();
                        for (int i = 0; i < listUser.Count; i++)
                        {
                            if(login_email == listUser[i].Email && 
                                login_password == listUser[i].Password)
                            {
                                Console.WriteLine("Sayın " + listUser[i].Name + " " + listUser[i].Surname);
                            };
                        }
                    }

                    //break;
                };
                if (input == '3')
                {
                    


                    for (int i=0;i< listMovie.Count; i++)
                    {
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");

                        Console.WriteLine("\n" +
                            "Filmin ismi : " + listMovie[i].Name +  "\n" +
                            "Yayın evi : " + listMovie[i].publisher + "\n" + 
                            "Filmin açıklaması : " + listMovie[i].description + "\n" +
                            "Filmin yazarı : "+ listMovie[i].author + "\n" + 
                            "Filmin puanı : " + listMovie[i].rating + "\n" 
                            
                            );
                    }
                    
                };
                if (input == '4')
                {

                    for (int i=0; i < listMovie.Count; i++)
                    {
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");

                        Console.WriteLine("\n\n" +
                            "Filmin Id'si" + listMovie[i].Id + "\n" +
                            "Filmin ismi : " + listMovie[i].Name + "\n" +
                            "Filmin yazarı : " + listMovie[i].author + "\n" +
                            "Filmin puanı : " + listMovie[i].rating + "\n"

                            );
                    }

                    Console.WriteLine("\nPuanlamak istediğiniz filmin numarası seçiniz");
                    string temp = Console.ReadLine(); 
                    int intValue = Int32.Parse(temp); 
                    // gelen veri string oldugu içim benim modelimdeki filmin id'si ise integer oldugundan convert işlemi yaptım

                    Console.WriteLine("\nFilmine bir puan giriniz numarası seçiniz");
                    string temp2 = Console.ReadLine();
                    int intValue2 = Int32.Parse(temp2); 
                    // gelen veri string oldugu içi benim modelimdeki filmin rating'i integer oldugundan convert işlemi yaptım

                    listMovie[intValue - 1].rating = intValue2; // seçtiği puanı , değiştirmek istedigi filmin rating' e atadım.
                    
                       

                    Console.WriteLine("\n" +

                        "Filmin ismi : " + listMovie[intValue - 1].Name + "\n" +
                        "Filmin yazarı : " + listMovie[intValue - 1].author + "\n" +
                        "Filmin puanı : " + listMovie[intValue - 1].rating + "\n"

                        );



                };
                if (input == 'q')
                {
                    Console.WriteLine("q tuşuna bastığınız için teşekkürler!");
                    break;
                };
                
            }
        }
    }
}




    
