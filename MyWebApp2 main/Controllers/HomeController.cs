using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebApp2.Models;
using MyWebApp2.ViewModels;

namespace MyWebApp2.Controllers
{
    public class HomeController : Controller
    {
        #region Questions
        QuestTempl FirstQuest = new QuestTempl()
        {
            Question = "Выберите корректное описание типа документа HTML:",

            VariantAnswer1 = "<!HTML>",
            VariantAnswer2 = "<DOCTYPE>",
            VariantAnswer3 = "<!DOCTYPE html>",
            VariantAnswer4 = "<!html DOCTYPE>",

            QuestTier = 1
        };

        QuestTempl SecondQuest = new QuestTempl()
        {
            Question = "Выберите синтаксически правильный код для создания ссылки, " +
            "которая будет открывать документ в новом окне:",

            VariantAnswer1 = "<a href='url' target='_blank'>",
            VariantAnswer2 = "<a href='url' new>",
            VariantAnswer3 = "<a target='new window'>",
            VariantAnswer4 = "<a href='url' target='new'>",

            QuestTier = 1
        };

        QuestTempl ThirdQuest = new QuestTempl()
        {
            Question = "Какой тег включает в себя описание всех областей на карте-изображении?",

            VariantAnswer1 = "<img>",
            VariantAnswer2 = "<map>",
            VariantAnswer3 = "<area>",
            VariantAnswer4 = "<usemap>",

            QuestTier = 1
        };

        QuestTempl FourthQuest = new QuestTempl()
        {
            Question = "Какой из HTML тегов используется для переноса строки?",

            VariantAnswer1 = "<new line/>",
            VariantAnswer2 = "<br />",
            VariantAnswer3 = "<break line>",
            VariantAnswer4 = "<break row/>",

            QuestTier = 1
        };

        QuestTempl FivethQuest = new QuestTempl()
        {
            Question = "С помощью какого тега можно задать направление вывода текста?",

            VariantAnswer1 = "<bdi></bdi>",
            VariantAnswer2 = "<b></b>",
            VariantAnswer3 = "<dir></dir>",
            VariantAnswer4 = "<bdo></bdo>",

            QuestTier = 1
        };

        QuestTempl SixthQuest = new QuestTempl()
        {
            Question = "Какие преимущества использования CSS?",

            VariantAnswer1 = "Разграничение кода и оформления",
            VariantAnswer2 = "Все перечисленные варианты",
            VariantAnswer3 = "Разное оформление для разных устройств",
            VariantAnswer4 = "Единое стилевое оформление множества документов",

            QuestTier = 1
        };

        QuestTempl SeventhQuest = new QuestTempl()
        {
            Question = "Свойство border – это универсальное свойство, которое позволяет устанавливать одновременно:",

            VariantAnswer1 = "Радиус округления, стиль и цвет границы",
            VariantAnswer2 = "Изображение для границы, радиус округления и стиль границы",
            VariantAnswer3 = "Толщину, стиль и цвет границы",
            VariantAnswer4 = "Толщину, радиус округления и цвет границы",

            QuestTier = 1
        };

        QuestTempl EighthQuest = new QuestTempl()
        {
            Question = "CSS - это:",

            VariantAnswer1 = "Creative Styles Systems",
            VariantAnswer2 = "Cascade Server Sheets",
            VariantAnswer3 = "Cascading Style Sheets",
            VariantAnswer4 = "Central Style Solution",

            QuestTier = 1
        };

        QuestTempl NinthQuest = new QuestTempl()
        {
            Question = "Какое свойство позволяет масштабировать фоновое изображение:",

            VariantAnswer1 = "background-position",
            VariantAnswer2 = "background-clip",
            VariantAnswer3 = "background-size",
            VariantAnswer4 = "background-image",

            QuestTier = 1
        };

        QuestTempl TenthQuest = new QuestTempl()
        {
            Question = "Укажите возможные способы добавления стилей на страницу:",

            VariantAnswer1 = "С помощью атрибута style",
            VariantAnswer2 = "С помощью тега <css>",
            VariantAnswer3 = "С помощью атрибута CSS",
            VariantAnswer4 = "С помощью тега <link> +",

            QuestTier = 1
        };

