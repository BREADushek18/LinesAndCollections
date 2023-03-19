using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesAndCollections {
    class File {
        static void Main(string[] args) {
            Console.Write("Путь к файлу: ");
            string Path = Console.ReadLine();
            FileInfo fileInfo = new FileInfo(Path);
            if (!fileInfo.Exists) {
                Console.WriteLine("Ошибка, такого файла похоже не существует.");
            }
            int UserChoice = 0;
            while (UserChoice != 3) {
                Console.WriteLine("Операции с файлом:\n1.Замена номера телефона \n2.Исправить слова, написанные с ошибкой \n3. Выход");
                while (UserChoice < 1 || UserChoice > 3) {
                    if (int.TryParse(Convert.ToString(Console.ReadLine()), out UserChoice) == false) {
                        Console.WriteLine("Несуществующая операция");
                    }
                }
                Console.Clear();
                switch (UserChoice) {
                    case 1:
                        Console.Clear();
                        ChangingTheNumber.EditorOfPhoneNumbers(Path);
                        UserChoice = 0;
                        break;
                    case 2:
                        Console.Clear();
                        WordChange.SearchingWrongWords(Path);
                        UserChoice = 0;
                        break;
                }

            }
            Console.ReadKey();
        }

    }
}