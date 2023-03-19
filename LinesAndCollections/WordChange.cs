using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesAndCollections
{
    internal class WordChange {
        public static void SearchingWrongWords(string Path) {
            var Words = new List<string>() {
               "люпофь", "люиаовь", "любовт", "любгвь", "любви", "абиогинечески", "абиогинетичиски", "абиагенетическе"
            };
            var UsingWords = new List<string>(Words);

            for (int IndexOfWord = 0; IndexOfWord < UsingWords.Count; ++IndexOfWord) {
                if (UsingWords[IndexOfWord] == "люпофь" || UsingWords[IndexOfWord] == "люиаовь"
                    || UsingWords[IndexOfWord] == "любовт" || UsingWords[IndexOfWord] == "любгвь" || UsingWords[IndexOfWord] == "любви") {
                    string Word = UsingWords[IndexOfWord];
                    string Text = string.Empty;
                    using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path)) {
                        Text = Reader.ReadToEnd();
                    }
                    if (Text.Contains(Word)) {
                        string RightWord = "Любовь";
                        string Result = Text.Replace(Word, RightWord);
                        using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path)) {
                            File.Write(Result);
                        }
                    }
                } else if (UsingWords[IndexOfWord] == "абиогинечески" || UsingWords[IndexOfWord] == "абиогинетичиски" || UsingWords[IndexOfWord] == "абиагенетическе") {
                    string Word = UsingWords[IndexOfWord];
                    string Text = string.Empty;
                    using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path)) {
                        Text = Reader.ReadToEnd();
                    }
                    if (Text.Contains(Word)) {
                        string RightWord = "Абиогенетически";
                        string Result = Text.Replace(Word, RightWord);
                        using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path)) {
                            File.Write(Result);
                        }
                    }
                }
            }
            Console.Clear();
            Console.Write("Слова были исправлены");
            Console.ReadKey();
        }
    }
}