        QuestTempl EleventhQuest = new QuestTempl()
        {
            Question = "Что такое Not-a-Number?",

            VariantAnswer1 = "Возможный результат арифметической операции с целыми числами.",
            VariantAnswer2 = "Результат попытки сложения строки и числа.",
            VariantAnswer3 = "Все нечисловые типы C#.",
            VariantAnswer4 = "Возможный результат арифметической операции с вещественными числами.",

            QuestTier = 1
        };

        QuestTempl TwelfthQuest = new QuestTempl()
        {
            Question = "Какого арифметического оператора не бывает?",

            VariantAnswer1 = "Постфиксный.",
            VariantAnswer2 = "Коферментный.",
            VariantAnswer3 = "Унарный.",
            VariantAnswer4 = "Префиксный.",

            QuestTier = 1
        };

        QuestTempl ThirteenthQuest = new QuestTempl()
        {
            Question = "Какая арифметическая операция имеет наивысший приоритет в выражении?",

            VariantAnswer1 = "Умножение.",
            VariantAnswer2 = "Сложение.",
            VariantAnswer3 = "Постфиксный декремент.",
            VariantAnswer4 = "Префиксный инкремент.",

            QuestTier = 1
        };

        QuestTempl FourteenthQuest = new QuestTempl()
        {
            Question = "С помощью какого метода возможно вычислить квадратный корень числа?",

            VariantAnswer1 = "Math.Pow(double x, double y)",
            VariantAnswer2 = "Math.TRoot(double x)",
            VariantAnswer3 = "Math.Sqrt2(double x)",
            VariantAnswer4 = "Math.Sqrt(double x)",

            QuestTier = 1
        };

        QuestTempl FifteenthQuest = new QuestTempl()
        {
            Question = "Что из перечисленного является операцией составного присваивания с прибавлением?",

            VariantAnswer1 = "x += 10;",
            VariantAnswer2 = "x =+10;",
            VariantAnswer3 = "int x = 5, y =6;",
            VariantAnswer4 = "x = y++;",

            QuestTier = 1
        };

        QuestTempl SixteenthQuest = new QuestTempl()
        {
            Question = "Что из перечисленного является операцией составного присваивания с прибавлением?",

            VariantAnswer1 = "Упорядоченный набор однотипных констант.",
            VariantAnswer2 = "Набор переменных, относящихся к общей теме.",
            VariantAnswer3 = "Несколько именованных переменных, проинициализированных в коде одна за другой.",
            VariantAnswer4 = "Структура, состоящая из упорядоченного набора однотипных элементов.",

            QuestTier = 1
        };

        QuestTempl SeventeenthQuest = new QuestTempl()
        {
            Question = "Какой индекс имеется у самого левого элемента массива.",

            VariantAnswer1 = "Равен длине массива минус 1.",
            VariantAnswer2 = "0",
            VariantAnswer3 = "1",
            VariantAnswer4 = "Равен длине массива.",

            QuestTier = 1
        };

        QuestTempl EighteenthQuest = new QuestTempl()
        {
            Question = "Чтобы получить значение элемента массива требуется…",

            VariantAnswer1 = "После имени массива в квадратных скобках указать порядковый номер элемента.",
            VariantAnswer2 = "После имени массива в круглых скобках указать индекс элемента.",
            VariantAnswer3 = "После имени массива в круглых скобках указать порядковый номер элемента.",
            VariantAnswer4 = "После имени массива в квадратных скобках указать индекс элемента.",

            QuestTier = 1
        };

        QuestTempl NineteenthQuest = new QuestTempl()
        {
            Question = "Индекс массива может быть типа…",

            VariantAnswer1 = "char",
            VariantAnswer2 = "bool",
            VariantAnswer3 = "string",
            VariantAnswer4 = "int",

            QuestTier = 1
        };

        QuestTempl TwentiethQuest = new QuestTempl()
        {
            Question = "Использование какой конструкции позволяет последовательно получить доступ ко всем элементам массива?",

            VariantAnswer1 = "if-else",
            VariantAnswer2 = "array",
            VariantAnswer3 = "switch-case",
            VariantAnswer4 = "while",

            QuestTier = 1
        };
        #endregion

        List<QuestTempl> QuestList = new List<QuestTempl>();

