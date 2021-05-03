using System;
using System.Collections.Generic;
using System.Text;

namespace SIMS_8
{
    class Generator
    {
        float p1;

        double deltap =0.05;

        Dictionary<double, string> ps = new Dictionary<double, string>();

        Random rnd = new Random();
        
        double alpha = 0;

        public Generator()
        {
            ps.Add(0.05, "Весьма сомнительно");
            ps.Add(0.1, "Перспективы не очень хорошие");
            ps.Add(0.15, "По моим данным — «нет»");
            ps.Add(0.2, "Мой ответ — «нет»");
            ps.Add(0.25, "Даже не думай");
            ps.Add(0.3, "Сконцентрируйся и спроси опять");
            ps.Add(0.35, "Сейчас нельзя предсказать");
            ps.Add(0.4, "Лучше не рассказывать");
            ps.Add(0.45, "Спроси позже");
            ps.Add(0.5, "Пока не ясно, попробуй снова");
            ps.Add(0.55, "Да");
            ps.Add(0.6, "Знаки говорят — «да»");
            ps.Add(0.65, "Хорошие перспективы");
            ps.Add(0.7, "Вероятнее всего");
            ps.Add(0.75, "Мне кажется — «да»");
            ps.Add(0.8, "Можешь быть уверен в этом");
            ps.Add(0.85, "Определённо да");
            ps.Add(0.9, "Никаких сомнений");
            ps.Add(0.95, "Предрешено");
            ps.Add(1, "Бесспорно");
        }

        public bool singleEventAnswer(float p)
        {
            p1 = p;
            alpha = rnd.NextDouble();
            if (alpha < p1)
                return true;
            else
                return false;
        }

        public string groupOfEventAnswer()
        {
            string answer = "Hz";
            alpha = rnd.NextDouble();

            for (int i = 1; i<= 20; i ++)
            {
                alpha -= deltap;
                if (alpha < 0)
                {
                    answer = ps[Math.Round(deltap * i,5)];
                    break;
                }
            }
            return answer;
        }
    }
}
