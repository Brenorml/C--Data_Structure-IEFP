using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTelemoveis
{
    static class Constants
    {
        public const int MaxString = 3;
    }
    internal class Program
    {
        struct PhoneDetails
        {
            public int id;
            public string brand;
            public string model;
            public string provider;
            public string operationSystem;            
            public string cam, smsOrMms, wifi, socialMedia, bluetooth;
        }
        static int RegisterMobile(PhoneDetails[] strList, int quant)
        {
            string option = "s";
            if(quant < strList.Length)
            {
                while (option == "s" && quant < strList.Length)
                {
                    //Preenchimento de dados obrigatorios para ID, marca e modelo
                    strList[quant].id = quant + 1;
                    strList[quant].brand = String.Empty;
                    while (strList[quant].brand.Length == 0)
                    {
                        Console.Write($"Indique a marca: ");
                        strList[quant].brand = Console.ReadLine();
                    }
                    strList[quant].model = String.Empty;
                    while (strList[quant].model.Length == 0)
                    {
                        Console.Write($"Indique o modelo: ");
                        strList[quant].model = Console.ReadLine();
                    }
                    //Preenchimento de dados opcionais
                    Console.Write($"Indique a operadora: ");
                    strList[quant].provider = Console.ReadLine();
                    Console.Write($"Indique o Sistema Operacional: ");
                    strList[quant].operationSystem = Console.ReadLine();

                    Console.Write($"Possui câmera? (s/n) ");
                    strList[quant].cam = Console.ReadLine().ToLower();
                    if (strList[quant].cam != "s")
                    {
                        strList[quant].cam = "n";
                    }
                    //Prenchimento de dados opcionais mas com default negativo
                    Console.Write($"Possui SMS/MMS? (s/n) ");
                    strList[quant].smsOrMms = Console.ReadLine().ToLower();
                    if (strList[quant].smsOrMms != "s")
                    {
                        strList[quant].smsOrMms = "n";
                    }

                    Console.Write($"Possui WIFI? (s/n) ");
                    strList[quant].wifi = Console.ReadLine().ToLower();
                    if (strList[quant].wifi != "s")
                    {
                        strList[quant].wifi = "n";
                    }

                    Console.Write($"Possui Rede Social? (s/n) ");
                    strList[quant].socialMedia = Console.ReadLine().ToLower();
                    if (strList[quant].socialMedia != "s")
                    {
                        strList[quant].socialMedia = "n";
                    }

                    Console.Write($"Possui Bluetooth? (s/n) ");
                    strList[quant].bluetooth = Console.ReadLine().ToLower();
                    if (strList[quant].bluetooth != "s")
                    {
                        strList[quant].bluetooth = "n";
                    }
                    quant++;                    
                    Console.Write($"\nDeseja inserir um novo telemovel? (s/n) ");
                    option = Console.ReadLine().ToLower();
                    Console.Clear();
                    if (option != "s")
                    {
                        Console.Clear();
                        return quant;                                             
                    }                    
                }
                if(quant == strList.Length)
                {
                    Console.WriteLine("Não há mais espaço na memória para um novo cadastro.");
                    Console.WriteLine("\nPressione enter e retorne ao menu principal...");
                    Console.ReadKey();
                    Console.Clear();
                    return quant;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Não há mais espaço na memória para um novo cadastro.");
                Console.WriteLine("\nPressione enter e retorne ao menu principal...");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
        }
        static void FindMobile(PhoneDetails[] strList, int idToFind)
        {
            int count = 0;
            for (int i = 0; i < strList.Length; i++)
            {
                if (strList[i].id == idToFind)
                {
                    Console.WriteLine($"ID: {strList[i].id}");
                    Console.WriteLine($"Marca: {strList[i].brand}");
                    Console.WriteLine($"Modelo: {strList[i].model}");
                    Console.WriteLine($"Operadora: {strList[i].operationSystem}");
                    Console.WriteLine($"Câmera: {strList[i].cam}");
                    Console.WriteLine($"SMS/MMS: {strList[i].smsOrMms}");
                    Console.WriteLine($"WIFI: {strList[i].wifi}");
                    Console.WriteLine($"Rede Social: {strList[i].socialMedia}");
                    Console.WriteLine($"Bluetooth: {strList[i].bluetooth}\n");
                    count++;                }
            }
            if(count == 0)
            {
                Console.WriteLine("Código não registrado!!!\n\nPressione enter e tente novamente...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {                
                Console.WriteLine("Pressione uma tecla para voltar ao menu principal...");
                Console.ReadKey();
                Console.Clear();
            }
            
        }

        static void PrintList(PhoneDetails[] strList)
        {
            for (int i = 0; i < strList.Length; i++)
            {
                if (strList[i].id != 0)
                {
                    Console.WriteLine($"ID: {strList[i].id}");
                    Console.WriteLine($"Marca: {strList[i].brand}");
                    Console.WriteLine($"Modelo: {strList[i].model}");
                    Console.WriteLine($"Operadora: {strList[i].operationSystem}");
                    Console.WriteLine($"Câmera: {strList[i].cam}");
                    Console.WriteLine($"SMS/MMS: {strList[i].smsOrMms}");
                    Console.WriteLine($"WIFI: {strList[i].wifi}");
                    Console.WriteLine($"Rede Social: {strList[i].socialMedia}");
                    Console.WriteLine($"Bluetooth: {strList[i].bluetooth}\n");
                }                
            }
            Console.WriteLine("Pressione uma tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            PhoneDetails[] phoneList = new PhoneDetails[Constants.MaxString];
            string[] findString = new string[Constants.MaxString];
            int option, count = 0, idToFind;

            do
            {
                Console.WriteLine("Escolha uma opção:\n\n\t1 - Cadastrar telemóveis\n\t2 - Consultar telemóveis\n\t3 - Imptimir lista\n\t0 - Sair\n");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        count += RegisterMobile(phoneList, count);                                                
                        break;
                    case 2:
                        Console.Write("Digite o código do telemóvel: ");
                        idToFind = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (idToFind != 0)
                        {
                            FindMobile(phoneList, idToFind);
                        }
                        else
                        {
                            Console.WriteLine("Código inválido!!!\n\nPressione enter e tente novamente...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        PrintList(phoneList);                        
                        break;
                    default:
                        if(option > 2)
                        {
                            Console.WriteLine("Opção inválida!!!\n\nPressione enter e tente novamente...");
                            Console.ReadKey();
                            Console.Clear();
                        }                        
                         break;
                }
            } while (option != 0);
        }
    }
}
