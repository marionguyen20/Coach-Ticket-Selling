using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSelling.DTO
{
    public class Payment
    {
        private string idReceipt;
        private string name;
        private string bank;
        private int cardNumber;
        private string type;
        private string datePay;
        private string idTicket;

        public Payment (string idReceipt, string name, string bank, int cardNumber, string type, string datePay, string idTicket)
        {
            this.idReceipt = idReceipt;
            this.name = name;
            this.bank = bank;
            this.cardNumber = cardNumber;
            this.type = type;
            this.datePay = datePay;
            this.idTicket = idTicket;
        }

        public Payment (DataRow row)
        {
            this.idReceipt = row["idReceipt"].ToString();
            this.name = row["name"].ToString();
            this.bank = row["bank"].ToString();
            this.cardNumber = (int) row["cardNumber"];
            this.type = row["type"].ToString();
            this.datePay = ((DateTime)row["datePay"]).ToString("dd-MM-yyyy");
            this.idTicket = row["idTicket"].ToString();
        }
        
    }
}
