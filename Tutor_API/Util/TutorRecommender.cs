using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tutor_API.Models;

namespace Tutor_API.Util
{
    public class TutorRecommender
    {
        private TutorEntities db = new TutorEntities();
        Dictionary<int, List<OcjenaTutor>> tutori = new Dictionary<int, List<OcjenaTutor>>();

        public List<Tutor> GetSlicneTutore(int TutuorId,int tipStudenta)
        {
            UcitajTutore(TutuorId, tipStudenta);
            var ocjenePosmatranogTutora = db.OcjenaTutors.Where(x => x.TutorId == TutuorId).OrderBy(x => x.StudentId).ToList();

            var zajednickeOcjene1 = new List<OcjenaTutor>();
            var zajednickeOcjene2 = new List<OcjenaTutor>();

            List<Tutor> preporuceniTutori = new List<Tutor>();

            foreach (var t in tutori)
            {
                foreach (OcjenaTutor o in ocjenePosmatranogTutora)
                {
                    if (t.Value.Where(x => x.StudentId == o.StudentId).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(t.Value.Where(x => x.StudentId == o.StudentId).First());
                    }
                }

                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnost > 0.4)
                    preporuceniTutori.Add(db.Tutors.FirstOrDefault(x => x.TutorId == t.Key));
                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return preporuceniTutori;

        }

        private double GetSlicnost(List<OcjenaTutor> zajednickeOcjene1, List<OcjenaTutor> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                brojnik = zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena;
                nazivnik1 = zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena;
                nazivnik2 = zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena;
            }

            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);

            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0) return 0;

            return brojnik / nazivnik;
        }

        private void UcitajTutore(int tutorId,int tipStudenta)
        {
            var tutor = db.Tutors.FirstOrDefault(x => x.TutorId == tutorId);//Posmatrani tutor
            

            var aktivniTutori = from t in db.Tutors
                         join os in db.ObimStudents on t.TutorId equals os.TutorId
                         where t.TutorId != tutor.TutorId && t.GradId == tutor.GradId && t.PodKategorijaId == tutor.PodKategorijaId && 
                         os.TipStudentaId == tipStudenta && t.StatusKorisnickoRacunaId==1
                         select t;
            List<OcjenaTutor> ocjene;

            foreach (var t in aktivniTutori)
            {
                ocjene = db.OcjenaTutors.Where(x => x.TutorId == tutorId).OrderBy(x => x.StudentId).ToList();
                if (ocjene.Count > 0)
                    tutori.Add(t.TutorId, ocjene);
            }
            
            
        }
    }
}