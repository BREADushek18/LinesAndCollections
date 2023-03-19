using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LinesAndCollections {
    internal class ChangingTheNumber {
        public static void EditorOfPhoneNumbers(string Path) {
            string FirstNumber = "(012)-345-67-89";
            string Text = string.Empty;
            using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path)) {
                Text = Reader.ReadToEnd();
            }
            if (Text.Contains(FirstNumber)) {
                string Pattern = @"\D(\S{4})\D\S*";
                string Result = "+380-12-345-67-89";
                Regex regex = new Regex(Pattern);
                string ResultOfConvert = regex.Replace(FirstNumber, Result);
                string Fin = Text.Replace(FirstNumber, ResultOfConvert);
                using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path)) {
                    File.Write(Fin);
                }
            }
            Console.Clear();
            if (!Text.Contains(FirstNumber)) {
                Console.Write("Номер для замены не найден");
            } else {
                Console.WriteLine("Номера были заменены");
            }
            Console.ReadKey();
        }
    }
}