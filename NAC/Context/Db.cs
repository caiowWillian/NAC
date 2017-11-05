using NAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAC.Context
{
    public class Db
    {
        private static IList<Nota> Notas = new List<Nota>();

        public bool Insert(Nota nota)
        {
            try
            {
                Notas.Add(nota);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool Remove(Nota nota)
        {
            try
            {
                Notas.Remove(nota);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Nota nota, int? rm)
        {
            
            if(Notas.Where(m => m.Rm == rm).Count() > 0)
            {
                Notas.Where(m => m.Rm == rm).FirstOrDefault().Am = nota.Am;
                Notas.Where(m => m.Rm == rm).FirstOrDefault().Nac = nota.Nac;
                Notas.Where(m => m.Rm == rm).FirstOrDefault().Nome = nota.Nome;
                Notas.Where(m => m.Rm == rm).FirstOrDefault().Ps = nota.Ps;
                Notas.Where(m => m.Rm == rm).FirstOrDefault().Rm = nota.Rm;

                return true;
            }
            return false;
        }

        public Nota GetNotaByRm(int? rm)
        {
            try
            {
                return Notas.Where(m => m.Rm == rm).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<Nota> GetNotas()
        {
            return Notas.AsEnumerable();
        }
    }
}