using System;
using System.Collections.Generic;
using voting_app.Business;

namespace voting_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> categories = new List<string> {"Aksiyon" , "Komedi", "Polisiye", "Belgesel"};

            Console.WriteLine("Kullanıcı adınızı giriniz: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Şifrenizi giriniz: ");
            string password = Console.ReadLine();

            UserControl userControl = new UserControl();
            bool a = userControl.Controller(userName, password);

            int aksiyonCount = 0, komediCount = 0, polisiyeCount = 0, belgeselCount = 0;

            if(a == true)
            {
                Console.WriteLine("Giriş başarılı. Lütfen oylamaya katılın");
                for (int i = 0; i < categories.Count; i++)
                {
                    Console.WriteLine(categories[i] + " için " + i + " 'ye basıınız. ");
                }

                int b = Convert.ToInt32(Console.ReadLine());

                if (b == 1)
                {
                    aksiyonCount++;
                    Success();
                }                    
                else if (b == 2)
                {
                    komediCount++;
                    Success();
                }
                else if (b == 3)                    
                {
                    polisiyeCount++;
                    Success();
                }
                else if (b == 4)                  
                {
                    belgeselCount++;
                    Success();
                }
                else
                    Console.WriteLine("Hatalı tuşlama yaptınız.");
            }

            if(a == false)
            {
                kayit:
                Console.WriteLine("Oy kullanabilmek için kayıt olmanız gereklidir. Kullanıcı adınızı giriniz: ");
                string newUser = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz : ");
                string newPassword = Console.ReadLine();

                bool c = userControl.AddUser(newUser, newPassword);

                if (c == true)
                    Console.WriteLine("Kayıt başarılı.");
                else
                    Console.WriteLine("Kullanıcı adı kullanılıyor. Yeniden denemek isterseniz 1'e basın, çıkış yapmak için 0' a basın.");
                string choice = Console.ReadLine();

                if (choice == "1")
                    goto kayit;
                
            }
        }
        static void Success()
        {
            Console.WriteLine("Oyunuz kaydedilmiştir. Teşekkürler");
        }
    }
}