        public IActionResult Index()
        {
            #region AddQuestion
            QuestList.Add(FirstQuest);
            QuestList.Add(SecondQuest);
            QuestList.Add(ThirdQuest);
            QuestList.Add(FourthQuest);
            QuestList.Add(FivethQuest);
            QuestList.Add(SixthQuest);
            QuestList.Add(SeventhQuest);
            QuestList.Add(EighthQuest);
            QuestList.Add(NinthQuest);
            QuestList.Add(TenthQuest);
            QuestList.Add(EleventhQuest);
            QuestList.Add(TwelfthQuest);
            QuestList.Add(ThirteenthQuest);
            QuestList.Add(FourteenthQuest);
            QuestList.Add(FifteenthQuest);
            QuestList.Add(SixteenthQuest);
            QuestList.Add(SeventeenthQuest);
            QuestList.Add(EighteenthQuest);
            QuestList.Add(NineteenthQuest);
            QuestList.Add(TwentiethQuest);
            #endregion

            return View(QuestList);
        }

        public IActionResult Result(UserAnswer[] user)
        {
            ViewData["Validation"] = false;

            if (user.Length == 20)
            {
                ViewData["Validation"] = true;

                #region AddQuestion
                QuestList.Add(FirstQuest);
                QuestList.Add(SecondQuest);
                QuestList.Add(ThirdQuest);
                QuestList.Add(FourthQuest);
                QuestList.Add(FivethQuest);
                QuestList.Add(SixthQuest);
                QuestList.Add(SeventhQuest);
                QuestList.Add(EighthQuest);
                QuestList.Add(NinthQuest);
                QuestList.Add(TenthQuest);
                QuestList.Add(EleventhQuest);
                QuestList.Add(TwelfthQuest);
                QuestList.Add(ThirteenthQuest);
                QuestList.Add(FourteenthQuest);
                QuestList.Add(FifteenthQuest);
                QuestList.Add(SixteenthQuest);
                QuestList.Add(SeventeenthQuest);
                QuestList.Add(EighteenthQuest);
                QuestList.Add(NineteenthQuest);
                QuestList.Add(TwentiethQuest);
                #endregion

                double AnswerTrue = 0;

                for (int i = 0; i < user.Length; i++)
                {
                    #region CheckAnswer-1
                    if (user[0].TrdAnswr & i == 0)
                    {
                        AnswerTrue += 5;

                        if (user[0].FrstAnswr | user[0].ScndAnswr | user[0].FrAnswr)
                        {
                            AnswerTrue -=5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-2
                    if (user[1].FrstAnswr & user[1].FrAnswr & i == 1)
                    {
                        AnswerTrue += 5;

                        if (user[1].ScndAnswr & user[1].TrdAnswr)
                        {
                            AnswerTrue -= 5;
                        }

                        else if (user[1].ScndAnswr | user[1].TrdAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }
                    }

                    if (user[1].FrstAnswr & i == 1)
                    {
                        AnswerTrue += 2.5;

                        if (user[1].FrAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }

                        if (user[1].ScndAnswr | user[1].TrdAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }
                    }

                    if (user[1].FrAnswr & i == 1)
                    {
                        AnswerTrue += 2.5;

                        if (user[1].FrstAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }

                        if (user[1].ScndAnswr | user[1].TrdAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-3
                    if (user[2].ScndAnswr & i == 2)
                    {
                        AnswerTrue += 5;

                        if (user[2].FrstAnswr | user[2].TrdAnswr | user[2].FrAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-4
                    if (user[3].ScndAnswr & i == 3)
                    {
                        AnswerTrue += 5;

                        if (user[3].FrstAnswr | user[3].TrdAnswr | user[3].FrAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-5
                    if (user[4].FrAnswr & i == 4)
                    {
                        AnswerTrue += 5;

                        if (user[4].FrstAnswr | user[4].ScndAnswr | user[4].TrdAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-6
                    if (user[5].ScndAnswr & i == 5)
                    {
                        AnswerTrue += 5;

                        if (user[5].FrstAnswr | user[5].TrdAnswr | user[5].FrAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-7
                    if (user[6].TrdAnswr & i == 6)
                    {
                        AnswerTrue += 5;

                        if (user[6].FrstAnswr | user[6].ScndAnswr | user[6].FrAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-8
                    if (user[7].TrdAnswr & i == 7)
                    {
                        AnswerTrue += 5;

                        if (user[7].FrstAnswr | user[7].ScndAnswr | user[7].FrAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-9
                    if (user[8].TrdAnswr & i == 8)
                    {
                        AnswerTrue += 5;

                        if (user[8].FrstAnswr | user[8].ScndAnswr | user[8].FrAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-10
                    if (user[9].FrstAnswr & user[9].FrAnswr & i == 9)
                    {
                        AnswerTrue += 5;

                        if (user[9].ScndAnswr & user[9].TrdAnswr)
                        {
                            AnswerTrue -= 5;
                        }

                        else if (user[9].ScndAnswr | user[9].TrdAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }
                    }

                    if (user[9].FrstAnswr & i == 9)
                    {
                        AnswerTrue += 2.5;

                        if (user[9].FrAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }

                        if (user[9].ScndAnswr | user[9].TrdAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }
                    }

                    if (user[9].FrAnswr & i == 9)
                    {
                        AnswerTrue += 2.5;

                        if (user[9].FrstAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }

                        if (user[9].ScndAnswr | user[9].TrdAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-11
                    if (user[10].FrstAnswr & user[10].FrAnswr & i == 10)
                    {
                        AnswerTrue += 5;

                        if (user[10].ScndAnswr & user[10].TrdAnswr)
                        {
                            AnswerTrue -= 5;
                        }

                        else if (user[10].ScndAnswr | user[10].TrdAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }
                    }

                    if (user[10].FrstAnswr & i == 10)
                    {
                        AnswerTrue += 2.5;

                        if (user[10].FrAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }

                        if (user[10].ScndAnswr | user[10].TrdAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }
                    }

                    if (user[10].FrAnswr & i == 10)
                    {
                        AnswerTrue += 2.5;

                        if (user[10].FrstAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }

                        if (user[10].ScndAnswr | user[10].TrdAnswr)
                        {
                            AnswerTrue -= 2.5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-12
                    if (user[11].ScndAnswr & i == 11)
                    {
                        AnswerTrue += 5;

                        if (user[11].FrstAnswr | user[11].TrdAnswr | user[11].FrAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-13
                    if (user[12].FrAnswr & i == 12)
                    {
                        AnswerTrue += 5;

                        if (user[12].FrstAnswr | user[12].ScndAnswr | user[12].TrdAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-14
                    if (user[13].FrAnswr & i == 13)
                    {
                        AnswerTrue += 5;

                        if (user[13].FrstAnswr | user[13].ScndAnswr | user[13].TrdAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-15
                    if (user[14].FrstAnswr & i == 14)
                    {
                        AnswerTrue += 5;

                        if (user[14].ScndAnswr | user[14].TrdAnswr | user[14].FrAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-16
                    if (user[15].FrAnswr & i == 15)
                    {
                        AnswerTrue += 5;

                        if (user[15].FrstAnswr | user[15].ScndAnswr | user[15].TrdAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-17
                    if (user[16].ScndAnswr & i == 16)
                    {
                        AnswerTrue += 5;

                        if (user[16].FrstAnswr | user[16].TrdAnswr | user[16].FrAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-18
                    if (user[17].FrAnswr & i == 17)
                    {
                        AnswerTrue += 5;

                        if (user[17].FrstAnswr | user[17].ScndAnswr | user[17].TrdAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-19
                    if (user[18].FrAnswr & i == 18)
                    {
                        AnswerTrue += 5;

                        if (user[18].FrstAnswr | user[18].ScndAnswr | user[18].TrdAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                    #region CheckAnswer-20
                    if (user[19].FrAnswr & i == 19)
                    {
                        AnswerTrue += 5;

                        if (user[19].FrstAnswr | user[19].ScndAnswr | user[19].TrdAnswr)
                        {
                            AnswerTrue -= 5;
                        }
                    }
                    #endregion

                }

                ViewData["UserAnswer"] = AnswerTrue;

                ViewAnswer newModel = new ViewAnswer()
                {
                    QuestTempls = QuestList,
                    UserAnswers = user
                };

                return View(newModel);
            }

            else
            {
                ViewData["ErrorMessage"] = $"К сожалению вы пропустили {user.Length+1}-й вопрос." +
                    $" Пожалуйста вернитесь обратно к тесту и выберите правильные ответы";
                return View();
            }
        }
    }
}
