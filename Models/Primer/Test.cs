using Cyrsovay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyrsovay.Models.Primer
{
    public static class Test
    {
        public static void Initialize(Context context)
        {
                context.Cyrsach.AddRange(
                    new TextModel
                    {
                        Imya = "Даниил",
                        Familia = "Макунин",
                        Otchestvo = "Сергеевич",
                        Speciality = "Информатика",
                        State = "Учится",
                        Cyrs = "И-3А"
                    }
                );
                context.SaveChanges();
        }
    }
}
