using System;
using NUnit.Framework;
//Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
//Testas “žalias” jeigu šiandien trečiadienis naudoti ChatGPT, kad išsiaiškinti kaip C# dirbti su dienomis
//Testas “žalias” jeigu dabar yra 13h naudoti ChatGPT, kad išsiaiškinti kaip C# dirbti su valandomis
//Bonus: Testas “žalias” jei nuo 1 iki 10 (imtinai) yra 4 lyginiai skaičia

namespace AutomatinisTestavimas
{
    public class Testai
    {
        [Test]
        public void Testas_995DalinasiIs3()
        {
            int skaicius = 995;
            Assert.AreEqual(0, skaicius % 3, "995 turėtų dalintis iš 3 be liekanos");
        }

        [Test]
        public void Testas_SiandienTreciadienis()
        {
            DayOfWeek siandien = DateTime.Now.DayOfWeek;
            Assert.AreEqual(DayOfWeek.Wednesday, siandien, "Šiandien turėtų būti trečiadienis");
        }

        [Test]
        public void Testas_DabarYra13Valanda()
        {
            int dabartineValanda = DateTime.Now.Hour;
            Assert.AreEqual(13, dabartineValanda, "Dabar turėtų būti 13 valanda");
        }

        [Test]
        public void Testas_PenkiosLyginesSkaiciuoseNuor1iki10()
        {
            int lyginiuSkaiciuKiekis = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    lyginiuSkaiciuKiekis++;
                }
            }

            Assert.AreEqual(5, lyginiuSkaiciuKiekis, "Tarp skaičių nuo 1 iki 10 (imtinai) turėtų būti 5 lyginiai skaičiai");
        }
    }
}

