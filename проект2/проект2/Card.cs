using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проект2
{
    class Card
    {
        public int Id { get; set; }
        private string pin, cardname, cardnum, cardholdername;
        public string PIN
        {
            get { return pin; }
            set { pin = value; }
        }
        public string Cardname
        {
            get { return cardname; }
            set { cardname = value; }
        }
        public string Cardholdername
        {
            get { return cardholdername; }
            set { cardholdername = value; }
        }
        public string Cardnum
        {
            get { return cardnum; }
            set { cardnum = value; }
        }
        public Card() { }
        public Card(string pin, string cardnum, string cardholdername, string cardname)
        {
            this.pin = pin;
            this.cardname = cardname;
            this.cardholdername = cardholdername;
            this.cardnum = cardnum;
        }
        public override string ToString()
        {
            return "ФИО:" +cardholdername  + "PIN" + pin + "Номер карты" + cardnum + "Платежная система" + cardname; 
        }
    }
}
