using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorokFeladat
{
    internal class Kifejezes
    {
        int elsoOperandus;
        string operatorValtozo;
        int masodikOperandus;

        public Kifejezes(int elsoOperandus, string operatorValtozo, int masodikOperandus)
        {
            this.elsoOperandus = elsoOperandus;
            this.operatorValtozo = operatorValtozo;
            this.masodikOperandus = masodikOperandus;
        }

        public int ElsoOperandus { get => elsoOperandus; }
        public string OperatorValtozo { get => operatorValtozo; }
        public int MasodikOperandus { get => masodikOperandus; }

        public Kifejezes(string szovegSor)
        {
            this.elsoOperandus = Convert.ToInt32(szovegSor.Split()[0]);
            this.operatorValtozo = szovegSor.Split()[1];
            this.masodikOperandus = Convert.ToInt32(szovegSor.Split()[2]);
        }
    }
}
